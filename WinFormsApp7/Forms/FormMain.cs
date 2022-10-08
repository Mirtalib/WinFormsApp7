using WinFormsApp7.Forms;
using WinFormsApp7.Reposidory;

namespace WinFormsApp7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var student = FaceRepo.GetStudents();


            for (int i = student.Count - 1; i >= 0;  i--)
            {
                Uc_Student uc = new Uc_Student(student[i]);
                uc.Dock = DockStyle.Top;
                pnlStdentContent.Controls.Add(uc);
            }
        }


        private void rbCheckTeacher1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheckTeacher1.Checked == true)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void rbCheckTeacher2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheckTeacher2.Checked == true)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtMaterial.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnEdit.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtMaterial.Text))
            {

                foreach (var control in pnlStdentContent.Controls)
                {
                    if (control is Uc_Student s)
                    {
                        s.rbtn1.Enabled = true;
                        s.rbtn2.Enabled = true;
                        s.rbtn3.Enabled = true;
                    }
                }
                btnEdit.Visible = true;
                rbtnAllTrue.Enabled = true;
                txtMaterial.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblLessonName.Text = txtMaterial.Text;
            }
            else
            {
                MessageBox.Show("Enter Text");
            }
        }


        

        private void rbtnAllTrue_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in pnlStdentContent.Controls)
            {
                if (control is Uc_Student s)
                {
                    s.rbtn1.Checked = true;
                }
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaterial.Clear();
            txtMaterial.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnEdit.Visible = true;
            lblLessonName.Text=txtMaterial.Text;
        }
    }
}
