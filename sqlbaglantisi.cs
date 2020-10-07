using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ticariotomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FSK9SUOB\SQLEXPRESS;Initial Catalog=dboTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
