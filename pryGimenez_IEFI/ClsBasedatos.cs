using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // Agregamos  System.Data.OleDb y System.Data
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace pryGimenez_IEFI
{
    internal class ClsBasedatos
    {
        OleDbConnection coneccionBD;
        OleDbCommand comandoBD;
        OleDbDataReader corriendoBD;
        OleDbDataAdapter adaptadorBD;

        DataSet obj; // esto es dato de memoria

        string rutabasedatos;
        public string estado;

        public string rol;

        public void Usuario()
        {
            try
            {
                rutabasedatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Registro.accdb";
                    
                obj = new DataSet();
                estado = "Conectado con exito";
            }
            catch(Exception error)
            {
                estado = error.Message;
            }
           
        }
        public void Registrodesesion(string User, string rol)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = coneccionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Auditoria";

            User = User.ToString();
            rol = rol.ToString();

            adaptadorBD = new OleDbDataAdapter();
            adaptadorBD.Fill(obj, "Auditoria");


        }
        
        public void iniciarsesion(string nombreUser, string passUser)// para poder ingresar en el form
        {
            try
            {
                rutabasedatos = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Registro.accdb";

                coneccionBD = new OleDbConnection(rutabasedatos);
                coneccionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = coneccionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuarios";

                corriendoBD = comandoBD.ExecuteReader();
                if (corriendoBD.HasRows)
                {
                    while (corriendoBD.Read())
                    {
                        if(corriendoBD[1].ToString() == nombreUser && corriendoBD[2].ToString() == passUser)
                        {
                            estado = "Usuario correcto";
                            string Nombre = Environment.UserName;
                            string horaingresada = DateTime.Now.ToString();

                            //agrgado ahora 11/06/
                            /*
                            coneccionBD = new OleDbConnection(rutabasedatos);
                            coneccionBD.Open();
                            comandoBD = new OleDbCommand();

                            comandoBD.Connection = coneccionBD;
                            comandoBD.CommandType = System.Data.CommandType.TableDirect;
                            comandoBD.CommandText = "Auditoria";
                            */

                        }

                    }

                }

            }
            catch(Exception error)
            {
                estado = error.Message;
            }

        }
        
        public void Auditoria(DataGridView grilla)
        {
            try
            {
                string Usuario = Environment.UserName;
                string FechaHora = DateTime.Now.ToString("g");
                string Rol = "";

                grilla.Rows.Add(Usuario, FechaHora, Rol);
           
            }  
            catch (Exception error)
            {
                estado = error.Message;
            }

        }
        
        public void GrillaUsuario(DataGridView grilla2)
        {
            try
            {
                string ConnectionChain = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Registro.accdb";

                using (OleDbConnection connection = new OleDbConnection(ConnectionChain))
                {
                    connection.Open();
                    OleDbCommand comand = new OleDbCommand("SELECT * FROM Usuarios", connection);

                    OleDbDataAdapter adapter = new OleDbDataAdapter(comand);

                    DataTable tabla = new DataTable();

                    adapter.Fill(tabla);

                    grilla2.DataSource = tabla;

                    estado = "Usuario cargado completo";

                }

            }
            catch (Exception error)
            {
                estado = "Error al mostrar " + error.Message;
                MessageBox.Show(estado);
            }


        }



    }

}
