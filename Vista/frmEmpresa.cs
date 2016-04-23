using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                this.empresaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.digitalterminalDataSet);
                MessageBox.Show("la empresa se actualizó cone exito");
            }catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.ToString());
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'digitalterminalDataSet.empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.digitalterminalDataSet.empresa);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
