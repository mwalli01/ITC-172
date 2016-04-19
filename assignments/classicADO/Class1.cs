using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// this class will connect to the database with methods to retrieve services
/// it will also retrieve all the grants for that service 
/// </summary>
public class DataClass
{
    SqlConnection connect;
    public DataClass()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ToString());
    }

    public DataTable GetAuthor()
    {
        DataTable tbl = null;
        string sql = "Select AuthorKey, AuthorName from Author";
        SqlCommand cmd = new SqlCommand(sql, connect);
        tbl = ProcessConnection(cmd);
        return tbl;
    }

    public DataTable GetAuthorBook(int AuthorKey)
    {
        DataTable tbl = null;
        
        string sql = "SELECT * FROM book INNER JOIN authorbook ON book.bookkey= authorbook.bookkey WHERE authorkey = @authorkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@authorkey", AuthorKey);
        
        tbl = ProcessConnection(cmd);
        return tbl;
    }
    
    private DataTable ProcessConnection(SqlCommand cmd)
    {
        SqlDataReader reader = null;
        DataTable tbl = new DataTable();
        

        connect.Open();

        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();

        return tbl;
    }
}
