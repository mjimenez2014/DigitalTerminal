using System;
using System.Data;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmVentasXFecha : Form
    {
        string desde = string.Empty;
        string hasta = string.Empty;
        DataTable dataTable = new DataTable();

        public frmVentasXFecha()
        {
            InitializeComponent();
        }

        public frmVentasXFecha(string desde, string hasta)
        {
            InitializeComponent();
            this.desde = desde;
            this.hasta = hasta;
        }

        private void frmVentasXFecha_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataTable = new DocumentoModel().getVentasXFecha(desde, hasta);
            foreach (DataRow fila in dataTable.Rows)
            {
                Int32 n = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = fila["nombre"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = fila["TipoDTE"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = fila["Folio"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = fila["FchEmis"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = fila["RznSocRecep"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = fila["MntNeto"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = fila["MntExe"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = fila["IVA"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = fila["MntTotal"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.exportaraexcel(dataGridView1);
        }
    }
}
