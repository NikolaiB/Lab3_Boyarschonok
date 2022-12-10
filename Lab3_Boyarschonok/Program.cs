namespace Lab3_Boyarschonok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output odd numbers from 1 to 99:");

            for (int i = 0; i <= 99; i++) 
            {
                if (i%2==0) // если остаток от деления равен 0, то четное
                {
                    i++; //increment
                    Console.WriteLine(i);
                }
            }


        }
    }
}