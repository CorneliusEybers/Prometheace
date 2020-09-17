using System;

namespace Prometheace
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("HourGlass:");
      Console.WriteLine("==========");

      var hourGlass = new HourGlass();

      var matrix = hourGlass.GenerateMatrix(depth:6);

      var sumMaxHourGlass = hourGlass.SumMaxHourGlass(matrix);

      Console.WriteLine("===END====");
      Console.WriteLine(string.Empty);
    }
  }
}
