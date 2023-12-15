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
    public partial class frmgiderler : Form
    {
        public frmgiderler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();


        void giderlerlist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_gıderler ORDER BY ıd asc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtid.Text = "";
            txtay.Text = "";
            txtyil.Text = "";
            txtelektrik.Text = "";
            txtsu.Text = "";
            txtdogalgaz.Text = "";
            txtint.Text = "";
            txtmaas.Text = "";
            txtektra.Text = "";
            txtnot.Text = "";


        }

        private void frmgiderler_Load(object sender, EventArgs e)
        {
            giderlerlist();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_gıderler (ay,yıl,elektrık,su,dogalgaz,ınternet,maaslar,ekstra,notlar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtay.Text);
            komut.Parameters.AddWithValue("@p2", txtyil.Text);
            komut.Parameters.AddWithValue("@p3",decimal.Parse( txtelektrik.Text));
            komut.Parameters.AddWithValue("@p4",decimal.Parse( txtsu.Text));
            komut.Parameters.AddWithValue("@p5",decimal.Parse( txtdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6",decimal.Parse( txtint.Text));
            komut.Parameters.AddWithValue("@p7",decimal.Parse( txtmaas.Text));
            komut.Parameters.AddWithValue("@p8",decimal.Parse( txtektra.Text));
            komut.Parameters.AddWithValue("@p9", txtnot.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
   
            MessageBox.Show("gider eklendi");
            giderlerlist();
            //temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtay.Text = dr["AY"].ToString();
                txtyil.Text = dr["YIL"].ToString();
                txtelektrik.Text = dr["ELEKTRIK"].ToString() ;
                txtsu.Text = dr["SU"].ToString() ;
                txtdogalgaz.Text = dr["DOGALGAZ"].ToString();
                txtint.Text = dr["INTERNET"].ToString();
                txtmaas.Text = dr["MAASLAR"].ToString();
                txtektra.Text = dr["EKSTRA"].ToString();
                txtnot.Text = dr["NOTLAR"].ToString();


            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_gıderler where ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("gider silindi");
            giderlerlist();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_gıderler set ay=@p1,yıl=@p2,elektrık=@p3,su=@p4,dogalgaz=@p5,ınternet=@p6,maaslar=@p7,ekstra=@p8,notlar=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtay.Text);
            komut.Parameters.AddWithValue("@p2", txtyil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtelektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtint.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtektra.Text));
            komut.Parameters.AddWithValue("@p9", txtnot.Text);
            komut.Parameters.AddWithValue("@p10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("gider guncellendi");
            giderlerlist();
            temizle();
        }
    }
}
