namespace Task5_CustomDescendingOrderApplyingOOP
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
            listBoxResults = new ListBox();
            listBoxOriginal = new ListBox();
            btnSort = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(513, 44);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(250, 394);
            listBoxResults.TabIndex = 0;
            // 
            // listBoxOriginal
            // 
            listBoxOriginal.FormattingEnabled = true;
            listBoxOriginal.ItemHeight = 15;
            listBoxOriginal.Location = new Point(257, 44);
            listBoxOriginal.Name = "listBoxOriginal";
            listBoxOriginal.Size = new Size(250, 394);
            listBoxOriginal.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(57, 44);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(154, 29);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Unsorted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 26);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Sorted";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(223, 25);
            label3.TabIndex = 5;
            label3.Text = "Custom Descending Order";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSort);
            Controls.Add(listBoxOriginal);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResults;
        private ListBox listBoxOriginal;
        private Button btnSort;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
