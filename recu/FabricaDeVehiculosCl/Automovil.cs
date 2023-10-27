using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeVehiculosCl
{
    public class Automovil : Vehiculo
    {

        public Automovil() : base(EPropulsion.Hibrida)
        {

        }

        
        protected override string Tipo
        {
            get
            {
                return "Automovil";
            }
        }
    }
}
