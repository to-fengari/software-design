namespace Task5BubbleSort
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Procedural: a standalone method that receives data, works on it step by step
		// and hands the result back. No objects are involved.
		public int[] BubbleSort(int[] numbers)
		{
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				for (int j = 0; j < numbers.Length - 1 - i; j++)
				{
					if (numbers[j] > numbers[j + 1])
					{
						int temp = numbers[j];
						numbers[j] = numbers[j + 1];
						numbers[j + 1] = temp;
					}
				}
			}

			return numbers;
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			int[] numbers = { 3, 1, 5, 2, 4 };
			int[] sortedNumbers = BubbleSort(numbers);
			listBoxResults.DataSource = sortedNumbers;
		}
	}
}
