using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParicial.Models
{
    internal class Denuncia:Ticket
    {
        private Vehiculo dominio;
        static int numero;



        public Denuncia(Vehiculo asegurado,int nroOrden,DateTime fecha):base(nroOrden, fecha)
        {
            dominio = asegurado;
            base.nroOrden = nroOrden;
        }

        public override string ToString()
        {
            return nroOrden + " - " + dominio.VerPatente();
        }

    }
}
