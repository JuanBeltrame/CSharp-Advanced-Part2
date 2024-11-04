using System.Text;

namespace View_Example_17._0._02
{
    public partial class FrmHilos : Form
    {
        private static Random random;
        private CancellationTokenSource? cancellationTokenSource;
        private List<Task> hilos;

        static FrmHilos() => random = new Random();
        
        public FrmHilos()
        {
            InitializeComponent();
            hilos = new();
        }

        private void FrmHilos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHilos_Load(object sender, EventArgs e) => IniciarHilos();
        
        private void IniciarHilos()
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;

            cancellationTokenSource = new();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task task1 = new Task(() => IniciarProceso(progressBar1, label1), cancellationToken);
            task1.Start();
            hilos.Add(task1);

            Task task2 = Task.Run(() => IniciarProceso(progressBar2, label2), cancellationToken);
            hilos.Add(task2);

            Task task3 = Task.Run(() => IniciarProceso(progressBar3, label3), cancellationToken);
            hilos.Add(task3);

            Task task4 = Task.Run(() => IniciarProceso(progressBar4, label4), cancellationToken);
            hilos.Add(task4);

            Task task5 = Task.Run(() => IniciarProceso(progressBar5, label5), cancellationToken);
            hilos.Add(task5);
        }

        private void IniciarProceso(ProgressBar barraProgreso, Label label)
        {
            while (barraProgreso.Value < barraProgreso.Maximum && !cancellationTokenSource!.IsCancellationRequested)
            {
                Thread.Sleep(random.Next(100, 1000));
                IncrementarBarraProgreso(barraProgreso, label, Task.CurrentId!.Value);
            }

            FinalizarProceso(barraProgreso, label);
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
                    label.Text = "Proceso finalizado";
                else
                    label.Text = "Proceso cancelado";
            }
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

        private void btnCancelar_Click(object sender, EventArgs e) => cancellationTokenSource?.Cancel();
       
        private void btnMostrar_Click(object sender, EventArgs e) => MessageBox.Show(textBox1.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


        private void btnInfo_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new();
            foreach (Task hilo in hilos)
            {
                stringBuilder.AppendLine($"Hilo: {hilo.Id}");
                string mensaje = hilo.IsCompleted ? $"Esta Completado" : $"En estado: {hilo.Status}";
                stringBuilder.AppendLine(mensaje);
                stringBuilder.AppendLine();
            }

            MessageBox.Show(stringBuilder.ToString(), "Informacion de hilos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();

            while(!hilos.All(hilo => hilo.IsCompleted))
                await Task.Delay(10000);
            
            IniciarHilos();
        }

        private void FrmHilos_FormClosing(object sender, FormClosingEventArgs e) => cancellationTokenSource?.Cancel();
       
    }
}
