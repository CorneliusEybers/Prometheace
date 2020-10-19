using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prometheace.Tests
{
  [TestClass]
  public class HourGlassTests
  {
    public class Resources
    {
      #region ClassVariables

      #endregion

      #region Properties

      public HourGlass HourGlass { get; }

      #endregion

      #region Construct

      public Resources()
      {
        HourGlass = new HourGlass();
      }

      #endregion

      #region Methods

      /// <summary>
      /// - Create a rigidly defined Matrix that can be used
      ///   to test the HourGlass Algorithm...
      /// </summary>
      /// <returns>
      /// - Matrix for HourGlass computations
      /// </returns>
      public int[][] CreateMatrix()
      {
        int depth = 6;
        int[][] matrix = new int[depth][];

        for (int indexRow = 0; indexRow < depth; indexRow++)
        {
          matrix[indexRow] = new int[depth];

          for (int indexCol = 0; indexCol < depth; indexCol++)
          {
            matrix[indexRow][indexCol] = indexCol + 1;
          }
        }

        return matrix;
      }

      public int[][] CreateMatrixSkewed(int depthRow, int depthCol)
      {
        int[][] matrix = new int[depthRow][];

        for (int indexRow = 0; indexRow < depthRow; indexRow++)
        {
          matrix[indexRow] = new int[depthCol];

          for (int indexCol = 0; indexCol < depthCol; indexCol++)
          {
            matrix[indexRow][indexCol] = indexCol;
          }
        }

        return matrix;
      }

      #endregion
    }

    [TestMethod]
    public void GenerateMatrix()
    {
      // - Setup 
      var resources = new Resources();

      // - Given
      int depth = 6;

      // - When
      var matrix = resources.HourGlass.GenerateMatrix(depth);

      // - Then
      Assert.IsNotNull(matrix);
      Assert.AreEqual(depth,matrix.Length);

      for (int indexRow = 0; indexRow < depth; indexRow++)
      {
        Assert.AreEqual(depth,matrix[indexRow].Length);
      }
    }

    [TestMethod]
    public void GenerateMatrix_InvalidDepth()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      int depth = 8;

      // - When
      var matrix = resources.HourGlass.GenerateMatrix(depth);

      // - Then
      Assert.IsNotNull(matrix);
      Assert.AreEqual(0,matrix.Length);
    }

    [TestMethod]
    public void SumMaxHourGlass()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      int[][] matrix = resources.CreateMatrix();

      // - When
      var sumMaxHourGlass = resources.HourGlass.SumMaxHourGlass(matrix);

      // - Then
      Assert.AreEqual(35,sumMaxHourGlass);
    }

    [TestMethod]
    public void SumMaxHourGlass_EmptyMatrix()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      var matrix = new int[0][];

      // - When
      var result = resources.HourGlass.SumMaxHourGlass(matrix);

      // - Then
      Assert.AreEqual(0,result);
    }

    [TestMethod]
    public void SumMaxHourGlass_SkewedMatrix()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      var matrixShortRow = resources.CreateMatrixSkewed(2, 6);
      var matrixShortCol = resources.CreateMatrixSkewed(6, 2);
      var matrixLopSidedRow = resources.CreateMatrixSkewed(8, 9);
      var matrixLopSidedCol = resources.CreateMatrixSkewed(9, 8);
      var matrixSkew = resources.CreateMatrixSkewed(3,6);
      
      // - When
      var resultShortRow = resources.HourGlass.SumMaxHourGlass(matrixShortRow);
      var resultShortCol = resources.HourGlass.SumMaxHourGlass(matrixShortCol);
      var resultLopSidedRow = resources.HourGlass.SumMaxHourGlass(matrixLopSidedRow);
      var resultLopSidedCol = resources.HourGlass.SumMaxHourGlass(matrixLopSidedCol);
      var resultSkew = resources.HourGlass.SumMaxHourGlass(matrixSkew);

      // - Then
      Assert.AreEqual(0,resultShortRow);
      Assert.AreEqual(0,resultShortCol);
      Assert.AreEqual(0,resultLopSidedRow);
      Assert.AreEqual(0,resultLopSidedCol);
      Assert.AreEqual(0,resultSkew);
    }

  }
}
