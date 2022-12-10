namespace Ex_6
{
    internal class Program
    {  
        private static int [] OutputArray( int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
               
                Console.Write(arr[i] + "\t");
                
            }
            
            return arr;
            
        }

        private static int [] ChangeEvenIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)

                {
                    array[i] = 0;
                }

                Console.Write(array[i] + "\t");

            }
            return array;
        }

        static void Main(string[] args)
        {
            
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8};

            Console.WriteLine(": Output array", OutputArray(array));
            Console.WriteLine(": Output new array", ChangeEvenIndex(array) );
            

            
           
        }
            


           
        
    }
}