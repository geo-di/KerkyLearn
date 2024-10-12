using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KerkyLearn
{
    public partial class statistics : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Session["previouspage"] = HttpContext.Current.Request.Url.AbsolutePath;
                Response.Redirect("login.aspx");
            }
            if (!IsPostBack)
            {
                LoadStats();
            }
        }

        private void LoadStats()
        {
            string dbpath = Server.MapPath(@"~/KerkyLearn.accdb");

            using (con = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;" + @"DATA SOURCE=" + dbpath + ""))
            {
                con.Open();


                string query = "select count(*) from paths where studentId = ?";

                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@studentId", Session["userid"]);

                int quizzesDone = (int)cmd.ExecuteScalar();
                double completionPercentage = (quizzesDone / 5.0) * 100;
                courseCompletion.Text = completionPercentage.ToString() + "% completed!";

                query = "SELECT TOP 3 course FROM visitedCourses WHERE studentId = ? ORDER BY timesVisited DESC";

                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@studentId", Session["userid"]);
                    using (reader = cmd.ExecuteReader())
                    {
                        string[] topCourses = new string[3];
                        int index = 0;

                        while (reader.Read() && index < 3)
                        {
                            topCourses[index] = reader["course"].ToString();
                            ListItem listItem = new ListItem();
                            listItem.Text = topCourses[index].ToString();
                            courseList.InnerHtml += $"<li>{topCourses[index]}</li>";
                            index++;
                        }
                        


                    }
                }

                query = @"SELECT TOP 1 quizId
                         FROM paths
                         WHERE studentId = ?
                         ORDER BY score ASC;";

                using( cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@studentId", (int)Session["userid"]);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int worstquiz = Convert.ToInt32(result);
                        worstQuiz.Text = "Your worst performance was in quiz: " + worstquiz.ToString();
                    }
                }
                
                

                query = @"SELECT TOP 1 quizId
                         FROM paths
                         WHERE studentId = ?
                         ORDER BY score DESC; ";

                using (cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@studentId", (int)Session["userid"]);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int bestquiz = Convert.ToInt32(result);
                        bestQuiz.Text = "Your best performance was in quiz: " +  bestquiz.ToString();
                    }
                }

                query = @"select AVG(score)
                          from paths
                          where studentId = ?; ";
                
                using(cmd = new OleDbCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@studentId", (int)Session["userid"]);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        double averageScore = Convert.ToDouble(result);
                        overall.Text = $"Average Score: {averageScore:F2}/100.00";
                    }
                }


            }

            

        }
    }
}