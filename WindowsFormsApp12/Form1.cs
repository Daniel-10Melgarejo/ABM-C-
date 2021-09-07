using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaseDeDatos
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private OracleConnection conexion;

        private OracleDataAdapter adaptador;

        private DataSet datos;

        private void Form1_Load(object sender, EventArgs e)
        {
            // string oradb2 = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=ORCL)));User Id=SYS AS SYSDBA; Password=Melga_838@;";
            string oradb3 = "Data Source = ORCL; User Id = SYS AS SYSDBA; Password = Melga838_@; DBA Privilege = SYSDBA;";
            //string oradb = "Data Source=ORCL;User Id=SYS AS SYSDBA;Password=Melga838_@;";
            //conexion = new OracleConnection("Data Source=DESKTOP-N6FU7L1\\SQLEXPRESS;Initial Catalog=tp2;Integrated Security=True"); //AQUÍ VA EL STRING DE CONEXIÓN DE SU PC 
            conexion = new OracleConnection(oradb3);
            adaptador = new OracleDataAdapter();

            OracleCommand alta =  new OracleCommand("insert into USUARIOS(nombre, apellido, correo, telefono, cedula_identidad) values (:nombre, :apellido, :correo, :telefono, :cedula_identidad)", conexion); 
            
            adaptador.InsertCommand = alta;
            adaptador.InsertCommand.Parameters.Add(new OracleParameter("nombre", OracleDbType.Varchar2));
            adaptador.InsertCommand.Parameters.Add(new OracleParameter("apellido", OracleDbType.Varchar2));
            adaptador.InsertCommand.Parameters.Add(new OracleParameter("correo", OracleDbType.Varchar2));
            adaptador.InsertCommand.Parameters.Add(new OracleParameter("telefono", OracleDbType.Varchar2));
           // adaptador.InsertCommand.Parameters.Add(new OracleParameter("fecha", OracleDbType.Date));
            adaptador.InsertCommand.Parameters.Add(new OracleParameter("cedula_identidad", OracleDbType.Varchar2));

            OracleCommand baja = new OracleCommand("delete from usuarios where cedula_identidad=:cedula_identidad", conexion);
            adaptador.DeleteCommand = baja;
            adaptador.DeleteCommand.Parameters.Add(new OracleParameter("cedula_identidad", OracleDbType.Varchar2));

            OracleCommand modificacion = new OracleCommand("update usuarios set nombre=:nombre, apellido = :apellido where nombre = :nombreant", conexion); 

            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new OracleParameter("nombre", OracleDbType.Varchar2));
            adaptador.UpdateCommand.Parameters.Add(new OracleParameter("apellido", OracleDbType.Varchar2));
            adaptador.UpdateCommand.Parameters.Add(new OracleParameter("nombreant", OracleDbType.Varchar2));

            OracleCommand consulta = new OracleCommand("select nombre,apellido,correo,telefono,cedula_identidad from USUARIOS", conexion);
            adaptador.SelectCommand = consulta;
            datos = new DataSet();
            conexion.Open();
            adaptador.Fill(datos, "USUARIOS");
            conexion.Close();
           // grillaUsuarios.DataSource = datos;
            //grillaUsuarios.DataMember = "usuarios";
        }

        private void ActualizarDatos()
        {
            datos.Clear();
            adaptador.Fill(datos, "USUARIOS");
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            adaptador.InsertCommand.Parameters["nombre"].Value = txtNombre.Text;
            adaptador.InsertCommand.Parameters["apellido"].Value = txtApellido.Text;
            adaptador.InsertCommand.Parameters["correo"].Value = textCorreo.Text;
            adaptador.InsertCommand.Parameters["telefono"].Value = textTelefono.Text;
            //  adaptador.InsertCommand.Parameters["fecha"].Value = textFecha.Text;
            adaptador.InsertCommand.Parameters["cedula_identidad"].Value = textCedula.Text;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
                ActualizarDatos();
            }

            catch (SqlException excepcion)
            {

                MessageBox.Show(excepcion.ToString());
            }

            finally
            {
                conexion.Close();
            }
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            adaptador.DeleteCommand.Parameters["cedula_identidad"].Value = txtCedulaBaja.Text;

            try
            {
                conexion.Open();

                int cantidad = adaptador.DeleteCommand.ExecuteNonQuery();

                if (cantidad == 0)
                {

                    MessageBox.Show("No existe");
                }
                ActualizarDatos();
            }

            catch (SqlException excepcion)
            {

                MessageBox.Show(excepcion.ToString());
            }

            finally
            {
                conexion.Close();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            adaptador.UpdateCommand.Parameters["nombreant"].Value = txtNombreActual.Text;
            adaptador.UpdateCommand.Parameters["nombre"].Value = txtNuevoNombre.Text;
            adaptador.UpdateCommand.Parameters["apellido"].Value = txtApellido2.Text;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
                ActualizarDatos();
            }

            catch (SqlException excepcion)
            {

                MessageBox.Show(excepcion.ToString());
            }

            finally
            {
                conexion.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



