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
//    Benito M. Zaragozí. 2009. R2Csharp, 
//    R histrogram graphs through .NET. Computer software 
//    program produced by the authors at the University of Alicante, Spain. 
//    Available at the following web site: http://www.gisandchips.org/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace R2Csharp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
