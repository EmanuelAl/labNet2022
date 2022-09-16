using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Omnibus: TransportePublico
    {
        private string nombre { get; set; }
        public Omnibus(int pasajeros): base(pasajeros)
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
