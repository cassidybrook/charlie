using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charlie
{
    public partial class Aim : Form
    {
        public Aim()
        {
            InitializeComponent();
        }

        private void StudentInterviewButton_CheckedChanged(object sender, EventArgs e)
        {
            VisitorRegistration.vis.MeetingAim = StudentInterviewButton.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            VisitorRegistration.ButtonMeetingAim.Text = VisitorRegistration.vis.MeetingAim;

        }

        private void MeetingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            VisitorRegistration.vis.MeetingAim = MeetingRadioButton.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();

        }

        private void SalesAppointmentButton_CheckedChanged(object sender, EventArgs e)
        {
            VisitorRegistration.vis.MeetingAim = SalesAppointmentButton.Text; 
        }

        private void SiteVisitButton_CheckedChanged(object sender, EventArgs e)
        {
            VisitorRegistration.vis.MeetingAim = SalesAppointmentButton.Text;
        }

        private void Aim_Load(object sender, EventArgs e)
        {

        }
    }
}
