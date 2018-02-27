namespace WindowsFormsApp1
{
    partial class FormAnti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnti));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.iTalk_TabControl1 = new iTalk.iTalk_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.iTalk_Button_22 = new iTalk.iTalk_Button_2();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iTalk_Button_24 = new iTalk.iTalk_Button_2();
            this.iTalk_Listview1 = new iTalk.iTalk_Listview();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.iTalk_LinkLabel1 = new iTalk.iTalk_LinkLabel();
            this.iTalk_Icon_Tick1 = new iTalk.iTalk_Icon_Tick();
            this.iTalk_Button_23 = new iTalk.iTalk_Button_2();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.iTalk_Label9 = new iTalk.iTalk_Label();
            this.iTalk_Label10 = new iTalk.iTalk_Label();
            this.iTalk_Label11 = new iTalk.iTalk_Label();
            this.iTalk_Label12 = new iTalk.iTalk_Label();
            this.iTalk_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_TabControl1
            // 
            this.iTalk_TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.iTalk_TabControl1.Controls.Add(this.tabPage1);
            this.iTalk_TabControl1.Controls.Add(this.tabPage2);
            this.iTalk_TabControl1.Controls.Add(this.tabPage3);
            this.iTalk_TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.iTalk_TabControl1.ItemSize = new System.Drawing.Size(44, 135);
            this.iTalk_TabControl1.Location = new System.Drawing.Point(-3, 1);
            this.iTalk_TabControl1.Multiline = true;
            this.iTalk_TabControl1.Name = "iTalk_TabControl1";
            this.iTalk_TabControl1.SelectedIndex = 0;
            this.iTalk_TabControl1.Size = new System.Drawing.Size(704, 348);
            this.iTalk_TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.iTalk_TabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.iTalk_Label2);
            this.tabPage1.Controls.Add(this.iTalk_Label1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.iTalk_Button_22);
            this.tabPage1.Controls.Add(this.iTalk_Button_21);
            this.tabPage1.Location = new System.Drawing.Point(139, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operațiuni";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label2.Location = new System.Drawing.Point(370, 146);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(36, 13);
            this.iTalk_Label2.TabIndex = 4;
            this.iTalk_Label2.Text = "Files: ";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label1.Location = new System.Drawing.Point(21, 255);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(36, 13);
            this.iTalk_Label1.TabIndex = 2;
            this.iTalk_Label1.Text = "Path: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 309);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(502, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 251);
            this.listBox1.TabIndex = 6;
            // 
            // iTalk_Button_22
            // 
            this.iTalk_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_22.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_22.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_22.Image = null;
            this.iTalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_22.Location = new System.Drawing.Point(373, 79);
            this.iTalk_Button_22.Name = "iTalk_Button_22";
            this.iTalk_Button_22.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_22.TabIndex = 3;
            this.iTalk_Button_22.Text = "Scann";
            this.iTalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_22.Click += new System.EventHandler(this.iTalk_Button_22_Click);
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(373, 18);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_21.TabIndex = 1;
            this.iTalk_Button_21.Text = "browse";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.iTalk_Button_24);
            this.tabPage2.Controls.Add(this.iTalk_Listview1);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.MinimumSize = new System.Drawing.Size(126, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carantină";
            // 
            // iTalk_Button_24
            // 
            this.iTalk_Button_24.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_24.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_24.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_24.Image = null;
            this.iTalk_Button_24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_24.Location = new System.Drawing.Point(0, 259);
            this.iTalk_Button_24.Name = "iTalk_Button_24";
            this.iTalk_Button_24.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_24.TabIndex = 1;
            this.iTalk_Button_24.Text = "Adaugă";
            this.iTalk_Button_24.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_24.Click += new System.EventHandler(this.iTalk_Button_24_Click);
            // 
            // iTalk_Listview1
            // 
            this.iTalk_Listview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iTalk_Listview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.iTalk_Listview1.FullRowSelect = true;
            this.iTalk_Listview1.GridLines = true;
            this.iTalk_Listview1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.iTalk_Listview1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_Listview1.Name = "iTalk_Listview1";
            this.iTalk_Listview1.Scrollable = false;
            this.iTalk_Listview1.Size = new System.Drawing.Size(561, 244);
            this.iTalk_Listview1.TabIndex = 0;
            this.iTalk_Listview1.UseCompatibleStateImageBehavior = false;
            this.iTalk_Listview1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Obiectul";
            this.columnHeader2.Width = 493;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage3.Controls.Add(this.iTalk_Label12);
            this.tabPage3.Controls.Add(this.iTalk_Label11);
            this.tabPage3.Controls.Add(this.iTalk_Label10);
            this.tabPage3.Controls.Add(this.iTalk_Label9);
            this.tabPage3.Controls.Add(this.iTalk_Label8);
            this.tabPage3.Controls.Add(this.iTalk_Label7);
            this.tabPage3.Controls.Add(this.iTalk_Label6);
            this.tabPage3.Controls.Add(this.iTalk_Label5);
            this.tabPage3.Controls.Add(this.iTalk_Label4);
            this.tabPage3.Controls.Add(this.iTalk_LinkLabel1);
            this.tabPage3.Controls.Add(this.iTalk_Icon_Tick1);
            this.tabPage3.Controls.Add(this.iTalk_Button_23);
            this.tabPage3.Controls.Add(this.iTalk_Label3);
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(561, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informați";
            // 
            // iTalk_LinkLabel1
            // 
            this.iTalk_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel1.AutoSize = true;
            this.iTalk_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel1.Location = new System.Drawing.Point(39, 324);
            this.iTalk_LinkLabel1.Name = "iTalk_LinkLabel1";
            this.iTalk_LinkLabel1.Size = new System.Drawing.Size(254, 13);
            this.iTalk_LinkLabel1.TabIndex = 4;
            this.iTalk_LinkLabel1.TabStop = true;
            this.iTalk_LinkLabel1.Text = "Copyright 2018 Popa Viorel. All Rights Reserved.";
            this.iTalk_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            // 
            // iTalk_Icon_Tick1
            // 
            this.iTalk_Icon_Tick1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_Icon_Tick1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_Icon_Tick1.Location = new System.Drawing.Point(0, 307);
            this.iTalk_Icon_Tick1.Name = "iTalk_Icon_Tick1";
            this.iTalk_Icon_Tick1.Size = new System.Drawing.Size(33, 33);
            this.iTalk_Icon_Tick1.TabIndex = 3;
            this.iTalk_Icon_Tick1.Text = "iTalk_Icon_Tick1";
            // 
            // iTalk_Button_23
            // 
            this.iTalk_Button_23.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_23.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_23.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_23.Image = null;
            this.iTalk_Button_23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_23.Location = new System.Drawing.Point(27, 17);
            this.iTalk_Button_23.Name = "iTalk_Button_23";
            this.iTalk_Button_23.Size = new System.Drawing.Size(116, 40);
            this.iTalk_Button_23.TabIndex = 1;
            this.iTalk_Button_23.Text = "Actualizare";
            this.iTalk_Button_23.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_23.Click += new System.EventHandler(this.iTalk_Button_23_Click);
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label3.Location = new System.Drawing.Point(24, 87);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(71, 25);
            this.iTalk_Label3.TabIndex = 0;
            this.iTalk_Label3.Text = "Nume:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label4.Location = new System.Drawing.Point(24, 121);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(98, 25);
            this.iTalk_Label4.TabIndex = 5;
            this.iTalk_Label4.Text = "Prenume:";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label5.Location = new System.Drawing.Point(24, 155);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(72, 25);
            this.iTalk_Label5.TabIndex = 6;
            this.iTalk_Label5.Text = "E-mail:";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label6.Location = new System.Drawing.Point(23, 184);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(74, 25);
            this.iTalk_Label6.TabIndex = 7;
            this.iTalk_Label6.Text = "Parola:";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label7.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label7.Location = new System.Drawing.Point(149, 87);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(114, 25);
            this.iTalk_Label7.TabIndex = 8;
            this.iTalk_Label7.Text = "iTalk_Label7";
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label8.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label8.Location = new System.Drawing.Point(150, 121);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(114, 25);
            this.iTalk_Label8.TabIndex = 9;
            this.iTalk_Label8.Text = "iTalk_Label8";
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label9.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label9.Location = new System.Drawing.Point(149, 155);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(114, 25);
            this.iTalk_Label9.TabIndex = 10;
            this.iTalk_Label9.Text = "iTalk_Label9";
            // 
            // iTalk_Label10
            // 
            this.iTalk_Label10.AutoSize = true;
            this.iTalk_Label10.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label10.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label10.Location = new System.Drawing.Point(149, 184);
            this.iTalk_Label10.Name = "iTalk_Label10";
            this.iTalk_Label10.Size = new System.Drawing.Size(124, 25);
            this.iTalk_Label10.TabIndex = 11;
            this.iTalk_Label10.Text = "iTalk_Label10";
            // 
            // iTalk_Label11
            // 
            this.iTalk_Label11.AutoSize = true;
            this.iTalk_Label11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label11.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label11.Location = new System.Drawing.Point(24, 218);
            this.iTalk_Label11.Name = "iTalk_Label11";
            this.iTalk_Label11.Size = new System.Drawing.Size(49, 25);
            this.iTalk_Label11.TabIndex = 12;
            this.iTalk_Label11.Text = "Key:";
            // 
            // iTalk_Label12
            // 
            this.iTalk_Label12.AutoSize = true;
            this.iTalk_Label12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iTalk_Label12.ForeColor = System.Drawing.Color.Black;
            this.iTalk_Label12.Location = new System.Drawing.Point(150, 218);
            this.iTalk_Label12.Name = "iTalk_Label12";
            this.iTalk_Label12.Size = new System.Drawing.Size(124, 25);
            this.iTalk_Label12.TabIndex = 13;
            this.iTalk_Label12.Text = "iTalk_Label12";
            // 
            // FormAnti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 349);
            this.Controls.Add(this.iTalk_TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnti";
            this.Text = "Vio antivirus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAnti_FormClosing);
            this.Load += new System.EventHandler(this.FormAnti_Load);
            this.iTalk_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_TabControl iTalk_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private iTalk.iTalk_Button_2 iTalk_Button_22;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Button_2 iTalk_Button_23;
        private iTalk.iTalk_Icon_Tick iTalk_Icon_Tick1;
        private iTalk.iTalk_LinkLabel iTalk_LinkLabel1;
        private iTalk.iTalk_Listview iTalk_Listview1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private iTalk.iTalk_Button_2 iTalk_Button_24;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private iTalk.iTalk_Label iTalk_Label12;
        private iTalk.iTalk_Label iTalk_Label11;
        private iTalk.iTalk_Label iTalk_Label10;
        private iTalk.iTalk_Label iTalk_Label9;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label4;
    }
}