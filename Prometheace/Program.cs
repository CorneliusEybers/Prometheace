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
      ProcessHourGlass();

      ProcessRotatingArray();
    }

    private static void ProcessRotatingArray()
    {
      Console.WriteLine("Rotating Array:");
      Console.WriteLine("===============");
      Console.WriteLine("");

      var rotatingArray = new RotatingArray();
      int[] arrayToSpin = new int[] {1, 2, 3, 4, 5};
      int timesToSpin = 4;

      string arrayToSpinString = rotatingArray.ArrayToString(arrayToSpin);
      Console.WriteLine("Array to be Rotated : " + arrayToSpinString);

      var arraySpunRight = rotatingArray.RotateArrayRight(arrayToSpin, timesToSpin);
      string arraySpunRightString = rotatingArray.ArrayToString(arraySpunRight);
      Console.WriteLine("Array Rotated Right : " + arraySpunRightString);

      var arraySpunLeft = rotatingArray.RotateArrayLeft(arrayToSpin, timesToSpin);
      string arraySpunLeftString = rotatingArray.ArrayToString(arraySpunLeft);
      Console.WriteLine("Array Rotated Left : " + arraySpunLeftString);

      var arraySpunLeftFast = rotatingArray.RotateArrayLeftFast(arrayToSpin, timesToSpin);
      string arraySpunLeftFastString = rotatingArray.ArrayToString(arraySpunLeftFast);
      Console.WriteLine("Array Rotated Left Fast: " + arraySpunLeftFastString);

      var arraySpunLeftRapid = rotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin);
      string arraySpunLeftRapidString = rotatingArray.ArrayToString(arraySpunLeftRapid);
      Console.WriteLine("Array Rotated Left Rapidly: " + arraySpunLeftRapidString);

      Console.WriteLine("");
      Console.WriteLine("===END=========");
    }

    private static void ProcessHourGlass()
    {
      Console.WriteLine("HourGlass:");
      Console.WriteLine("==========");

      var hourGlass = new HourGlass();
      int depth     = 6;

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
