namespace FizzBuzz {

    public class Generator {

        public string GenerateOutput(int n) {
            var output = "";
            for (var i = 1; i < n; i++) {
                output += GenerateNextOutput(i) + "\n";
            }
            output += GenerateNextOutput(n);
            return output;
        }
        
        public string GenerateNextOutput(int i) {
            if (i % 15 == 0)
                return "FizzBuzz";
            if (i % 5 == 0)
                return "Buzz";
            if (i % 3 == 0)
                return "Fizz";
            return i.ToString();
        }
    }
}