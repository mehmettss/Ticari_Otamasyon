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
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt =new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_urunler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmurunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //verileri kaydetme
            SqlCommand komut = new SqlCommand("insert into tbl_urunler (urunad,marka,model,yıl,adet,alısfıyat,satısfıyat,detay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", txtyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((txtadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalisf.Text).ToString());
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatisf.Text).ToString());
            komut.Parameters.AddWithValue("@p8", txtdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("urun sisteme eklendi");
            listele();
            temizleurun();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_urunler where ID=@P1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("urunsilindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["ID"].ToString();
            txtad.Text = dr["urunAD"].ToString();
            txtmarka.Text = dr["marka"].ToString();
            txtmodel.Text = dr["model"].ToString();
            txtyil.Text = dr["yıl"].ToString();
            txtadet.Text = dr["adet"].ToString();
            txtalisf.Text = dr["alısfıyat"].ToString();
            txtsatisf.Text = dr["satısfıyat"].ToString();
            txtdetay.Text = dr["detay"].ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE tbl_urunler set urunad=@p1,marka=@p2,model=@p3,yıl=@p4,adet=@p5,alısfıyat=@p6,satısfıyat=@p7,detay=@p8 where ID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", txtyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((txtadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalisf.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatisf.Text));
            komut.Parameters.AddWithValue("@p8", txtdetay.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("urun bilgisi guncellendi");
            listele();
        }

        void temizleurun()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            txtyil.Text = "";
            txtalisf.Text = "";
            txtsatisf.Text = "";
            txtdetay.Text = "";
            txtadet.Value = 0;
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizleurun();
        }
    }
}
