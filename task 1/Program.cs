namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("How many small carpets?");
            int small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many large carpets?");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===============================");

            Console.WriteLine("Number of small carpets:" + small);
            Console.WriteLine("Number of small carpets:" + large);
            Console.WriteLine("Price per small carpet : $25 ");
            Console.WriteLine("Price per larg carpet : $35 ");
            Console.WriteLine($"Cost : ${small * 25 + large * 35}");

            int cost = (small * 25 + large * 35);
            double Tax = cost * (6.0 / 100); Console.WriteLine($"Tax : ${Tax} ");
            double Total = cost + Tax;
            Console.WriteLine("===============================");

            Console.WriteLine("Total estimate: $"+ Total);
            Console.WriteLine("This estimate is valid for 30 days");







        }
    }
}
