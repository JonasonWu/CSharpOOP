namespace Assignment3
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }

        public int ThrownCount { get; set; }
        public Ball(int size)
        {
            Size = size;
            Color = new Color(100, 100, 100);
            Console.WriteLine($"Ball of size {size} is created with default colors.");
        }

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            Console.WriteLine($"Ball of size {size} is created with custom colors.");
        }


        public void Pop()
        {
            Size = 0;
            Console.WriteLine($"Ball of size {Size} is popped.");
        }

        public void Throw()
        {
            if (Size > 0)
            {
                Console.WriteLine($"Ball of size {Size} is thrown.");
                ThrownCount++;
            }
            else
            {
                Console.WriteLine($"Ball of size {Size} is popped already. Cannot be thrown.");
            }

        }
    }
}
