using System;
using Xunit;
using Library;

namespace TestLibrary
{
    public class LibraryTests
    {
        [Fact]
        public void Test1()
        {
            Assert.NotEqual(42, new Answer().GetAnswer(40,3));
        }
    }
}
