namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int riceCount = 40;             
            int fishCount = 10;    
            int cucumberCount = 50;
            int meetCount = 20;    
            int sausageCount = 30; 
            int breadCount = 100;
            Console.WriteLine("1. If you want make SUSHI press 1");
            Console.WriteLine("2. If you want make HOTDOG press 2");
            Console.WriteLine("3. If you want make BURGER press 3");
            Console.WriteLine("3. If you want make one SUSHI and one HOTDOG and one BURGER press 4");
            Console.Write("Write number and press enter - ");
            try
            {
                byte whatMake = Byte.Parse(Console.ReadLine());
                Restaurant restaurant = new Restaurant();
                switch (whatMake)
                {
                    case 1:
                        Console.Write("Enter sushi`s count - ");
                        int sushiCount = Int32.Parse(Console.ReadLine());
                        restaurant.MakeSushi(in sushiCount, ref riceCount, ref fishCount, ref cucumberCount);
                        break;
                    case 2:
                        Console.Write("Enter hotdog`s count - ");
                        int hotdogCount = Int32.Parse(Console.ReadLine());
                        restaurant.MakeHotDog(in hotdogCount, ref sausageCount, ref breadCount);
                        break;
                    case 3:
                        Console.Write("Enter burger`s count - ");
                        int burgerCount = Int32.Parse(Console.ReadLine());
                        restaurant.MakeBurger(in burgerCount, ref meetCount, ref breadCount);
                        break;
                    case 4:
                        Restaurant restaurantAll = new Restaurant(ref riceCount, ref fishCount, ref cucumberCount, ref sausageCount, ref meetCount, ref breadCount);
                        break;
                    default:
                        throw new Exception(nameof(Messages.EnterTheCorrectNumber));
                        break;
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Rice - " + riceCount + " Fish - " + fishCount + " Cucumber - " + cucumberCount + " Meet - " + meetCount + " Sausage - " + sausageCount + " Bread - " + breadCount);
            }
        }
    }
}