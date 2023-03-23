using System.Text;

int score = 0;
int count = 0;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

Console.Write("What is your name?");
string name = Console.ReadLine();

Console.Write("Would you like to play a game? (yes/no)");
string playerDecision = Console.ReadLine();

if (playerDecision == "yes")
{
    Console.WriteLine("Let's Play!");

    do
    {   
        Console.WriteLine("Heads or Tails?");
        string HT = Console.ReadLine();

        Random rand = new Random();
        int number = rand.Next(0, 2); // 0 is Heads, 1 is Tails

        if (HT == "Heads" && number == 0)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        if (HT == "Tails" && number == 0)
        {
            Console.WriteLine("Wrong!");
        }
        if (HT == "Heads" && number == 1)
        {
            Console.WriteLine("Wrong!");
        }
        if (HT == "Tails" && number == 1)
        {
            Console.WriteLine("Correct!");
            score++;
        }

        count++;
    } while (count < 5);
    Console.WriteLine("Thank you "+ name +". You got a score of " + score++);
}

if (playerDecision == "no")
{
    Console.WriteLine("You are a coward " + name);
}