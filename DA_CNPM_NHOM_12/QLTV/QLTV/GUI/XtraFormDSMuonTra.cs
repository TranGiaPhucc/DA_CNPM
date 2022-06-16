using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;

namespace GUI
{
    public partial class XtraFormDSMuonTra : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormDSMuonTra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reload()
        {
            textEditPhieuMuon.Enabled = false;
            textEditPhieuTra.Enabled = false;

            var ds = db.PHIEUTRAs.Select(t => t);
            dataGridViewDSTra.DataSource = ds;

            var d = db.PHIEUMUONs.Select(t => t);
            dataGridViewDSMuon.DataSource = d;

            textEditPhieuMuon.Text = (dataGridViewDSMuon.Rows.Count-1).ToString();
            textEditPhieuTra.Text = (dataGridViewDSTra.Rows.Count-1).ToString();
        }

        private void XtraFormDSTra_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}