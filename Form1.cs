

using AC3_Comarca;
using System.Windows.Forms;

namespace AC3_GUI_C_
{
    public partial class GestioDadesContainer : Form
    {
        public string filePathCSV = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";
        public string filePathXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402.xml";

        public GestioDadesContainer()
        {
            InitializeComponent();
            CargarDatosCSV();

            if (!File.Exists(filePathXML))
            {
                CreateXML();
            };
            LoadComboBox();
            DG_CSV.CellClick += LoadViews;

        }
        private void CargarDatosCSV()
        {
            DG_CSV.DataSource = Helper.ReadCSV(filePathCSV);
            DG_CSV.Columns[1].Visible = false;
        }


        private void CreateXML()
        {
            Helper.CreateXMLWithCSV(filePathCSV, filePathXML);
        }

        private void LoadComboBox()
        {
            Helper.loadXMLinComboBox(filePathXML, CBComarca);
        }

        private void LoadViews(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string filePath = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";
                DataGridViewRow row = DG_CSV.Rows[n];
                List<Comarca> comarcas = Helper.ReadCSV(filePath);

                int poblacio = Convert.ToInt32(row.Cells[3].Value);
                lblPoblacioGreatherThan.Text = (poblacio > 20000) ? "SI" : "NO";

                string comarca = row.Cells[2].Value.ToString();
                var filterComarcasName = comarcas.Where(c => c.NomComarca == comarca);
                double consum = filterComarcasName.Average(c => c.ConsumDomesticPerCapita);
                lblConsDomMitja.Text = $"{consum:N0}";

                double consumDomesticPerCapita = Convert.ToDouble(row.Cells[7].Value);
                var filterComarcaALT = filterComarcasName.OrderByDescending(c => c.ConsumDomesticPerCapita).First();
                lblConsDomesticCapitaAlt.Text = filterComarcaALT.ConsumDomesticPerCapita == consumDomesticPerCapita ? "SI" : "NO";

                var filterComarcaBAX = filterComarcasName.OrderByDescending(c => c.ConsumDomesticPerCapita).Last();
                lblConsDomesticCapitaBaix.Text = filterComarcaBAX.ConsumDomesticPerCapita == consumDomesticPerCapita ? "SI" : "NO";
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblConDomCapitaAlt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CBAny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GBEstadistiques_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBPoblacio_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButNetejar_Click(object sender, EventArgs e)
        {
            TBPoblacio.Text = "";
            CBComarca.Text = "";
            CBAny.Text = "";
            TBDomesticXarxa.Text = "";
            TBConsumDom.Text = "";
            TBTotal.Text = "";
            TBActivitatsEcon.Text = "";
        }

        private void ButGuardar_Click(object sender, EventArgs e)
        {
           

            if (this.ValidateChildren())
            {
                List<Comarca> comarques = new List<Comarca>()
                {
                    new Comarca()
                    {
                        Any = Convert.ToInt32(CBAny.Text),
                        CodiComarca = Convert.ToInt32(CBComarca.SelectedValue),
                        NomComarca = CBComarca.Text,
                        Poblacio = Convert.ToInt32(TBPoblacio.Text),
                        DomesticXarxa = Convert.ToInt32(TBDomesticXarxa.Text),
                        ActivitatsEconomiques = Convert.ToInt32(TBActivitatsEcon.Text),
                        Total = Convert.ToInt32(TBTotal.Text),
                        ConsumDomesticPerCapita = Convert.ToDouble(TBConsumDom.Text)
                    }

                };

                Helper.AppendCSV(comarques);

                CargarDatosCSV();

            }

        }

        private void TBPoblacio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = TBPoblacio;

            errorProvider1.SetError(textBox, "");


            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

            if (!int.TryParse(textBox.Text, out int poblacio))
            {
                errorProvider1.SetError(textBox, "El valor ingressat no es un numero valid.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }

            if (poblacio < 0)
            {
                errorProvider1.SetError(textBox, "El valor no pot ser menor de 0.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }
        }

        private void CBComarca_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ComboBox comboBox = CBComarca;

            errorProvider1.SetError(comboBox, "");


            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider1.SetError(comboBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

        }

        private void CBAny_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ComboBox comboBox = CBAny;

            errorProvider1.SetError(comboBox, "");


            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider1.SetError(comboBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

        }

        private void TBDomesticXarxa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = TBDomesticXarxa;

            errorProvider1.SetError(textBox, "");


            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

            if (!int.TryParse(textBox.Text, out int poblacion))
            {
                errorProvider1.SetError(textBox, "El valor ingressat no es un numero valid.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }


            if (poblacion < 0)
            {
                errorProvider1.SetError(textBox, "El valor no pot ser menor de 0.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }
        }

        private void TBActivitatsEcon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = TBActivitatsEcon;

            errorProvider1.SetError(textBox, "");


            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

            // Comprobar si el valor no es un número
            if (!int.TryParse(textBox.Text, out int poblacion))
            {
                errorProvider1.SetError(textBox, "El valor ingressat no es un numero valid.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }

            // Comprobar si el valor es menor que 0
            if (poblacion < 0)
            {
                errorProvider1.SetError(textBox, "El valor no pot ser menor de 0.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }
        }

        private void TBConsumDom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = TBConsumDom;

            errorProvider1.SetError(textBox, "");


            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

            // Comprobar si el valor no es un número
            if (!int.TryParse(textBox.Text, out int poblacion))
            {
                errorProvider1.SetError(textBox, "El valor ingressat no es un numero valid.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }

            // Comprobar si el valor es menor que 0
            if (poblacion < 0)
            {
                errorProvider1.SetError(textBox, "El valor no pot ser menor de 0.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }
        }

        private void TBTotal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = TBTotal;

            errorProvider1.SetError(textBox, "");


            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, "El camp no pot estar buit.");
                e.Cancel = true;
                return;
            }

            // Comprobar si el valor no es un número
            if (!int.TryParse(textBox.Text, out int poblacion))
            {
                errorProvider1.SetError(textBox, "El valor ingressat no es un numero valid.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }

            // Comprobar si el valor es menor que 0
            if (poblacion < 0)
            {
                errorProvider1.SetError(textBox, "El valor no pot ser menor de 0.");
                e.Cancel = true; // Cancelar el evento de validación
                return;
            }
        }
    }
}
