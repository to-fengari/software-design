namespace lab3.Task2
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
            listBoxBooksDetailDisplay = new ListBox();
            buttonShowBooks = new Button();
            SuspendLayout();
            // 
            // listBoxBooksDetailDisplay
            // 
            listBoxBooksDetailDisplay.FormattingEnabled = true;
            listBoxBooksDetailDisplay.Location = new Point(372, 50);
            listBoxBooksDetailDisplay.Name = "listBoxBooksDetailDisplay";
            listBoxBooksDetailDisplay.Size = new Size(365, 344);
            listBoxBooksDetailDisplay.TabIndex = 0;
            // 
            // buttonShowBooks
            // 
            buttonShowBooks.Location = new Point(134, 204);
            buttonShowBooks.Name = "buttonShowBooks";
            buttonShowBooks.Size = new Size(94, 29);
            buttonShowBooks.TabIndex = 1;
            buttonShowBooks.Text = "Show Books";
            buttonShowBooks.UseVisualStyleBackColor = true;
            buttonShowBooks.Click += buttonShowBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowBooks);
            Controls.Add(listBoxBooksDetailDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooksDetailDisplay;
        private Button buttonShowBooks;
    }
}
