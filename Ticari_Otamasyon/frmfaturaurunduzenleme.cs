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
    public partial class frmfaturaurunduzenleme : Form
    {
        public frmfaturaurunduzenleme()
        {
            InitializeComponent();
        }
        public string urunid;

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listeleduzen()
        {

            SqlCommand cmd = new SqlCommand("select * from tbl_faturadetay where FATURAURUNID=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtid2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txturunad.Text = dr[1].ToString();
                txtfiyat.Text = dr[3].ToString();
                txtmiktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
                bgl.baglanti().Close();
            }
        }
        private void frmfaturaurunduzenleme_Load(object sender, EventArgs e)
        {
            txtid2.Text = urunid;
            listeleduzen();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturadetay set urunad=@p1,mıktar=@p2,fıyat=@p3,tutar=@p4 where FATURAURUNID=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunad.Text);
            komut.Parameters.AddWithValue("@p2",( txtmiktar.Text));
            komut.Parameters.AddWithValue("@p3",decimal.Parse( txtfiyat.Text));
            komut.Parameters.AddWithValue("@p4",decimal.Parse( txttutar.Text));
            komut.Parameters.AddWithValue("@p5", txtid2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("fatura detayı guncellendi");
            listeleduzen();
            


        }

        void temizleduzen()
        {
            txtid2.Text = "";
            txturunad.Text = "";
            txtmiktar.Text = "";
            txtfiyat.Text = "";
            txttutar.Text = "";
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturadetay where faturaurunıd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("secilen fatura detayı silindi");
            temizleduzen();
            
        }
    }
}
