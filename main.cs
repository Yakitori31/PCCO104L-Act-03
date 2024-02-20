using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter text. Type 'exit' to exit.");

    string input = Console.ReadLine();

    while (input != "exit")
    {
      Console.WriteLine("You entered: " + input);
      input = Console.ReadLine();
    }
    
    Console.WriteLine("Program closed.");
  }
}