using System;

namespace rps
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Hello Player!");
      Console.WriteLine("What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name}");
      bool running = true;
      var choices = new string[3]{
          "rock",
          "paper",
          "scissors"
      };
      int playerWins = 0;
      int compWins = 0;
      while (running)
      {
        Console.WriteLine("Do you want to play a game? (y/n)");
        if (Console.ReadKey().KeyChar == 'n')
        {
          running = false;
          break;
        }
        Console.Clear();
        Console.WriteLine("Rock, Paper, or Scissors?");
        string playerChoice = Console.ReadLine().ToLower().Trim();
        Random rnd = new Random();
        int compChoice = rnd.Next(3);
        int playerNum = 0;
        bool flag = false;
        for (int i = 0; i < choices.Length; i++)
        {
          if (playerChoice == choices[i])
          {
            playerNum = i;
            flag = true;
          }
        }
        if (flag)
        {
          Console.WriteLine($"Player Choice: {choices[playerNum]}. Computer Choice: {choices[compChoice]}");
          if (playerChoice == choices[compChoice])
          {
            Console.WriteLine("Neither of you won!");
          }
          else if (compChoice == 0 && playerNum != 2 || playerNum > compChoice || playerNum == 0 && compChoice == 2)
          {
            playerWins++;
            Console.WriteLine($"{name} wins!");
          }
          else
          {
            compWins++;
            Console.WriteLine("Computer wins!");
          }
          Console.WriteLine($"Computer: {compWins}, {name}: {playerWins}");
        }
      }
    }
  }
}
