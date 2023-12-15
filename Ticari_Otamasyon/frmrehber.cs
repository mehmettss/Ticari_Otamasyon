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

namespace Ticari_Otamasyon
{
    public partial class frmrehber : Form
    {
        public frmrehber()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmrehber_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ad,soyad,telefon,telefon2,maıl from tbl_musterıler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource= dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select ad,yetkılıadsoyad,telefon1,telefon2,telefon3,maıl,fax from tbl_fırmalar", bgl.baglanti());
            da1.Fill(dt2 );
            gridControl2.DataSource= dt2;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmmail frm = new frmmail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null )
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmmail frm = new frmmail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
