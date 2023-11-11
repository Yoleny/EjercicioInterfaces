using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Resta : IOperacionMatematica
    {
        private int numero1;
        private int numero2;
        private int resultado;

        public Resta(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public void RealizarOperacion()
        {
            resultado = numero1 - numero2;
        }

        public int ObtenerResultado()
        {
            return resultado;
        }
        public void MostrarResultado()
        {
            Console.WriteLine($"El resultado de la resta es: {resultado}");
        }
    }
}
