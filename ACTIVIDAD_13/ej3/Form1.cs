namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 modal = new Form2();
        Lote nuevoLote = new Lote();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignarNumeroLote_Click(object sender, EventArgs e)
        {
            int numeroLote = nuevoLote.Numero;
            if (numeroLote == 0)
            {
                nuevoLote.Numero = Convert.ToInt32(tbAsignarNumeroLote.Text);
            }
        }

        private void btnRegistrarMedida_Click(object sender, EventArgs e)
        {
            if (modal.ShowDialog() == DialogResult.OK)
            {
                double medida = Convert.ToDouble(modal.tbRegistrarMedida.Text);
                nuevoLote.RegistrarMedida(medida);
            }
        }

        private void btnVerCantidad_Click(object sender, EventArgs e)
        {
            int cantidad = nuevoLote.Cantidad;
            lbCantidad.Text = $"{cantidad}";
        }

        private void btnVerNumeroLote_Click(object sender, EventArgs e)
        {
            int numero = nuevoLote.Numero;
            if (numero != 0)
            {
                lbLote.Text = $"{numero}";
            }
            else
            {
                lbLote.Text = "!";
            }
        }
        private void lbxVerCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbLote_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearLote_Click(object sender, EventArgs e)
        {
            nuevoLote = new Lote();
        }

        private void btnVerMedida_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(tbIndice.Text);
            nuevoLote.VerMedida(indice, out double medida);
            if (medida != 0) 
            { lbMedida.Text = $"{medida}"; }
            else
            {
                lbMedida.Text = "!";
            }
        }
    }
}
