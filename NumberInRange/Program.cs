namespace NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool inrandge = n >= 1 && n <= 100;


            while (!inrandge)
            {

                n = int.Parse(Console.ReadLine());
                inrandge = n >= 1 && n <= 100;
            }
            Console.WriteLine(n);
        }
    }
}