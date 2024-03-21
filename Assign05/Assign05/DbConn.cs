using System.Data;
using System.Data.SqlClient;

public class DbConn
{
    public string connStr = "Data Source=ecn-classmssql.ecn.purdue.edu; Initial Catalog=zCGT456_maddy; Integrated Security=True;";
    public SqlDataAdapter dbSDA;
    public DataSet dbDS;
    public SqlDataReader dbDR;
    public DataTable dbDT;
    public SqlConnection dbConn;
    public SqlCommand dbCmd;
    public string SQL;

    public DbConn() {
        // DbConn Constructor
    }

    public DataSet createDataSet(string sql) {

        dbConn = new SqlConnection(connStr);
        dbConn.Open();
        dbCmd = new SqlCommand(sql, dbConn);
        dbSDA = new SqlDataAdapter();
        dbSDA.SelectCommand = dbCmd;
        dbDS = new DataSet();
        dbSDA.Fill(dbDS);
        return dbDS;
    }

    public SqlDataReader createDataReader(string sql)
    {
        dbConn = new SqlConnection(connStr);
        dbConn.Open();
        dbCmd = new SqlCommand(sql, dbConn);

        dbDR = dbCmd.ExecuteReader();

        return dbDR;
    }
}
