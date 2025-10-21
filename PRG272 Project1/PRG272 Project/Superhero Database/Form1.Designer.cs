namespace Superhero_Database
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuperheroIDtxt = new System.Windows.Forms.TextBox();
            this.Agetxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Summarybtn = new System.Windows.Forms.Button();
            this.ViewAllbtn = new System.Windows.Forms.Button();
            this.Heroesdgv = new System.Windows.Forms.DataGridView();
            this.SuperheroID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeroName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuperPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreatLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.SuperPowertxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ThreatLevelcmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Rankcmb = new System.Windows.Forms.ComboBox();
            this.Citytxt = new System.Windows.Forms.TextBox();
            this.ExamScoretxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Heroesdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Superhero Database System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Superhero ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Super Power";
            // 
            // SuperheroIDtxt
            // 
            this.SuperheroIDtxt.Location = new System.Drawing.Point(187, 114);
            this.SuperheroIDtxt.Name = "SuperheroIDtxt";
            this.SuperheroIDtxt.Size = new System.Drawing.Size(100, 22);
            this.SuperheroIDtxt.TabIndex = 6;
            // 
            // Agetxt
            // 
            this.Agetxt.Location = new System.Drawing.Point(187, 214);
            this.Agetxt.Name = "Agetxt";
            this.Agetxt.Size = new System.Drawing.Size(100, 22);
            this.Agetxt.TabIndex = 8;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(397, 674);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(92, 40);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(560, 674);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(86, 40);
            this.Updatebtn.TabIndex = 11;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(724, 674);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(80, 40);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Summarybtn
            // 
            this.Summarybtn.Location = new System.Drawing.Point(1036, 674);
            this.Summarybtn.Name = "Summarybtn";
            this.Summarybtn.Size = new System.Drawing.Size(181, 48);
            this.Summarybtn.TabIndex = 13;
            this.Summarybtn.Text = "Generate Summary";
            this.Summarybtn.UseVisualStyleBackColor = true;
            this.Summarybtn.Click += new System.EventHandler(this.Summarybtn_Click);
            // 
            // ViewAllbtn
            // 
            this.ViewAllbtn.Location = new System.Drawing.Point(862, 674);
            this.ViewAllbtn.Name = "ViewAllbtn";
            this.ViewAllbtn.Size = new System.Drawing.Size(82, 40);
            this.ViewAllbtn.TabIndex = 14;
            this.ViewAllbtn.Text = "View All";
            this.ViewAllbtn.UseVisualStyleBackColor = true;
            this.ViewAllbtn.Click += new System.EventHandler(this.ViewAllbtn_Click);
            // 
            // Heroesdgv
            // 
            this.Heroesdgv.AllowUserToAddRows = false;
            this.Heroesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Heroesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuperheroID,
            this.HeroName,
            this.Age,
            this.SuperPower,
            this.City,
            this.ExamScore,
            this.Rank,
            this.ThreatLevel});
            this.Heroesdgv.Location = new System.Drawing.Point(369, 86);
            this.Heroesdgv.Name = "Heroesdgv";
            this.Heroesdgv.ReadOnly = true;
            this.Heroesdgv.RowHeadersWidth = 51;
            this.Heroesdgv.RowTemplate.Height = 24;
            this.Heroesdgv.Size = new System.Drawing.Size(990, 552);
            this.Heroesdgv.TabIndex = 17;
            // 
            // SuperheroID
            // 
            this.SuperheroID.HeaderText = "Superhero ID";
            this.SuperheroID.MinimumWidth = 6;
            this.SuperheroID.Name = "SuperheroID";
            this.SuperheroID.ReadOnly = true;
            this.SuperheroID.Width = 80;
            // 
            // HeroName
            // 
            this.HeroName.HeaderText = "Hero Name";
            this.HeroName.MinimumWidth = 6;
            this.HeroName.Name = "HeroName";
            this.HeroName.ReadOnly = true;
            this.HeroName.Width = 120;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 80;
            // 
            // SuperPower
            // 
            this.SuperPower.HeaderText = "Super Power";
            this.SuperPower.MinimumWidth = 6;
            this.SuperPower.Name = "SuperPower";
            this.SuperPower.ReadOnly = true;
            this.SuperPower.Width = 120;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // ExamScore
            // 
            this.ExamScore.HeaderText = "Exam Score";
            this.ExamScore.MinimumWidth = 6;
            this.ExamScore.Name = "ExamScore";
            this.ExamScore.ReadOnly = true;
            this.ExamScore.Width = 80;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.MinimumWidth = 6;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Width = 80;
            // 
            // ThreatLevel
            // 
            this.ThreatLevel.HeaderText = "Threat Level";
            this.ThreatLevel.MinimumWidth = 6;
            this.ThreatLevel.Name = "ThreatLevel";
            this.ThreatLevel.ReadOnly = true;
            this.ThreatLevel.Width = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.Nametxt.Location = new System.Drawing.Point(187, 163);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(100, 22);
            this.Nametxt.TabIndex = 19;
            // 
            // SuperPowertxt
            // 
            this.SuperPowertxt.Location = new System.Drawing.Point(187, 267);
            this.SuperPowertxt.Name = "SuperPowertxt";
            this.SuperPowertxt.Size = new System.Drawing.Size(100, 22);
            this.SuperPowertxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Threat Level";
            // 
            // ThreatLevelcmb
            // 
            this.ThreatLevelcmb.FormattingEnabled = true;
            this.ThreatLevelcmb.Location = new System.Drawing.Point(187, 490);
            this.ThreatLevelcmb.Name = "ThreatLevelcmb";
            this.ThreatLevelcmb.Size = new System.Drawing.Size(121, 24);
            this.ThreatLevelcmb.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Exam Score";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Rank";
            // 
            // Rankcmb
            // 
            this.Rankcmb.FormattingEnabled = true;
            this.Rankcmb.Location = new System.Drawing.Point(187, 444);
            this.Rankcmb.Name = "Rankcmb";
            this.Rankcmb.Size = new System.Drawing.Size(121, 24);
            this.Rankcmb.TabIndex = 26;
            // 
            // Citytxt
            // 
            this.Citytxt.Location = new System.Drawing.Point(187, 328);
            this.Citytxt.Name = "Citytxt";
            this.Citytxt.Size = new System.Drawing.Size(100, 22);
            this.Citytxt.TabIndex = 27;
            // 
            // ExamScoretxt
            // 
            this.ExamScoretxt.Location = new System.Drawing.Point(187, 386);
            this.ExamScoretxt.Name = "ExamScoretxt";
            this.ExamScoretxt.Size = new System.Drawing.Size(100, 22);
            this.ExamScoretxt.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 758);
            this.Controls.Add(this.ExamScoretxt);
            this.Controls.Add(this.Citytxt);
            this.Controls.Add(this.Rankcmb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ThreatLevelcmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SuperPowertxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Heroesdgv);
            this.Controls.Add(this.ViewAllbtn);
            this.Controls.Add(this.Summarybtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Agetxt);
            this.Controls.Add(this.SuperheroIDtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Superhero System";
            ((System.ComponentModel.ISupportInitialize)(this.Heroesdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SuperheroIDtxt;
        private System.Windows.Forms.TextBox Agetxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Summarybtn;
        private System.Windows.Forms.Button ViewAllbtn;
        private System.Windows.Forms.DataGridView Heroesdgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox SuperPowertxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ThreatLevelcmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Rankcmb;
        private System.Windows.Forms.TextBox Citytxt;
        private System.Windows.Forms.TextBox ExamScoretxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuperheroID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeroName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuperPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreatLevel;
    }
}

