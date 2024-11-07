using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace formsimthe
{
    class Class2
    {
        string conStr = @"Data Source=LAPTOP-0PUQ22QH\SQLEXPRESS;Initial Catalog=simthe;Integrated Security=True";
        SqlConnection conn;
       public Class2()
      {
           conn = new SqlConnection(conStr);
       }
        public DataSet LayDuLieu(string truyvan)
      {
            try
            {
                DataSet ds = new DataSet();
               SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
       
    }
}

