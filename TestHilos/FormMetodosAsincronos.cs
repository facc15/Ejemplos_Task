using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace TestHilos
{

    public partial class FormMetodosAsincronos : Form
    {
        public FormMetodosAsincronos()
        {
            InitializeComponent();
        }

        private void btnSincronico_Click(object sender, EventArgs e)
        {
            List<Alfajor> respuesta = this.TraerAlfajores();

            this.CargarListBox(respuesta);
        }

        private List<Alfajor> TraerAlfajores()
        {
            List<Alfajor> lista = new List<Alfajor>();
            lista.Add(new Alfajor("Havanna", 300));
            lista.Add(new Alfajor("Jorgito", 150));
            lista.Add(new Alfajor("Guaymallen", 80));
            lista.Add(new Alfajor("Milka", 350));

            Thread.Sleep(5000);

            return lista;
        }



        private async void btnAsincronico_Click(object sender, EventArgs e)
        {
            List<Alfajor> respuesta = await this.TraerAlfajoresAsincronico();

            this.CargarListBox(respuesta);
        }


        private async Task<List<Alfajor>> TraerAlfajoresAsincronico()
        {

            List<Alfajor> alfajores = await Task.Run(() =>
             {
                 List<Alfajor> lista = new List<Alfajor>();
                 lista.Add(new Alfajor("Havanna", 300));
                 lista.Add(new Alfajor("Jorgito", 150));
                 lista.Add(new Alfajor("Guaymallen", 80));
                 lista.Add(new Alfajor("Milka", 350));

                 Thread.Sleep(5000);

                 return lista;
             });

            return alfajores;
        }

        private void CargarListBox(List<Alfajor> alfajores)
        {
            foreach (Alfajor item in alfajores)
            {
                this.listBox1.Items.Add(item);
            }
        }


    }
}
