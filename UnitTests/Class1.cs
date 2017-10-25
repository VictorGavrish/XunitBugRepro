using System.Collections.Generic;
using Xunit;
using Moq;

namespace UnitTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            var mock = new Mock<IEnumerable<int>>();
            var obj = mock.Object;
        }
    }
}
