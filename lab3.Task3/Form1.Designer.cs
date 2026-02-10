namespace lab3.Task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxBooksDisplayDetails = new ListBox();
            buttonShowBooks = new Button();
            SuspendLayout();
            // 
            // listBoxBooksDisplayDetails
            // 
            listBoxBooksDisplayDetails.FormattingEnabled = true;
            listBoxBooksDisplayDetails.Location = new Point(12, 12);
            listBoxBooksDisplayDetails.Name = "listBoxBooksDisplayDetails";
            listBoxBooksDisplayDetails.Size = new Size(776, 324);
            listBoxBooksDisplayDetails.TabIndex = 0;
            // 
            // buttonShowBooks
            // 
            buttonShowBooks.Location = new Point(353, 372);
            buttonShowBooks.Name = "buttonShowBooks";
            buttonShowBooks.Size = new Size(94, 29);
            buttonShowBooks.TabIndex = 1;
            buttonShowBooks.Text = "Show List";
            buttonShowBooks.UseVisualStyleBackColor = true;
            buttonShowBooks.Click += buttonShowBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowBooks);
            Controls.Add(listBoxBooksDisplayDetails);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooksDisplayDetails;
        private Button buttonShowBooks;
    }
}
