using Ejercicio4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.VOCS.Modelos
{
    internal class Servicio
    {
        private Vehiculo[] vehiculos = new Vehiculo[15];
        private int cVehiculos = 0;
        private int cViajes = 0;

        public int CVehiculos
        {
            get { return cVehiculos; }
            set { cVehiculos = value; }
        }
        public int CViajes
        {
            get { return cViajes; }
            set { cViajes = value; }
        }
        public bool CrearVehiculo(string pat, double km)
        {
            if ((cVehiculos < 15) && (BuscarVehiculo(pat) == -1))
            {
                vehiculos[cVehiculos] = new Vehiculo(pat, km);
                CVehiculos = CVehiculos + 1;
                return true;
            }
            return false;

        }
        public bool CargarViaje(string pat, double km)
        {
            int idx = BuscarVehiculo(pat);
            if (idx != -1)
            {
                vehiculos[idx].CargarViaje(km);
                cViajes++;
                return true;
            }
            return false;
        }
        public int BuscarVehiculo(string pat)
        {
            int res = -1;
            for (int i = 0; i < cVehiculos; i++)
            {
                if (vehiculos[i].VerPatente() == pat)
                    res = i;
            }
            return res;
        }
        public void Ordenar()
        {
            Vehiculo VAux = null;

            for (int i = 0; i < cVehiculos - 1; i++)
            {
                for (int j = i + 1; j < cVehiculos; j++)
                {
                    if (vehiculos[i].VerKilometraje() > vehiculos[j].VerKilometraje())
                    {
                        VAux = vehiculos[j];
                        vehiculos[j] = vehiculos[i];
                        vehiculos[i] = VAux;
                    }
                }
            }
        }

        public double VerPromedioKm()
        {
            double acum = 0;
            for (int i = 0; i < CVehiculos; i++)
            {
                acum += vehiculos[i].VerKilometraje();
            }
            return (acum / CVehiculos);
        }

        public double VerKilometraje(int idx)
        {
            return vehiculos[idx].VerKilometraje();
        }
        public string VerPatente(int idx)
        {
            return vehiculos[idx].VerPatente();
        }

    }
}
