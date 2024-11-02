using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParicial.Models
{
    internal class Vehiculo:IComparable<Vehiculo>
    {
        private string nroPatente;
        private Cliente dueño;

        public Vehiculo(string patente, Cliente dueño)
        {
            nroPatente = patente;
            this.dueño=dueño;
        }
        public Cliente VerDueño()
        {
            return dueño;
        }
        public string VerPatente()
        {
            return nroPatente;
        }
        public int CompareTo(Vehiculo v)
        {
            if (v != null)
                return this.nroPatente.CompareTo(v.nroPatente);
            return 0;
        }
    }
}
