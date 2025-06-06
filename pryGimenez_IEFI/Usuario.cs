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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        ClsBasedatos cadena = new ClsBasedatos();

        private void Usuario_Load(object sender, EventArgs e)
        {
            cadena.GrillaUsuario(DgvUsuario);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Principal back = new Principal();
            back.Show();
            this.Hide();
            
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
