// - Required Assemblies
using System;
using System.Text;

// - Application Assemblies

namespace Prometheace
{
  public class RotatingArray
  {
    #region PublicMethods

    internal string ArrayToString(int[] arrayRotating)
    {
      var stringBuilder = new StringBuilder();

      foreach (var item in arrayRotating)
      {
        stringBuilder.Append(item.ToString());
        stringBuilder.Append(", ");
      }

      return stringBuilder.ToString();
    }

    /// <summary>
    /// <para>
    /// - Left rotation operation on an array shifts each of the array's
    ///   elements 1 unit to the left.
    /// - The Array can be rotated any number of times which will march
    ///   the digits of the array to the left over and over...
    /// </para>
    /// </summary>
    /// <param name="arrayToSpin"></param>
    /// <param name="timesToSpin"></param>
    /// <returns>
    /// The array after the last rotation.
    /// </returns>
    public int[] RotateArrayLeft(int[] arrayToSpin, int timesToSpin)
    {
      int[] arraySpun = new int[arrayToSpin.Length];
      arrayToSpin.CopyTo(arraySpun,0);

      for (var indexSpin = 1; indexSpin <= timesToSpin; indexSpin++)
      {
        int holdHead = -1;

        for (var indexLeft = 0; indexLeft < arraySpun.Length; indexLeft++)
        {
          // - Grab the Head and hold it...
          if (indexLeft == 0)  // 
          {
            holdHead = arraySpun[indexLeft];
          }

          // - Shove the head into the tail
          if (indexLeft == arraySpun.Length - 1)
          {
            arraySpun[indexLeft] = holdHead;
          }
          else
          {
            arraySpun[indexLeft] = arraySpun[indexLeft + 1];
          }
        }
      }

      return arraySpun;
    }

    /// <summary>
    /// <para>
    /// - Right rotation operation on an array shifts each of the array's
    ///   elements 1 unit to the right.
    /// - The Array can be rotated any number of times which will march
    ///   the digits of the array to the right over and over...
    /// </para>
    /// </summary>
    /// <param name="arrayToSpin"></param>
    /// <param name="timesToSpin"></param>
    /// <returns>
    /// The array after the last rotation.
    /// </returns>
    public int[] RotateArrayRight(int[] arrayToSpin, int timesToSpin)
    {
      int[] arraySpun = new int[arrayToSpin.Length];
      arrayToSpin.CopyTo(arraySpun,0);

      for (var indexSpin = 1; indexSpin <= timesToSpin; indexSpin++)
      {
        int holdTail = -1;

        for (var indexRight = arraySpun.Length - 1; indexRight >= 0; indexRight--)
        {
          // - Grab the Head and hold it...
          if (indexRight == arraySpun.Length - 1)
          {
            holdTail = arraySpun[indexRight];
          }

          // - Shove the tail into the head
          if (indexRight == 0)
          {
            arraySpun[indexRight] = holdTail;
          }
          else
          {
            arraySpun[indexRight] = arraySpun[indexRight - 1];
          }
        }
      }

      return arraySpun;
    }

    #endregion

    #region PrivateMethods

    #endregion
  }
}