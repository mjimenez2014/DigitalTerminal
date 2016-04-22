using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmUsuario : Form
    {
        UsuarioModel usuarioM = new UsuarioModel();
        frmListaUsuarios frmlistausuarios;
        int idUsuario;
        public frmUsuario()
        {
            InitializeComponent();
        }

        public frmUsuario(int idUsuario, frmListaUsuarios frmlistausuarios)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.frmlistausuarios = frmlistausuarios;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (idUsuario != 0)
            {
                DataTable dt = usuarioM.getUsuarioXId(idUsuario); 

                foreach (DataRow row in dt.Rows)
                {
                    textBoxNombre.Text = row["nombre"].ToString();
                    textBoxUsuario.Text = row["usuario"].ToString();
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxPass.Text == "" || textBoxUsuario.Text == "")
            {
                MessageBox.Show("Tiene que llenar todos los campos");
                textBoxNombre.Select();
            }
            else
            {
                if (usuarioM.exists(idUsuario) == "True")
                {
                    // si existe lo actualizo de lo contrario nuevo
                    usuarioM.nombre = textBoxNombre.Text;
                    usuarioM.usuario = textBoxUsuario.Text;
                    usuarioM.password = textBoxPass.Text;
                    usuarioM.id = idUsuario;
                    usuarioM.update(usuarioM);
                    this.frmlistausuarios.actDataG();
                    this.Close();
                    MessageBox.Show("El Usuario se actualizo!!");
                }
                else
                {
                    usuarioM.nombre = textBoxNombre.Text;
                    usuarioM.usuario = textBoxUsuario.Text;
                    usuarioM.password = textBoxPass.Text;
                    usuarioM.save(usuarioM);
                    this.frmlistausuarios.actDataG();
                    this.Close();
                    MessageBox.Show("El Usuario se creo con exito!!");
                }
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
