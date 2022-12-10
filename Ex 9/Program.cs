namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                string[] arrayOfSurnames = new string[5];

                for (int i = 0; i < arrayOfSurnames.Length; i++)
                {
                    Console.WriteLine("Введтие фамилию: ");
                    string Surname = Console.ReadLine();
                    arrayOfSurnames[i] = Surname;
                }

                Array.Sort(arrayOfSurnames);
                for (int i = 0; i < arrayOfSurnames.Length; i++)
                {
                    Console.Write(" " + arrayOfSurnames[i]);
                }
                
            }
        }    
    }
}