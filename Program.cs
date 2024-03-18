namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Min());
        }
        public static int Min()
        {
            int[] number = { 1, 2, 35, 47, 89, 64, 45 };
            int min = number[0];           
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < min)
                {
                    min = number[i];                  
                }
            }
            return min;
        }
    }
}
