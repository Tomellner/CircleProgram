namespace CircleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Circle objects, one with a radius of 5 and the other with a radius of 6.
            Circle firstCircle = new Circle(5);
            Circle secondCircle = new Circle(6);

            // Display information about the first circle.
            Console.WriteLine("Första cirkeln med radie 5:");
            Console.WriteLine("Area: " + firstCircle.getArea());
            Console.WriteLine("Omkrets: " + firstCircle.getCircumference());
            Console.WriteLine("Volym: " + firstCircle.getVolume());
            Console.WriteLine();
            // Display information about the second circle.
            Console.WriteLine("Andra cirkeln med radie 6:");
            Console.WriteLine("Area: " + secondCircle.getArea());
            Console.WriteLine("Omkrets: " + secondCircle.getCircumference());
            Console.WriteLine("Volym: " + secondCircle.getVolume());
        }
    }
    public class Circle
    {
        // Fields to store the value of Pi and radius.
        public float _pi = 3.141f;
        public int _radius;

        // Constructor to initialize a Circle object with a given radius.
        public Circle(int radius)
        {
            _radius = radius;
        }
        // Method to calculate and return the area of the circle.
        public float getArea()
        {
            float area = _radius * _radius * _pi;
            return area;
        }
        // Method to calculate and return the circumference of the circle.
        public float getCircumference()
        {
            float circumference = _radius * 2 * _pi;
            return circumference;
        }
        // Method to calculate and return the volume of a sphere with the same radius as the circle.
        public float getVolume()
        {
            float volume = (4 * _pi * (_radius * _radius * _radius)) / 3;
            return volume;
        }
    }
}