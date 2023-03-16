// See https://aka.ms/new-console-template for more information
int score = 0;
Random rnd = new();
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
string input1 = Console.ReadLine();
if (input1 == "Yes")
{
    for (int j = 0; j < 5; j++)
    {
        int flip = rnd.Next(0, 2);
        Console.WriteLine("Heads or Tails?");
        string input2 = Console.ReadLine();
        if (input2 == "Heads" && flip == 0)
        {
            Console.WriteLine("Correct!");
            score++;
        } else if (input2 == "Heads" && flip == 1)
        {
            Console.WriteLine("Wrong!");
        } else if (input2 == "Tails" && flip == 0)
        {
            Console.WriteLine("Wrong!");
        } else if (input2 == "Tails" && flip == 1)
        {
            Console.WriteLine("Correct!");
            score++;
        }
    }
    Console.WriteLine("Thank you " + name + ". You got a score of " + score + "!");

} else if (input1 == "No")
{
    Console.WriteLine("You are a coward " + name);
}
