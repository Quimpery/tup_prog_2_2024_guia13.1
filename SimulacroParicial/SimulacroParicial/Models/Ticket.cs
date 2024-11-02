using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParicial.Models
{
    internal abstract class Ticket
    {
        protected int nroOrden;
        private DateTime FechayHora;
        

        public Ticket(int nroOrden, DateTime fechayHora)
        {
            this.nroOrden = nroOrden;
            FechayHora = fechayHora; 
        }

        public int VerNro()
        {
            return nroOrden;
                
        }
     public DateTime VerFechayHora()
        {
            return FechayHora;
        }
    }
}
