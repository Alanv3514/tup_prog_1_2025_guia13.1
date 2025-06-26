using Ejercicio2.CS;
using Ejercicio2.CS.Modelos;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        ServicioVehiculos SVehiculos = new ServicioVehiculos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                if (SVehiculos.BuscarVehiculo(fdatos.tBpatente.Text) == -1)
                {
                    SVehiculos.CrearVehiculo(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text));

                    this.listBoxPatentes.Items.Add(fdatos.tBpatente.Text);

                    this.btnCargarViaje.Enabled = true;
                    this.btnResumenFinal.Enabled = true;

                    if (SVehiculos.VerCantidadVehiculos() == 15)
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
                if ((SVehiculos.BuscarVehiculo(fdatos.tBpatente.Text)) != -1)
                {
                    SVehiculos.CargarViaje(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text));
                    this.labelCantViajes.Text = $"{SVehiculos.VerCantidadViajes()}";
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
            SVehiculos.Ordenar();
            for (int i = 0; i < SVehiculos.VerCantidadVehiculos(); i++)
            {
                fresumen.listBoxResumen.Items.Add($"Kilometraje:{SVehiculos.VerKilometraje(i),10:f2} - Patentes {SVehiculos.VerPatente(i)}");
            }
            fresumen.listBoxResumen.Items.Add($"Promedio Kilometros:{SVehiculos.VerPromedioKm(),10:f2} - Viajes Totales: {SVehiculos.VerCantidadViajes()}");
            fresumen.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
