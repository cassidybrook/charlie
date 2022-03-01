namespace charlie
{
    partial class VisitorRegistration
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
            this.VisitorBox = new System.Windows.Forms.GroupBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Email1 = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.Mobile1 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.Suname1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.MeetingDetailBox = new System.Windows.Forms.GroupBox();
            this.MeetingWithCombo = new System.Windows.Forms.ComboBox();
            this.MeetingAimName = new System.Windows.Forms.Label();
            this.MeetingAimButton = new System.Windows.Forms.Button();
            this.MeetingWithName = new System.Windows.Forms.Label();
            this.MinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.HoursUpdown = new System.Windows.Forms.NumericUpDown();
            this.TimeName = new System.Windows.Forms.Label();
            this.DateName = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.VisitorOnSite1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.DropDownDeletePerson = new System.Windows.Forms.ComboBox();
            this.DeletePersonButton = new System.Windows.Forms.Button();
            this.DeletePerson = new System.Windows.Forms.Label();
            this.VisitorBox.SuspendLayout();
            this.MeetingDetailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpdown)).BeginInit();
            this.VisitorOnSite1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisitorBox
            // 
            this.VisitorBox.Controls.Add(this.EmailTextBox);
            this.VisitorBox.Controls.Add(this.Email1);
            this.VisitorBox.Controls.Add(this.MobileTextBox);
            this.VisitorBox.Controls.Add(this.Mobile1);
            this.VisitorBox.Controls.Add(this.SurnameTextBox);
            this.VisitorBox.Controls.Add(this.Suname1);
            this.VisitorBox.Controls.Add(this.NameTextBox);
            this.VisitorBox.Controls.Add(this.NameLable);
            this.VisitorBox.Location = new System.Drawing.Point(12, 12);
            this.VisitorBox.Name = "VisitorBox";
            this.VisitorBox.Size = new System.Drawing.Size(368, 409);
            this.VisitorBox.TabIndex = 0;
            this.VisitorBox.TabStop = false;
            this.VisitorBox.Text = "Visitor Details";
            this.VisitorBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(11, 351);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(336, 26);
            this.EmailTextBox.TabIndex = 7;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // Email1
            // 
            this.Email1.AutoSize = true;
            this.Email1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email1.Location = new System.Drawing.Point(9, 317);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(53, 20);
            this.Email1.TabIndex = 6;
            this.Email1.Text = "Email";
            this.Email1.Click += new System.EventHandler(this.label4_Click);
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(11, 265);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(336, 26);
            this.MobileTextBox.TabIndex = 5;
            this.MobileTextBox.TextChanged += new System.EventHandler(this.MobileTextBox_TextChanged);
            // 
            // Mobile1
            // 
            this.Mobile1.AutoSize = true;
            this.Mobile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile1.Location = new System.Drawing.Point(7, 222);
            this.Mobile1.Name = "Mobile1";
            this.Mobile1.Size = new System.Drawing.Size(61, 20);
            this.Mobile1.TabIndex = 4;
            this.Mobile1.Text = "Mobile";
            this.Mobile1.Click += new System.EventHandler(this.label3_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(11, 164);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(336, 26);
            this.SurnameTextBox.TabIndex = 3;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // Suname1
            // 
            this.Suname1.AutoSize = true;
            this.Suname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suname1.Location = new System.Drawing.Point(9, 126);
            this.Suname1.Name = "Suname1";
            this.Suname1.Size = new System.Drawing.Size(81, 20);
            this.Suname1.TabIndex = 2;
            this.Suname1.Text = "Surname";
            this.Suname1.Click += new System.EventHandler(this.Suname1_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(336, 26);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLable.Location = new System.Drawing.Point(7, 40);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(55, 20);
            this.NameLable.TabIndex = 0;
            this.NameLable.Text = "Name";
            this.NameLable.Click += new System.EventHandler(this.NameLable_Click);
            // 
            // MeetingDetailBox
            // 
            this.MeetingDetailBox.Controls.Add(this.MeetingWithCombo);
            this.MeetingDetailBox.Controls.Add(this.MeetingAimName);
            this.MeetingDetailBox.Controls.Add(this.MeetingAimButton);
            this.MeetingDetailBox.Controls.Add(this.MeetingWithName);
            this.MeetingDetailBox.Controls.Add(this.MinutesUpDown);
            this.MeetingDetailBox.Controls.Add(this.HoursUpdown);
            this.MeetingDetailBox.Controls.Add(this.TimeName);
            this.MeetingDetailBox.Controls.Add(this.DateName);
            this.MeetingDetailBox.Controls.Add(this.DatePicker);
            this.MeetingDetailBox.Location = new System.Drawing.Point(408, 12);
            this.MeetingDetailBox.Name = "MeetingDetailBox";
            this.MeetingDetailBox.Size = new System.Drawing.Size(384, 409);
            this.MeetingDetailBox.TabIndex = 1;
            this.MeetingDetailBox.TabStop = false;
            this.MeetingDetailBox.Text = "Meeting Details";
            // 
            // MeetingWithCombo
            // 
            this.MeetingWithCombo.FormattingEnabled = true;
            this.MeetingWithCombo.Items.AddRange(new object[] {
            "Tim Tim",
            "Sam Sam",
            "Cass Cass"});
            this.MeetingWithCombo.Location = new System.Drawing.Point(10, 263);
            this.MeetingWithCombo.Name = "MeetingWithCombo";
            this.MeetingWithCombo.Size = new System.Drawing.Size(333, 28);
            this.MeetingWithCombo.TabIndex = 11;
            this.MeetingWithCombo.SelectedIndexChanged += new System.EventHandler(this.MeetingWithCombo_SelectedIndexChanged);
            // 
            // MeetingAimName
            // 
            this.MeetingAimName.AutoSize = true;
            this.MeetingAimName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingAimName.Location = new System.Drawing.Point(6, 306);
            this.MeetingAimName.Name = "MeetingAimName";
            this.MeetingAimName.Size = new System.Drawing.Size(108, 20);
            this.MeetingAimName.TabIndex = 10;
            this.MeetingAimName.Text = "Meeting Aim";
            this.MeetingAimName.Click += new System.EventHandler(this.MeetingAimName_Click);
            // 
            // MeetingAimButton
            // 
            this.MeetingAimButton.Location = new System.Drawing.Point(10, 340);
            this.MeetingAimButton.Name = "MeetingAimButton";
            this.MeetingAimButton.Size = new System.Drawing.Size(333, 37);
            this.MeetingAimButton.TabIndex = 9;
            this.MeetingAimButton.Text = "Meeting Aim";
            this.MeetingAimButton.UseVisualStyleBackColor = true;
            this.MeetingAimButton.Click += new System.EventHandler(this.MeetingAimButton_Click);
            // 
            // MeetingWithName
            // 
            this.MeetingWithName.AutoSize = true;
            this.MeetingWithName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingWithName.Location = new System.Drawing.Point(6, 222);
            this.MeetingWithName.Name = "MeetingWithName";
            this.MeetingWithName.Size = new System.Drawing.Size(114, 20);
            this.MeetingWithName.TabIndex = 8;
            this.MeetingWithName.Text = "Meeting With";
            this.MeetingWithName.Click += new System.EventHandler(this.MeetingWithName_Click);
            // 
            // MinutesUpDown
            // 
            this.MinutesUpDown.Location = new System.Drawing.Point(184, 153);
            this.MinutesUpDown.Name = "MinutesUpDown";
            this.MinutesUpDown.Size = new System.Drawing.Size(159, 26);
            this.MinutesUpDown.TabIndex = 6;
            this.MinutesUpDown.ValueChanged += new System.EventHandler(this.MinutesUpDown_ValueChanged);
            // 
            // HoursUpdown
            // 
            this.HoursUpdown.Location = new System.Drawing.Point(10, 153);
            this.HoursUpdown.Name = "HoursUpdown";
            this.HoursUpdown.Size = new System.Drawing.Size(152, 26);
            this.HoursUpdown.TabIndex = 5;
            this.HoursUpdown.ValueChanged += new System.EventHandler(this.HoursUpdown_ValueChanged);
            // 
            // TimeName
            // 
            this.TimeName.AutoSize = true;
            this.TimeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeName.Location = new System.Drawing.Point(6, 115);
            this.TimeName.Name = "TimeName";
            this.TimeName.Size = new System.Drawing.Size(47, 20);
            this.TimeName.TabIndex = 4;
            this.TimeName.Text = "Time";
            // 
            // DateName
            // 
            this.DateName.AutoSize = true;
            this.DateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateName.Location = new System.Drawing.Point(6, 30);
            this.DateName.Name = "DateName";
            this.DateName.Size = new System.Drawing.Size(48, 20);
            this.DateName.TabIndex = 3;
            this.DateName.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(6, 53);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(337, 26);
            this.DatePicker.TabIndex = 2;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // VisitorOnSite1
            // 
            this.VisitorOnSite1.Controls.Add(this.DeletePerson);
            this.VisitorOnSite1.Controls.Add(this.DeletePersonButton);
            this.VisitorOnSite1.Controls.Add(this.DropDownDeletePerson);
            this.VisitorOnSite1.Controls.Add(this.listBox1);
            this.VisitorOnSite1.Location = new System.Drawing.Point(827, 23);
            this.VisitorOnSite1.Name = "VisitorOnSite1";
            this.VisitorOnSite1.Size = new System.Drawing.Size(384, 506);
            this.VisitorOnSite1.TabIndex = 3;
            this.VisitorOnSite1.TabStop = false;
            this.VisitorOnSite1.Text = "Visitors on-site";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 344);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(49, 441);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(702, 88);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // DropDownDeletePerson
            // 
            this.DropDownDeletePerson.FormattingEnabled = true;
            this.DropDownDeletePerson.Location = new System.Drawing.Point(6, 413);
            this.DropDownDeletePerson.Name = "DropDownDeletePerson";
            this.DropDownDeletePerson.Size = new System.Drawing.Size(358, 28);
            this.DropDownDeletePerson.TabIndex = 1;
            this.DropDownDeletePerson.SelectedIndexChanged += new System.EventHandler(this.DropDownDeletePerson_SelectedIndexChanged);
            // 
            // DeletePersonButton
            // 
            this.DeletePersonButton.Location = new System.Drawing.Point(6, 447);
            this.DeletePersonButton.Name = "DeletePersonButton";
            this.DeletePersonButton.Size = new System.Drawing.Size(358, 53);
            this.DeletePersonButton.TabIndex = 2;
            this.DeletePersonButton.Text = "Delete Person";
            this.DeletePersonButton.UseVisualStyleBackColor = true;
            this.DeletePersonButton.Click += new System.EventHandler(this.DeletePersonButton_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.AutoSize = true;
            this.DeletePerson.Location = new System.Drawing.Point(6, 390);
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(110, 20);
            this.DeletePerson.TabIndex = 3;
            this.DeletePerson.Text = "Delete Person";
            this.DeletePerson.Click += new System.EventHandler(this.label1_Click);
            // 
            // VisitorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 550);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.VisitorOnSite1);
            this.Controls.Add(this.MeetingDetailBox);
            this.Controls.Add(this.VisitorBox);
            this.Name = "VisitorRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisitorBox.ResumeLayout(false);
            this.VisitorBox.PerformLayout();
            this.MeetingDetailBox.ResumeLayout(false);
            this.MeetingDetailBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursUpdown)).EndInit();
            this.VisitorOnSite1.ResumeLayout(false);
            this.VisitorOnSite1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VisitorBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label Mobile1;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label Suname1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label Email1;
        private System.Windows.Forms.GroupBox MeetingDetailBox;
        private System.Windows.Forms.Label MeetingAimName;
        private System.Windows.Forms.Button MeetingAimButton;
        private System.Windows.Forms.Label MeetingWithName;
        private System.Windows.Forms.NumericUpDown MinutesUpDown;
        private System.Windows.Forms.NumericUpDown HoursUpdown;
        private System.Windows.Forms.Label TimeName;
        private System.Windows.Forms.Label DateName;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.GroupBox VisitorOnSite1;
        private System.Windows.Forms.ComboBox MeetingWithCombo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label DeletePerson;
        private System.Windows.Forms.Button DeletePersonButton;
        private System.Windows.Forms.ComboBox DropDownDeletePerson;
    }
}

