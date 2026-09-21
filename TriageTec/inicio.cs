namespace TriageTec
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            AplicarEstilos();
        }

        private void AplicarEstilos()
        {
            Tema.Aplicar(this);

            Tema.EstilizarLateral(panelLateral);
            panelContenido.BackColor = Tema.Tarjeta;

            Tema.Titulo(lblBienvenida);
            Tema.Subtitulo(lblInstruccion);
            Tema.Subtitulo(lblPie);

            Tema.BotonPrimario(button1);
            Tema.BotonSecundario(button2);

            AcceptButton = button1;
            CancelButton = button2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
