using FizzBuzz;
using Xunit;

namespace FizzBuzzTests {
    public class FizzBuzzShould {
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ReturnFizzWhenMultipleOfThree(int i) {
            var gen = new Generator();
            var result = gen.GenerateNextOutput(i);
            Assert.Equal("Fizz", result);
        }
        
        [Theory]
        [InlineData(5)]
        [InlineData(20)]
        [InlineData(35)]
        public void ReturnBuzzWhenMultipleOfFive(int i) {
            var gen = new Generator();
            var result = gen.GenerateNextOutput(i);
            Assert.Equal("Buzz", result);
        }
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void ReturnFizzBuzzWhenMultipleOfFifteen(int i) {
            var gen = new Generator();
            var result = gen.GenerateNextOutput(i);
            Assert.Equal("FizzBuzz", result);
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(19)]
        public void ReturnItselfWhenNotMultiple(int i) {
            var gen = new Generator();
            var expected = i.ToString();
            var result = gen.GenerateNextOutput(i);
            Assert.Equal(expected, result);
        }
        
    }
}