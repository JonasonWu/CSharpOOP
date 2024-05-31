using System.Text;

namespace Assignment3
{
    public class ReverseArray
    {
        /// <summary>
        /// Generates an array of length determined by parameter.
        /// </summary>
        /// <param name="length"></param>
        public static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }
        /// <summary>
        /// Reverse the array in-place.
        /// </summary>
        /// <param name="numbers"></param>
        public static void Reverse(int[] numbers) {

            for (int start = 0, end = numbers.Length-1; start < numbers.Length / 2; start++, end--)
            {
                int tmp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = tmp;
            }
        }

        /// <summary>
        /// Print the array of numbers.
        /// </summary>
        /// <param name="numbers"></param>
        public static void PrintNumbers(int[] numbers)
        {
            StringBuilder sb = new();
            foreach (int i in numbers) {
                sb.Append(i).Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb.ToString());
        }
    }
}
