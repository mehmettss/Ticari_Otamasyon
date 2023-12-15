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
    public partial class frmbankalar : Form
    {
        public frmbankalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void bankaliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("execute bankabilgileri", bgl.baglanti());
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

        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from tbl_fırmalar", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;

        }

        void temizlebanka()
        {
            txtid.Text = "";
            txtbankaad.Text = "";
            txtil.Text = "";
            txtilce.Text = "";
            txtsube.Text = "";
            txtiban.Text = "";
            txthsp.Text = "";
            txtyetkili.Text = "";
            txttel.Text = "";
            maskedTextBox1.Text = "";
            txthesaptur.Text = "";
            lookUpEdit1.Text = "";


        }

        private void frmbankalar_Load(object sender, EventArgs e)
        {
            bankaliste();
            iller();
            firmalistesi();
            temizlebanka();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_bankalar (bankaadı,ıl,ılce,sube,ıban,hesapno,yetkılı,telefon,tarıh,hesapturu,fırmaıd) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankaad.Text);
            komut.Parameters.AddWithValue("@p2", txtil.Text);
            komut.Parameters.AddWithValue("@p3", txtilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", txtiban.Text);
            komut.Parameters.AddWithValue("@p6", txthsp.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", txttel.Text);
            komut.Parameters.AddWithValue("@p9", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p10", txthesaptur.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("banka ekleme islemi gerceklesti");
            bankaliste();

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
                txtbankaad.Text = dr["BANKAADI"].ToString();
                txtil.Text = dr["IL"].ToString();
                txtilce.Text = dr["ILCE"].ToString();
                txtsube.Text = dr["SUBE"].ToString();
                txtiban.Text = dr["IBAN"].ToString();
                txthsp.Text = dr["HESAPNO"].ToString();
                txtyetkili.Text = dr["YETKILI"].ToString();
                txttel.Text = dr["TELEFON"].ToString();
                txthesaptur.Text = dr["HESAPTURU"].ToString();
                maskedTextBox1.Text = dr["TARIH"].ToString();
                lookUpEdit1.Text = dr["AD"].ToString();






            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizlebanka();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from tbl_bankalar where ID=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("banka silme islemi gerceklesti");
            bankaliste();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_bankalar set bankaadı=@p1,ıl=@p2,ılce=@p3,sube=@p4,ıban=@p5,hesapno=@p6,yetkılı=@p7,telefon=@p8,tarıh=@p9,hesapturu=@p10,fırmaıd=@p11 where ID=@P12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankaad.Text);
            komut.Parameters.AddWithValue("@p2", txtil.Text);
            komut.Parameters.AddWithValue("@p3", txtilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", txtiban.Text);
            komut.Parameters.AddWithValue("@p6", txthsp.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", txttel.Text);
            komut.Parameters.AddWithValue("@p9", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p10", txthesaptur.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("banka guncelleme islemi gerceklesti");
            bankaliste();
        }
    }
}
