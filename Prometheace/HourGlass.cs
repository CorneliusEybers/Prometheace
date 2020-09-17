// - Required Assemblies
using System;

// - Application Assemblies

namespace Prometheace
{
  /// <summary>
  /// - In a matrix of integers with dimensions that are divisible by 3 (3,6,9,12...)
  /// - Where the two dimensions are equal(Y = X I.E. 3x3, 6x6, 9x9, 12x12 ...)
  /// - Find the sum of all values in this pattern:
  ///   a b c  |  5 0 4
  ///     d    |    9
  ///   e f g  |  3 8 2 = 31
  /// - Hour-Glasses may overlap, the middle of the one hour-glass
  ///   can be the left-side of the next hour-glass.
  /// - Determine the largest hourglass in the matrix given.
  /// - Negative values are allowed and -12 is greater that -13...
  /// - Max Value of any Hourglass is 63 because 9 + 9 + 9 + 9 + 9 + 9 + 9 = 63
  /// </summary>
  public class HourGlass
  {

    #region PublicMethods

    /// <summary>
    /// - Generate two dimensional array that will form a matrix
    ///   for the Hour-Glass algorithm.
    /// - Matrix must be square(X-Axis = Y-Axis)
    /// - Matrix depth must be divisible by 3.
    /// </summary>
    /// <param name="depth"> X and Y length of the Matrix</param>
    /// <returns></returns>
    public int[][] GenerateMatrix(int depth)
    {
      // - Validation
      if (depth % 3 != 0)
      {
        Console.WriteLine("Depth of Matrix must be increments of 3...");
        return new int[0][];
      }

      int[][] matrix = new int[depth][];

      for (int indexRow = 0; indexRow < depth; indexRow++)
      {
        matrix[indexRow] = new int[depth];

        for (int indexCol = 0; indexCol < depth; indexCol++)
        {
          matrix[indexRow][indexCol] = RandomInt();
        }
      }

      return matrix;
    }

    public int SumMaxHourGlass(int[][] matrix)
    {
      int result = 0;
      int sumMaxHourGlass = -63;
      int row    = 0;
      int left   = 0;

      // - Validation
      if (ValidMatrix(matrix))
      {
        for (left = 0; left <= 3; left++)
        {
          for (row = 0; row <= 3; row++)
          {
            int glass = 0;

            glass += matrix[row][left] + matrix[row][left + 1] + matrix[row][left             + 2];
            glass += matrix[row                                                               + 1][left + 1];
            glass += matrix[row + 2][left] + matrix[row + 2][left + 1] + matrix[row + 2][left + 2];

            if (glass > sumMaxHourGlass)
            {
              sumMaxHourGlass = glass;
            }
          }
        }

        result = sumMaxHourGlass;
      }

      return result;
    }

    #endregion

    #region PrivateMethods

    private int RandomInt()
    {
      var random = new Random();

      return random.Next(50);
    }

    private bool ValidMatrix(int[][] matrix)
    {
      if (matrix.Length < 3)
      {
        Console.WriteLine("Matrix have less than 3 rows...");
        return false;
      }

      if (matrix.Length % 3 != 0)
      {
        Console.WriteLine("Number of rows in Matrix are not divisible by 3...");
        return false;
      }

      foreach (var row in matrix)
      {
        if(row.Length < 3)
        {
          Console.WriteLine("Matrix has one row with less than 3 columns...");
          return false;
        }

        if (row.Length % 3 != 0)
        {
          Console.WriteLine("Matrix has one row that is not divisible by 3...");
          return false;
        }

        if (row.Length != matrix.Length)
        {
          Console.WriteLine("Matrix has one row that is not the same length as the res of the Matrix...");
          return false;;
        }
      }

      // - Zero error point
      return true;
    }

    #endregion
  }
}