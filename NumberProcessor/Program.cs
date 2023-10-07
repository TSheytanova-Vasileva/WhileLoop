namespace NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            int sum = 0;

            while (comand != "End")
            {
                if (comand == "Inc")
                {
                    num ++;
                }
                else if (comand == "Dec")
                {
                    num--;
                }


                comand = Console.ReadLine();

            }
            Console.WriteLine(num);
        }
    }
}