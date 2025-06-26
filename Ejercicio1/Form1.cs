using Ejercicio1.VIC;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private string[] patentes = new string[15];
        private double[] kilometrajes = new double[15];
        private int contador = 0;
        private int cantidadViajes = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void CrearVehiculo(string pat, double km)
        {
            if ((contador < 15) && (BuscarVehiculo(pat) == -1))
            {
                patentes[contador] = pat;
                kilometrajes[contador] = km;
                contador++;
                if (contador == 15)
                    this.btnRegistrar.Enabled = false;
            }
            else if (BuscarVehiculo(pat) != -1)
            {
                MessageBox.Show("Error, la patente ya existe");
            }
            else
            {
                MessageBox.Show("Error, no se pueden ingresar mas de 15");
            }

        }

        public void CargarViaje(string pat, double km)
        {
            int idx = BuscarVehiculo(pat);
            if (idx == -1)
            {
                MessageBox.Show("Error, la patente no existe");
            }
            else
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
        public int BuscarVehiculo(string pat)
        {
            for (int i = 0; i < contador; i++)
            {
                if (patentes[i] == pat)
                    return i;
            }
            return -1;
        }

        public void Ordenar()
        {
            double DAux;
            string SAux;

            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
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
            for (int i = 0; i < contador; i++)
            {
                acum += kilometrajes[i];
            }
            return (acum / contador);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                CrearVehiculo(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text));
                this.listBoxPatentes.Items.Add(fdatos.tBpatente.Text);
                this.btnCargarViaje.Enabled = true;
                this.btnResumenFinal.Enabled = true;
            }
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {

            Fdatos fdatos = new Fdatos();
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                CargarViaje(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text));
                this.labelCantViajes.Text = $"{cantidadViajes}";
            }
        }

        private void btnResumenFinal_Click(object sender, EventArgs e)
        {
            Fresumen fresumen = new Fresumen();
            Ordenar();
            for (int i = 0; i < contador; i++)
            {
                fresumen.listBoxResumen.Items.Add($"Kilometraje:{kilometrajes[i],10:f2} - Patentes {patentes[i]}");
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
