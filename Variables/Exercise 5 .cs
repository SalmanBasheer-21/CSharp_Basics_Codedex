using System;

class YearOfTheX
{
  static void Main()
  {
   Console.WriteLine("What year were you born?");
    
    string input = Console.ReadLine();
    int birthYear = int.Parse(input);
  int cycle = 12;
  int currentYear = 2026;
  int yearsUntilZodiac = (cycle - ((currentYear - birthYear) % cycle)) % cycle;
  Console.WriteLine(yearsUntilZodiac);
  }
}
