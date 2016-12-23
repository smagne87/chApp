using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace chApp.UI.Common
{
    public static class UiHelper
    {
        public const string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                        [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                        [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public static bool IsFormOpen(Type formType)
        {
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
                if (form.GetType().Name == formType.Name)
                {
                    form.Focus();
                    return true;
                }
            return false;
        }

        public static bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Falta el Nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        public static bool IsEmailValid(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                bool res = Regex.IsMatch(email, MatchEmailPattern);

                if (!res)
                {
                    MessageBox.Show("Email No es válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                    return true;
            }
            else
            {
                //MessageBox.Show("Falta Email", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }

        public static bool IsMontoValido(string monto, System.Windows.Forms.Label lbl)
        {
            if (!string.IsNullOrWhiteSpace(lbl.Text))
            {
                decimal number;
                if (string.IsNullOrWhiteSpace(monto))
                {
                    MessageBox.Show("Falta el " + lbl.Text, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (decimal.TryParse(monto, out number))
                    return true;
                else
                {
                    MessageBox.Show("El " + lbl.Text + " ingresado no es válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return false;
        }

        public static string CuitConverter(string cuit)
        {
            var cuitC = cuit.Replace("-", "");

            return cuitC;
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Se ha producido el siguiente error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void WarningMessage(string message)
        {
            MessageBox.Show(message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Exporta Datagridview a Archivo de Excel
        public static void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "ArchivoExportado";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    //for (int i = 0; i < grd.Rows.Count - 1; i++)
                    for (int i = 0; i < grd.Rows.Count; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }

        public static void ExportarDataGridViewExcelWithHeader(DataGridView dGV, string filename)
        {
            try
            {
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV.RowCount ; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }

    public enum Bancos
    {
        [Display(Name = "Santander Río")]
        SantanderRio = 1,
        [Display(Name = "Banco Ciudad")]
        BancoCiudad = 2,
        [Display(Name = "Banco Galicia")]
        BancoGalicia = 3,
        [Display(Name = "Banco Provincia de Buenos Aires")]
        BancoProv = 4,
        [Display(Name = "Citibank")]
        Citibank = 5,
        [Display(Name = "Banco Macro")]
        BancoMacro = 6,
        [Display(Name = "BBVA Frances")]
        BancoFrances = 7,
        [Display(Name = "ICBC")]
        Icbc = 8,
        [Display(Name = "HSBC")]
        Hsbc = 9,
        [Display(Name = "Banco Credicoop")]
        BancoCredicoop = 10,
        [Display(Name = "Banco Comafi")]
        BancoComafi = 11,
        [Display(Name = "Banco Hipotecario	")]
        BancoHipotecario = 12,
        [Display(Name = "Banco Itaú")]
        BancoItau = 13,
        [Display(Name = "Banco Nación")]
        BancoNacion = 14,
        [Display(Name = "Banco Supervielle")]
        BancoSupervielle = 15,
        [Display(Name = "Banco Patagonia")]
        BancoPatagonia = 16,
        [Display(Name = "Banco Columbia")]
        BancoColumbia = 17,
    }
}
