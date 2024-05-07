using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{ //sstring conn = @"Data Source=v00egd00002l.lec-admin.dmu.ac.uk;Initial Catalog=p2790115;User ID=P2790115;Password=TheLibraryTeam123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


    protected void Page_Load(object sender, EventArgs e)
    {
        //using (SqlConnection sqlConnection = new SqlConnection(conn)) 
        {
            //sqlConnection.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM OrderTable",sqlConnection);
            //DataTable dt = new DataTable();
            //sqlDataAdapter.Fill(dt);
            //OrderList.DataSource = dt;
            //OrderList.DataBind();
        }
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    //private void ShowOrders (){

    //  string Query = "SELECT * FROM OrderTableTable";

    //    OrderList.DataSource = Query;
    //    OrderList.DataBind();
    //}

    protected void OrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}