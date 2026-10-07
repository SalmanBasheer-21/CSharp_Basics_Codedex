using System;

class SayUncle
{
  static void Main()
  {
    // Write code below 💖
    string text="";
    while(text != "uncle"){
      string input= Console.ReadLine();
      if ( input != "uncle"){
        Console.WriteLine(input);
      }
    }
    
  }
}