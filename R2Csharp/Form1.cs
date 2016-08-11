//    R2Csharp. R histrogram graphs through .NET
//    Copyright (C) 2009 Benito M. Zaragozí (www.gisandchips.org)
//    Send comments and suggestions to info@gisandchips.org
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see http://www.gnu.org/licenses/.

//    How to cite R2Csharp:
//    Benito M. Zaragozí. 2009. R2Csharp, R histrogram graphs through .NET. Computer software 
//    program produced by the author at the University of Alicante, Spain. 
//    Available at the following web site: http://www.gisandchips.org/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
//Servidor COM
using STATCONNECTORCLNTLib;
using StatConnectorCommonLib;
using STATCONNECTORSRVLib;

namespace R2Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sc1.Init("R");
            //asignamos el WD y después lo consultamos
            sc1.EvaluateNoReturn("setwd('C:/')");
            sc1.Evaluate("wd<-getwd()");
            string wd = (string)sc1.GetSymbol("wd");
            lblWD.Text = wd;
            sc1.EvaluateNoReturn("dir.create('tmp_r2csharp')");

        }

        //Conexión a R
        StatConnector sc1 = new STATCONNECTORSRVLib.StatConnectorClass();
        //Lista de los objetos creados y la ruta del fichero de origen
        Hashtable TOC = new Hashtable();    


        private void btcargarObjeto_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            if ((openFileDialog1.ShowDialog() == DialogResult.Cancel)) return;

            string fileName = openFileDialog1.FileName.Replace(@"\", "/");
            string objectName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

            //añade el nuevo objeto a la TOC o si ya existía, lo sobreescribe
            if (TOC.ContainsKey(objectName))
            {
                TOC.Remove(objectName);
            }
            else
            {
                TOC.Add(objectName, fileName);
            }


            //creamos un nuevo dataframe en R
            string leerFichero = objectName + "<-read.table('" + fileName + "',header=T)";
            sc1.Evaluate(leerFichero);

            //listamos todos los objetos menos los creados para consultar información en R.
            sc1.Evaluate("dir <-ls()");
            string[] dir = (string[])sc1.GetSymbol("dir");

            lstObjetos.Items.Clear();

            for (int i = 0; i < dir.Length; i++)
            {
                if (dir[i] != "wd" & dir[i] != "dir" & dir[i] != "campos" & dir[i] != "filasNombre" & dir[i] != "camposNombre" & dir[i] != "campoValores")
                {
                    lstObjetos.Items.Add(dir[i]);
                }

            }



        }

        private void btborrarObjeto_Click(object sender, EventArgs e)
        {

            if (lstObjetos.SelectedItem.ToString() != null)
            {
                //borramos un objeto
                sc1.EvaluateNoReturn("rm(" + lstObjetos.SelectedItem + ")");

                TOC.Remove(lstObjetos.SelectedItem.ToString());
                lstObjetos.Items.Remove(lstObjetos.SelectedItem);
                lstCampos.Items.Clear();
            }

        }

        private void btHisto_Click(object sender, EventArgs e)
        {
            //almacenamos las imagenes en un directorio temporal propio
            //las opciones de usar el clipboard no funcionan siempre por un problema
            //de incompatibilidad de los WMF
            sc1.EvaluateNoReturn("setwd('C:/tmp_r2csharp')");

            //creamos el histograma del objeto seleccionado en la lista
            string vector = lstObjetos.SelectedItem.ToString() + "$" + lstCampos.SelectedItem.ToString();
            sc1.EvaluateNoReturn("png('" + vector + ".png')");
            sc1.EvaluateNoReturn("hist(" + vector + ")");
            sc1.EvaluateNoReturn("dev.off()");


            sc1.EvaluateNoReturn("setwd('C:/')");

            //mostramos la imagen creada
            pictureBox1.ImageLocation = "C:/tmp_r2csharp/" + vector + ".png";



        }

        private void lstObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {


            dataGridView1.DataSource = "";
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();


            if (lstObjetos.SelectedItem != null)
            {
                lstCampos.Items.Clear();

                //Obtenemos los colnames
                sc1.Evaluate("camposNombre <-colnames(" + lstObjetos.SelectedItem + ")");
                string[] camposNombre = (string[])sc1.GetSymbol("camposNombre");
                //Añadimos los colnames
                for (int i = 0; i < camposNombre.Length; i++)
                {
                    if (camposNombre[i] != "wd" & camposNombre[i] != "dir" & camposNombre[i] != "campos")
                    {
                        lstCampos.Items.Add(camposNombre[i]);
                        dataGridView1.Columns.Add(camposNombre[i], camposNombre[i]);
                    }
                }


                //obtenemos los rownames
                sc1.Evaluate("filasNombre <-rownames(" + lstObjetos.SelectedItem + ")");
                string[] filasNombre = (string[])sc1.GetSymbol("filasNombre");
                dataGridView1.Rows.Add(filasNombre.Length);
                //añadimos los rownames
                for (int i = 0; i < filasNombre.Length; i++)
                {
                    if (filasNombre[i] != "wd" & filasNombre[i] != "dir" & filasNombre[i] != "campos")
                    {
                        dataGridView1.Rows[i].HeaderCell.Value = filasNombre[i];
                    }
                }


                //obtenemos los valores por columnas dependiendo del type del campo/vectorR
                object[] valoresPorCampo = new object[camposNombre.Length];

                for (int i = 0; i < camposNombre.Length; i++)
                {
                    string iR = (i + 1).ToString();
                    sc1.Evaluate("campoValores <-" + lstObjetos.SelectedItem + "[," + iR + "]");

                    //Podemos usar lo siguiente para consultar el tipo de dato devuelto por Rcom
                    //txtType.Text = sc1.GetSymbol("campoValores").GetType().ToString();
                    //y lo usamos después para añadirlo en las siguientes condiciones


                    if (sc1.GetSymbol("campoValores") is System.Int32[])
                    {
                        int[] campoValores = (int[])sc1.GetSymbol("campoValores");
                        //valoresPorCampoInt[i] = campoValores;
                        valoresPorCampo[i] = campoValores;
                    }

                    else if (sc1.GetSymbol("campoValores") is System.Double[])
                    {
                        double[] campoValores = (double[])sc1.GetSymbol("campoValores");
                        valoresPorCampo[i] = campoValores;
                    }

                }

                //rellenamos el datagridview por columnas y según el tipo de cada campo :-)

                for (int i = 0; i < camposNombre.Length; i++)
                {
                    if (valoresPorCampo[i] is System.Int32[])
                    {
                        int[] valoresCampo = (int[])valoresPorCampo[i];

                        for (int j = 0; j < filasNombre.Length; j++)
                        {
                            dataGridView1.Rows[j].Cells[i].Value = valoresCampo[j];
                        }
                    }

                    else if (valoresPorCampo[i] is System.Double[])
                    {

                        double[] valoresCampo = (double[])valoresPorCampo[i];

                        for (int j = 0; j < filasNombre.Length; j++)
                        {
                            dataGridView1.Rows[j].Cells[i].Value = valoresCampo[j];
                        }

                    }

                }

            }

        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //averiguamos que celda se quiere editar
            string editRow = (e.RowIndex + 1).ToString();
            string editCol = (e.ColumnIndex + 1).ToString();
            string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

            //actualizamos el valor en el objeto R
            //Si quisieramos guardar los cambios usariamos pejemplo un write.table del objeto
            sc1.EvaluateNoReturn(lstObjetos.SelectedItem + "[" + editRow + "," + editCol + "]<-" + newValue);


        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //eliminamos el directorio temporal
            sc1.EvaluateNoReturn("unlink('tmp_r2csharp', recursive = TRUE)");


        }
    }
}
