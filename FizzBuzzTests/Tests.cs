using FizzBuzz;
using Xunit;

namespace FizzBuzzTests {
    
    public class GenerateNextOutputShould {
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

    public class GenerateOutputShould {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "1\n2")]
        [InlineData(5, "1\n2\nFizz\n4\nBuzz")]
        [InlineData(15, "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz")]
        public void ReturnWhenInput(int n, string expected) {
            var gen = new Generator();
            var result = gen.GenerateOutput(n);
            Assert.Equal(expected, result);
        }
    }
}