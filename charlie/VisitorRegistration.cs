using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace charlie
{
    public partial class VisitorRegistration : Form
    {

        public struct Visitor
        {
            public string name;
            public string surname;
            public string mobile;
            public string email;
            public DateTime dateTime;
            public string MeetingPerson;
            public string MeetingAim;

        };

        public List<Visitor> visitors = new List<Visitor>();
        public static Visitor vis;

        public static Button ButtonMeetingAim;

        public VisitorRegistration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool onlyLettera = Regex.IsMatch(NameTextBox.Text, @"^[a-zA-Z]+$");
            if (!string.IsNullOrEmpty(NameTextBox.Text) && onlyLettera)
            {
                NameTextBox.BackColor = Color.White;

            }
            else
            {
                NameTextBox.BackColor = Color.Yellow;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MobileTextBox_TextChanged(object sender, EventArgs e)
        {
            bool Number = Regex.IsMatch(MobileTextBox.Text, @"^[0-9]+$");
            if (!string.IsNullOrEmpty(MobileTextBox.Text) && Number)
            {
                MobileTextBox.BackColor = Color.White;

            }
            else
            {
                MobileTextBox.BackColor = Color.Yellow;
            }

        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool letter = Regex.IsMatch(SurnameTextBox.Text, @"^[a-zA-Z]+$");
            if (!string.IsNullOrEmpty(SurnameTextBox.Text) && letter)
            {
                SurnameTextBox.BackColor = Color.White;

            }
            else
            {
                SurnameTextBox.BackColor = Color.Yellow;
            }
        }






        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MeetingWithName_Click(object sender, EventArgs e)
        {

        }

        private void MeetingAimButton_Click(object sender, EventArgs e)
        {
            ButtonMeetingAim = MeetingAimButton;
            Aim meetingAim = new Aim();
            meetingAim.Show();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

            vis.dateTime = DatePicker.Value;
        }

        private void HoursUpdown_ValueChanged(object sender, EventArgs e)
        {
            DatePicker.Value = new DateTime
            (DatePicker.Value.Year,
            DatePicker.Value.Month,
            DatePicker.Value.Day,
            Convert.ToInt32(HoursUpdown.Value),
            DatePicker.Value.Minute, 0);
        }

        private void MinutesUpDown_ValueChanged(object sender, EventArgs e)
        {
            DatePicker.Value = new DateTime
            (DatePicker.Value.Year,
            DatePicker.Value.Month,
            DatePicker.Value.Day,
            DatePicker.Value.Hour,
            Convert.ToInt32(MinutesUpDown.Value),
             0);
        }

        private void MeetingWithCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            vis.MeetingPerson = MeetingWithCombo.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isEmail = Regex.IsMatch(EmailTextBox.Text, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!string.IsNullOrEmpty(EmailTextBox.Text) && isEmail)

            {
                EmailTextBox.BackColor = Color.White;
                //vis.email = EmailTextBox.Text; 

            }
            else
            {
                EmailTextBox.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignInButton.Enabled = true;
            SignInButton.Visible = true;

        }
        private void ClearForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            vis = new Visitor();
        }

        private void NameLable_Click(object sender, EventArgs e)
        {

        }

        private void Suname1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {

            if (NameTextBox.BackColor != Color.Yellow &&
                SurnameTextBox.BackColor != Color.Yellow &&
                MobileTextBox.BackColor != Color.Yellow &&
                EmailTextBox.BackColor != Color.Yellow)

            {
                vis.name = NameTextBox.Text;
                vis.surname = SurnameTextBox.Text;
                vis.mobile = MobileTextBox.Text;
                vis.email = EmailTextBox.Text;

            }
            /*Debug.WriteLine(vis.name);
            Debug.WriteLine(vis.surname);
            Debug.WriteLine(vis.mobile);
            Debug.WriteLine(vis.email);
            Debug.WriteLine(vis.dateTime);
            Debug.WriteLine(vis.MeetingPerson);
            Debug.WriteLine(vis.MeetingAim);
            */


            if (vis.name != null && vis.surname != null &&
                vis.mobile != null && vis.email != null &&
                vis.dateTime != null && vis.MeetingPerson != null &&
                vis.MeetingAim != null)

            {

                visitors.Add(vis);
                ClearForm();

                foreach (Visitor v in visitors)
                {
                    listBox1.Items.Add("--------------------------------------");
                    listBox1.Items.Add("Name: " + v.name + " " + v.surname);
                    listBox1.Items.Add("Mobile Number: " + v.mobile);
                    listBox1.Items.Add("Email: " + v.email);
                    listBox1.Items.Add("Time and Date: " + v.dateTime.Hour +
                                        ":" + v.dateTime.Minute + "," +
                                        v.dateTime.DayOfWeek + " " +
                                        " " + v.dateTime.Day + "/" +
                                        v.dateTime.Month + "/" +
                                        v.dateTime.Year);
                    listBox1.Items.Add("Meeting With: " + v.MeetingPerson);
                    listBox1.Items.Add("Aim With: " + v.MeetingAim);
                    listBox1.Items.Add("--------------------------------------");

                    DropDownDeletePerson.Items.Add(v.name + " " + v.surname);
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DropDownDeletePerson_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void DeleteVisitor (Visitor vis)
        {
            int i = 0;
            while (!(listBox1.Items[i].ToString().Contains("Name: " + vis.name + " " + vis.surname)))
            {
                i++;
            }
            int j = i - 1;
            for (int k =  0; k < 8; k ++)
            {
                listBox1.Items.RemoveAt(j);
            }
        }
        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            if (DropDownDeletePerson.Items.Count != 0)
            {
                int j  =  0;
                while (visitors[j].name + " " + visitors[j].surname != DropDownDeletePerson.SelectedItem.ToString())
                {
                    j++;
                }
                Visitor toDelete = visitors[j];
                DeleteVisitor(toDelete);
                visitors.Remove(toDelete);
                DropDownDeletePerson.Items.Remove(DropDownDeletePerson.SelectedItem);
                DropDownDeletePerson.Text = null;

            }
        }

        private void MeetingAimName_Click(object sender, EventArgs e)
        {

        }
    }
}

