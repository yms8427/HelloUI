using Hello.UI.Models;
using System;
using System.Windows.Forms;

namespace Hello.UI
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Student selectedStudent;

        private void frmDetail_Load(object sender, EventArgs e)
        {
            txtFullName.Text = $"{selectedStudent.firstName} {selectedStudent.lastName}";
            txtCity.Text = selectedStudent.city;
            //if (selectedStudent.gender == Gender.Male)
            //{
            //    txtGender.Text = "Erkek";
            //}
            //else
            //{
            //    txtGender.Text = "Kadın";
            //}
            txtGender.Text = selectedStudent.gender == Gender.Male ? "Erkek" : "Kadın";
            txtLevel.Text = selectedStudent.level.ToString();
            txtBirthDate.Text = $"{selectedStudent.birthDate.ToString("dd/MM/yyyy")} - {DateTime.Now.Year - selectedStudent.birthDate.Year} yaşında";
        }
    }
}
