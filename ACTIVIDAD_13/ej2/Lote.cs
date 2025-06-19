using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    internal class Lote
    {
        private double[] medidas;
        private int numero;
        private int cantidad;

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
        public int GetCantidad()
        {
            int ingresados = 0;
            for (int i = 0; i < cantidad; i++)
            {
                ingresados++;
            }
            return ingresados;
        }
        public int GetNumero()
        {
            int numeroLote = numero;
            return numeroLote;
        }
        public void GetNumeroLote(int valor)
        {
            numero = valor;
        }
    }
}
