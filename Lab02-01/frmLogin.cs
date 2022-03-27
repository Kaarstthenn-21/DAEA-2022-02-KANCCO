using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {            
            string[] usernames = { "usuario1", "usuario2", "usuario3" };
            string[] password  = { "password1", "password2", "password3" };
            bool wasFound = false;

            for (int i = 0; i < usernames.Length; i++)
                if (txtUsuario.Text == usernames[i] && txtPassword.Text == password[i])
                {
                    wasFound = true;
                    break;
                }

            if (wasFound)
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                txtPassword.Clear();
                txtUsuario.Clear();
                txtPassword.ForeColor = Color.LightBlue;
                txtInfo.ForeColor = Color.Red;
                txtInfo.Text = "Credenciales incorrectas!";
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightBlue;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "usuario1 / password1";
        }
    }
}
