namespace Entidades
{
    public delegate void DelegadoDelAlfajor(Alfajor alfajor);
    public class Alfajor
    {
        private string path;
        private string nombre;
        private double precio;

        public string Path { get => this.path; set => this.path = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public double Precio { get => this.precio; set => this.precio = value; }

        public Alfajor(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public Alfajor(string path, string nombre, double precio):this(nombre,precio)
        {
            this.path = path;
        }


        public override string ToString()
        {
            return this.nombre + " - $" + this.precio;
        }

    }
}