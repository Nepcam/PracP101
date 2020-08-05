using System;
using System.Collections.Generic;
using System.Text;

namespace PracP1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int n = 0;
      string s = "";

      // Check if 2 argumnets
      if (args.Length == 2) {
        if (int.TryParse(args[0], out n)) {
          // Successful parse, so use n
          s = args[1]; // Second argument is character
          // Draw a line of characters
          DrawChars(n, s);
        } else {
          // Unsuccessful parse, so no n value
        }
      }

      // Wait for user to have read the output
      Console.WriteLine();
      Console.Write("<Press enter to finish>");
      Console.ReadLine();
    }

    /// <summary>
    /// Draws a line of characters
    /// </summary>
    /// <param name="n">Number of characters to draw</param>
    /// <param name="s">Character to draw n times</param>
    static void DrawChars(int n, string s)
    {
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }
    }

  }
}