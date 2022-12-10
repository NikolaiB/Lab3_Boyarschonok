namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5};
            int[] arr2 = { 11, 12, 13, 14, 15 };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("\n");

            for (int j = 0; j < arr2.GetLength(0); j++)
            {
                Console.Write(arr2[j] + "\t");
            }
            Console.WriteLine();

        }
    }
}