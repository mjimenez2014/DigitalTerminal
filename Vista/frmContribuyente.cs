using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using System.Data.Odbc;

namespace Vista
{
    public partial class frmContribuyente : Form
    {
        CiudadesModel ciudad = new CiudadesModel();
        ComunasModel comuna = new ComunasModel();
        frmCiudades frmciudad = new frmCiudades();
        frmComunas frmcomuna = new frmComunas();
        ContribuyenteModel clienteM = new ContribuyenteModel();
        

        public frmContribuyente()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
           // txtRut.Text = new MetodosComunes().formatearRut(txtRut.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }



        private void textBoxRutCliente_Validated(object sender, EventArgs e)
        {
            textBoxRutCliente.Text = new MetodosComunes().formatearRut(textBoxRutCliente.Text);
        }

        private void frmConstribuyente_Load(object sender, EventArgs e)
        {
            textBoxRutCliente.Select();
            comboBoxCiudad.ValueMember = "codCiudad";
            comboBoxCiudad.DisplayMember = "nomCiudad";
            comboBoxCiudad.DataSource = ciudad.getCiudades();
        }



        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxComuna.Text = "";
            labelCodCiudad.Text = comboBoxCiudad.SelectedValue.ToString();
            comboBoxComuna.ValueMember = "codComuna";
            comboBoxComuna.DisplayMember = "nomComuna";
            comboBoxComuna.DataSource =  comuna.getComunasXCiudad(Convert.ToInt32(labelCodCiudad.Text));
            comboBoxComuna.Enabled = true;

        }


        private void buttonNuevaCiudad_Click(object sender, EventArgs e)
        {
            frmciudad.ShowDialog();
        }

        private void buttonNuevaComuna_Click(object sender, EventArgs e)
        {
            frmcomuna.ShowDialog();
        }

        private void comboBoxComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCodComuna.Text = comboBoxComuna.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxRutCliente.Text == "")
            {
            }
            else
            {
                
                string rut = textBoxRutCliente.Text.ToUpper();
                if (clienteM.getContribuyente(rut).Rows.Count != 0)
                {
                    // MessageBox.Show("El cliente ya esta creado.");
                    clienteM.rut = rut;
                    clienteM.rznSoc = textBoxRazonSocial.Text.ToUpper();
                    clienteM.giro = textBoxGiro.Text.ToUpper();
                    clienteM.direccion = textBoxDireccion.Text.ToUpper();
                    clienteM.codComuna = Convert.ToInt32(labelCodComuna.Text);
                    clienteM.codCiudad = Convert.ToInt32(labelCodCiudad.Text);
                    clienteM.telefono = textBoxTelefono.Text;
                    try
                    {
                        clienteM.update(clienteM);
                        MessageBox.Show("El Cliente " + clienteM.rznSoc + " se actualizó con exito!!");
                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error al actualizar cliente " + ex.Message);
                    }

                }
                else
                {
                    clienteM.rut = rut;
                    clienteM.rznSoc = textBoxRazonSocial.Text.ToUpper();
                    clienteM.giro = textBoxGiro.Text.ToUpper();
                    clienteM.direccion = textBoxDireccion.Text.ToUpper();
                    clienteM.codComuna = Convert.ToInt32(labelCodComuna.Text);
                    clienteM.codCiudad = Convert.ToInt32(labelCodCiudad.Text);
                    clienteM.telefono = textBoxTelefono.Text;
                    try
                    {
                        clienteM.save(clienteM);
                        MessageBox.Show("El Cliente " + clienteM.rznSoc + " se creo con exito!!");
                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Error al crear cliente" + ex.Message);
                    }
                }
            }
        }

        private void buttonProdCli_Click(object sender, EventArgs e)
        {
            if (textBoxRutCliente.Text == "")
            {
                MessageBox.Show("Tiene que ingresar el cliente");
                textBoxRutCliente.Select();
                textBoxRutCliente.SelectAll();
            }
            else
            {
                new frmClientePrecio(this).ShowDialog();
            }
        }




        private void textBoxRutCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (e.KeyChar == (char)13)
            {
                textBoxRutCliente.Text = new MetodosComunes().formatearRut(textBoxRutCliente.Text);
                OdbcDataReader reader = clienteM.getClienteReader(textBoxRutCliente.Text.ToUpper());
                while (reader.Read())
                {
                    textBoxRutCliente.Text = reader.GetString(reader.GetOrdinal("rutRecep"));
                    textBoxRazonSocial.Text = reader.GetString(reader.GetOrdinal("rznSocRecep"));
                    textBoxGiro.Text = reader.GetString(reader.GetOrdinal("giroRecep"));
                    textBoxDireccion.Text = reader.GetString(reader.GetOrdinal("dirRecep"));
                    labelCodComuna.Text = reader.GetString(reader.GetOrdinal("codComuna"));
                    labelCodCiudad.Text = reader.GetInt32(reader.GetOrdinal("codCiudad")).ToString();
                    comboBoxCiudad.Text = reader.GetString(reader.GetOrdinal("nomCiudad"));
                    textBoxTelefono.Text = reader.GetString(reader.GetOrdinal("telefono"));
                    comboBoxComuna.Text = reader.GetString(reader.GetOrdinal("nomComuna"));

                }
            }
        }



    }
}
