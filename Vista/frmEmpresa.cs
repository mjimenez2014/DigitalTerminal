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
    public partial class frmEmpresa : Form
    {
        EmpresaModel empresaModel = new EmpresaModel();
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void cargaTextBoxs()
        {
            empresaModel = empresaModel.getEmpresa();
            textBoxRutEmpresa.Text = empresaModel.Rut;
            textBoxRazonSocial.Text = empresaModel.RazonSocial;
            textBoxGiroEmisor.Text = empresaModel.GiroEmisor;
            textBoxCodigoSucursal.Text = empresaModel.CodigoSiiSucursal.ToString();
            textBoxTelefonoEmisor.Text = empresaModel.Telefono;
            textBoxCorreoEmisor.Text = empresaModel.Correo;
            textBoxActeco.Text = empresaModel.Acteco.ToString();
            textBoxDireccionOrigen.Text = empresaModel.DireccionOrigen;
            textBoxComunaOrigen.Text = empresaModel.ComunaOrigen;
            textBoxCiudadOrigen.Text = empresaModel.CiudadOrigen;

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            cargaTextBoxs();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            EmpresaModel empresaModel = new EmpresaModel();
            try
            {
                empresaModel.Rut = textBoxRutEmpresa.Text;
                empresaModel.RazonSocial = textBoxRazonSocial.Text;
                empresaModel.GiroEmisor = textBoxGiroEmisor.Text;
                empresaModel.CodigoSiiSucursal = Convert.ToInt32(textBoxCodigoSucursal.Text);
                empresaModel.Telefono = textBoxTelefonoEmisor.Text;
                empresaModel.Correo = textBoxCorreoEmisor.Text;
                empresaModel.Acteco = Convert.ToInt32(textBoxActeco.Text);
                empresaModel.DireccionOrigen = textBoxDireccionOrigen.Text;
                empresaModel.ComunaOrigen = textBoxComunaOrigen.Text;
                empresaModel.CiudadOrigen = textBoxCiudadOrigen.Text;
                empresaModel.update(empresaModel);
                cargaTextBoxs();
                MessageBox.Show("La empresa se actualizo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Actualizar" + ex.ToString());
            }

        }
    }
}
