using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign02
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table table = new Table();
            TableCell tc = new TableCell();
            TableRow tr = new TableRow();

            table.Width = 360;
            table.CellPadding = 0;
            table.CellSpacing = 1;

            tc.ColumnSpan = 3;
            Image img = new Image();
            img.ImageUrl = "topBanner.jpg";
            img.Visible = true;
            img.Width = 360;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "PUR &nbsp; &nbsp; 0 &nbsp; &nbsp; | &nbsp; &nbsp; OSU &nbsp; &nbsp; 0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 16;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "Team Comparison";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Underline = true;
            tc.Font.Size = 14;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "Page Reloads Every 30 Seconds";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            img = new Image();
            img.ImageUrl = "purdue.jpg";
            img.Visible = true;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Width = 100;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "VS";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 14;
            tc.Font.Bold = true;
            tc.Width = 160;
            tr.Controls.Add(tc);

            tc = new TableCell();
            img = new Image();
            img.ImageUrl = "osu.jpg";
            img.Visible = true;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Width = 100;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "First Downs";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "3rd down efficiency";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "4th down efficiency";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Total Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Passing Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Comp-Att";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Yards per Pass";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Rushing Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Rushing Attempts";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Yards per Rush";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Penalty Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Turnovers";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Fumbles Lost";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Interceptions";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Time Of Posession";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.Font.Bold = true;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "<a href=\"refresh.aspx\">Refresh</a> &nbsp; &nbsp; | &nbsp; &nbsp; <a href=\"playbyplay.aspx\">Play by Play</a> &nbsp; &nbsp; | &nbsp; &nbsp; <a href=\"morestats.aspx\">More Stats</a>";
            tc.Font.Bold = true;
            tc.Font.Size = 10;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();
            img = new Image();

            tc.ColumnSpan = 3;
            img.ImageUrl = "bottomBanner.jpg";
            img.Visible = true;
            img.Width = 360;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);
            /////////////////////////////// NEXT ROW ///////////////////////////////
            myTable.Controls.Add(table);
        }
    }
}