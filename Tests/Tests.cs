using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        // Method 1
        [Theory]
        [InlineData(12, 4, 2)]
        [InlineData(600, 288, 12)]
        [InlineData(874, 256, 181)]
        public void CalcRectPerimeter_Test(int expected, int input1, int input2)
        {
            GroupTwoFunctions GTF = new GroupTwoFunctions();
            Assert.Equal(expected, GTF.CalcRectPerimeter(input1, input2));
        
        }

        // Method 2
        [Theory]
        [InlineData(true, 3)]
        [InlineData(true, 15)]
        [InlineData(false, 14)]
        [InlineData(false, 37)]
        public void IsTriangularNum_Test(bool expected, int input)
        {
            GroupTwoFunctions GTF = new GroupTwoFunctions();
            Assert.Equal(expected, GTF.IsTriangularNum(input));
        }

        //Method 3
        [Theory]
        [InlineData(0, 32)]
        [InlineData(38, 100)]
        [InlineData(100, 212)]
        [InlineData(10, 50)]
        public void FarenheitToCelsius_Test(int expected, int input)
        {
            GroupTwoFunctions GTF = new GroupTwoFunctions();
            Assert.Equals(expected, GTF.FarenheitToCelsius(input));
        }

        //Method 4
        [Theory]
        [InlineData(true, " hello")]
        [InlineData(true, "yes ")]
        [InlineData(false, "no")]
        [InlineData(false, "today")]
        public void CheckWhiteSpace_Test(bool expected, string input)
        {
            GroupTwoFunctions GTF = new GroupTwoFunctions();
            Assert.Equals(expected, GTF.CheckWhiteSpace(input));
        }

        //Method 5
        [Theory]
        [InlineData("ThIs", "This")]
        [InlineData("HeLlO", "HELLO")]
        [InlineData("ToDaY", "today")]
        [InlineData("MoRnInG", "mOrNiNg")]
        public void CamelString_Test(string expected, string input)
        {
            GroupTwoFunctions GTF = new GroupTwoFunctions();
            Assert.Equals(expected, GTF.CamelString(input));
        }

        //Method 6
        [Theory]
        [InlineData(5, "Hello")]
        [InlineData(4, "ThIs")]
        [InlineData(8, "Today345")]
        [InlineData(9, "MOR02NING")]
        public void CountDigits_Test(int expected, string input)
        {
            GroupTwoFunctions GTF = new GroupTwoFunctions();
            Assert.Equals(expected, GTF.CountDigits(input));
        }
    }
}
