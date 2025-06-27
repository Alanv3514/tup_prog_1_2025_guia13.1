using Ejercicio4;
using Ejercicio4.Modelos;
using Ejercicio4.VOCS.Modelos;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {

        Servicio SVehiculos = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Fdatos fdatos = new Fdatos();
            if (fdatos.ShowDialog() == DialogResult.OK)
            {
                if (SVehiculos.CrearVehiculo(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text)))
                {

                    this.listBoxPatentes.Items.Add(fdatos.tBpatente.Text);
                    this.btnCargarViaje.Enabled = true;
                    this.btnResumenFinal.Enabled = true;

                    if (SVehiculos.CVehiculos == 15)
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

                if (SVehiculos.CargarViaje(fdatos.tBpatente.Text, Convert.ToDouble(fdatos.tBkilometraje.Text)))
                {
                    this.labelCantViajes.Text = $"{SVehiculos.CViajes}";
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
            for (int i = 0; i < SVehiculos.CVehiculos; i++)
            {
                fresumen.listBoxResumen.Items.Add($"Kilometraje:{SVehiculos.VerKilometraje(i),10:f2} - Patentes {SVehiculos.VerPatente(i)}");
            }
            fresumen.listBoxResumen.Items.Add($"Promedio Kilometros:{SVehiculos.VerPromedioKm(),10:f2} - Viajes Totales: {SVehiculos.CViajes}");
            fresumen.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
