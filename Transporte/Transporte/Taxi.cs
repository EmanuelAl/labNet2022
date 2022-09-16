using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Taxi : TransportePublico
    {
        private string nombre { get; set; }
        public Taxi(int pasajeros): base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return "Estoy avanzando";
        }

        public override string Detenerse()
        {
            return "Estoy retrocediendo";
        }
        public override string MostrarPasajeros()
        {
            return $" {pasajeros} pasajeros ";
        }

        private string CargarCombustible()
        {
            return "";
        }
    }
}
