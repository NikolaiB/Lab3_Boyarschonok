namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number from 1 to ");
         
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
          

            for (int i = 0; i <= num; i++)

            {
                counter = counter + i;
            }

            

            Console.WriteLine("Сумма чисел:"+ counter);

        }
    }
}