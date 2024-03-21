using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;

public partial class Shoes : Page
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
        SQL = "SELECT * FROM Assign05Shoes";
        myReader = dbConn.createDataReader(SQL);
        results.DataSource = myReader;
        results.DataBind();
    }

    protected void SelectOne_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT Max(ShoeID) As MaxID FROM Assign05Shoes";
        ds = new DataSet();
        ds = dbConn.createDataSet(SQL);
        dt = new DataTable();
        dt = ds.Tables[0];

        if (dt.Rows[0][0].ToString() != "")
        {
            oConn = new SqlConnection(dbConn.connStr);
            oConn.Open();

            SQL = "SELECT * FROM Assign05Shoes WHERE ShoeID=@shoeID";
            cmd = new SqlCommand(SQL, oConn);
            cmd.Parameters.Add(new SqlParameter("@shoeID", SqlDbType.Int, 4));

            cmd.Parameters["@shoeID"].Value = dt.Rows[0][0].ToString();

            results.DataSource = cmd.ExecuteReader();
            results.DataBind();
            oConn.Close();
        }
    }

    protected void Update_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT Max(ShoeID) AS MaxID FROM Assign05Shoes";
        ds = new DataSet();
        ds = dbConn.createDataSet(SQL);
        dt = new DataTable();
        dt = ds.Tables[0];

        if (dt.Rows[0][0].ToString() != "")
        {
            oConn = new SqlConnection(dbConn.connStr);
            SQL = "UPDATE Assign05Shoes SET Name=@name WHERE ShoeID=@shoeID";
            cmd = new SqlCommand(SQL, oConn);

            cmd.Parameters.Add(new SqlParameter("@shoeID", SqlDbType.Int, 4));
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 100));
            cmd.Parameters["@shoeID"].Value = dt.Rows[0][0].ToString();
            cmd.Parameters["@name"].Value = "New Shoe Name";

            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();

        }
        Select_Click(sender, e);
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "SELECT Max(ShoeID) AS MaxID FROM Assign05Shoes";
        ds = new DataSet();
        ds = dbConn.createDataSet(SQL);
        dt = new DataTable();
        dt = ds.Tables[0];

        if (dt.Rows[0][0].ToString() != "")
        {
            oConn = new SqlConnection(dbConn.connStr);
            SQL = "DELETE FROM Assign05Shoes WHERE ShoeID=@shoeID";
            cmd = new SqlCommand(SQL, oConn);

            cmd.Parameters.Add(new SqlParameter("@shoeID", SqlDbType.Int, 4));
            cmd.Parameters["@shoeID"].Value = dt.Rows[0][0].ToString();

            oConn.Open();
            cmd.ExecuteNonQuery();
            oConn.Close();
        }
        Select_Click(sender, e);
    }

    protected void Insert_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "INSERT INTO Assign05Shoes(Name, Description, Color, Laces) ";
        SQL = SQL + "VALUES(@name, @description, @color, @laces)";
        oConn = new SqlConnection(dbConn.connStr);
        cmd = new SqlCommand(SQL, oConn);

        cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 100));
        cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.VarChar, 100));
        cmd.Parameters.Add(new SqlParameter("@color", SqlDbType.VarChar, 6));
        cmd.Parameters.Add(new SqlParameter("@laces", SqlDbType.VarChar, 6));

        cmd.Parameters["@name"].Value = "Nike Air Jordan 1";
        cmd.Parameters["@description"].Value = "Cool High Top Sneaker";
        cmd.Parameters["@color"].Value = "pink";
        cmd.Parameters["@laces"].Value = "blue";

        oConn.Open();
        cmd.ExecuteNonQuery();
        oConn.Close();

        Select_Click(sender, e);
    }

    protected void DeleteAll_Click(object sender, EventArgs e)
    {
        dbConn = new DbConn();
        SQL = "DELETE FROM Assign05Shoes";
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
        SQL = "TRUNCATE TABLE Assign05Shoes";
        oConn = new SqlConnection(dbConn.connStr);
        cmd = new SqlCommand(SQL, oConn);

        oConn.Open();
        cmd.ExecuteNonQuery();
        oConn.Close();

        Select_Click(sender, e);
    }
}
