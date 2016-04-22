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
    public partial class frmListaUsuarios : Form
    {
        UsuarioModel usuarioM = new UsuarioModel();
        public frmListaUsuarios()
        {
            InitializeComponent();
        }

        private void frmListaUsuarios_Load(object sender, EventArgs e)
        {
            actDataG();
        }



        public void actDataG()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = usuarioM.getUsuarios();

            foreach (DataRow row in dt.Rows)
            {
                Int32 n = this.dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = row["id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = row["nombre"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = row["usuario"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = "Editar";

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                int idSistema = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                //MessageBox.Show("Edita " + idSistema);
                new frmUsuario(idSistema,this).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            new frmUsuario(0,this).ShowDialog();
        }
    }
}
