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
using DevExpress.XtraCharts.Designer;

namespace Ticari_Otamasyon
{
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select urunad,sum(adet) as 'Miktar' from TBL_URUNLER group by URUNAD",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //charta stok miktarı ekleme
            SqlCommand komut = new SqlCommand("select urunad,sum(adet) as 'Miktar' from tbl_urunler group by urunad",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

            //ChartActionsControl SEHİR SAYISI CEKME
            SqlCommand konut2 = new SqlCommand("select ıl,count(*) from tbl_fırmalar group by ıl", bgl.baglanti());
            SqlDataReader dr2=konut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 2"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmstokdetay fr = new frmstokdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
            }
            fr.Show();
        }
    }
}
