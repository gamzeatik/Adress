using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace ASKO
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GAMZE;Initial Catalog=ASKO;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
