using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatosInvenTacos;

namespace InvenTacos.GUIs
{
    public partial class Frm_Permitir : Form
    {
        public bool Autorizado;

        public Frm_Permitir()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Autorizar();
        }
        private void Autorizar()
        {
            string usuario = txbUsuario.Text.ToUpper();
            string contraseña = txbContraseña.Text.ToUpper();

            Credenciales Sesion = new Credenciales();
            if (usuario == Sesion.Usuario && contraseña == Sesion.Contraseña)
            {                
                Autorizado= true;
                this.Close();
            }
            else
            {
                Autorizado= false;
                MessageBox.Show("Las credenciales son incorrectas...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Autorizar();
        }
    }
}
