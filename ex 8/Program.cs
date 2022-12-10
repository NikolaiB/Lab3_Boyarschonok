namespace ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Последовательность Фиббоначи : ");

            int j = 1;
            Console.Write(1+"\t");
             for (int i = 0; i <= 9; i++)
             {
                j+=i;
                Console.Write(j+"\t");
             }
            
        }
    }
    
}