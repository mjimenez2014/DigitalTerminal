using System;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmLogin : Form
    {
        UsuarioModel userModel = new UsuarioModel();
        RegistroWin regWin = new RegistroWin();
        BaseDato baseDato = new BaseDato();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (baseDato.ConnectPostgres() == null)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS: \n 1.- Revise si esta instalado el ODBC\n 2.- Las configuraciones de registro windows", "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                txtContrasena.PasswordChar = '*';
                if (regWin.getRegWin().unidadDT == null)
                {
                    MessageBox.Show(regWin.creaRegistrosWin(), "Digital Terminal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (userModel.validaUser(txtNombreUsuario.Text, txtContrasena.Text) == "true")
            {
                new frmInicio().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Invalido!");
                txtNombreUsuario.Text = "";
                txtContrasena.Text = "";
                txtNombreUsuario.Select();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtContrasena.Select();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
