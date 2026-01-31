namespace lab2.Task3RecursiveFibonacciSequence
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
            lblTitle = new Label();
            textBoxInput = new TextBox();
            btnCalcFibunacci = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(228, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Recursive Fibonacci Sequence";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(338, 183);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 1;
            textBoxInput.Text = "Enter 'n'";
            textBoxInput.Click += textBoxInput_Click;
            // 
            // btnCalcFibunacci
            // 
            btnCalcFibunacci.Location = new Point(353, 235);
            btnCalcFibunacci.Name = "btnCalcFibunacci";
            btnCalcFibunacci.Size = new Size(94, 29);
            btnCalcFibunacci.TabIndex = 2;
            btnCalcFibunacci.Text = "Calculate";
            btnCalcFibunacci.UseVisualStyleBackColor = true;
            btnCalcFibunacci.Click += btnCalcFibunacci_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(400, 292);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalcFibunacci);
            Controls.Add(textBoxInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBoxInput;
        private Button btnCalcFibunacci;
        private Label lblResult;
    }
}
