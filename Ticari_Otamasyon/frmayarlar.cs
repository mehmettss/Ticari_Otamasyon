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
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string ad;
        void listeleadmin()
        {
            DataTable dataTable = new DataTable();
            string sqlquery = "select * from tbl_admın where kullaniciad = @KullaniciAdi";
            SqlCommand komut3= new SqlCommand(sqlquery,bgl.baglanti());
            komut3.Parameters.AddWithValue("@KullaniciAdi", ad);
            SqlDataAdapter da = new SqlDataAdapter(komut3);
            
            da.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void frmayarlar_Load(object sender, EventArgs e)
        {
            
            listeleadmin();
            txtkullaniciad.Text = "";
            txtsifre.Text = "";
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            if (btnislem.Text == "Kaydet")
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_admın values (@p1,@p2)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
                cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("yeni admin sisteme kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleadmin();
            }
            if(btnislem.Text == "Guncelle")
            {
                SqlCommand komut = new SqlCommand("update tbl_admın set sifre=@p2 where kullaniciad=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
                komut.Parameters.AddWithValue("@p2", txtsifre.Text);
                komut.ExecuteNonQuery() ;
                bgl.baglanti() .Close();    
                MessageBox.Show("Kullanıcısifresi Guncellendi","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleadmin() ;
            }


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtkullaniciad.Text = dr["Kullaniciad"].ToString();
                txtsifre.Text = dr["Sifre"].ToString();
                btnislem.Text = "Guncelle";
                btnislem.BackColor = Color.GreenYellow;

            }
        }

        private void txtkullaniciad_TextChanged(object sender, EventArgs e)
        {
            if(txtkullaniciad.Text == "")
            {
                btnislem.Text = "Kaydet";
                btnislem.BackColor = Color.MediumTurquoise;

            }

        }
    }
}
