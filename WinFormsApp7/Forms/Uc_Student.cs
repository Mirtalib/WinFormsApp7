using WinFormsApp7.MOdels;

namespace WinFormsApp7.Forms
{
    public partial class Uc_Student : UserControl
    {
        public Uc_Student(Student student)
        {
            InitializeComponent();


            if (!string.IsNullOrEmpty(student.PictureUrl))
            {
                pictureBox1.Load($"./../../../Resources/{student.PictureUrl}");
            }

            lblNo.Text = student.Number.ToString();
            lblFullname.Text = student.FullName.ToString();
            lblLAstIn.Text = student.LastIn.ToShortDateString();



            switch (student.Status)
            {
                case ParticipationStatus.Unknown:
                    break;
                case ParticipationStatus.Present:
                    rbtn1.Checked = true;
                    break;
                case ParticipationStatus.Absent:
                    rbtn2.Checked = true;
                    break;
                case ParticipationStatus.Late:
                    rbtn3.Checked = true;
                    break;
            }
        }




    }
}
