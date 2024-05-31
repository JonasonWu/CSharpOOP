namespace Assignment3
{
    public class Program
    {

        static void Main(string[] args)
        {
            Color AlternativeBallColor = new Color(200, 200, 200);

            Console.WriteLine("Creating a few Balls...");

            List<Ball> ballList = new() {
                new Ball(10),
                new Ball(20),
                new Ball(30, AlternativeBallColor)
            };
            ballList[0].Throw();
            ballList[0].Throw();
            ballList[1].Throw();
            ballList[1].Throw();
            ballList[0].Pop();
            ballList[0].Throw();
            ballList[1].Throw();

            Console.WriteLine("Game has ended");
            foreach (Ball b in ballList)
            {
                Console.WriteLine($"Ball of size {b.Size} has been thrown {b.ThrownCount} times.");
            }


        }
    }
}
