using System;

class NotificationOverload
{
  static void Main()
  {
    // Write code below 💖
    
    string[] msg={
      " Michael: who's going dancing tonight??? ",
      "Sara: not meeeeee I gotta work on this project",
      " Nate: join usssssss",
      "Syd: i should rly stay in too tbh"

    };
    int l=msg.Length;

    for (int i=0;i<l;i++){
      Console.WriteLine(msg[i]);
    }
  }
}