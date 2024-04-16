

namespace AC3_GUI_C_
{
    public partial class GestioDadesContainer : Form
    {
        public GestioDadesContainer()
        {
            InitializeComponent();
            CargarDatosCSV();

        }

        private void CargarDatosCSV()
        {
            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";

            DG_CSV.DataSource = Helper.ReadCSV(rutaArchivo);
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
    }
}
