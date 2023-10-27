namespace FabricaDeVehiculosCl
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public Vehiculo(EPropulsion propulsion)
        {
            this.esAWD = false;
            this.propulsion = propulsion;
            numeroDeChasis = Guid.NewGuid();
        }

        public Vehiculo(bool esAWD, EPropulsion propulsion)
        {
            this.esAWD = esAWD;
            this.propulsion = propulsion;
            numeroDeChasis = Guid.NewGuid();
        }

        public EPropulsion Propulsion {
            get 
            {
                return propulsion;
            }
        }

        protected virtual string Tipo
        {
            get
            {
                return "Vehiculo";
            }
        }

       
        protected virtual string GetInfo()
        {
            string esAWD;
            if (this.esAWD)
            {
                esAWD = "Si";
            }
            else
            {
                esAWD = "NO";
            }
            return string.Format("{0} con propulsión a{1}, {2} es AWD, numero de chasis{3}.", this.Tipo, this.propulsion, esAWD, this.numeroDeChasis);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Tipo == v2.Tipo && v1.numeroDeChasis == v2.numeroDeChasis);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Tipo != v2.Tipo || v1.numeroDeChasis != v2.numeroDeChasis);
        }


        public string ToString()
        {
            return GetInfo();
        }
    }
    public enum EPropulsion
    {
        Combustion,
        Hibrida,
        Electrica
    }

}