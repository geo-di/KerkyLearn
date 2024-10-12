using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KerkyLearn
{
    public partial class dashboard : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        List<int> paths = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
        
            if (Session["user"] == null)
            {
                Session["previouspage"] = HttpContext.Current.Request.Url.AbsolutePath;
                Response.Redirect("login.aspx");
            } else
            {
                getAnswers();
                if(paths.Count > 0)
                {
                    quiz1.Attributes["class"] = "disabled";
                    hr2.Visible= true;
                    if (paths[0] > 50)
                    {
                        unit2b.Visible = true;
                        unit2a.Visible = false;
                        if(paths.Count > 1)
                        {
                            quiz2b.Attributes["class"] = "disabled";
                            hr3.Visible = true;
                            if (paths[1]  > 50)
                            {
                                unit3c.Visible = true;
                                unit3b.Visible = false;
                                unit3a.Visible = false;
                                if (paths.Count > 2)
                                {
                                    quiz3c.Attributes["class"] = "disabled";
                                    hr4.Visible = true;
                                    if (paths[2] > 50)
                                    {
                                        unit4d.Visible = true;
                                        unit4c.Visible = false;
                                        unit4b.Visible = false;
                                        unit4a.Visible = false;
                                        if (paths.Count > 3)
                                        {
                                            quiz4d.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = true;
                                        unit4b.Visible = false;
                                        unit4a.Visible = false;
                                        if (paths.Count > 3)
                                        {
                                            quiz4c.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                }
                            } else
                            {
                                unit3c.Visible = false;
                                unit3b.Visible = true;
                                unit3a.Visible = false;
                                if (paths.Count > 2)
                                {
                                    quiz3b.Attributes["class"] = "disabled";
                                    hr4.Visible = true;
                                    if (paths[2] > 50)
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = true;
                                        unit4b.Visible = false;
                                        unit4a.Visible = false;
                                        if (paths.Count > 3)
                                        {
                                            quiz4c.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = false;
                                        unit4b.Visible = true;
                                        unit4a.Visible = false;
                                        if (paths.Count > 3)
                                        {
                                            quiz4b.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        unit2a.Visible=true;
                        unit2b.Visible=false;
                        if (paths.Count > 1)
                        {
                            quiz2a.Attributes["class"] = "disabled";
                            hr3.Visible = true;
                            if (paths[1] > 50)
                            {
                                unit3c.Visible = false;
                                unit3b.Visible = true;
                                unit3a.Visible = false;
                                if (paths.Count > 2)
                                {
                                    quiz3b.Attributes["class"] = "disabled";
                                    hr4.Visible = true;
                                    if (paths[2] > 50)
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = true;
                                        unit4b.Visible = false;
                                        unit4a.Visible = false;
                                        if(paths.Count > 3)
                                        {
                                            quiz4c.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = false;
                                        unit4b.Visible = true;
                                        unit4a.Visible = false;
                                        if (paths.Count > 3)
                                        {
                                            quiz4b.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;

                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                unit3c.Visible = false;
                                unit3b.Visible = false;
                                unit3a.Visible = true;
                                if (paths.Count > 2)
                                {
                                    quiz3a.Attributes["class"] = "disabled";
                                    hr4.Visible = true;
                                    if (paths[2] > 50)
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = false;
                                        unit4b.Visible = true;
                                        unit4a.Visible = false;
                                        if (paths.Count > 3)
                                        {
                                            quiz4b.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        unit4d.Visible = false;
                                        unit4c.Visible = false;
                                        unit4b.Visible = false;
                                        unit4a.Visible = true;
                                        if (paths.Count > 3)
                                        {
                                            quiz4a.Attributes["class"] = "disabled";
                                            Final.Visible = true;
                                            if (paths.Count > 4)
                                            {
                                                Final.Visible = false;
                                                Congrats.Visible = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            


        }

        private List<int> getAnswers()
        {

            string dbpath = Server.MapPath(@"~/KerkyLearn.accdb");

            using (con = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;" + @"DATA SOURCE=" + dbpath + ""))
            {
                con.Open();

                string query = @"
                        SELECT quizId, score
                        FROM paths
                        WHERE studentid = "+ (int)Session["userid"] + @"
                        ORDER BY quizId ASC";

                cmd = new OleDbCommand(query, con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paths.Add(reader.GetInt32(1));
                }
                return paths;
            }
        }
    }
}