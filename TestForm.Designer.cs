namespace XMLBookTracker
{
    partial class TestForm
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
            this.lblViewBooks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDefineNewBooks = new System.Windows.Forms.Label();
            this.controlEditBook1 = new XMLBookTracker.ControlEditBook();
            this.controlViewBooks1 = new XMLBookTracker.ControlViewBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblViewBooks);
            this.panel1.Controls.Add(this.controlViewBooks1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 463);
            this.panel1.TabIndex = 0;
            // 
            // lblViewBooks
            // 
            this.lblViewBooks.AutoSize = true;
            this.lblViewBooks.Location = new System.Drawing.Point(3, 16);
            this.lblViewBooks.Name = "lblViewBooks";
            this.lblViewBooks.Size = new System.Drawing.Size(63, 13);
            this.lblViewBooks.TabIndex = 1;
            this.lblViewBooks.Text = "View Books";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lblDefineNewBooks);
            this.panel2.Controls.Add(this.controlEditBook1);
            this.panel2.Location = new System.Drawing.Point(563, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 460);
            this.panel2.TabIndex = 1;
            // 
            // lblDefineNewBooks
            // 
            this.lblDefineNewBooks.AutoSize = true;
            this.lblDefineNewBooks.Location = new System.Drawing.Point(14, 16);
            this.lblDefineNewBooks.Name = "lblDefineNewBooks";
            this.lblDefineNewBooks.Size = new System.Drawing.Size(96, 13);
            this.lblDefineNewBooks.TabIndex = 1;
            this.lblDefineNewBooks.Text = "Define New Books";
            // 
            // controlEditBook1
            // 
            this.controlEditBook1.AllowEditing = true;
            this.controlEditBook1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlEditBook1.Location = new System.Drawing.Point(17, 32);
            this.controlEditBook1.Name = "controlEditBook1";
            this.controlEditBook1.SaveButtonText = "Add";
            this.controlEditBook1.Size = new System.Drawing.Size(153, 195);
            this.controlEditBook1.TabIndex = 0;
            // 
            // controlViewBooks1
            // 
            this.controlViewBooks1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlViewBooks1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlViewBooks1.Location = new System.Drawing.Point(3, 32);
            this.controlViewBooks1.Name = "controlViewBooks1";
            this.controlViewBooks1.Size = new System.Drawing.Size(529, 428);
            this.controlViewBooks1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblViewBooks;
        private ControlViewBooks controlViewBooks1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDefineNewBooks;
        private ControlEditBook controlEditBook1;
    }
}

