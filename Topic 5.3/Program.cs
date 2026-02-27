namespace Topic_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money;
            string work;

            //task 1
            Console.WriteLine("You want to go to the movies? Are you working?");
            work = Console.ReadLine();
            if (work == "no" || work == "yes")
            {
                Console.WriteLine("Okay, and how much do you have?");
            }
            money = Convert.ToDouble(Console.ReadLine());
            if (money >= 20 && work == "no")
            {
                Console.WriteLine("You have " + money.ToString("C") + " and aren't going to work, so you can go!");
            }
            if (money < 20 && work == "no")
            {
                Console.WriteLine(money.ToString("C") + " Is not enough to go.");
            }
            if (money >= 20 && work == "yes")
            {
                Console.WriteLine("You have work and can't go.");
            }
            if (money < 20 && work == "yes")
            {
                Console.WriteLine("You have work and can't go.");
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //task 2

        }
    }
}
