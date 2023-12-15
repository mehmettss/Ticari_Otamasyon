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
using System.Xml;

namespace Ticari_Otamasyon
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();


        void azalanstok()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select urunad,sum(adet) as 'ADET' FROM TBL_URUNLER GROUP BY URUNAD having SUM(adet)<=20 order by sum(adet)", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 11 tarıh,saat,baslık from TBL_NOTLAR  order by ıd desc", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        void listelefirmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec firmahareket2", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;

        }

        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ad,telefon1 from tbl_fırmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }

        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.haberturk.com/rss/manset.xml");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox2.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            azalanstok();
            ajanda();
            listelefirmahareket();
            fihrist();
            haberler();

            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
