using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

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
  }
}
