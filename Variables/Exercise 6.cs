using System;

class GiantPlushie
{
  static void Main()
  {
    // Write code below 💖
  Console.WriteLine("How many tickets do u have? : ");
  string input=Console.ReadLine();
  int tickets=int.Parse(input);
  int plushie=50;
  int noofplushies = tickets/plushie;
  int leftover = tickets%plushie;
  Console.WriteLine(noofplushies);
  Console.WriteLine(leftover);
  }
}
