using System;

class TheReaper
{
  static void Main()
  {
    // Write code below 💖
    Console.WriteLine("Enter Spice level upto 10");
    string spicelevel=Console.ReadLine();
    int spicy=int.Parse(spicelevel);
    if(spicy>=5){
      Console.WriteLine("Ouch! My mouth is burning!");
    }
    
  }
}