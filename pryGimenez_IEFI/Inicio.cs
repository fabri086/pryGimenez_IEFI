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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        ClsBasedatos basedatos = new ClsBasedatos();

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = TxtUsuario.Text;
            string contraaseña = TxtContraseña.Text;
            basedatos.iniciarsesion(nombre, contraaseña);

            if (basedatos.estado == "Usuario correcto")
            {
                string rol = basedatos.rol;



                this.Hide();
                Principal siguiente = new Principal();

                siguiente.usuario = TxtUsuario.Text;

                siguiente.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario no identificado");
                
            }
            
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
