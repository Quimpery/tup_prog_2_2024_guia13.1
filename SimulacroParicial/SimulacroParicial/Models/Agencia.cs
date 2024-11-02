using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroParicial.Models
{
    class Agencia
    {

        public List<Ticket> ListaAtendidos = new List<Ticket>();
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();
        Queue<Cliente> nuevos = new Queue<Cliente>();

        
        public void AgregarTicket(Ticket turno)
        {
            
            if (turno != null)
            {
                if(turno is Denuncia)
                {
                    denuncias.Enqueue(turno as Denuncia);
                }
                else
                {
                    nuevos.Enqueue(turno as Cliente);
                }
            }
            else
            {
                throw new Exception("No se aceptan nulos");
            }
        }
        public void AtenderTicket(int tipo)
        {
            if (tipo == 1)
            {
                if(denuncias.Dequeue() != null)
                {
                    throw new Exception("No existe elemento para eliminar hdp");
                }
            }
            else if(tipo == 2) 
            {
                if(nuevos.Dequeue() == null)
                {
                    throw new Exception("No existe elemento para eliminar hdp");
                }
            }
      

        }
        public Vehiculo BuscarVehiculo(string patente)
        {
            Vehiculo vehiculo = null;
            foreach (Vehiculo v in listaVehiculos)
            {
                if (v.VerPatente().Equals(patente))
                    vehiculo = v;
            }
            return vehiculo;
        }

        public void AgregarVehiculos(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
        }

    }
}
