using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // Agregamos  System.Data.OleDb y System.Data
using System.Data;
using System.Security.Cryptography.X509Certificates;

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
        public void Registrodesesion()
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = coneccionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "logs";

            adaptadorBD = new OleDbDataAdapter();
            adaptadorBD.Fill(obj, "logs");

        }
        
        public void iniciarsesion(string nombreUser, string passUser)
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
                        }
                    }
                }
            }
            catch(Exception error)
            {
                estado = error.Message;
            }

        }


    }

}
