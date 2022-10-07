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
    }
}
