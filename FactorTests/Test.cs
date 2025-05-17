using Xunit;
using FactorLogic;
using System.Collections.Generic;

namespace FactorTests
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var expectedFactors = new List<int> { 2, 2, 7 };
            var actualFactors = Factorizer.Factor(28);
            Assert.Equal(expectedFactors, actualFactors);
        }
        [Fact]
        public void PrimeFactorsOf23()
        {
            var expected = new List<int> { 23 };
            var actual = Factorizer.Factor(23);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrimeFactorsOf1()
        {
            var expected = new List<int>();
            var actual = Factorizer.Factor(1);
            Assert.Equal(expected, actual);
        }
    }
}


