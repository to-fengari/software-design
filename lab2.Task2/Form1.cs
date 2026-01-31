namespace lab2.Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long RecursiveSum(long[] numbers, long n)
        {
            if (n <= 0)
                return 0;
            return numbers[n - 1] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                long[] numbers = txtArrayInput.Text.Split(',').Select(long.Parse).ToArray();
                long result = RecursiveSum(numbers, numbers.Length);
                lblSumResult.Text = $"Sum is {result}";
                lblSumResult.Left = (this.ClientSize.Width - lblSumResult.Size.Width) / 2;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid array of integers separated by commas.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("One of the numbers is too large.");
            }
        }

        private void txtArrayInput_Click(object sender, EventArgs e)
        {
            txtArrayInput.Clear();
        }
    }
}
