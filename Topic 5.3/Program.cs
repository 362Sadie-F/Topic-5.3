namespace Topic_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money;
            string work;
            string password;
            string favAnimal;
            int guessNum;
            int age;

            //CopyPaste:
            // Console.WriteLine();
            // Console.WriteLine("Press ENTER to continue");
            // Console.ReadLine();
            // Console.Clear();

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
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            if (password == "EPIC")
            {
                Console.WriteLine("Correct! Welcome!");
            }
            else
            {
                Console.WriteLine("Incorrect! Please try again.");
                Console.WriteLine("Guess: 1. \t Press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.Write("Please enter your password: ");
                password = Console.ReadLine();
                if (password == "EPIC")
                {
                    Console.WriteLine("Correct! Welcome!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Please try again.");
                    Console.WriteLine("Guess: 2. \t Press ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Please enter your password: ");
                    password = Console.ReadLine();
                    if (password == "EPIC")
                    {
                        Console.WriteLine("Correct! Welcome!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Please try again.");
                        Console.WriteLine("Guess: 3. \t Press ENTER to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.Write("Please enter your password: ");
                        password = Console.ReadLine();
                        if (password == "EPIC")
                        {
                            Console.WriteLine("Correct! Welcome!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect! Please try again.");
                            Console.WriteLine("Guess: 4. \t Press ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.Write("Please enter your password: ");
                            password = Console.ReadLine();
                            if (password == "EPIC")
                            {
                                Console.WriteLine("Correct! Welcome!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect! Please try again.");
                                Console.WriteLine("Guess: 5. \t Press ENTER to continue.");
                                Console.ReadLine();
                                Console.Clear();
                                Console.Write("Please enter your password: ");
                                password = Console.ReadLine();
                                if (password == "EPIC")
                                {
                                    Console.WriteLine("Correct! Welcome!");
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect! You're out of guesses. Please try again later.");
                                }
                            }
                        }

                    }
                }
            }
            Console.WriteLine("\t Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            //task 1
            Console.Write("To procced in you purchase of a bus ticket, please enter your age: ");
           age = Convert.ToInt32(Console.ReadLine());
            if (age <= 12 || age >= 60)
            {
                Console.WriteLine("The price of your ticket is $2.00");
            }
            else
            {
                Console.WriteLine("The price of your ticket is $3.50");
            }
            Console.WriteLine("\t Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            //task 2
            Console.WriteLine("What's your favorite animal?");
            Console.Write("My favorite animal is: ");
            favAnimal = Console.ReadLine();
            if (favAnimal == "cat" || favAnimal == "Cat" || favAnimal == "CAT")
            {
                Console.WriteLine("Cool! I have a cat name Yvette!");
            }
            else if (favAnimal == "Dog" || favAnimal == "dog" || favAnimal == "DOG")
            {
                Console.WriteLine("I used to have a dog too- his name was Beau.");
            }
            else
            {
                Console.WriteLine("To each their own.");
            }


        }
    }
}
