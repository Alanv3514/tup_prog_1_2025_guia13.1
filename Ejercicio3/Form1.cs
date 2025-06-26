using Ejercicio3.VOF;
using Ejercicio3.VOF.Modelos;

namespace Ejercicio3.VOF
{
    public partial class Form1 : Form
    {
        Vehiculo[] vehiculos = new Vehiculo[15];
        int cantidadVehiculos = 0;
        int cantidadViajes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public int BuscarVehiculo(string pat)
        {
            int res = -1;
            for (int i = 0; i < cantidadVehiculos; i++)
            {
                if (vehiculos[i].VerPatente() == pat)
                    res = i;
            }
            return res;
        }

        public void Ordenar()
        {
            Vehiculo VAux = null;

            for (int i = 0; i < cantidadVehiculos - 1; i++)
            {
                for (int j = i + 1; j < cantidadVehiculos; j++)
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
            for (int i = 0; i < cantidadVehiculos; i++)
            {
                acum += vehiculos[i].VerKilometraje();
            }
            return (acum / cantidadVehiculos);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                if (BuscarVehiculo(fdatos.tBpatente.Text) == -1)
                {

                    vehiculos[cantidadVehiculos] = new Vehiculo();
                    vehiculos[cantidadVehiculos].CrearVehiculo(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text));

                    this.listBoxPatentes.Items.Add(fdatos.tBpatente.Text);

                    this.btnCargarViaje.Enabled = true;
                    this.btnResumenFinal.Enabled = true;
                    cantidadVehiculos++;

                    if (cantidadVehiculos == 15)
                    {
                        this.btnRegistrar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Error, vehiculo repetido.");
                }

            }
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();


            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                int idx = BuscarVehiculo(fdatos.tBpatente.Text);
                if (idx != -1)
                {
                    vehiculos[idx].CargarViaje(Convert.ToDouble(fdatos.tBkilometraje.Text));
                    cantidadViajes++;
                    this.labelCantViajes.Text = $"{cantidadViajes}";
                }
                else
                {
                    MessageBox.Show("Error, no se encuentra el vehiculo.");
                }

            }
        }

        private void btnResumenFinal_Click(object sender, EventArgs e)
        {
            Fresumen fresumen = new Fresumen();
            Ordenar();
            for (int i = 0; i < cantidadVehiculos; i++)
            {
                fresumen.listBoxResumen.Items.Add($"Kilometraje:{vehiculos[i].VerKilometraje(),10:f2} - Patentes {vehiculos[i].VerPatente()}");
            }
            fresumen.listBoxResumen.Items.Add($"Promedio Kilometros:{VerPromedioKm(),10:f2} - Viajes Totales: {cantidadViajes}");
            fresumen.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
