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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void Statushora_Click(object sender, EventArgs e)
        {

        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auditoria next = new Auditoria();
            next.Show();
            this.Hide();

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cerraSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio salir = new Inicio();
            salir.Show();
            this.Hide();
            MessageBox.Show("Cerrar Sesion con exito");
        }
    }

}
