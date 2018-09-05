using NUnit.Framework;
using System;

namespace OverlyPositive.Tests
{
	[TestFixture]
    public class FirstTest
    {
		[Test]
		public void WorthlessTest()
		{
			bool haveRoomToImprove = true;
			Assert.IsTrue(haveRoomToImprove);
		}
    }
}
