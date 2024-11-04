namespace View_Example_17._0._02
{
    public partial class FrmHilos : Form
    {
        private static Random random;
        private CancellationTokenSource cancellationTokenSource;

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
            cancellationTokenSource = new();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task task1 = new Task(() => IniciarProceso(progressBar1, label1), cancellationToken);
            task1.Start();

            Task task2 = Task.Run(() => IniciarProceso(progressBar2, label2), cancellationToken);

            Task task3 = Task.Run(() => IniciarProceso(progressBar3, label3), cancellationToken);

            Task task4 = Task.Run(() => IniciarProceso(progressBar4, label4), cancellationToken);

            Task task5 = Task.Run(() => IniciarProceso(progressBar5, label5), cancellationToken);
        }



        private void IniciarProceso(ProgressBar barraProgreso, Label label)
        {
            while (barraProgreso.Value < barraProgreso.Maximum && !cancellationTokenSource.IsCancellationRequested)
            {
                Thread.Sleep(random.Next(100, 1000));
                IncrementarBarraProgreso(barraProgreso, label, Task.CurrentId!.Value);
            }

            FinalizarProceso(barraProgreso, label);
        }

        private void IncrementarBarraProgreso(ProgressBar barraProgreso, Label label, int idHilo)
        {
            // InvokeRequired retorna true si requiero una invocacion desde el hilo que creo al formulario
            // Es decir, si estoy en un hilo distinto al principal
            if (InvokeRequired)
            {
                // Encapsular la referencia al metodo que modifica los controles en un delegado.
                Action<ProgressBar, Label, int> delegado = IncrementarBarraProgreso;
                // Si y solo si recibe parametros, voy a guardarlos en un arreglo de objetos
                object[] parametros = [barraProgreso, label, idHilo];
                // Invoke invoca al delegado desde el hilo que creo al formulario, pasandole los parametros (si tiene) en el mismo orden del array. 
                Invoke(delegado, parametros);
            }
            else
            {
                // Luego del invoke, InvokeRequired da false porque estamos en el mismo hilo que creo el formulario
                // y se pueden modificar los controles de manera segura.
                barraProgreso.Increment(1);
                label.Text = $"Hilo N: {idHilo} - {barraProgreso.Value}%";
            }
        }

        private void FinalizarProceso(ProgressBar barraProgreso, Label label)
        {
            if (InvokeRequired)
            {
                Action<ProgressBar, Label> finalizarProceso = FinalizarProceso;
                object[] parametros = [barraProgreso, label];
                Invoke(finalizarProceso, parametros);
            }
            else
            {
                if (barraProgreso.Value == barraProgreso.Maximum)
                {
                    label.Text = "Proceso finalizado";

                }
                else
                {
                    label.Text = "Proceso cancelado";

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void btnMostrar_Click(object sender, EventArgs e) => MessageBox.Show(textBox1.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }

        private void FrmHilos_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
