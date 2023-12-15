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
using System.Data.Common;
using DevExpress.Utils.Extensions;

namespace Ticari_Otamasyon
{
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_musterıler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        
        void iller()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_ILLER",bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtil.Items.Add(dr[1]);
                txtil.DisplayMember = "SEHIR";
                txtil.ValueMember = "ID";
            }
            bgl.baglanti();
        }

        //void ilce()
        //{
        //    SqlCommand cmd = new SqlCommand("select * from tbl_ILCELER", bgl.baglanti());
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        txtilce.Items.Add(dr[1]);
        //    }
        //}

        private void frmmusteriler_Load(object sender, EventArgs e)
        {
            listele();
            iller();
            temizlemusteri();


        }

        private void txtil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand konut = new SqlCommand("select ILCE from tbl_ILCELER WHERE SEHIR=@P1", bgl.baglanti());
            konut.Parameters.AddWithValue("@P1",txtil.SelectedIndex+1);
            SqlDataReader dr = konut.ExecuteReader();
            txtilce.Items.Clear();
            while (dr.Read())
            {
               
                txtilce.Items.Add(dr[0]);
            }
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_musterıler (ad,soyad,telefon,telefon2,tc,maıl,ıl,ılce,adres,vergıdaıre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txttel1.Text);
            komut.Parameters.AddWithValue("@p4", txttel2.Text);
            komut.Parameters.AddWithValue("@p5", txttc.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7", txtil.Text);
            komut.Parameters.AddWithValue("@p8", txtilce.Text);
            komut.Parameters.AddWithValue("@p9", txtadres.Text);
            komut.Parameters.AddWithValue("@p10", txtvergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("yeni musteri eklendi");
            listele();
            temizlemusteri();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                txttel1.Text = dr["TELEFON"].ToString();
                txttel2.Text = dr["TELEFON2"].ToString();
                txttc.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                txtil.Text = dr["IL"].ToString();
                txtilce.Text = dr["ILCE"].ToString();
                txtadres.Text = dr["ADRES"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();

            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            DialogResult secim = new DialogResult();
            secim =MessageBox.Show("musteri kaydınız silinecektir.eminmisiniz?","musteri kaydı silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_musterıler where ID=@p1", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtid.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("musteri silindi");
                listele();
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_musterıler set ad=@p1,soyad=@p2,telefon=@p3,telefon2=@p4,tc=@p5,maıl=@p6,ıl=@p7,ılce=@p8,vergıdaıre=@p9,adres=@p10 where ıd=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txttel1.Text);
            komut.Parameters.AddWithValue("@p4", txttel2.Text);
            komut.Parameters.AddWithValue("@p5", txttc.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7", txtil.Text);
            komut.Parameters.AddWithValue("@p8", txtilce.Text);
            komut.Parameters.AddWithValue("@p10", txtadres.Text);
            komut.Parameters.AddWithValue("@p9", txtvergi.Text);
            komut.Parameters.AddWithValue("@p11",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("musteri guncellendi");
            listele();
        }
        void temizlemusteri()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txttel1.Text = "";
            txttel2.Text = "";
            txttc.Text = "";
            txtmail.Text = "";
            txtil.Text = "";
            txtilce.Text = "";
            txtadres.Text = "";
            txtvergi.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizlemusteri();
        }
    }
}
