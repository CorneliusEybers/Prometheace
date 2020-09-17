// - Required Assemblies
using System;
using System.Text;

// - Application Assemblies

namespace Prometheace
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("HourGlass:");
      Console.WriteLine("==========");

      var hourGlass = new HourGlass();
      int depth = 6;

      var matrix = hourGlass.GenerateMatrix(depth:depth);

      var sumMaxHourGlass = hourGlass.SumMaxHourGlass(matrix);

      Console.WriteLine("Matrix: ");
      Console.WriteLine("--------");
      Console.WriteLine(string.Empty);

      var stringBuilder = new StringBuilder();

      for (int indexRow = 0; indexRow < depth; indexRow++)
      {
        for (int indexCol = 0; indexCol < depth; indexCol++)
        {
          stringBuilder.Append(matrix[indexRow][indexCol].ToString("00"));
          stringBuilder.Append("|");
        }

        Console.WriteLine(stringBuilder.ToString());
        stringBuilder.Clear();
      }

      Console.WriteLine(string.Empty);
      Console.WriteLine("Max Hour-Glass Sum : " + sumMaxHourGlass.ToString());
      Console.WriteLine(string.Empty);

      Console.WriteLine("===END====");
      Console.WriteLine(string.Empty);
    }
  }
}
