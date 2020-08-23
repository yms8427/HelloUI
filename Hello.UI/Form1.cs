using Hello.UI.Models;
using System;
using System.Windows.Forms;

namespace Hello.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var cities = new string[] { "Ankara", "İstanbul", "Hatay", "Muş" };
            //var city = Array.IndexOf(cities, "Kars");
            //var a = cities[-1];

            var ns = new Student
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                city = cmbCities.SelectedItem.ToString(),
                birthDate = dtpBirthDate.Value,
                level = (byte)nudLevel.Value,
                gender = rdbMale.Checked ? Gender.Male : Gender.Female
            };

            lstRecords.Items.Add(ns);

            txtFirstName.Clear();
            txtLastName.ResetText();
            cmbCities.SelectedIndex = -1;
            txtFirstName.Focus();
            dtpBirthDate.Value = DateTime.Now;
            nudLevel.Value = 1;
            rdbMale.Checked = true;
        }

        private void lstRecords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = lstRecords.SelectedItem as Student;
            if (selected != null)
            {
                var frm = new frmDetail();
                frm.selectedStudent = selected;
                frm.ShowDialog();
            }
        }
    }
}
