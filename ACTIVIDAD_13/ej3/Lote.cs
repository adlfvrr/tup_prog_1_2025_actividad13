using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Lote
    {
        private double[] medidas;
        private int numero;
        private int cantidad;
        public int Numero   
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
        }
        public Lote()
        {
            medidas = new double[20];
            cantidad = 0;
            numero = 0;
        }

        public void RegistrarMedida(double medida)
        {
            medidas[cantidad] = medida;
            cantidad++;
        }
        public void VerMedida(int idx, out double medida)
        {
            medida = medidas[idx];
        }
    }
}
