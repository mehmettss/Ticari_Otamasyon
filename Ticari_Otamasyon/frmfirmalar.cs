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
    public partial class frmfirmalar : Form
    {
        public frmfirmalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmalar()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_fırmalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void iller()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_ILLER", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtil.Items.Add(dr[1]);
                txtil.DisplayMember = "SEHIR";
                txtil.ValueMember = "ID";
            }
            bgl.baglanti();
        }

        void caricodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("select FIRMAKOD1 from tbl_kodlar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }


        private void frmfirmalar_Load(object sender, EventArgs e)
        {
            
            iller();
            firmalar();
            temizle();
            caricodaciklamalar();

        }

        void temizle()
        {
            txtad.Text = "";
            txtid.Text = "";
            txtyetkili.Text = "";
            txtygorev.Text = "";
            txttc.Text = "";
            txtsektor.Text = "";
            txttel1.Text = "";
            txttel2.Text = "";
            txttel3.Text = "";
            txtmail.Text = "";
            txtfax.Text = "";
            txtil.Text = "";
            txtilce.Text = "";
            txtvergi.Text = "";
            txtadres.Text = "";
            txtkod1.Text = "";
            txtkod2.Text = "";
            txtkod3.Text = "";
            txtad.Focus();

        }


        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtygorev.Text = dr["YETKILISTATU"].ToString();
                txtyetkili.Text = dr["YETKILIADSOYAD"].ToString();
                txttc.Text = dr["YETKILITC"].ToString();
                txtsektor.Text = dr["SEKTOR"].ToString();
                txttel1.Text = dr["TELEFON1"].ToString();
                txttel2.Text = dr["TELEFON2"].ToString();
                txttel3.Text = dr["TELEFON3"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                txtfax.Text = dr["FAX"].ToString();
                txtil.Text = dr["IL"].ToString();
                txtilce.Text = dr["ILCE"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();
                txtadres.Text = dr["ADRES"].ToString();
                txtkod1.Text = dr["OZELKOD1"].ToString();
                txtkod2.Text = dr["OZELKOD2"].ToString();
                txtkod3.Text = dr["OZELKOD3"].ToString();


            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_fırmalar (ad,yetkılıstatu,yetkılıadsoyad,yetkılıtc,sektor,telefon1,telefon2,telefon3,maıl,fax,ıl,ılce,vergıdaıre,adres,ozelkod1,ozelkod2,ozelkod3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtygorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", txttc.Text);
            komut.Parameters.AddWithValue("@p5", txtsektor.Text);
            komut.Parameters.AddWithValue("@p6", txttel1.Text);
            komut.Parameters.AddWithValue("@p7", txttel2.Text);
            komut.Parameters.AddWithValue("@p8", txttel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p10", txtfax.Text);
            komut.Parameters.AddWithValue("@p11", txtil.Text);
            komut.Parameters.AddWithValue("@p12", txtilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergi.Text);
            komut.Parameters.AddWithValue("@p14", txtadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("musteri sisteme kayıt edildi");
            firmalar();
            temizle();

        }

        private void txtil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand konut = new SqlCommand("select ILCE from tbl_ILCELER WHERE SEHIR=@P1", bgl.baglanti());
            konut.Parameters.AddWithValue("@P1", txtil.SelectedIndex + 1);
            SqlDataReader dr = konut.ExecuteReader();
            txtilce.Items.Clear();
            while (dr.Read())
            {

                txtilce.Items.Add(dr[0]);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_fırmalar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalar();
            MessageBox.Show("secilen firma silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_fırmalar set ad=@p1,yetkılıstatu=@p2,yetkılıadsoyad=@p3,yetkılıtc=@p4,sektor=@p5,telefon1=@p6,telefon2=@p7,telefon3=@p8,maıl=@p9,fax=@p10,ıl=@p11,ılce=@p12,vergıdaıre=@p13,adres=@p14,ozelkod1=@p15,ozelkod2=@p16,ozelkod3=@p17 where ID=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtygorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", txttc.Text);
            komut.Parameters.AddWithValue("@p5", txtsektor.Text);
            komut.Parameters.AddWithValue("@p6", txttel1.Text);
            komut.Parameters.AddWithValue("@p7", txttel2.Text);
            komut.Parameters.AddWithValue("@p8", txttel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p10", txtfax.Text);
            komut.Parameters.AddWithValue("@p11", txtil.Text);
            komut.Parameters.AddWithValue("@p12", txtilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergi.Text);
            komut.Parameters.AddWithValue("@p14", txtadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.Parameters.AddWithValue("@p18",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("musteri guncellendi");
            firmalar();
            temizle();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

 
    }
}
