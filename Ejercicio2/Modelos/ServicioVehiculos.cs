using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.CS.Modelos
{
    internal class ServicioVehiculos
    {
        private string[] patentes = new string[15];
        private double[] kilometrajes = new double[15];
        private int vehiculos = 0;
        private int cantidadViajes = 0;

        public void CrearVehiculo(string pat, double km)
        {
            if ((vehiculos < 15) && (BuscarVehiculo(pat) ==-1))
            {
                patentes[vehiculos] = pat;
                kilometrajes[vehiculos] = km;
                vehiculos ++;
            }

        }

        public void CargarViaje(string pat,double km)
        {
            int idx = BuscarVehiculo(pat);
            if (idx != -1)
            {
                kilometrajes[idx] += km;
                cantidadViajes++;
            }
        }

        public double VerKilometraje(int idx)
        {
            return kilometrajes[idx];
        }
        public string VerPatente(int idx)
        {
            return patentes[idx];
        }
        public int VerCantidadViajes()
        {
            return cantidadViajes;
        }
        public int VerCantidadVehiculos()
        {
            return vehiculos;
        }
        public int BuscarVehiculo(string pat)
        {
            int res = -1;
            for (int i = 0; i < vehiculos; i++)
            {
                if(patentes[i] == pat)
                    res= i;
            }
            return res;
        }

        public void Ordenar()
        {
            double DAux;
            string SAux;

            for(int i = 0;i < vehiculos - 1; i++)
            {
                for(int j = i+1; j < vehiculos; j++)
                {
                    if (kilometrajes[i] > kilometrajes[j])
                    {
                        DAux = kilometrajes[j];
                        kilometrajes[j] = kilometrajes[i];
                        kilometrajes[i] = DAux;

                        SAux = patentes[j];
                        patentes[j] = patentes[i];
                        patentes[i] = SAux;
                    }
                }
            }
        }

        public double VerPromedioKm()
        {
            double acum = 0;
            for (int i = 0; i < vehiculos; i++)
            {
                acum += kilometrajes[i];
            }
            return (acum / VerCantidadVehiculos());
        }
    }
}
