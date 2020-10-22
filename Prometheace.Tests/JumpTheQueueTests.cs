// - Required Assemblies
using Microsoft.VisualStudio.TestTools.UnitTesting;

// - Application Assemblies

namespace Prometheace.Tests
{
  [TestClass]
  public class JumpTheQueueTests
  {
    public class Resources
    {
      #region Properties

      public JumpTheQueue JumpTheQueue { get; set; }

      #endregion

      #region Construct

      public Resources()
      {
        JumpTheQueue = new JumpTheQueue();
      }

      #endregion
    }

    [TestMethod]
    public void MinimumJumps()
    {
      // - Setup
      var resources = new Resources();

      // - Given
      var queue1a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
      var queue2a = new int[] { 1, 2, 3, 5, 4, 6, 7, 8 };
      var queue3a = new int[] { 1, 2, 5, 3, 4, 6, 7, 8 };
      var queue4a = new int[] { 2, 1, 5, 3, 4, 6, 7, 8 };
      var queue5a = new int[] { 2, 1, 5, 4, 3, 6, 7, 8 }; // - 4 bribe 3 to get back to 4
      var queue6a = new int[] { 2, 1, 5, 4, 3, 6, 8, 7 };
      var queue7a = new int[] { 2, 1, 5, 4, 3, 8, 6, 7 };
      var queue8a = new int[] { 2, 1, 5, 4, 3, 8, 7, 6 }; // - 7 bribe 6 to get back to 7
      // - Divergence from Queue5
      var queue6b = new int[] { 2, 1, 5, 4, 6, 3, 7, 8 };
      var queue7b = new int[] { 2, 1, 5, 4, 6, 3, 8, 7 };
      var queue8b = new int[] { 2, 1, 5, 4, 6, 8, 3, 7 };
      var queue9b = new int[] { 2, 1, 5, 4, 6, 8, 7, 3 }; // - 7 bribe 3 to get back to 7

      // - When
      var minimumJumps1a = resources.JumpTheQueue.MinimumJumps(queue1a);
      var minimumJumps2a = resources.JumpTheQueue.MinimumJumps(queue2a);
      var minimumJumps3a = resources.JumpTheQueue.MinimumJumps(queue3a);
      var minimumJumps4a = resources.JumpTheQueue.MinimumJumps(queue4a);
      var minimumJumps5a = resources.JumpTheQueue.MinimumJumps(queue5a);
      var minimumJumps6a = resources.JumpTheQueue.MinimumJumps(queue6a);
      var minimumJumps7a = resources.JumpTheQueue.MinimumJumps(queue7a);
      var minimumJumps8a = resources.JumpTheQueue.MinimumJumps(queue8a);
      // - Divergence from Queue5
      var minimumJumps6b = resources.JumpTheQueue.MinimumJumps(queue6b);
      var minimumJumps7b = resources.JumpTheQueue.MinimumJumps(queue7b);
      var minimumJumps8b = resources.JumpTheQueue.MinimumJumps(queue8b);
      var minimumJumps9b = resources.JumpTheQueue.MinimumJumps(queue9b);

      // - Then
      Assert.AreEqual(0, minimumJumps1a);
      Assert.AreEqual(1, minimumJumps2a);
      Assert.AreEqual(2, minimumJumps3a);
      Assert.AreEqual(3, minimumJumps4a);
      Assert.AreEqual(4, minimumJumps5a);
      Assert.AreEqual(5, minimumJumps6a);
      Assert.AreEqual(6, minimumJumps7a);
      Assert.AreEqual(7, minimumJumps8a);
    }
  }
}
