namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = 123123123;
            Watchdog dawg = new Watchdog("budder dawg","nowhere");
            Dog muhDawg = dawg;

            int temp = dawg.GetBaseTax();
            Console.WriteLine(temp);

            temp = muhDawg.GetBaseTax();
            Console.WriteLine(temp);

            Console.WriteLine(dawg.ToString());
            Console.WriteLine(test.ToString());
        }
    }
}
