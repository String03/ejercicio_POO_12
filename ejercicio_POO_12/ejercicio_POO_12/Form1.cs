using ejercicio_POO_12.Modelo;
using ejercicio_POO_12.Modelo.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_POO_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<Cliente> Clientes = new List<Cliente>();
        private List<Contenedor> Contenedores = new List<Contenedor>();

        private void RefrescarGrillaContenedor()
        {
            GrillaContenedores.DataSource = null;
            GrillaContenedores.DataSource = Contenedores;
        }

        private void RefrescarGrillaCliente()
        {
            GrillaClientes.DataSource = null;
            GrillaClientes.DataSource = Clientes;
        }

        private void RefrescarGrillaContenedoresCliente(Cliente cliente = null)
        {
            GrillaContenedoresCliente.DataSource = null;

            if (cliente != null)
            {

                GrillaContenedoresCliente.DataSource = cliente.Contenedores;

            }
            

        }

        private void Contener_Funcion_Peso(object o, EventArgs s)
        {
            var args = s as PesoSuperiorA4000Eventargs;
            string stringcliente;
          if (args.Cliente == null)
            {
                stringcliente = "cliente vacío";
            }
          else
            {
                stringcliente = "del cliente" + args.Cliente.Legajo + args.Cliente.Nombre + args.Cliente.Apellido + args.Cliente.RazonSocial;
            }
            MessageBox.Show(this, "el contenedor" + args.Contenedor.Codigo + args.Contenedor.Denominacion + stringcliente);


        }


        private void btn_alta_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Contenedor contenedor;
                if (rdo_contenedor_a.Checked)
                {

                    contenedor = new ContenedorA();


                }
                else if (rdo_contenedor_b.Checked)
                {
                    contenedor = new ContenedorB();
                }
                else
                {
                    throw new Exception("No seleccionó radiobutton");
                }


                contenedor.ContenerPesoSuperiorA4000EventArgs += Contener_Funcion_Peso;





                contenedor.Codigo = Convert.ToInt32(txt_codigo_contenedor.Text);
                contenedor.Denominacion = txt_denominacion_contenedor.Text;
                contenedor.FechaDeIngreso = DateTime.ParseExact(txt_fecha_de_ingreso_contenedor.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                contenedor.Peso = Convert.ToDouble(txt_peso_contenedor.Text);

                Contenedores.Add(contenedor);
                RefrescarGrillaContenedor();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_alta_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;

                if (rdo_empresa_cliente.Checked)
                {
                    cliente = new Empresa();
                    cliente.Legajo = Convert.ToInt32(txt_legajo_empresa_cliente.Text);
                    cliente.RazonSocial = txt_razonsocial_persona_cliente.Text;

                }
                else if (rdo_persona_cliente.Checked)
                {
                    cliente = new Persona();
                    cliente.Legajo = Convert.ToInt32(txt_legajo_persona_cliente.Text);
                    cliente.Nombre = txt_nombre_persona_cliente.Text;
                    cliente.Apellido = txt_apellido_persona_cliente.Text;
                }
                else
                {
                    throw new Exception("No seleccionó radiobutton");
                }

                           
                
                
                

                Clientes.Add(cliente);
                RefrescarGrillaCliente();


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }






        }

        private void btn_baja_contenedor_Click(object sender, EventArgs e)
        {
            try
            {

                Contenedor contenedor = GrillaContenedores.SelectedRows[0].DataBoundItem as Contenedor;


                Contenedores.Remove(contenedor);
                foreach (Cliente c in Clientes)
                {
                    c.Contenedores.RemoveAll(co => co.Codigo == contenedor.Codigo);
                }

                RefrescarGrillaContenedor();


                try
                {
                    Cliente cliente = GrillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                    RefrescarGrillaContenedoresCliente(cliente);
                }
                catch (Exception)
                {

                    RefrescarGrillaContenedoresCliente();
                }



            }
           
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_contenedores_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = GrillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                Contenedor contenedor = GrillaContenedores.SelectedRows[0].DataBoundItem as Contenedor;

                contenedor.Cliente = cliente;
                cliente.Contenedores.Add(contenedor);
                RefrescarGrillaContenedoresCliente(cliente);
                RefrescarGrillaContenedor();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
            
        }

        private void btn_baja_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;
                cliente = GrillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                foreach (Contenedor co in Contenedores)
                {
                    if(co.Cliente != null && cliente.Legajo == co.Cliente.Legajo)
                    {
                        co.Cliente = null;
                    }
                }

                Clientes.Remove(cliente);
                RefrescarGrillaCliente();
                RefrescarGrillaContenedoresCliente();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_modificacion_contenedor_Click(object sender, EventArgs e)
        {
            try
            {
                Contenedor contenedor = GrillaContenedores.SelectedRows[0].DataBoundItem as Contenedor;

                contenedor.Denominacion = txt_denominacion_contenedor.Text;
                contenedor.FechaDeIngreso = DateTime.ParseExact(txt_fecha_de_ingreso_contenedor.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                contenedor.Peso = Convert.ToDouble(txt_peso_contenedor.Text);

                


                RefrescarGrillaContenedor();

                try
                {
                    Cliente cliente = GrillaClientes.SelectedRows[0].DataBoundItem as Cliente;
                    RefrescarGrillaContenedoresCliente(cliente);
                }
                catch (Exception )
                {

                    RefrescarGrillaContenedoresCliente();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_modificacion_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = GrillaClientes.SelectedRows[0].DataBoundItem as Cliente;

                if (cliente is Empresa)
                {
                    cliente.RazonSocial = txt_razonsocial_persona_cliente.Text;
                }

                else if(cliente is Persona){
                    cliente.Nombre = txt_nombre_persona_cliente.Text;
                    cliente.Apellido = txt_apellido_persona_cliente.Text;
                }
                else
                {
                    throw new Exception("no");
                }

                


                RefrescarGrillaCliente();
                RefrescarGrillaContenedoresCliente(cliente);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
