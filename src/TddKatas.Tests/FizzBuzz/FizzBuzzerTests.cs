using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddKatas.FizzBuzz;

namespace TddKatas.Tests.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        FizzBuzzer _Sut;

        [SetUp]
        public void SetUp()
        {
            _Sut = new FizzBuzzer();
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void GetString_ReturnsNumberInStringForm_WhenNumberIsNotSpecial(int number, string expected)
        {
            var result = _Sut.GetString(number);

            result.Should().Be(expected);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GetString_ReturnsFizz_WhenNumberIsMultipleOfThree(int number)
        {
            var result = _Sut.GetString(number);
            var expected = "Fizz";

            result.Should().Be(expected);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GetString_ReturnsBuzz_WhenNumberIsMultipleOfFive(int number)
        {
            var result = _Sut.GetString(number);
            var expected = "Buzz";

            result.Should().Be(expected);
        }

        [TestCase(15)]
        public void GetString_ReturnsFizzBuzz_WhenNumberIsMultipleOfThreeAndFive(int number)
        {
            var result = _Sut.GetString(number);
            var expected = "FizzBuzz";

            result.Should().Be(expected);
        }

        [Test]
        public void ExecuteForRange_Returns100Lines_When1Through100ArePassed()
        {
            var result = _Sut.ExecuteForRange(1, 100);

            result.Should().HaveCount(100);
        }
    }
}
