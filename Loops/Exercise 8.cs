// Codédex

using System;

class BestKeptSecret
{
  static void Main()
  {
    string secretPhrase = "Onigiri";
    int attempts = 0;
    string input = "";

    while (input != secretPhrase)
    {
      Console.WriteLine("Enter the secret phrase:");
      input = Console.ReadLine();
      attempts++;
    }

    Console.WriteLine("The bookshelf shifts aside, revealing a hidden passageway.");
    Console.WriteLine("Attempts: " + attempts);
  }
}