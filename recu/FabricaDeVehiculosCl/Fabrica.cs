using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeVehiculosCl
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos { get { return this.vehiculos; }  }

        private Fabrica()
        {
             this.vehiculos = new List<Vehiculo>();  
        }
        public Fabrica(int capacidad) :this()
        {
            this.capacidad = capacidad; 
        }

        public static Fabrica operator +(Fabrica fabrica,Vehiculo vehiculo)
        {

            if (fabrica.capacidad > fabrica.vehiculos.Count)
            {
                fabrica.vehiculos.Add(vehiculo); 
            }

            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {

            if (0 < fabrica.vehiculos.Count)
            {
                foreach (Vehiculo item in fabrica.vehiculos)
                {
                    if (item == vehiculo )
                    {
                        fabrica.vehiculos.Remove(item);
                        break;
                    }
                }
            }

            return fabrica;
        }

    }
}
