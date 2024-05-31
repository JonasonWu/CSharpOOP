
namespace Assignment3
{
    public class FibonacciSequence
    {
        List<int> fibonacci;
        /// <summary>
        /// Creates a fibonacci sequence with initial values as 1 and 1.
        /// </summary>
        public FibonacciSequence() {
            fibonacci = new();
            fibonacci.Add(0);
            fibonacci.Add(1);
            fibonacci.Add(1);
        }

        /// <summary>
        /// Returns the fibonacci number at the position indicated by parameter.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int Fibonacci(int position)
        {
            if (position < 0)
            {
                position = 0;
            }
            
            for (int i = fibonacci.Count; i <= position; i++)
            {
                fibonacci.Add(fibonacci.ElementAt(i - 1) + fibonacci.ElementAt(i - 2));
            }
            return fibonacci.ElementAt(position);

        }
    }
}
