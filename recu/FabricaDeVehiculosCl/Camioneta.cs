using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeVehiculosCl
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;


        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(true, propulsion)
        {
            this.cabinaSimple = cabinaSimple;

        }
        protected override string GetInfo()
        {
            string info;
            string cabinaSimple;
            StringBuilder sb = new StringBuilder();

            if (this.cabinaSimple)
            {
                cabinaSimple = "Simple";
            }
            else
            {
                cabinaSimple = "Doble";
            }

            info = base.GetInfo();

            sb.Append(info);
            sb.Append(", con cabina ");
            sb.Append(cabinaSimple);

            return sb.ToString();

        }



        protected override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }
    }
}
}
