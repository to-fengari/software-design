namespace lab2.Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long Factorial(long n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }

        private void btnSolveFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                long number = long.Parse(textBoxInput.Text);
                long result = Factorial(number);
                lblResult.Text = $"Factorial of {number} is {result}";
                lblResult.Left = (this.ClientSize.Width - lblResult.Size.Width) / 2;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too large to compute its factorial.");
            }
        }

        private void textBoxInput_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInput.Clear();
        }
    }
}
