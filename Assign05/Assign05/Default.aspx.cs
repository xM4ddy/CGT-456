using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;

public partial class Default : Page
{
    public DbConn dbConn;
    public string SQL;
    public SqlDataReader myReader;
    public DataSet ds;
    public DataTable dt;
    public SqlConnection oConn;
    public SqlCommand cmd;

    protected void Select_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT * FROM Products_Lab5";
        myReader = dbConn.createDataReader(SQL);
        results.DataSource = myReader;
        results.DataBind();
    }

    protected void SelectOne_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT Max(ProductID) As MaxID FROM Products_Lab5";
        ds = new DataSet();
        ds = dbConn.createDataSet(SQL);
        dt = new DataTable();
        dt = ds.Tables[0];

        if (dt.Rows[0][0].ToString() != "")
        {
            oConn = new SqlConnection(dbConn.connStr);
            oConn.Open();

            SQL = "SELECT * FROM Products_Lab5 WHERE ProductID=@prodID";
            cmd = new SqlCommand(SQL, oConn);
            cmd.Parameters.Add(new SqlParameter("@prodID", SqlDbType.Int, 4));

            cmd.Parameters["@prodID"].Value = dt.Rows[0][0].ToString();

            results.DataSource = cmd.ExecuteReader();
            results.DataBind();
            oConn.Close();
        }
    }

    protected void Update_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT Max(ProductID) AS MaxID FROM Products_Lab5";
        ds = new DataSet();
        ds = dbConn.createDataSet(SQL);
        dt = new DataTable();
        dt = ds.Tables[0];

        if (dt.Rows[0][0].ToString() != "")
        {
            oConn = new SqlConnection(dbConn.connStr);
            SQL = "UPDATE Products_Lab5 SET Title=@title WHERE ProductID=@prodID";
            cmd = new SqlCommand(SQL, oConn);

            cmd.Parameters.Add(new SqlParameter("@prodID", System.Data.SqlDbType.Int, 4));
            cmd.Parameters.Add(new SqlParameter("@title", System.Data.SqlDbType.VarChar, 100));
            cmd.Parameters["@prodID"].Value = dt.Rows[0][0].ToString();
            cmd.Parameters["@title"].Value = "New Title Value";

            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();

        }
        Select_Click(sender, e);
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT Max(ProductID) AS MaxID FROM Products_Lab5";
        ds = new DataSet();
        ds = dbConn.createDataSet(SQL);
        dt = new DataTable();
        dt = ds.Tables[0];

        if (dt.Rows[0][0].ToString() != "")
        {
            oConn = new SqlConnection(dbConn.connStr);
            SQL = "DELETE FROM Products_Lab5 WHERE ProductID=@prodID";
            cmd = new SqlCommand(SQL, oConn);

            cmd.Parameters.Add(new SqlParameter("@prodID", SqlDbType.Int, 4));
            cmd.Parameters["@prodID"].Value = dt.Rows[0][0].ToString();

            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();
        }
        Select_Click(sender, e);
    }

    protected void Insert_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "INSERT INTO Products_Lab5(title, authors, copyrightDate, edition, isbn, coverart, description, price) ";
        SQL = SQL + "VALUES(@title, @authors, @copyrightDate, @edition, @isbn, @coverart, @description, @price)";
        oConn = new SqlConnection(dbConn.connStr);
        cmd = new SqlCommand(SQL, oConn);

        cmd.Parameters.Add(new SqlParameter("@title", SqlDbType.VarChar, 100));
        cmd.Parameters.Add(new SqlParameter("@authors", SqlDbType.VarChar, 100));
        cmd.Parameters.Add(new SqlParameter("@copyrightDate", SqlDbType.VarChar, 6));
        cmd.Parameters.Add(new SqlParameter("@edition", SqlDbType.VarChar, 6));
        cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.VarChar, 25));
        cmd.Parameters.Add(new SqlParameter("@coverart", SqlDbType.VarChar, 100));
        cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.VarChar, 100));
        cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.VarChar, 100));

        cmd.Parameters["@title"].Value = "MSFT Visual Studio .NET";
        cmd.Parameters["@authors"].Value = "Bob and Carol";
        cmd.Parameters["@copyrightDate"].Value = "2009";
        cmd.Parameters["@edition"].Value = "2009";
        cmd.Parameters["@isbn"].Value = "0735475849";
        cmd.Parameters["@coverart"].Value = "Joe Smith";
        cmd.Parameters["@description"].Value = "A book about .NET n stuff";
        cmd.Parameters["@price"].Value = "$356.19";

        oConn.Open();
        cmd.ExecuteNonQuery();
        oConn.Close();

        Select_Click(sender, e);
    }

    protected void DeleteAll_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "DELETE FROM Products_Lab5";
        oConn = new SqlConnection(dbConn.connStr);
        cmd = new SqlCommand(SQL, oConn);

        oConn.Open();
        cmd.ExecuteNonQuery();
        oConn.Close();

        Select_Click(sender, e);
    }

    protected void Truncate_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "TRUNCATE TABLE Products_Lab5";
        oConn = new SqlConnection(dbConn.connStr);
        cmd = new SqlCommand(SQL, oConn);

        oConn.Open();
        cmd.ExecuteNonQuery();
        oConn.Close();

        Select_Click(sender, e);
    }
}
