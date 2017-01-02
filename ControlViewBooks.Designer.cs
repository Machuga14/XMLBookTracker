namespace XMLBookTracker
{
    partial class ControlViewBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvBooks = new System.Windows.Forms.ListView();
            this.columnHeaderBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEditBook = new System.Windows.Forms.Label();
            this.controlEditBook1 = new XMLBookTracker.ControlEditBook();
            this.SuspendLayout();
            // 
            // lvBooks
            // 
            this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBookName,
            this.columnHeaderAuthorName,
            this.columnHeaderPrice,
            this.columnHeaderQuantity});
            this.lvBooks.FullRowSelect = true;
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(3, 3);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(355, 521);
            this.lvBooks.TabIndex = 0;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            this.lvBooks.SelectedIndexChanged += new System.EventHandler(this.lvBooks_SelectedIndexChanged);
            // 
            // columnHeaderBookName
            // 
            this.columnHeaderBookName.Text = "Name";
            this.columnHeaderBookName.Width = 106;
            // 
            // columnHeaderAuthorName
            // 
            this.columnHeaderAuthorName.Text = "Author";
            this.columnHeaderAuthorName.Width = 106;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "$";
            this.columnHeaderPrice.Width = 69;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "#";
            this.columnHeaderQuantity.Width = 47;
            // 
            // lblEditBook
            // 
            this.lblEditBook.AutoSize = true;
            this.lblEditBook.Location = new System.Drawing.Point(364, 26);
            this.lblEditBook.Name = "lblEditBook";
            this.lblEditBook.Size = new System.Drawing.Size(53, 13);
            this.lblEditBook.TabIndex = 2;
            this.lblEditBook.Text = "Edit Book";
            // 
            // controlEditBook1
            // 
            this.controlEditBook1.AllowEditing = true;
            this.controlEditBook1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlEditBook1.Location = new System.Drawing.Point(364, 42);
            this.controlEditBook1.Name = "controlEditBook1";
            this.controlEditBook1.SaveButtonText = "Save";
            this.controlEditBook1.Size = new System.Drawing.Size(153, 195);
            this.controlEditBook1.TabIndex = 1;
            // 
            // ControlViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblEditBook);
            this.Controls.Add(this.controlEditBook1);
            this.Controls.Add(this.lvBooks);
            this.Name = "ControlViewBooks";
            this.Size = new System.Drawing.Size(525, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ColumnHeader columnHeaderBookName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthorName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private ControlEditBook controlEditBook1;
        private System.Windows.Forms.Label lblEditBook;
    }
}
