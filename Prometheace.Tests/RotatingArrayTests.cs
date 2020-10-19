// - Required Assemblies
using Microsoft.VisualStudio.TestTools.UnitTesting;

// - Application Assemblies

namespace Prometheace.Tests
{
  [TestClass]
  public class RotatingArrayTests
  {
    public class Resources
    {
      #region Properties

      public RotatingArray RotatingArray { get; private set; }

      #endregion

      #region Construct

      public Resources()
      {
        RotatingArray = new Prometheace.RotatingArray();
      }

      #endregion
    }

    [TestMethod]
    public void RotateArrayLeftFast()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      int[] arrayToSpin = new int[] { 1, 2, 3, 4, 5 };
      int timesToSpin4 = 4;
      int timesToSpin5 = 5;
      int timesToSpin18 = 18;
      int timesToSpin20 = 20;

      // - When
      var arraySpunLeftFast4 = resources.RotatingArray.RotateArrayLeftFast(arrayToSpin, timesToSpin4);
      var arraySpunLeftFast5 = resources.RotatingArray.RotateArrayLeftFast(arrayToSpin, timesToSpin5);
      var arraySpunLeftFast18 = resources.RotatingArray.RotateArrayLeftFast(arrayToSpin, timesToSpin18);
      var arraySpunLeftFast20 = resources.RotatingArray.RotateArrayLeftFast(arrayToSpin, timesToSpin20);

      // - Then
      Assert.AreEqual(5, arraySpunLeftFast4[0]);
      Assert.AreEqual(1, arraySpunLeftFast4[1]);
      Assert.AreEqual(2, arraySpunLeftFast4[2]);
      Assert.AreEqual(3, arraySpunLeftFast4[3]);
      Assert.AreEqual(4, arraySpunLeftFast4[4]);

      Assert.AreEqual(1, arraySpunLeftFast5[0]);
      Assert.AreEqual(2, arraySpunLeftFast5[1]);
      Assert.AreEqual(3, arraySpunLeftFast5[2]);
      Assert.AreEqual(4, arraySpunLeftFast5[3]);
      Assert.AreEqual(5, arraySpunLeftFast5[4]);

      Assert.AreEqual(4, arraySpunLeftFast18[0]);
      Assert.AreEqual(5, arraySpunLeftFast18[1]);
      Assert.AreEqual(1, arraySpunLeftFast18[2]);
      Assert.AreEqual(2, arraySpunLeftFast18[3]);
      Assert.AreEqual(3, arraySpunLeftFast18[4]);

      Assert.AreEqual(1, arraySpunLeftFast20[0]);
      Assert.AreEqual(2, arraySpunLeftFast20[1]);
      Assert.AreEqual(3, arraySpunLeftFast20[2]);
      Assert.AreEqual(4, arraySpunLeftFast20[3]);
      Assert.AreEqual(5, arraySpunLeftFast20[4]);
    }

    //---
    [TestMethod]
    public void RotateArrayLeftRapid()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      int[] arrayToSpin = new int[] { 1, 2, 3, 4, 5 };
      int timesToSpin1 = 1;
      int timesToSpin2 = 2;
      int timesToSpin3 = 3;
      int timesToSpin4 = 4;
      int timesToSpin5 = 5;
      int timesToSpin18 = 18;
      int timesToSpin20 = 20;

      // - When
      var arraySpunLeftRapid1 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin1);
      var arraySpunLeftRapid2 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin2);
      var arraySpunLeftRapid3 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin3);
      var arraySpunLeftRapid4 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin4);
      var arraySpunLeftRapid5 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin5);
      var arraySpunLeftRapid18 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin18);
      var arraySpunLeftRapid20 = resources.RotatingArray.RotateArrayLeftRapid(arrayToSpin, timesToSpin20);

      // - Then
      Assert.AreEqual(2, arraySpunLeftRapid1[0]);
      Assert.AreEqual(3, arraySpunLeftRapid1[1]);
      Assert.AreEqual(4, arraySpunLeftRapid1[2]);
      Assert.AreEqual(5, arraySpunLeftRapid1[3]);
      Assert.AreEqual(1, arraySpunLeftRapid1[4]);

      Assert.AreEqual(3, arraySpunLeftRapid2[0]);
      Assert.AreEqual(4, arraySpunLeftRapid2[1]);
      Assert.AreEqual(5, arraySpunLeftRapid2[2]);
      Assert.AreEqual(1, arraySpunLeftRapid2[3]);
      Assert.AreEqual(2, arraySpunLeftRapid2[4]);

      Assert.AreEqual(4, arraySpunLeftRapid3[0]);
      Assert.AreEqual(5, arraySpunLeftRapid3[1]);
      Assert.AreEqual(1, arraySpunLeftRapid3[2]);
      Assert.AreEqual(2, arraySpunLeftRapid3[3]);
      Assert.AreEqual(3, arraySpunLeftRapid3[4]);

      Assert.AreEqual(5, arraySpunLeftRapid4[0]);
      Assert.AreEqual(1, arraySpunLeftRapid4[1]);
      Assert.AreEqual(2, arraySpunLeftRapid4[2]);
      Assert.AreEqual(3, arraySpunLeftRapid4[3]);
      Assert.AreEqual(4, arraySpunLeftRapid4[4]);

      Assert.AreEqual(1, arraySpunLeftRapid5[0]);
      Assert.AreEqual(2, arraySpunLeftRapid5[1]);
      Assert.AreEqual(3, arraySpunLeftRapid5[2]);
      Assert.AreEqual(4, arraySpunLeftRapid5[3]);
      Assert.AreEqual(5, arraySpunLeftRapid5[4]);

      Assert.AreEqual(4, arraySpunLeftRapid18[0]);
      Assert.AreEqual(5, arraySpunLeftRapid18[1]);
      Assert.AreEqual(1, arraySpunLeftRapid18[2]);
      Assert.AreEqual(2, arraySpunLeftRapid18[3]);
      Assert.AreEqual(3, arraySpunLeftRapid18[4]);

      Assert.AreEqual(1, arraySpunLeftRapid20[0]);
      Assert.AreEqual(2, arraySpunLeftRapid20[1]);
      Assert.AreEqual(3, arraySpunLeftRapid20[2]);
      Assert.AreEqual(4, arraySpunLeftRapid20[3]);
      Assert.AreEqual(5, arraySpunLeftRapid20[4]);
    }
  }
}
