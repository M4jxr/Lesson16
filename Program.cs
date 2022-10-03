
using System;
class Program
{
    static void Main(string[] args)
    {
        Theme topic = new Theme();
        Console.WriteLine(topic.topic("Electing of "));

        Voting voting = new Voting();
        voting.dec();
    }
}
class Theme
{
    public string? topic(string message)
    {
        Console.Write("Election of ");
        string? top = Console.ReadLine();
        return message + top;
    }
}
class Voting
{

    public void dec()
    {
        Console.WriteLine("Make a decision: Yes or No\n0.Exit");
        List<string> yesOrNo = new List<string>() { };
        bool trully = true;
        int i, j;
        i = 0;
        j = 0;
        while (trully)
        {
            string? decision = Console.ReadLine();
            if (decision == "Yes")
            {
                yesOrNo.Add(decision + " " + i);
                i++;
            }
            else if (decision == "No")
            {
                yesOrNo.Add(decision + " " + j);
                j++;
            }
            else if (decision == null)
            {
                Console.WriteLine("You didn't vote");
            }
            else if (decision == "0")
            {
                trully = false;
                break;
            }
            else
            {
                Console.WriteLine("Vote is incorrect");
            }
        }
        foreach (var voting in yesOrNo)
        {
            Console.WriteLine(voting);
        }

    }
}
//checked
