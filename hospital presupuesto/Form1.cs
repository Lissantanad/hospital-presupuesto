namespace hospital_presupuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Distribuir_Click(object sender, EventArgs e)
        {

            Double Presupuesto, Emergencia, Cirugia, Suministros, Laboratorio, Administracion, Imagenes;

            Presupuesto = Double.Parse(txtPresupuesto.Text);

            Emergencia = (Presupuesto * 30) / 100;
            Cirugia = (Presupuesto * 15) / 100;
            Suministros = (Presupuesto * 25) / 100;
            Administracion = (Presupuesto * 18) / 100;
            Laboratorio = (Presupuesto * 5) / 100;
            Imagenes = (Presupuesto * 7) / 100;

            txtEmergencia.Text = Emergencia.ToString();
            txtCirugia.Text = Cirugia.ToString();
            txtSuministros.Text = Suministros.ToString();
            txtAdministracion.Text = Administracion.ToString();
            txtLaboratorio.Text = Laboratorio.ToString();
            txtImagenes.Text = Imagenes.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtPresupuesto.Clear();
            txtEmergencia.Clear();
            txtCirugia.Clear();
            txtSuministros.Clear();
            txtAdministracion.Clear();
            txtLaboratorio.Clear();
            txtImagenes.Clear();


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
