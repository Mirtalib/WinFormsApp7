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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogbook = new System.Windows.Forms.Label();
            this.pnlStdentContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblLogbook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblLogbook
            // 
            this.lblLogbook.AutoSize = true;
            this.lblLogbook.Location = new System.Drawing.Point(730, 43);
            this.lblLogbook.Name = "lblLogbook";
            this.lblLogbook.Size = new System.Drawing.Size(54, 15);
            this.lblLogbook.TabIndex = 0;
            this.lblLogbook.Text = "Logbook";
            // 
            // pnlStdentContent
            // 
            this.pnlStdentContent.BackColor = System.Drawing.SystemColors.Info;
            this.pnlStdentContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStdentContent.Location = new System.Drawing.Point(7, 100);
            this.pnlStdentContent.Name = "pnlStdentContent";
            this.pnlStdentContent.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnlStdentContent.Size = new System.Drawing.Size(1500, 477);
            this.pnlStdentContent.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1080, 0);
            this.ClientSize = new System.Drawing.Size(1514, 577);
            this.Controls.Add(this.pnlStdentContent);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Text = "LoogBook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlStdentContent;
        private Label lblLogbook;
    }
}