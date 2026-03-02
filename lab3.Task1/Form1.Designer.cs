namespace lab3.Task1
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
            buttonShowInfo = new Button();
            SuspendLayout();
            // 
            // buttonShowInfo
            // 
            buttonShowInfo.Location = new Point(343, 272);
            buttonShowInfo.Name = "buttonShowInfo";
            buttonShowInfo.Size = new Size(94, 29);
            buttonShowInfo.TabIndex = 3;
            buttonShowInfo.Text = "Show Info";
            buttonShowInfo.UseVisualStyleBackColor = true;
            buttonShowInfo.Click += buttonShowInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonShowInfo;
    }
}
