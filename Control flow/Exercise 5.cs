using System;

class InviteOnly
{
  static void Main()
  {
    // Write code below 💖
    string num=Console.ReadLine();
    int age=int.Parse(num);
    string ggg=Console.ReadLine();
    if ( age>21 && ggg=="true"){
      Console.WriteLine("Come on in !!");
    }
    else{
      Console.WriteLine("Not tonight buddy");
    }
    
  }
}