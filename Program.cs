// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
string response = Console.ReadLine();
{
    if (response == "No")
        Console.WriteLine("You are a coward " + name);

    if (response == "Yes")
    {
        int score = 0;
        Random ran = new Random();
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Round :"+i);
            Console.WriteLine("Heads or Tails?");
            int randomnum = ran.Next(0, 2);
            string guess = Console.ReadLine();

            if (guess == "Heads" && randomnum == 0)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            if (guess == "Heads" && randomnum == 1)
            {
                Console.WriteLine("Wrong!");
            }
            if (guess == "Tails" && randomnum == 1)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            if (guess == "Tails" && randomnum == 0)
            {
                Console.WriteLine("Wrong!");
            }
        }Console.WriteLine("Thank you " + name + ". You got a score of " + score + "!");
    }
}






