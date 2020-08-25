using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoNetExample.Models
{
    public class LibraryContext
    {
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=true");
        public List<BookCategory> GetBookCategory()
        {
            List<BookCategory> listobj = new List<BookCategory>();
            SqlCommand cmd = new SqlCommand("spr_getCategoryBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BookCategory obj = new BookCategory();
                obj.CategoryBookId = Convert.ToInt32(dr[0]);
                obj.CategoryBookName = Convert.ToString(dr[1]);
                listobj.Add(obj);
            }
            return listobj;
        }
    }
}