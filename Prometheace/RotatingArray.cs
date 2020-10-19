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
    ///   elements 1 digit to the left.
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
          if (indexLeft == 0) 
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
    /// - Left rotation operation on an array shifts each of the array's
    ///   elements 1 digit to the left.
    /// - The Array can be rotated any number of times which will march
    ///   the digits of the array to the left over and over...
    /// </para>
    /// </summary>
    /// <param name="arrayToSpin"></param>
    /// <param name="timesToSpin"></param>
    /// <returns>
    /// The array after the last rotation.
    /// </returns>
    public int[] RotateArrayLeftFast(int[] arrayToSpin, int timesToSpin)
    {
      int[] arraySpun = new int[arrayToSpin.Length];
      arrayToSpin.CopyTo(arraySpun, 0);

      // - Relation between the length of the array and the number of times to spin.
      // - Every number of times to spin that is equal to the length of the array
      //   the resulting array will look the same as the initial array:
      //   all digits moved to be exactly where they were...
      // - Optimisation do not do all the work to get where you already are.
      var arrayToSpinLength = arrayToSpin.Length;
      var timesToSpinRemainder = timesToSpin % arrayToSpinLength;
      
      // - Rotate the remaining times
      if(timesToSpinRemainder > 0)
      {
        for (var indexSpin = 1; indexSpin <= timesToSpinRemainder; indexSpin++)
        {
          int holdHead = -1;

          for (var indexLeft = 0; indexLeft < arraySpun.Length; indexLeft++)
          {
            // - Grab the Head and hold it...
            if (indexLeft == 0)
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
      }

      return arraySpun;
    }

    /// <summary>
    /// <para>
    /// - Left rotation operation on an array shifts each of the array's
    ///   elements 1 digit to the left.
    /// - The Array can be rotated any number of times which will march
    ///   the digits of the array to the left over and over...
    /// </para>
    /// </summary>
    /// <param name="arrayToSpin"></param>
    /// <param name="timesToSpin"></param>
    /// <returns>
    /// The array after the last rotation.
    /// </returns>
    public int[] RotateArrayLeftRapid(int[] arrayToSpin, int timesToSpin)
    {
      int[] arraySpun = new int[arrayToSpin.Length];
      arrayToSpin.CopyTo(arraySpun, 0);

      // - Relation between the length of the array and the number of times to spin.
      // - Every number of times to spin that is equal to the length of the array
      //   the resulting array will look the same as the initial array:
      //   all digits moved to be exactly where they were...
      // - Optimisation do not do all the work to get where you already are.
      var timesToSpinRemainder = timesToSpin % arrayToSpin.Length;

      // - Rotate the remaining times
      if (timesToSpinRemainder > 0)
      {
        int jump;

        for (var indexSpin = 0; indexSpin < arrayToSpin.Length; indexSpin++)
        {
          if (indexSpin >= timesToSpinRemainder)
          {
            jump = indexSpin - timesToSpinRemainder;
          }
          else
          {
            jump = (arrayToSpin.Length - timesToSpinRemainder) + indexSpin;
          }

          arraySpun[jump] = arrayToSpin[indexSpin];
        }
      }

      return arraySpun;
    }

    /// <summary>
    /// <para>
    /// - Right rotation operation on an array shifts each of the array's
    ///   elements 1 digit to the right.
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