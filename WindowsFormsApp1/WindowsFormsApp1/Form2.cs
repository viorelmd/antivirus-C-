using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string[] lista_nume = new string[] { "virus", "qwerty", "three" };
        public Form2()
        {
            InitializeComponent();
            string s = "Windows version: " + Environment.OSVersion.ToString();
            iTalk_Label3.Text = s;

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int fisiere;
        

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
            foreach(string item in fisiere_gasite)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string citeste = stream.ReadToEnd();
                    foreach(string st in lista_nume)
                    {
                        if (Regex.IsMatch(citeste, st))
                        {
                            fisiere += 1;
                            iTalk_Label2.Text = "Files: " + fisiere.ToString();
                            listBox1.Items.Add(item);
                        }
                        progressBar1.Increment(1);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void iTalk_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
