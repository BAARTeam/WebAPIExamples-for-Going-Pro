namespace GoingProAddLoginData
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
            this.TBLoginID = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LBLResults = new System.Windows.Forms.Label();
            this.BSubmit = new System.Windows.Forms.Button();
            this.TBDistrict = new System.Windows.Forms.TextBox();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBBuilding = new System.Windows.Forms.ComboBox();
            this.LBLLoginDBID = new System.Windows.Forms.Label();
            this.BTNaddLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBLoginID
            // 
            this.TBLoginID.Location = new System.Drawing.Point(171, 25);
            this.TBLoginID.Name = "TBLoginID";
            this.TBLoginID.Size = new System.Drawing.Size(439, 26);
            this.TBLoginID.TabIndex = 0;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(171, 76);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(439, 26);
            this.TBPassword.TabIndex = 1;
            // 
            // LBLResults
            // 
            this.LBLResults.AutoSize = true;
            this.LBLResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LBLResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLResults.Location = new System.Drawing.Point(166, 385);
            this.LBLResults.MinimumSize = new System.Drawing.Size(500, 0);
            this.LBLResults.Name = "LBLResults";
            this.LBLResults.Size = new System.Drawing.Size(500, 26);
            this.LBLResults.TabIndex = 2;
            this.LBLResults.Click += new System.EventHandler(this.LBLResults_Click);
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(711, 25);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(193, 46);
            this.BSubmit.TabIndex = 8;
            this.BSubmit.Text = "Add Login Info";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // TBDistrict
            // 
            this.TBDistrict.Location = new System.Drawing.Point(171, 127);
            this.TBDistrict.Name = "TBDistrict";
            this.TBDistrict.Size = new System.Drawing.Size(439, 26);
            this.TBDistrict.TabIndex = 2;
            this.TBDistrict.Text = "KentISD";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(171, 229);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(439, 26);
            this.TBFirstName.TabIndex = 4;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(171, 280);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(439, 26);
            this.TBLastName.TabIndex = 5;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(171, 331);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(439, 26);
            this.TBEmail.TabIndex = 6;
            // 
            // BTNLogin
            // 
            this.BTNLogin.Location = new System.Drawing.Point(711, 107);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(193, 46);
            this.BTNLogin.TabIndex = 9;
            this.BTNLogin.Text = "Log In";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(711, 189);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(193, 47);
            this.BTNUpdate.TabIndex = 10;
            this.BTNUpdate.Text = "Update Information";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Building";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // CBBuilding
            // 
            this.CBBuilding.FormattingEnabled = true;
            this.CBBuilding.Items.AddRange(new object[] {
            "KCTC",
            "KIH",
            "MySchool",
            "KTC"});
            this.CBBuilding.Location = new System.Drawing.Point(171, 174);
            this.CBBuilding.Name = "CBBuilding";
            this.CBBuilding.Size = new System.Drawing.Size(439, 28);
            this.CBBuilding.TabIndex = 3;
            this.CBBuilding.Text = "KCTC";
            // 
            // LBLLoginDBID
            // 
            this.LBLLoginDBID.AutoSize = true;
            this.LBLLoginDBID.Location = new System.Drawing.Point(711, 336);
            this.LBLLoginDBID.MinimumSize = new System.Drawing.Size(30, 0);
            this.LBLLoginDBID.Name = "LBLLoginDBID";
            this.LBLLoginDBID.Size = new System.Drawing.Size(30, 20);
            this.LBLLoginDBID.TabIndex = 18;
            this.LBLLoginDBID.Visible = false;
            // 
            // BTNaddLog
            // 
            this.BTNaddLog.Location = new System.Drawing.Point(711, 272);
            this.BTNaddLog.Name = "BTNaddLog";
            this.BTNaddLog.Size = new System.Drawing.Size(193, 46);
            this.BTNaddLog.TabIndex = 19;
            this.BTNaddLog.Text = "BTNAddLogData";
            this.BTNaddLog.UseVisualStyleBackColor = true;
            this.BTNaddLog.Click += new System.EventHandler(this.BTNaddLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(928, 475);
            this.Controls.Add(this.BTNaddLog);
            this.Controls.Add(this.LBLLoginDBID);
            this.Controls.Add(this.CBBuilding);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.TBDistrict);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.LBLResults);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLoginID);
            this.Name = "Form1";
            this.Text = "GoingPro Update Login Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLoginID;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LBLResults;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.TextBox TBDistrict;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBBuilding;
        private System.Windows.Forms.Label LBLLoginDBID;
        private System.Windows.Forms.Button BTNaddLog;
    }
}

