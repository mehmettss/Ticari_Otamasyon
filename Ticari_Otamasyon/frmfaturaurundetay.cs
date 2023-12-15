using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraBars;

namespace Ticari_Otamasyon
{
    public partial class frmfaturaurundetay : Form
    {
        public frmfaturaurundetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        
        void lisetlefaturadetay()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_faturadetay where FATURAID='"+id+"'",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }



        public string id;
        
        private void frmfaturaurundetay_Load(object sender, EventArgs e)
        {
        lisetlefaturadetay();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaurunduzenleme fr =new frmfaturaurunduzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.urunid = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
            //this.Hide();
        }
    }
}
