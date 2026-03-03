namespace lab6.Task1_3
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            BookID = new Label();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            progressBar = new ProgressBar();
            lblProgressReport = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxSearchByTitle = new TextBox();
            btnSearchBookbyTitle = new Button();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(531, 362);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(94, 29);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Show";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(361, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(427, 344);
            listBoxBooks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(90, 27);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(240, 27);
            txtAuthorName.TabIndex = 4;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(90, 64);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(240, 27);
            txtBookTitle.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(162, 97);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += BtnAddBook_Click;
            // 
            // BookID
            // 
            BookID.AutoSize = true;
            BookID.Location = new Point(27, 160);
            BookID.Name = "BookID";
            BookID.Size = new Size(61, 20);
            BookID.TabIndex = 7;
            BookID.Text = "BookID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(90, 157);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(240, 27);
            txtBookID.TabIndex = 8;
            txtBookID.TextChanged += TextBoxBookID_TextChanged;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(106, 190);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 29);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += BtnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(206, 190);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 29);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += BtnDeleteBook_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 428);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(776, 10);
            progressBar.TabIndex = 11;
            // 
            // lblProgressReport
            // 
            lblProgressReport.AutoSize = true;
            lblProgressReport.Location = new Point(12, 405);
            lblProgressReport.Name = "lblProgressReport";
            lblProgressReport.Size = new Size(0, 20);
            lblProgressReport.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 257);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 13;
            label3.Text = "Search by Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 280);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 14;
            label4.Text = "Title:";
            // 
            // textBoxSearchByTitle
            // 
            textBoxSearchByTitle.Location = new Point(90, 280);
            textBoxSearchByTitle.Name = "textBoxSearchByTitle";
            textBoxSearchByTitle.Size = new Size(240, 27);
            textBoxSearchByTitle.TabIndex = 15;
            // 
            // btnSearchBookbyTitle
            // 
            btnSearchBookbyTitle.Location = new Point(162, 327);
            btnSearchBookbyTitle.Name = "btnSearchBookbyTitle";
            btnSearchBookbyTitle.Size = new Size(94, 29);
            btnSearchBookbyTitle.TabIndex = 16;
            btnSearchBookbyTitle.Text = "Search";
            btnSearchBookbyTitle.UseVisualStyleBackColor = true;
            btnSearchBookbyTitle.Click += BtnSearchBookbyTitle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchBookbyTitle);
            Controls.Add(textBoxSearchByTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblProgressReport);
            Controls.Add(progressBar);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(BookID);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private Label label1;
        private Label label2;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label BookID;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private ProgressBar progressBar;
        private Label lblProgressReport;
        private Label label3;
        private Label label4;
        private TextBox textBoxSearchByTitle;
        private Button btnSearchBookbyTitle;
    }
}
