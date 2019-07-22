using System;
using Xunit;
using Utility;

namespace Utility.Tests
{
    public class UtilityTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Utility.Helper.Add(2, 2));
        }
    }
}
