using MVCUnitTest.Controllers;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController home = new HomeController();
            string result = home.GetEmployeeName(1);
            Assert.Equal("Jignesh", result);
        }

        [Fact]
        public void Test2()
        {
            HomeController home = new HomeController();
            string result = home.GetEmployeeName(1);
            Assert.Equal("Rakesh", result);
        }
    }
}
