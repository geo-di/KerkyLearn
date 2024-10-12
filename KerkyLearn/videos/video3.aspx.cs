using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KerkyLearn.videos
{
    public partial class video3 : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Session["previouspage"] = HttpContext.Current.Request.Url.AbsolutePath;
                Response.Redirect("login.aspx");
            }
            if (!IsPostBack)
            {
                UpdatePageLoadCounter();
            }
        }

        private void UpdatePageLoadCounter()
        {
            string currentCourse = GetPageName();
            Console.WriteLine(currentCourse);

            string dbpath = Server.MapPath(@"~/KerkyLearn.accdb");

            using (con = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;" + @"DATA SOURCE=" + dbpath + ""))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM visitedCourses WHERE course = ? AND studentId = ?";
                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@course", currentCourse);
                    cmd.Parameters.AddWithValue("@studentId", Session["userid"]);

                    int row = (int)cmd.ExecuteScalar();

                    if (row > 0)
                    {
                        string updateQuery = "UPDATE visitedCourses SET timesVisited = timesVisited + 1 WHERE course = ? AND studentId =?";
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@course", currentCourse);
                            updateCmd.Parameters.AddWithValue("@studentId", Session["userid"]);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO visitedCourses (course, timesVisited, studentId) VALUES (?, 1, ?)";
                        using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@course", currentCourse);
                            insertCmd.Parameters.AddWithValue("@studentId", Session["userid"]);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private string GetPageName()
        {
            string filePath = HttpContext.Current.Request.Url.AbsolutePath;
            return Path.GetFileNameWithoutExtension(filePath);

        }
    }
}