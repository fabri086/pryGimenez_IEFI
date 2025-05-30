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
            cadena.Auditoria(DgvGrilla);
        }

        private void Auditoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
