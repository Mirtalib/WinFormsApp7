using WinFormsApp7.MOdels;
using WinFormsApp7;

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
            lblFullname.Text = student?.FullName?.ToString();
            lblLAstIn.Text = student?.LastIn.ToShortDateString();

        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true || rbtn2.Checked == true)
            {
                comboBoxLbrt.Enabled = true;
                comboBox2.Enabled = true;
                btnComent.Enabled = true;
                btnDiamond1.Enabled = true;
                btnDiamond2.Enabled = true;
                btnDiamond3.Enabled = true;
                btnDiamondCancel.Enabled = true;               
            }
            else
            {
                comboBoxLbrt.Enabled = false;
                comboBoxLbrt.Text = null;
                comboBox2.Enabled = false;
                comboBox2.Text = null;
                btnComent.Enabled = false;
                btnDiamond1.Enabled = false;
                btnDiamond2.Enabled = false;
                btnDiamond3.Enabled = false;
                btnDiamondCancel.Enabled = false;
                txtBoxComment.Text = null;
                txtBoxComment.Visible = false;
                btnDiamond3.BackColor = Color.White;
                btnDiamond2.BackColor = Color.White;
                btnDiamond1.BackColor = Color.White;
            }
        }


        private void btnComent_Click(object sender, EventArgs e)
        {
            btnComent.Visible = false;
            txtBoxComment.Visible = true;
            txtBoxComment.Enabled = true;
            btnSaveComment.Visible = true;
        }

        private void btnSaveComment_Click(object sender, EventArgs e)
        {
            btnComent.Visible = true;
            txtBoxComment.Enabled = false;
            btnSaveComment.Visible = false;
        }

        private void btnDiamond3_Click(object sender, EventArgs e)
        {
                btnDiamond1.BackColor = Color.Blue;
                btnDiamond2.BackColor = Color.Blue;
                btnDiamond3.BackColor = Color.Blue;
        }

        private void btnDiamond2_Click(object sender, EventArgs e)
        {
            btnDiamond3.BackColor =Color.White;
            btnDiamond2.BackColor = Color.Blue;
            btnDiamond1.BackColor = Color.Blue;
        }

        private void btnDiamond1_Click(object sender, EventArgs e)
        {
            btnDiamond3.BackColor = Color.White;
            btnDiamond2.BackColor = Color.White;
            btnDiamond1.BackColor = Color.Blue;
        }
    }
}
