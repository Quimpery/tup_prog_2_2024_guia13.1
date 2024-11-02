using SimulacroParicial.Models;
using System;
using System.Windows.Forms;

namespace SimulacroParicial
{
    public partial class Form1 : Form
    {
        Agencia agencia;
        public Form1()
        {
            InitializeComponent();
            agencia = new Agencia();
            cbTipo.Items.Add("Moto");
            cbTipo.Items.Add("Auto");
            cbTipo.Items.Add("Equipo de Trabajo");
            cbTipo.Items.Add("Bicicleta");
            agencia.AgregarVehiculos(new Vehiculo("abc432", new Cliente(400, DateTime.Now, 44210659)));
        }

        int numero = 0;


        private void btnTicket_Click(object sender, EventArgs e)
        {

            if (rbDenuncia.Checked)
            {
                string patente = tbPatente.Text;
                Vehiculo v = agencia.BuscarVehiculo(patente);
                Ticket denuncia = new Denuncia(v, numero, DateTime.Now);
                numero++;
                agencia.AgregarTicket(denuncia);
                lbTurnos.Items.Add(denuncia.ToString());
            }
            if (rbNuevoCliente.Checked)
            {
                if (tbDni != null && tbPatente != null && cbTipo.SelectedIndex != -1)
                {
                    long dni = Convert.ToInt64(tbDni.Text);
                    Ticket cliente = new Cliente(numero, DateTime.Now, dni);
                    numero++;
                    agencia.AgregarTicket(cliente);
                    lbTurnos.Items.Add(cliente.ToString());
                }
                else
                {
                    MessageBox.Show("Alguno de los campos esta incompleto");
                }
            }
        }

        private void btnAtenderDenuncias_Click(object sender, EventArgs e)
        {

            try
            {
                agencia.AtenderTicket(1);
                lbTurnos.Items.Remove(lbTurnos.SelectedItem);
            }
            catch(Exception exepcion)
            {
                MessageBox.Show(exepcion.Message);
            }


        }

        private void btnAtenderNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                agencia.AtenderTicket(2);
                lbTurnos.Items.Remove(lbTurnos.SelectedItem);
            }
            catch(Exception exepcion)
            {
                MessageBox.Show(exepcion.Message);  
            }
        }
    }
}
