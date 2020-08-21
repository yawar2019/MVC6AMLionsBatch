using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace AdoNetExample.Models
{
    public class AuthorContext
    {
        SqlConnection con = new SqlConnection(@"Data Source=AZAM-PC\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=true");
        public List<AuthorModel> GetAuthors()
        {
            List<AuthorModel> listobj = new List<AuthorModel>();
           SqlCommand cmd = new SqlCommand("spr_getAuthors", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                AuthorModel obj = new AuthorModel();
                obj.AuthorId =Convert.ToInt32(dr[0]);
                obj.AuthorName = Convert.ToString(dr[1]);
                obj.Description = Convert.ToString(dr[2]);

                listobj.Add(obj);
            }
            return listobj;
        }

        public int SaveAuthors(AuthorModel obj) {
            SqlCommand cmd = new SqlCommand("spr_insertAuthor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Authname", obj.AuthorName);
            cmd.Parameters.AddWithValue("@Description", obj.Description);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

         

             public AuthorModel getAuthodById(int ? id)
        {
            AuthorModel obj = new AuthorModel();
            SqlCommand cmd = new SqlCommand("spr_getAuthorDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@authid", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                obj.AuthorId = Convert.ToInt32(dr[0]);
                obj.AuthorName = Convert.ToString(dr[1]);
                obj.Description = Convert.ToString(dr[2]);

                
            }
            return obj;
        }
        

             public int EditAuthors(AuthorModel obj)
        {
            SqlCommand cmd = new SqlCommand("spr_updateAuthorDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@authid", obj.AuthorId);
            cmd.Parameters.AddWithValue("@AuthName", obj.AuthorName);
            cmd.Parameters.AddWithValue("@description", obj.Description);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DeleteAuthors(int? Id)
        {
            SqlCommand cmd = new SqlCommand("spr_deleteAuthorDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@authid", Id);
             
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        
    }
}