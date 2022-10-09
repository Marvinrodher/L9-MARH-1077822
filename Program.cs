namespace Lab9_MARH_1077822
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Automovil
    {
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambiaDolar;
        private double descuentoAplicado;

        public Automovil (int Modelo, double Precio, string Marca, bool Disponible, double TipoCambiaDolar, double DescuentoAplicado)
        {
            modelo = Modelo;
            precio = Precio;
            marca = Marca;
            disponible = Disponible;
            tipoCambiaDolar = TipoCambiaDolar;
            descuentoAplicado = DescuentoAplicado;
        }

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }
        public void DefinirPrecio(int unPrecio)
        {
            precio = unPrecio;
        }
        public void DefinirMarca(int unaMarca)
        {
            modelo = unaMarca; 
        }
        public void DefinirTipoCambio(double unTipoCambio)
        {
            tipoCambiaDolar = unTipoCambio;
        }

        public void CambiarDisponibilidad()
        {
            if (disponible == true)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }

        public string MostrarDisponibilidad()
        {
            if (disponible == true)
            {
                return "Disponible";
            }
            else
            {
                return "No se encuentra disponible actualmente";
            }
        }
        public string MostrarInformacion()
        {
            return "Marca: " + marca + ", precio: " + precio;
        }
    }
}

   