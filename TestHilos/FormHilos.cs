using Entidades;


namespace TestHilos
{

    public partial class FormHilos : Form
    {
        private CancellationToken cancellation;
        private CancellationTokenSource cancellationSource;
        public FormHilos()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.cancellationSource = new CancellationTokenSource();
            this.cancellation = this.cancellationSource.Token;
        }

        private void btnAlfajores_Click(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Gold;
            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    ((Label)item).BackColor = Color.Gold;
                    ((Label)item).BorderStyle = BorderStyle.Fixed3D;
                }

            }

            Alfajor[] alfajores =
            {
                new Alfajor("havanna.png","Havanna",300),
                new Alfajor("jorgito.png","Jorgito",150),
                new Alfajor("terrabusi.png","Terrabusi",180),
                new Alfajor("milka.png","Milka",220),
                new Alfajor("capitan.png","Capitan del espacio",200),
                new Alfajor("fulbito.png","Fulbito",50),
                new Alfajor("tofi.png","Tofi",206),
                new Alfajor("negro.png","Negro",250),
                new Alfajor("bonobon.png","Bon o bon",195),
                new Alfajor("fantoche.png","Fantoche triple",350),
            };



            Task t = Task.Run(() => MostrarAlfajores(alfajores));
        }


        private void MostrarAlfajores(Alfajor[] alfajores)
        {
            do
            {
                Random alfajorAleatorio = new Random();
                this.ActualizarAlfajor(alfajores[alfajorAleatorio.Next(10)]);
                Thread.Sleep(2000);

            } while (true);

        }

        private void ActualizarAlfajor(Alfajor alfajor)
        {
            if (this.pictureBox1.InvokeRequired)
            {
                DelegadoDelAlfajor delegado = new DelegadoDelAlfajor(ActualizarAlfajor);
                object[] parametros = { alfajor };
                this.pictureBox1.Invoke(delegado, parametros);
            }
            else
            {
                if (this.cancellation.IsCancellationRequested)
                {
                    this.pictureBox1.ImageLocation = "";
                    this.lblDatos.Text = "Se canceló la tarea";
                    this.lblPrecio.Text = "Se canceló la tarea";
                    return;
                }


                this.pictureBox1.ImageLocation = alfajor.Path;
                this.lblDatos.Text = "Alfajor: " + alfajor.Nombre;
                this.lblPrecio.Text = "Precio: $" + alfajor.Precio.ToString();


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationSource.Cancel();

        }


    }
}