using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FabricaDeVehiculosCl;


namespace recu
{
    public partial class Form1 : Form
    {
        private Fabrica fabrica;

        public Form1()
        {
            InitializeComponent();
            fabrica = new Fabrica(10);
        }
        /// <summary>
        /// Crea un nuevo vehiculo segun el cmb
        /// </summary>
        /// <returns>retorna el nuevo vehiculo</returns>
        private Vehiculo CrearVehiculo()
        {
            Vehiculo nuevoVehiculo = null;

            switch (cmbTipo.SelectedText)
            {
                case "Moto":
                    nuevoVehiculo = new Moto(EPropulsion.Electrica);
                    break;
                case "Automovil":
                    nuevoVehiculo = new Automovil();
                    break;
                case "Camioneta":
                    nuevoVehiculo = new Camioneta(EPropulsion.Combustion, true);
                    break;
            }

            return nuevoVehiculo;
        }
        /// <summary>
        /// Refresca la lst
        /// 
        /// </summary>
        private void Refrescar()
        {
            StringBuilder sb = new StringBuilder();
            lstVehiculos.Items.Clear();

            lstVehiculos.DataSource = null;
            foreach (var item in fabrica.Vehiculos)
            {
                sb.AppendLine(item.ToString());
            }

            lstVehiculos.DataSource = sb.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = null;

            nuevoVehiculo = CrearVehiculo();

            fabrica = fabrica + nuevoVehiculo;

            Refrescar();
        }

    //    private void btnEliminar_Click(object sender, EventArgs e)
    //    {
    //        switch (cmbTipo.SelectedText)
    //        {
    //            case "Moto":
    //                foreach (Vehiculo item in fabrica.Vehiculos)
    //                {
    //                    item.
    //                }
    //                break;
    //            case "Automovil":
    //                nuevoVehiculo = new Automovil();
    //                break;
    //            case "Camioneta":
    //                nuevoVehiculo = new Camioneta(EPropulsion.Combustion, true);
    //                break;
    //        }

    //        return nuevoVehiculo;
    //    }
    }
}
