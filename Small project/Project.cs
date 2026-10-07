using System;
class Madlyricist
{
    static void Main(){
        Console.WriteLine("Welcome to MAD Lyricist ");
        Console.WriteLine("Enter a noun : ");
        string input = Console.ReadLine();
        Console.WriteLine("Enter a verb: ");
        string verbi = Console.ReadLine();
        Console.WriteLine("Enter a adjective: ");
        string adji=Console.ReadLine();
        Console.WriteLine("Enter an object : ");
        string obji=Console.ReadLine();
        Console.WriteLine("Enter a place: ");
        string plci=Console.ReadLine();
        Console.WriteLine("  🎶 Your Song 🎶 ");
        Console.WriteLine("  Twinkle, twinkle, little " + input);
        Console.WriteLine("  How I  " + verbi + " what you are.");
        Console.WriteLine("  Up above the bug so" + adji);
        Console.WriteLine(" Like a " + obji + " in the " + plci + " .");
    }
}