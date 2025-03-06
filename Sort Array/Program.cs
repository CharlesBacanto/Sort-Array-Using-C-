namespace Sort_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 9, 1, 4, 3, 8, 5, 7, 6, 2 };

            int size = numbers.Length;

            Console.WriteLine(size);
            Sort.sortArray(numbers, size, Sort.temp);

            Sort.printSort(numbers, size);

        }

       
    }
}
