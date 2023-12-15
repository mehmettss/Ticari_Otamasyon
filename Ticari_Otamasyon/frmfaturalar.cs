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
    public partial class frmfaturalar : Form
    {
        public frmfaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listelefatura()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_TBLFATURABILGI",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizlefatura()
        {
            txtid.Text = "";
            txtseri.Text = "";
            txtsırano.Text = "";
            txttarih.Text = "";
            txtsaat.Text = "";
            txtvergidaire.Text = "";
            txtalici.Text = "";
            txtselimeden.Text = "";
            txtteslimalan.Text = "";
        }

        private void frmfaturalar_Load(object sender, EventArgs e)
        {
            listelefatura();
            temizlefatura();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //firma carisi
            if (txtfaturaid.Text=="")
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_tblfaturabılgı (serı,sırano,tarıh,saat,vergıdaıre,alıcı,teslımeden,teslımalan) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtseri.Text);
                cmd.Parameters.AddWithValue("@p2", txtsırano.Text);
                cmd.Parameters.AddWithValue("@p3", txttarih.Text);
                cmd.Parameters.AddWithValue("@p4", txtsaat.Text);
                cmd.Parameters.AddWithValue("@p5", txtvergidaire.Text);
                cmd.Parameters.AddWithValue("@p6", txtalici.Text);
                cmd.Parameters.AddWithValue("@p7", txtselimeden.Text);
                cmd.Parameters.AddWithValue("@p8", txtteslimalan.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("yeni fatura bilgisi eklendi");
                listelefatura();
                temizlefatura();

            }
            //firma carisi--------------------------------------------
            if (txtfaturaid.Text != "" && comboBox1.Text == "Firma")
            {

                double miktar, tutar, fiyat;
                fiyat=Convert.ToDouble(txtfiyat.Text);
                miktar=Convert.ToDouble(txtmiktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text=tutar.ToString();
                SqlCommand komut = new SqlCommand("insert into tbl_faturadetay (urunad,mıktar,fıyat,tutar,faturaıd) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",txturunad.Text);
                komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
                komut.Parameters.AddWithValue("@p3",decimal.Parse( txtfiyat.Text));
                komut.Parameters.AddWithValue("@p4",decimal.Parse( txttutar.Text));
                komut.Parameters.AddWithValue("@p5", txtfaturaid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti() .Close();

                //HAREKET TABLOSUNA VERİ GİRİS
                SqlCommand komut3 = new SqlCommand("insert into tbl_fırmahareketler (urunıd,adet,personel,fırma,fıyat,toplam,faturaıd,tarıh) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtid2.Text);
                komut3.Parameters.AddWithValue("@h2", txtmiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtpersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtfirma.Text);
                komut3.Parameters.AddWithValue("@h5",decimal.Parse( txtfiyat.Text));
                komut3.Parameters.AddWithValue("@h6",decimal.Parse( txttutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtfaturaid.Text);
                komut3.Parameters.AddWithValue("@h8", txttarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //STOK SAYI AZALTMA
                SqlCommand komut4 = new SqlCommand("update tbl_urunler set adet-=@s1 where ıd=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtmiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtid2.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close(); 


                MessageBox.Show("fatura detayları eklendi");
            }
           

            //musteri carisi--------------------------------------------
            if (txtfaturaid.Text != "" && comboBox1.Text == "Musteri")
            {

                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmiktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
                SqlCommand komut = new SqlCommand("insert into tbl_faturadetay (urunad,mıktar,fıyat,tutar,faturaıd) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txturunad.Text);
                komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@p5", txtfaturaid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                //HAREKET TABLOSUNA VERİ GİRİS
                SqlCommand komut3 = new SqlCommand("insert into TBL_MUSTERIHAREKETLER (urunıd,adet,personel,musterı,fıyat,toplam,faturaıd,tarıh) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtid2.Text);
                komut3.Parameters.AddWithValue("@h2", txtmiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtpersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtfirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtfiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txttutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtfaturaid.Text);
                komut3.Parameters.AddWithValue("@h8", txttarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //STOK SAYI AZALTMA
                SqlCommand komut4 = new SqlCommand("update tbl_urunler set adet-=@s1 where ıd=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtmiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtid2.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("fatura detayları eklendi");
            }


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtseri.Text = dr["SERI"].ToString();
                txtsırano.Text = dr["SIRANO"].ToString();
                txttarih.Text = dr["TARIH"].ToString();
                txtsaat.Text = dr["SAAT"].ToString();
                txtvergidaire.Text = dr["VERGIDAIRE"].ToString();
                txtalici.Text = dr["ALICI"].ToString();
                txtselimeden.Text = dr["TESLIMEDEN"].ToString();
                txtteslimalan.Text = dr["TESLIMALAN"].ToString();

            }
        }

    

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizlefatura();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_tblfaturabılgı where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("fatura bilgisi silindi");
            listelefatura();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_tblfaturabılgı set serı=@p1,sırano=@p2,tarıh=@p3,saat=@p4,vergıdaıre=@p5,alıcı=@p6,teslımeden=@p7,teslımalan=@p8 where ID=@p9",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtseri.Text);
            cmd.Parameters.AddWithValue("@p2", txtsırano.Text);
            cmd.Parameters.AddWithValue("@p3", txttarih.Text);
            cmd.Parameters.AddWithValue("@p4", txtsaat.Text);
            cmd.Parameters.AddWithValue("@p5", txtvergidaire.Text);
            cmd.Parameters.AddWithValue("@p6", txtalici.Text);
            cmd.Parameters.AddWithValue("@p7", txtselimeden.Text);
            cmd.Parameters.AddWithValue("@p8", txtteslimalan.Text);
            cmd.Parameters.AddWithValue("@p9", txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" fatura bilgisi guncellendi");
            listelefatura();
            temizlefatura();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaurundetay fr = new frmfaturaurundetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null )
            {
                fr.id = dr["ID"].ToString();
            }
            fr.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut =  new SqlCommand("select urunad,satısfıyat from tbl_urunler where ıd=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txturunad.Text = dr[0].ToString();
                txtfiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

        }
    }
}
