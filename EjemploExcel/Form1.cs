using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace EjemploExcel
{
    public partial class Form1 : Form
    {
        // Atributos   -------------



        // Constructor   -------------------
        public Form1()
        {
            InitializeComponent();
            
        }

        // Métodos    -------------------

        /// <summary>
        /// Crea un nuevo archivo de excel con datos de prueba.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NuevoArchivo(object sender, EventArgs e)
        {
            try
            {
                var AplicacionExcel = new Microsoft.Office.Interop.Excel.Application();   // Aplicacion de excel
                Microsoft.Office.Interop.Excel._Workbook Libro = AplicacionExcel.Workbooks.Add("");   // Crea un nuevo libro con una hoja
                
                //Microsoft.Office.Interop.Excel._Worksheet hoja = Libro.ActiveSheet; // La hoja actual.
                Microsoft.Office.Interop.Excel._Worksheet hoja = Libro.Sheets.Add(Count: 1); // Crea una nueva hoja
                hoja.Name = "NUEVA";

                // Poner datos en celdas
                hoja.Cells[1, 1] = "First Name";
                hoja.Cells[1, 2] = "Last Name";
                hoja.Cells[1, 3] = "Full Name";
                hoja.Cells[1, 4] = "Salary";

                //Poner formatos: A1:D1 as bold, vertical alignment = center.
                hoja.get_Range("A1", "D1").Font.Bold = true;
                hoja.get_Range("A1", "D1").VerticalAlignment = XlVAlign.xlVAlignCenter;

                // Datos de prueba:
                string[,] saNames = new string[5, 2];
                saNames[0, 0] = "John";
                saNames[0, 1] = "Smith";
                saNames[1, 0] = "Tom";
                saNames[4, 1] = "Johnson";

                // Llenar desde una matriz
                hoja.get_Range("A2", "B6").Value2 = saNames;

                // Llenar desde una formula
                Range rango = hoja.get_Range("C2", "C6");
                rango.Formula = "=A2 & \" \" & B2";

                rango = hoja.get_Range("D2", "D6");
                rango.Formula = "=RAND()*100000";
                rango.NumberFormat = "$0.00";

                //AutoFit 
                rango = hoja.get_Range("A1", "D1");
                rango.EntireColumn.AutoFit();

                Libro.SaveAs("test505.xlsx", XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                                false, false, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); // Lo guarda en Mis Documentos.

                AplicacionExcel.Visible = true; // Hace visible la ventana de excel.
                

               //Libro.Close();

            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }
        }
    }
}
