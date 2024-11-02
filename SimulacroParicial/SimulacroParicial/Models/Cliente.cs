using System;
using System.Text.RegularExpressions;

namespace SimulacroParicial.Models
{
    internal class Cliente:Ticket
    {
        private long dni;
        static int numero = 0;

        public Cliente(int nroOrden,DateTime fechayHora,long dni):base(nroOrden,fechayHora)
        {
            string dnii = Convert.ToString(dni);
            Match match = null;
            match = Regex.Match(dnii, @"^[\d]{8}$", RegexOptions.IgnoreCase);

            if (match.Success)
            {
                this.dni = Convert.ToInt64(dni);

                if (this.dni < 5000000)
                    throw new Exception("El DNI ingresado es invalido");
                else
                {
                    base.nroOrden=nroOrden;
                    numero++;
                }
            }
            else
            {
                throw new Exception("El dni no puede contener letras");
            }
        }
        public override string ToString()
        {
            return nroOrden.ToString()+" - "+dni.ToString();
        }



    }
}
