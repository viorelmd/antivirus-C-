using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string APIusers;
        public Form1()
        {
            InitializeComponent();
        }
        
        string connection_string = @"server=.\SQLEXPRESS; Database=Antivirus; trusted_connection=true; ";
        SqlConnection connection;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connection_string);
            iTalk_TextBox_Big2.UseSystemPasswordChar = true;
            iTalk_TextBox_Big4.UseSystemPasswordChar = true;
        }

        private void Get_data()
        {
            try
            {
                connection.Open();

                SqlDataReader reader = new SqlCommand("SELECT * FROM Users", connection).ExecuteReader();
                //listBox1.Items.Clear();
                while (reader.Read())
                {
                    //listBox1.Items.Add(reader["idUsers"].ToString()+" "+reader["nume"].ToString() + " " + reader["prenume"].ToString() + " " + reader["mail"].ToString() + " " + reader["parola"].ToString());
                }

                reader.Close();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataReader myReader;

                int count = 0;
                int key = 0;
                

                if (!iTalk_TextBox_Big6.Text.Equals(""))
                {
                    myReader = new SqlCommand("select * from Users where keyactiv like '" + this.iTalk_TextBox_Big6.Text + "';", connection).ExecuteReader();
                    while (myReader.Read())
                    {
                        key++;
                        APIusers = myReader["keyactiv"].ToString();
                    }
                    if (key == 1)
                    {
                        FormAnti f2 = new FormAnti(APIusers);
                        this.Hide();
                        f2.ShowDialog();
                    }
                    else
                        MessageBox.Show("Key aren't correct..");
                    myReader.Close();
                    myReader.Dispose();
                }
                else if (!iTalk_TextBox_Big1.Text.Equals("") && !iTalk_TextBox_Big2.Text.Equals(""))
                {
                    myReader = new SqlCommand("select * from Users where mail = '" + this.iTalk_TextBox_Big1.Text + "' and parola = '" + this.iTalk_TextBox_Big2.Text + "';", connection).ExecuteReader();
                    while (myReader.Read()) {
                        count++;
                        APIusers = myReader["keyactiv"].ToString();
                    }   
                if (count == 1)
                    {
                        FormAnti f2 = new FormAnti(APIusers);
                        this.Hide();
                        f2.ShowDialog();
                    }
                    else if (count > 1)
                        MessageBox.Show("deplicate username and password");

                    else
                        MessageBox.Show("username and password aren't correct.. please try again");
                    myReader.Close();
                    myReader.Dispose();
                }
                else
                    MessageBox.Show("Va rugam indepliniti numele si parola sau key de activare!!!");                            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa ieși?",
                               "Eșire din aplicație",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true;
            }
        }


        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataReader maxid = new SqlCommand("select max(idUsers) as ids from Users;", connection).ExecuteReader();

                int count = 0;

                while (maxid.Read())
                {
                    count += int.Parse(maxid["ids"].ToString());
                }
                maxid.Close();
                maxid.Dispose();
                if (iTalk_TextBox_Big7.Text.Equals(""))
                {
                    MessageBox.Show("Va rugam completati campul cu Numele dvs.");
                }
                if (iTalk_TextBox_Big5.Text.Equals(""))
                {
                    MessageBox.Show("Va rugam completati campul cu Prenumel dvs.");
                }
                if (iTalk_TextBox_Big3.Text.Equals(""))
                {
                    MessageBox.Show("E-mail nu este scris");
                }
                else if (iTalk_TextBox_Big4.Text.Equals(""))
                {
                    MessageBox.Show("Parola nu este scrisa");
                }
                else if (iTalk_TextBox_Big3.Text.Equals(iTalk_TextBox_Big4.Text))
                {
                    MessageBox.Show("E-mail si parola sunt identice");
                }
                else
                {
                    SqlDataReader myReader = new SqlCommand("insert Users values('" + (count+1) + "' , '" + iTalk_TextBox_Big7.Text + "' , '" + iTalk_TextBox_Big5.Text + "' , '" + iTalk_TextBox_Big3.Text + "' , '" + iTalk_TextBox_Big4.Text + "' , 'B9"+rnd.Next(1,9)+ "MQ-ALPEQ-A" + rnd.Next(1, 9) + "DMO-SPF7" + rnd.Next(1, 9) + "-SU" + rnd.Next(1, 9) + "L6');", connection).ExecuteReader();
                    MessageBox.Show("Succes, va rugam sa va logati cu datele inregisrtate");
                    myReader.Close();
                    myReader.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
