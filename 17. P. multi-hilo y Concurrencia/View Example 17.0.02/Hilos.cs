namespace View_Example_17._0._02
{
    public partial class FrmHilos : Form
    {
        private static Random random;

        static FrmHilos()
        {
            random = new Random();
        }
        public FrmHilos()
        {
            InitializeComponent();
        }

        private void FrmHilos_Paint(object sender, PaintEventArgs e)
        {


        }

        private void FrmHilos_Load(object sender, EventArgs e)
        {
            Task task = new Task(() => IniciarProceso(progressBar1, label1));
            task.Start();
        }



        private void IniciarProceso(ProgressBar barraProgreso, Label label)
        {
            while (barraProgreso.Value < barraProgreso.Maximum)
            {
                Thread.Sleep(random.Next(100, 1000));
                IncrementarBarraProgreso(barraProgreso, label, Task.CurrentId!.Value);
            }
        }

        private void IncrementarBarraProgreso(ProgressBar barraProgreso, Label label, int idHilo)
        {
            // InvokeRequired retorna true si requiero una invocacion desde el hilo que creo al formulario
            if (InvokeRequired)
            {
                Action<ProgressBar, Label, int> delegado = IncrementarBarraProgreso;
                object[] parametros = [barraProgreso, label, idHilo];
                Invoke(delegado, parametros);
            }
            else
            {
                barraProgreso.Increment(1);
                label.Text = $"Hilo N: {idHilo} - {barraProgreso.Value}%";
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(txtMensaje.Text);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }

    }
}
