using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign05
{
	public partial class Default : Page
	{
		public Dbconn dbConn;
		public string SQL;
		public SqlDataReader myReader;
		public DataSet ds;
		public DataTable dt;
		public SqlConnection dConn;
		public SqlCommand cmd;

		protected void select_Click(object sender, EventArgs e)
		{
			dbConn = new Dbconn();
			SQL = "SELECT * FROM Products_Lab5";
			myReader = dbConn.createDataReader(SQL);
			results.DataSource = myReader;
			results.DataBind();
		}

		protected void selectOne_Click(object sender, EventArgs e)
		{
			dbConn = new Dbconn;
			SQL = "SELECT Max(ProductID) As MaxID FROM Products_Lab5";
			ds = new DataSet();
			dt = new DataTable();
			ds = dbConn.createDataSet(SQL);
			dt. = ds.Tables[0];

			if (dt.Rows[0][0].ToString() != "")
			{
				oConn = new SqlConnection(dbConn.connStr);
				oConn.Open();

				SQL = "SELECT * FROM Products_Lab5 WHERE ProductID=@prodID";
				cmd = new SqlCommand(SQL, oConn);
				cmd.Parameters.Add(new SqlParameter("@prodID", System.Data.SqlDbType.Int, 4))
				cmd.Parameters["@prodID"].value = dt.Rows[0][0].ToString();

				results.datasource = cmd.executeReader();
				results.DataBind();
				oConn.Close();
			}
		}

		protected void update_Click(object sender, EventArgs e)
		{

		}

		protected void delete_Click(object sender, EventArgs e)
		{
			dbconn = new Dbconn;
			SQL = "DELETE FROM Products_Lab5";
			oConn = new SqlConnection(dbconn.connStr);
			cmd = new SqlCommands(SQL, oConn);
			oConn.Open();
			cmd.execute();
			cmd.ExecuteNonQuery();
			oConn.Close();

			select Click(sender, e);
		}

		protected void insert_Click(object sender, EventArgs e)
		{

		}

		protected void deleteAll_Click(object sender, EventArgs e)
		{
			dbconn = new Dbconn;
			SQL = "DELETE FROM Products_Lab5";
			oConn = new SqlConnection(dbconn.connStr);
			cmd = new SqlCommands(SQL, oConn);
			oConn.Open();
			cmd.execute();
			cmd.ExecuteNonQuery();
			oConn.Close();

			select Click(sender, e);
		}

		protected void truncate_Click(object sender, EventArgs e)
		{
			dbconn = new Dbconn;
			SQL = "TRUNCATE TABLE Products_Lab5";
			oConn = new SqlConnection(dbconn.connStr);
			cmd = new SqlCommands(SQL, oConn);
			oConn.Open();
			cmd.execute();
			cmd.ExecuteNonQuery();
			oConn.Close();

			select Click(sender, e);
		}
	}
}



