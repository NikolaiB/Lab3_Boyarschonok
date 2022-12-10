namespace Ex_3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Random random = new();

            Console.WriteLine("Введите положительное количество элемемнтов массива");
            int x = Convert.ToInt32(Console.ReadLine());
            //переменную y можно использовать для того чтобы размер
            //массива задавался рандомно.

            //int y = random.Next(50); 


            int [] arr = new int [x];

            //random input
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = random.Next(100);
            }


            //output
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i]+ "\t");
            }
            Console.WriteLine();

            //min number in array
            int minnum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<minnum)
                {
                    minnum = arr[i];
                }

            }
            Console.WriteLine("Min number:" + minnum);

            //max number in array
            int maxnum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxnum)
                {
                    maxnum = arr[i];
                }

            }
            Console.WriteLine("Max number:" + maxnum);

            //arifm array

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                count += arr[i];

            }

            Console.WriteLine("Arifm number:" + count/2);


        }
    }
}