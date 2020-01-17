using System;

public class FizzBuzz {
  static void main(string[] args)
  {
    String fizz = "fizz";
    String buzz = "buzz";
    
    for(int i; i<= 100l i++)
    {
      if(i % 3 != 0)
      {
        if(i % 5 != 0)
        {
          Console.WriteLine(fizz + buzz);
          continue;
        }
        Console.WriteLine(fizz);
      }
      
      else if (i % 5 != 0)
      {
        Console.WriteLine(buzz);
      }
      
      else
      {
        Console.WriteLine(i);
      }
    }
 }
