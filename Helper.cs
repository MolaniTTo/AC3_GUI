using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AC3_GUI_C_;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Windows.Forms;

namespace AC3_GUI_C_
{
    public static class Helper
    {
        public static DataTable ReadCSV(string rutaArchivo)
        {
            DataTable dataTable = new DataTable();

            // Llegeix la primera linea per obtenir el header
            string[] header;
            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                if (!parser.EndOfData)
                {
                    header = parser.ReadFields();
                }
                else
                {
                    return null; // Si el fitxer està buit, retorna null
                }
            }

            // Afegir les columnes al DataTable
            foreach (string encabezado in header)
            {
                dataTable.Columns.Add(encabezado);
            }

            // Llegir les dades del fitxer i afegir-les al DataTable
            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Ignorar el header
                parser.ReadLine();

                // Llegir les dades
                while (!parser.EndOfData)
                {
                    string[] campos = parser.ReadFields();

                    // Afegeix una fila al DataTable
                    dataTable.Rows.Add(campos);
                }
            }
            return dataTable;
        }


        //El selector ComboBox “CBComarca” ha d’obtenir els valors a partir d’un document XML que s’ha de crear (clau: Codi Comarca, valor: Comarca) i amb les claus-valors del fitxer CSV

        public static Dictionary<string, string> GetComarques(string rutaArchivo)
        {
            Dictionary<string, string> comarques = new Dictionary<string, string>();

            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadLine(); // Ignorar el header

                while (!parser.EndOfData)
                {
                    string[] campos = parser.ReadFields();
                    comarques.Add(campos[0], campos[1]);
                }
            }

            return comarques;
        }



















    }
}
