using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuevo_InSiPo
{
    class cls_log
    {
        public static void archivoLog(Form fr, object sender, Exception ex)
        {

            string entradaLog = System.DateTime.Now.ToString() + " || " + fr.Text.ToString() + " || " + sender.GetType().GetProperty("Name").GetValue(sender).ToString() + "\n" + ex + "\n= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =";

            string path = @"c:\log.txt";
            try
            {
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(entradaLog);
                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(entradaLog);
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Informe el evento. No se pudo escribir el archivo log.txt", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
