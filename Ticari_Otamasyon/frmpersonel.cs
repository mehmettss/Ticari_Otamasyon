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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void personelliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_personeller",bgl.baglanti());
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

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txttel1.Text = "";
            txttc.Text = "";
            txtmail.Text = "";
            txtil.Text = "";
            txtilce.Text = "";
            txtadres.Text = "";
            txtgorev.Text = "";


        }


        private void frmpersonel_Load(object sender, EventArgs e)
        {
            personelliste();
            iller();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_personeller (ad,soyad,telefon,tc,maıl,ıl,ılce,adres,gorev) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txttel1.Text);
            komut.Parameters.AddWithValue("@p4", txttc.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", txtil.Text);
            komut.Parameters.AddWithValue("@p7", txtilce.Text);
            komut.Parameters.AddWithValue("@p8", txtadres.Text);
            komut.Parameters.AddWithValue("@p9", txtgorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("personel eklendi");
            personelliste();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsoyad.Text = dr["SOYAD"].ToString();
                txttel1.Text = dr["TELEFON"].ToString();
                txttc.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                txtil.Text = dr["IL"].ToString();
                txtilce.Text = dr["ILCE"].ToString();
                txtadres.Text = dr["ADRES"].ToString();
                txtgorev.Text = dr["GOREV"].ToString();

            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from tbl_personeller where ID=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("personel silindi");
            personelliste();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("update tbl_personeller set ad=@p1,soyad=@p2,telefon=@p3,tc=@p4,maıl=@p5,ıl=@p6,ılce=@p7,adres=@p8,gorev=@p9 where ıd=@p10", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtad.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtsoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txttel1.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txttc.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtmail.Text);
            sqlCommand.Parameters.AddWithValue("@p6", txtil.Text);
            sqlCommand.Parameters.AddWithValue("@p7", txtilce.Text);
            sqlCommand.Parameters.AddWithValue("@p8", txtadres.Text);
            sqlCommand.Parameters.AddWithValue("@p9", txtgorev.Text);
            sqlCommand.Parameters.AddWithValue("@p10",txtid.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("personel bilgileri guncellendi");
            personelliste();
            temizle();
        }
    }
}
