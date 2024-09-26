namespace Darts
{
    internal class Program
    {
        public static int CalculateScore(double x, double y)
        {
            
            double distance = Math.Sqrt(x * x + y * y);

           
            if (distance > 10)
            {
                return 0;
            }
            else if (distance > 5)
            {
                return 1; 
            }
            else if (distance > 1)
            {
                return 5; 
            }
            else
            {
                return 10; 
            }
        }

        static void Main()
        {
            
            double x = 2.5;
            double y = 3.0;

            
            int score = CalculateScore(x, y);
            Console.WriteLine($"Очки: {score}");
        }
    }
}
