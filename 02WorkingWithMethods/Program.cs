

namespace Assignment3
{
    public class GFG
    {

        // Main method 
        static public void Main()
        {
            // Problem #1
            Console.WriteLine("Reversing Generated Array.");
            int[] nums = ReverseArray.GenerateNumbers(10);
            Console.Write("Initial Array: ");
            ReverseArray.PrintNumbers(nums);
            ReverseArray.Reverse(nums);
            Console.Write("Reversed Array: ");
            ReverseArray.PrintNumbers(nums);
            Console.WriteLine();

            // Problem #2
            Console.WriteLine("Fibonacci Sequence");
            FibonacciSequence fs = new();
            Console.WriteLine($"First Fibonacci Number: {fs.Fibonacci(1)}");
            Console.WriteLine($"Third Fibonacci Number: {fs.Fibonacci(3)}");
            Console.WriteLine($"Eighth Fibonacci Number: {fs.Fibonacci(8)}");
            Console.WriteLine();


        }
    }
}