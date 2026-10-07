using System;

class BasementShow
{
  static void Main()
  {
    // Write your code below 💖
    string noise=Console.ReadLine();
    int noiselevel=int.Parse(noise);
    if (noiselevel < 40){
      Console.WriteLine("Np complaints yet");

    }
    else if (noiselevel > 40 && noiselevel<70){
      Console.WriteLine("The neighbours are getting annoyed!");
    }
    else{
      Console.WriteLine("We are gonna shut it down!!");
    }
    
  }
}