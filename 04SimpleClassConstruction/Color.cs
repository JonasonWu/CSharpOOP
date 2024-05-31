namespace Assignment3
{
    public class Color
    {

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public Color(byte red, byte green, byte blue, byte? alpha = 255)
        {

        }
        public Color(byte red, byte green, byte blue, byte alpha)
        {

        }

        public double GetGrayscaleValue()
        {
            int sum = Red + Green + Blue;
            return sum / 3.0;
        }
    }
}
