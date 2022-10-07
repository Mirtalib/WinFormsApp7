namespace WinFormsApp7
{
    partial class FormMain
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
            this.uc_Student1 = new WinFormsApp7.Forms.Uc_Student();
            this.SuspendLayout();
            // 
            // uc_Student1
            // 
            this.uc_Student1.Location = new System.Drawing.Point(11, 12);
            this.uc_Student1.MinimumSize = new System.Drawing.Size(800, 0);
            this.uc_Student1.Name = "uc_Student1";
            this.uc_Student1.Size = new System.Drawing.Size(1491, 59);
            this.uc_Student1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 450);
            this.Controls.Add(this.uc_Student1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.Uc_Student uc_Student1;
    }
}