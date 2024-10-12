using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KerkyLearn
{
    public partial class quizClass : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader reader;
        List<Question> questions;
        string quizId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Session["previouspage"] = HttpContext.Current.Request.Url.AbsolutePath;
                Response.Redirect("login.aspx");
            }
            quizId = Request.QueryString["id"];
            if (string.IsNullOrEmpty(quizId))
            {
                Response.Redirect("dashboard.aspx");
            }
            else
            {
                questions = GetQuestions();
                quizTitle.Text = "ΕΠΑΝΑΛΗΠΤΙΚΟ ΚΟΥΙΖ ΣΤΗΝ ΕΝΟΤΗΤΑ: " + quizId + "!";

                if (!IsPostBack)
                {
                    Session["Score"] = 0;
                    Session["CurrentQuestionIndex"] = 0;
                    Session["Answers"] = new int[questions.Count];
                    ShowQuestion(0);

                }
            }
                
        }

        

        protected void submitButton_Click(object sender, EventArgs e)
        {
            int question_index = (int)Session["CurrentQuestionIndex"];
            int score = (int)Session["Score"];
            int[] answers = (int[])Session["Answers"];
            answers.Append(answerList.SelectedIndex);
            Session["Answers"] = answers;
            if (questions[question_index].CorrectAnswerIndex == answerList.SelectedIndex)
            {
                score++;
            }
            if (question_index < questions.Count -1)
            {

                question_index++;
                Session["Score"] = score;
                Session["CurrentQuestionIndex"] = question_index;
                

                ShowQuestion(question_index);
            } else
            {
                messageText.Visible = true;
                submitButton.Visible = false;
                answerList.Visible = false;
                listItem1.Enabled = false;
                listItem2.Enabled = false;
                listItem3.Enabled = false;
                messageText.Text = "Click to go back to dashboard";


                if (quizId.Equals(5.ToString()))
                {
                    if (score  * 100 / questions.Count > 50 )
                    {
                        SaveAnswers(answers);
                        SetPath(score * 100 / questions.Count, int.Parse(quizId), (int)Session["userid"]);
                    }
                } 
                else
                {
                    SaveAnswers(answers);
                    SetPath(score * 100 / questions.Count, int.Parse(quizId), (int)Session["userid"]);
                }

                

                Question.Text = "Quiz Ended. Score is: " + score*100 / questions.Count + ("%.");
            }
           
            

          
        }

        private void SetPath(int score, int quiz, int student)
        {
            string dbpath = Server.MapPath(@"~/KerkyLearn.accdb");

            using (con = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;" + @"DATA SOURCE=" + dbpath + ""))
            {
                con.Open();

              
                string query = "insert into paths(studentId, quizId, score) values(" + student + ", " + quiz + ", " + score + ")";

                    cmd = new OleDbCommand(query, con);

                    cmd.ExecuteNonQuery();


            }





        }
        

        private void SaveAnswers(int[] answers)
        {
            string dbpath = Server.MapPath(@"~/KerkyLearn.accdb");

            using (con = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;" + @"DATA SOURCE=" + dbpath + ""))
            {
                con.Open();

                

                for (int i = 0; i < answers.Length; i++)
                {

                    
                    string query = "insert into answers(studentid, questionid, answer, correct, quizid, date_answered) values(" + (int)Session["userid"] + ", " + questions[i].Id + ", " + answers[i] + ", " + (answers[i] == questions[i].CorrectAnswerIndex).ToString() + " , " + int.Parse(quizId) + ", '" + DateTime.Now.ToString() + "')";

                    cmd = new OleDbCommand(query, con);

                    cmd.ExecuteNonQuery();

                
                    

                   
                }
                




            }
        }

        private void ShowQuestion(int question_index)
        {
            Question.Text = questions[question_index].Text;
            listItem1.Text = questions[question_index].Answers[0];
            listItem2.Text = questions[question_index].Answers[1];
            listItem3.Text = questions[question_index].Answers[2];
        }

        private List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();

            string dbpath = Server.MapPath(@"~/KerkyLearn.accdb");

            using (con = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;" + @"DATA SOURCE=" + dbpath + ""))
            {
                con.Open();

                if (quizId.Equals(5.ToString()))
                {
                    List<int> questionid = new List<int>();

                    string query1 = @"SELECT TOP 5 questionId
                                        FROM answers
                                        WHERE correct = false
                                        ORDER BY Rnd(-Timer() * [ID]);";

                    using (cmd = new OleDbCommand(query1, con))
                    {
                        using (reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                questionid.Add(reader.GetInt32(reader.GetOrdinal("questionId")));
                            }
                        }
                    }

                    if (questionid.Count < 5)
                    {
                        int neededCount = 5 - questionid.Count;

                        string query2 = @"SELECT TOP ? questionId
                                          FROM answers
                                          WHERE correct = true
                                          ORDER BY Rnd(-Timer() * [ID]);";

                        using (var cmd = new OleDbCommand(query2, con))
                        {
                            cmd.Parameters.AddWithValue("?", neededCount);

                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    questionid.Add(reader.GetInt32(reader.GetOrdinal("questionId")));
                                }
                            }
                        }
                    }


                    foreach (int i in questionid)
                    {
                        string query = "SELECT * FROM questions WHERE ID= ?";

                        using (cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@questionId", i);

                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    int id = reader.GetInt32(reader.GetOrdinal("Id"));
                                    string text = reader.GetString(reader.GetOrdinal("questionText"));
                                    string answer1 = reader.GetString(reader.GetOrdinal("answer1"));
                                    string answer2 = reader.GetString(reader.GetOrdinal("answer2"));
                                    string answer3 = reader.GetString(reader.GetOrdinal("answer3"));
                                    int correctAnswerIndex = reader.GetInt32(reader.GetOrdinal("correct"));

                                    Question question = new Question
                                    {
                                        Id = id,
                                        Text = text,
                                        Answers = new List<string>() { answer1, answer2, answer3 },
                                        CorrectAnswerIndex = correctAnswerIndex
                                    };

                                    questions.Add(question);

                                }
                            }

                        }

                        
                    }

                    return questions;
                }
                else
                {



                    string query = "SELECT * FROM questions WHERE quizId=" + quizId + "";

                    cmd = new OleDbCommand(query, con);

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string text = reader.GetString(reader.GetOrdinal("questionText"));
                            string answer1 = reader.GetString(reader.GetOrdinal("answer1"));
                            string answer2 = reader.GetString(reader.GetOrdinal("answer2"));
                            string answer3 = reader.GetString(reader.GetOrdinal("answer3"));
                            int correctAnswerIndex = reader.GetInt32(reader.GetOrdinal("correct"));

                            Question question = new Question
                            {
                                Id = id,
                                Text = text,
                                Answers = new List<string>() { answer1, answer2, answer3 },
                                CorrectAnswerIndex = correctAnswerIndex
                            };

                            questions.Add(question);

                        }
                    }

                    return questions;

                }
            }
        }

        
       
        

    }
}