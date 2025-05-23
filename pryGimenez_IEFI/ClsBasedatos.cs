using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // Agregamos  System.Data.OleDb y System.Data
using System.Data;

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
                //rutabasedatos=
            }
            catch(Exception error)
            {

            }

        }

    }

}
