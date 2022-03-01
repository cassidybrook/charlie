namespace charlie
{
    partial class Aim
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
            this.MeetingRadioButton = new System.Windows.Forms.RadioButton();
            this.SalesAppointmentButton = new System.Windows.Forms.RadioButton();
            this.SiteVisitButton = new System.Windows.Forms.RadioButton();
            this.StudentInterviewButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please specify the nature of the meeting";
            // 
            // MeetingRadioButton
            // 
            this.MeetingRadioButton.AutoSize = true;
            this.MeetingRadioButton.Location = new System.Drawing.Point(46, 119);
            this.MeetingRadioButton.Name = "MeetingRadioButton";
            this.MeetingRadioButton.Size = new System.Drawing.Size(91, 24);
            this.MeetingRadioButton.TabIndex = 1;
            this.MeetingRadioButton.TabStop = true;
            this.MeetingRadioButton.Text = "Meeting";
            this.MeetingRadioButton.UseVisualStyleBackColor = true;
            this.MeetingRadioButton.CheckedChanged += new System.EventHandler(this.MeetingRadioButton_CheckedChanged);
            // 
            // SalesAppointmentButton
            // 
            this.SalesAppointmentButton.AutoSize = true;
            this.SalesAppointmentButton.Location = new System.Drawing.Point(271, 119);
            this.SalesAppointmentButton.Name = "SalesAppointmentButton";
            this.SalesAppointmentButton.Size = new System.Drawing.Size(169, 24);
            this.SalesAppointmentButton.TabIndex = 2;
            this.SalesAppointmentButton.TabStop = true;
            this.SalesAppointmentButton.Text = "Sales Appointment";
            this.SalesAppointmentButton.UseVisualStyleBackColor = true;
            this.SalesAppointmentButton.CheckedChanged += new System.EventHandler(this.SalesAppointmentButton_CheckedChanged);
            // 
            // SiteVisitButton
            // 
            this.SiteVisitButton.AutoSize = true;
            this.SiteVisitButton.Location = new System.Drawing.Point(46, 221);
            this.SiteVisitButton.Name = "SiteVisitButton";
            this.SiteVisitButton.Size = new System.Drawing.Size(96, 24);
            this.SiteVisitButton.TabIndex = 3;
            this.SiteVisitButton.TabStop = true;
            this.SiteVisitButton.Text = "Site Visit";
            this.SiteVisitButton.UseVisualStyleBackColor = true;
            this.SiteVisitButton.CheckedChanged += new System.EventHandler(this.SiteVisitButton_CheckedChanged);
            // 
            // StudentInterviewButton
            // 
            this.StudentInterviewButton.AutoSize = true;
            this.StudentInterviewButton.Location = new System.Drawing.Point(271, 221);
            this.StudentInterviewButton.Name = "StudentInterviewButton";
            this.StudentInterviewButton.Size = new System.Drawing.Size(158, 24);
            this.StudentInterviewButton.TabIndex = 4;
            this.StudentInterviewButton.TabStop = true;
            this.StudentInterviewButton.Text = "Student Interview";
            this.StudentInterviewButton.UseVisualStyleBackColor = true;
            this.StudentInterviewButton.CheckedChanged += new System.EventHandler(this.StudentInterviewButton_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(112, 317);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(142, 39);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(293, 317);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(147, 39);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Aim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 388);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StudentInterviewButton);
            this.Controls.Add(this.SiteVisitButton);
            this.Controls.Add(this.SalesAppointmentButton);
            this.Controls.Add(this.MeetingRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "Aim";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Aim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MeetingRadioButton;
        private System.Windows.Forms.RadioButton SalesAppointmentButton;
        private System.Windows.Forms.RadioButton SiteVisitButton;
        private System.Windows.Forms.RadioButton StudentInterviewButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}