namespace R2Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCampos = new System.Windows.Forms.ListBox();
            this.btborrarObjeto = new System.Windows.Forms.Button();
            this.btHisto = new System.Windows.Forms.Button();
            this.lstObjetos = new System.Windows.Forms.ListBox();
            this.btcargarObjeto = new System.Windows.Forms.Button();
            this.lblWD = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 143);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstCampos);
            this.groupBox1.Controls.Add(this.btborrarObjeto);
            this.groupBox1.Controls.Add(this.btHisto);
            this.groupBox1.Controls.Add(this.lstObjetos);
            this.groupBox1.Controls.Add(this.btcargarObjeto);
            this.groupBox1.Location = new System.Drawing.Point(412, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 360);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "R-Control de objetos";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Objeto$campo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Objeto/Dataframe:";
            // 
            // lstCampos
            // 
            this.lstCampos.FormattingEnabled = true;
            this.lstCampos.Location = new System.Drawing.Point(16, 221);
            this.lstCampos.Name = "lstCampos";
            this.lstCampos.Size = new System.Drawing.Size(126, 95);
            this.lstCampos.TabIndex = 6;
            // 
            // btborrarObjeto
            // 
            this.btborrarObjeto.Location = new System.Drawing.Point(29, 48);
            this.btborrarObjeto.Name = "btborrarObjeto";
            this.btborrarObjeto.Size = new System.Drawing.Size(101, 23);
            this.btborrarObjeto.TabIndex = 5;
            this.btborrarObjeto.Text = "Borrar Objeto";
            this.btborrarObjeto.UseVisualStyleBackColor = true;
            this.btborrarObjeto.Click += new System.EventHandler(this.btborrarObjeto_Click);
            // 
            // btHisto
            // 
            this.btHisto.Location = new System.Drawing.Point(29, 322);
            this.btHisto.Name = "btHisto";
            this.btHisto.Size = new System.Drawing.Size(101, 26);
            this.btHisto.TabIndex = 9;
            this.btHisto.Text = "Hist";
            this.btHisto.UseVisualStyleBackColor = true;
            this.btHisto.Click += new System.EventHandler(this.btHisto_Click);
            // 
            // lstObjetos
            // 
            this.lstObjetos.DisplayMember = "(ninguno)";
            this.lstObjetos.FormattingEnabled = true;
            this.lstObjetos.Location = new System.Drawing.Point(16, 99);
            this.lstObjetos.Name = "lstObjetos";
            this.lstObjetos.Size = new System.Drawing.Size(126, 95);
            this.lstObjetos.TabIndex = 3;
            this.lstObjetos.SelectedIndexChanged += new System.EventHandler(this.lstObjetos_SelectedIndexChanged);
            // 
            // btcargarObjeto
            // 
            this.btcargarObjeto.Location = new System.Drawing.Point(29, 19);
            this.btcargarObjeto.Name = "btcargarObjeto";
            this.btcargarObjeto.Size = new System.Drawing.Size(101, 23);
            this.btcargarObjeto.TabIndex = 0;
            this.btcargarObjeto.Text = "Cargar Objeto";
            this.btcargarObjeto.UseVisualStyleBackColor = true;
            this.btcargarObjeto.Click += new System.EventHandler(this.btcargarObjeto_Click);
            // 
            // lblWD
            // 
            this.lblWD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWD.AutoSize = true;
            this.lblWD.Location = new System.Drawing.Point(-1, 544);
            this.lblWD.Name = "lblWD";
            this.lblWD.Size = new System.Drawing.Size(35, 13);
            this.lblWD.TabIndex = 12;
            this.lblWD.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(412, 372);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(160, 20);
            this.txtType.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 562);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "R2csharp_histoviewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstCampos;
        private System.Windows.Forms.Button btborrarObjeto;
        private System.Windows.Forms.Button btHisto;
        private System.Windows.Forms.ListBox lstObjetos;
        private System.Windows.Forms.Button btcargarObjeto;
        private System.Windows.Forms.Label lblWD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

