using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAnti : Form
    {
        int fisiere;
        SqlDataReader lucruBD;
        List<string> lista_nume = new List<string>();
        string connection_string = @"server=.\SQLEXPRESS; Database=Antivirus; trusted_connection=true; ";
        SqlConnection connection;
        string keyapi;
        DateTime time = DateTime.Now;
        public FormAnti(String api)
        {
            keyapi = api;
            connection = new SqlConnection(connection_string);
            InitializeComponent();
        }

        private void FormAnti_Load(object sender, EventArgs e)
        {
            try
            {
                actualizare();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizare()
        {
            try
            {
                connection.Open();
                lucruBD = new SqlCommand("SELECT * FROM Virusi", connection).ExecuteReader();
                while (lucruBD.Read())
                {
                    lista_nume.Add(lucruBD["nmvirus"].ToString());
                }
                lucruBD.Close();
                lucruBD.Dispose();
                lucruBD = new SqlCommand("SELECT * FROM Users where keyactiv like '"+ keyapi + "';", connection).ExecuteReader();
                while (lucruBD.Read())
                {
                    iTalk_Label7.Text = lucruBD["nume"].ToString();
                    iTalk_Label8.Text = lucruBD["prenume"].ToString();
                    iTalk_Label9.Text = lucruBD["mail"].ToString();
                    iTalk_Label10.Text = lucruBD["parola"].ToString();
                    iTalk_Label12.Text = lucruBD["keyactiv"].ToString();
                }
                lucruBD.Close();
                lucruBD.Dispose();
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

        private void scanare()
        {
            try
            {
                connection.Open();
                lucruBD = new SqlCommand("SELECT * FROM Virusi", connection).ExecuteReader();
                while (lucruBD.Read())
                {
                    lista_nume.Add(lucruBD["nmvirus"].ToString());
                }

                lucruBD.Close();
                lucruBD.Dispose();
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
            folderBrowserDialog1.ShowDialog();
            iTalk_Label1.Text += folderBrowserDialog1.SelectedPath;
            progressBar1.Value = 0;
            listBox1.Items.Clear();
            fisiere = 0;
        }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {         
            listBox1.Items.Clear(); fisiere = 0;
            List<string> fisiere_gasite = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*").ToList();
            progressBar1.Maximum = fisiere_gasite.Count;
            foreach (string item in fisiere_gasite)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string citeste = stream.ReadToEnd();
                    foreach (string st in lista_nume)
                    {
                        if (Regex.IsMatch(citeste.ToString(), st.ToString()))
                        {
                            fisiere += 1;
                            iTalk_Label2.Text = "Files: " + fisiere.ToString();
                            listBox1.Items.Add(item);
                        }
                        progressBar1.Increment(1);
                    }
                    if (fisiere == 0)
                        iTalk_Label2.Text = "Files: " + 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                connection.Open();
                lucruBD = new SqlCommand("select max(idScann) as maxid from Scann;", connection).ExecuteReader();

                int count = 0;

                while (lucruBD.Read())
                {
                    count += int.Parse(lucruBD["maxid"].ToString());
                }
                lucruBD.Close();
                lucruBD.Dispose();

                lucruBD = new SqlCommand("insert Scann values('" + (count + 1) + "' , '" + time.ToString("yyyy-MM-dd") + "' , 1 , " + fisiere + ", " + fisiere_gasite.Count + ");", connection).ExecuteReader();
                MessageBox.Show("Scanare finalizată..");
                lucruBD.Close();
                lucruBD.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                actualizare();
            }
        }

        private void FormAnti_FormClosing(object sender, FormClosingEventArgs e)
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

        private void iTalk_Button_23_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                lucruBD = new SqlCommand("select max(idPC) as maxid from Computer;", connection).ExecuteReader();

                int count = 0;

                while (lucruBD.Read())
                {
                    count += int.Parse(lucruBD["maxid"].ToString());
                }
                lucruBD.Close();
                lucruBD.Dispose();
                lucruBD = new SqlCommand("insert Computer values('" + (count + 1) + "' , '" + Environment.MachineName + "' , '" + (Environment.Is64BitOperatingSystem ? "Yes" : "No") + "' , '" + Environment.OSVersion + "');", connection).ExecuteReader();
                MessageBox.Show("Succes, Aveti la moment cea mai noua BD");
                lucruBD.Close();
                lucruBD.Dispose();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                actualizare();
            }            
        }

        private void iTalk_Button_24_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.Title = "Selectați un fișier pentru a adăuga în Carantină";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                //this.Cursor = new Cursor(openFileDialog1.OpenFile());
                iTalk_Listview1.Items.Add(new ListViewItem(new[] { time.ToString("yyyy-MM-dd"),openFileDialog1.FileName}));
            }
            
        }
    }
}
