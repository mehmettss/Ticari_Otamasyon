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
    public partial class frmnotlar : Form
    {
        public frmnotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listelenot()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_notlar",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizlenot()
        {
            txtid.Text = "";
            txttarih.Text = "";
            txtsaat.Text = "";
            txtbaslik.Text = "";
            txtdetay.Text = "";
            txtolusturan.Text = "";
            txthitap.Text = "";
        }
        private void frmnotlar_Load(object sender, EventArgs e)
        {
            listelenot();
            temizlenot();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_notlar (tarıh,saat,baslık,detay,olusturan,hıtap) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txttarih.Text);
            komut.Parameters.AddWithValue("@p2", txtsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtdetay.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txthitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("not bilgisi sisteme eklendi");
            listelenot() ;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
             if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txttarih.Text = dr["TARIH"].ToString();
                txtsaat.Text = dr["SAAT"].ToString();
                txtbaslik.Text = dr["BASLIK"].ToString();
                txtdetay.Text = dr["DETAY"].ToString();
                txtolusturan.Text = dr["OLUSTURAN"].ToString();
                txthitap.Text = dr["HITAP"].ToString();

            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizlenot() ;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_notlar where ID='" + txtid.Text + "'",bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("secilen not silindi");
            listelenot();
            temizlenot();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_notlar set tarıh=@p1,saat=@p2,baslık=@p3,detay=@p4,olusturan=@p5,hıtap=@p6 where ıd=@p7",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txttarih.Text);
            komut.Parameters.AddWithValue("@p2", txtsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtdetay.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txthitap.Text);
            komut.Parameters.AddWithValue("@p7", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("not bilgisi guncellendi");
            listelenot();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmnotdetay fr = new frmnotdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null )
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
