using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Ticari_Otamasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-91LH8V7\SQLEXPRESS;Initial Catalog=DboTicariOtamasyon;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
