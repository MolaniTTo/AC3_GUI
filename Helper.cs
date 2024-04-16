using AC3_Comarca;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Xml;

namespace AC3_GUI_C_
{
    public static class Helper
    {

        //LLEGIR EL CSV:
        public static List<Comarca> ReadCSV(string filePathCSV)
        {
            List<Comarca> comarques = new List<Comarca>();
            using (var reader = new StreamReader(filePathCSV))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var comarca = new Comarca
                    {
                        Any = csv.GetField<int>("Any"),
                        CodiComarca = csv.GetField<int>("Codi comarca"),
                        NomComarca = csv.GetField<string>("Comarca"),
                        Poblacio = csv.GetField<int>("Població"),
                        DomesticXarxa = csv.GetField<int>("Domèstic xarxa"),
                        ActivitatsEconomiques = csv.GetField<int>("Activitats econòmiques i fonts pròpies"),
                        Total = csv.GetField<int>("Total"),
                        ConsumDomesticPerCapita = csv.GetField<double>("Consum domèstic per càpita")
                    };
                    comarques.Add(comarca);
                }
            }
            return comarques;
        }


        //CREAR L'XML DES DEL CSV:

        public static void CreateXMLWithCSV(string filePathCSV, string filePathXML)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xmlDoc.CreateElement("Comarques");
            xmlDoc.InsertBefore(xmlDeclaration, xmlDoc.DocumentElement);
            xmlDoc.AppendChild(root);

            string[] lines = File.ReadAllLines(filePathCSV);

            foreach (string line in lines)
            {
                string[] strings = line.Split(',');
                
                XmlElement comarca = xmlDoc.CreateElement("Comarca");
                comarca.SetAttribute("Codigo", strings[1]);

                if (strings[3].StartsWith("1") || strings[3].StartsWith("2") || strings[3].StartsWith("3") || strings[3].StartsWith("4") || strings[3].StartsWith("5") || strings[3].StartsWith("6") || strings[3].StartsWith("7") || strings[3].StartsWith("8") || strings[3].StartsWith("9")) 
                {
                    comarca.InnerText = strings[2];
                }
                else
                {
                    comarca.InnerText = strings[2] + "," + strings[3];
                }

                root.AppendChild(comarca);
            }
            xmlDoc.Save(filePathXML);
        }

        //CARREGAR EL COMBOBOX DE COMARQUES:
        public static void loadXMLinComboBox(string filePathXML, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePathXML);

            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {

                string name = node.InnerText;
                comboBox.Items.Add(name);
            }
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }

        //AFEGIR DADES AL CSV:
        public static void AppendCSV(List<Comarca> comarques)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            string filePath = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";
            using var stream = File.Open(filePath, FileMode.Append);
            using var writer = new StreamWriter(stream);
            using var csvWriter = new CsvWriter(writer, config);
            csvWriter.WriteRecords(comarques);
        }





















    }
}
