using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGimenez_IEFI
{
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
        }
        ClsBasedatos cadena = new ClsBasedatos();
       
        private void Auditoria_Load(object sender, EventArgs e)
        {
            DgvGrilla.Columns.Add("colusuario", "usuario");
            DgvGrilla.Columns.Add("colfechahora", "fecha y hora");
            DgvGrilla.Columns.Add("colaccion", "accion");

            cadena.Auditoria(DgvGrilla);
            
        }

        private void Auditoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
           Principal back = new Principal();
            back.Show();
            this.Hide();
           
        }

        private void DgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
