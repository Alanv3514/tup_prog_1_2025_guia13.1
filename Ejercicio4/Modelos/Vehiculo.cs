using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Modelos
{
    internal class Vehiculo
    {
        private string patente="";
        private double kilometraje;

        public Vehiculo(string pat, double km)
        {
                this.patente = pat;
                this.kilometraje = km;
        }

        public void CargarViaje(double km)
        {
            kilometraje += km;
        }

        public double VerKilometraje()
        {
            return kilometraje;
        }
        public string VerPatente()
        {
            return patente;
        }
    }
}
