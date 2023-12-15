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
using DevExpress.Charts;

namespace Ticari_Otamasyon
{
    public partial class frmkasa : Form
    {
        public frmkasa()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();


        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MUSTERIHAREKETLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute FIRMAHAREKETLER", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        public string ad;
        private void frmkasa_Load(object sender, EventArgs e)
        {

            lblaktifkullanici.Text = ad;
            musterihareket();
            firmahareket();
            //toplam tutarı hesaplama
            SqlCommand komut1 = new SqlCommand("select sum(tutar) from tbl_faturadetay", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblkasatoplam.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //SON AYIN ODEMELERİ
            SqlCommand komut2 = new SqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) FROM TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblodemeler.Text = dr2[0].ToString() + " TL";

            }
            bgl.baglanti().Close();
            //SON AYIN PERSONEL MAASLARI
            SqlCommand komut3 = new SqlCommand("SELECT MAASLAR FROM TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblpermaas.Text = dr3[0].ToString() + " TL";

            }
            bgl.baglanti().Close();
            //TOPLAM MUSTERİ SAYISI
            SqlCommand komut4 = new SqlCommand("SELECT count(*) FROM tbl_musterıler", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblmusterisay.Text = dr4[0].ToString() ;

            }
            bgl.baglanti().Close();
            //TOPLAM fırma SAYISI
            SqlCommand komut5 = new SqlCommand("SELECT count(*) FROM tbl_fırmalar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblfirmasay.Text = dr5[0].ToString();

            }
            bgl.baglanti().Close();

            //TOPLAM fırma sehir SAYISI
            SqlCommand komut6 = new SqlCommand("SELECT count(distinct(ıl)) FROM tbl_fırmalar", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblsehirsay.Text = dr6[0].ToString();

            }
            bgl.baglanti().Close();

            //TOPLAM personel SAYISI
            SqlCommand komut7 = new SqlCommand("SELECT count(distinct(ıl)) FROM tbl_fırmalar", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblpersay.Text = dr7[0].ToString();

            }
            bgl.baglanti().Close();

            //TOPLAM urun-stok SAYISI
            SqlCommand komut8 = new SqlCommand("SELECT sum(adet) FROM tbl_urunler", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblstoksay.Text = dr8[0].ToString();

            }
            bgl.baglanti().Close();



     
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //ELEKTRİK
            if (sayac>0 && sayac<=5 )
            {
                groupControl10.Text = "ELEKTRİK";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 4 ay,elektrık from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayac>5 && sayac<=10)
            {
                groupControl10.Text = "SU";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,su from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //DOGALGAZ
            if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "DOGALGAZ";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("select top 4 ay,dogalgaz from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //internet
            if (sayac > 15 && sayac <= 20)
            {
                groupControl10.Text = "İNTERNET";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 4 ay,ınternet from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            //EKSTRA
            if (sayac > 20 && sayac <= 25)
            {
                groupControl10.Text = "EKSTRA";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut14 = new SqlCommand("select top 4 ay,ekstra from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();

            }
            if (sayac==26)
            {
                sayac = 0;
            }
        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            //ELEKTRİK
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "ELEKTRİK";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 4 ay,elektrık from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            //SU
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "SU";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 ay,su from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            //DOGALGAZ
            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl11.Text = "DOGALGAZ";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("select top 4 ay,dogalgaz from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //internet
            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl11.Text = "İNTERNET";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 4 ay,ınternet from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            //EKSTRA
            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl11.Text = "EKSTRA";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut14 = new SqlCommand("select top 4 ay,ekstra from tbl_gıderler order by ıd desc", bgl.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();
                while (dr14.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgl.baglanti().Close();

            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
