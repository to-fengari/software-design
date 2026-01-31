namespace lab2.Task2
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
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            lblTitle = new Label();
            txtArrayInput = new TextBox();
            SuspendLayout();
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(407, 237);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 20);
            lblSumResult.TabIndex = 0;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(348, 182);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(119, 29);
            btnCalculateSum.TabIndex = 1;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(181, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(452, 35);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Sum of Array Elements Using Recursion";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(282, 109);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(250, 27);
            txtArrayInput.TabIndex = 3;
            txtArrayInput.Click += txtArrayInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArrayInput);
            Controls.Add(lblTitle);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSumResult;
        private Button btnCalculateSum;
        private Label lblTitle;
        private TextBox txtArrayInput;
    }
}
