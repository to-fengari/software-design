namespace Task4
{
	// Object-Oriented Programming: the data and the behaviour that operates on it
	// are bundled together in a class instead of living in a standalone procedure.
	public class NumberSorter
	{
		// Encapsulation: the array is held by the object and exposed as a property.
		public int[] Numbers { get; private set; }

		public NumberSorter(int[] numbers)
		{
			Numbers = numbers;
		}

		// Declared virtual so a derived class can override the ordering (polymorphism).
		public virtual int[] Sort()
		{
			int[] sorted = (int[])Numbers.Clone();
			Array.Sort(sorted);
			return sorted;
		}
	}

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			int[] numbers = { 3, 1, 5, 2, 4 };

			// An object is created from the class, then asked to do the work.
			NumberSorter sorter = new NumberSorter(numbers);
			int[] sortedNumbers = sorter.Sort();

			listBoxResults.DataSource = sortedNumbers;
		}
	}
}
