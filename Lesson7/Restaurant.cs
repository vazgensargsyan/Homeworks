using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    enum Messages
    {
        BonAppetit,
        AnInternalServerError,
        YouDoNotHaveEnoughFoodToMakeSushi,
        YouDoNotHaveEnoughFoodToMakeHotDog,
        YouDoNotHaveEnoughFoodToMakeHotBurger,
        EnterTheCorrectNumber
    }
    internal class Restaurant
    {
        const int ONESUSHIRICECOUNT = 4;
        const int ONESUSHIFISHCOUNT = 1;
        const int ONESUSHICUCUMBERCOUNT = 3;
        const int ONEHOTDOGSAUSAGECOUNT = 2;
        const int ONEHOTDOGBREADCOUNT = 1;
        const int ONEBURGERBREADCOUNT = 1;
        const int ONEBURGERMEETCOUNT = 1;
        public Restaurant()
        {
            
        }
        public Restaurant(ref int riceCount, ref int fishCount, ref int cucumberCount, ref int sausageCount, ref int meetCount, ref int breadCount)
        {
            int count = 1;
            MakeSushi(in count, ref riceCount, ref fishCount, ref cucumberCount);
            MakeHotDog(in count, ref sausageCount, ref breadCount);
            MakeBurger(in count, ref meetCount, ref breadCount);
        }
        public void MakeSushi(in int sushiCount, ref int riceCount, ref int fishCount, ref int cucumberCount)
        {
            if(riceCount - sushiCount * ONESUSHIRICECOUNT >= 0 && fishCount - sushiCount * ONESUSHIFISHCOUNT >= 0 && cucumberCount - sushiCount * ONESUSHICUCUMBERCOUNT >= 0)
            {
                riceCount -= sushiCount * ONESUSHIRICECOUNT;
                fishCount -= sushiCount * ONESUSHIFISHCOUNT;
                cucumberCount -= sushiCount * ONESUSHICUCUMBERCOUNT;
            }
            else
            {
                throw new Exception(nameof(Messages.YouDoNotHaveEnoughFoodToMakeSushi));
            }
            Console.WriteLine(Messages.BonAppetit);
        }
        public void MakeHotDog(in int hotDogCount, ref int sausageCount, ref int breadCount)
        {
            if(sausageCount - hotDogCount * ONEHOTDOGSAUSAGECOUNT >= 0 && breadCount - hotDogCount * ONEHOTDOGBREADCOUNT >= 0)
            {
                sausageCount -= hotDogCount * ONEHOTDOGSAUSAGECOUNT;
                breadCount -= hotDogCount * ONEHOTDOGBREADCOUNT;
            }
            else
            {
                throw new Exception(nameof(Messages.YouDoNotHaveEnoughFoodToMakeHotDog));
            }
            Console.WriteLine(Messages.BonAppetit);
        }
        public void MakeBurger(in int burgerCount, ref int meetCount, ref int breadCount)
        {
            if(meetCount - burgerCount * ONEBURGERMEETCOUNT >= 0 && breadCount - burgerCount * ONEHOTDOGBREADCOUNT >= 0)
            {
                meetCount -= burgerCount * ONEBURGERMEETCOUNT;
                breadCount -= burgerCount * ONEBURGERBREADCOUNT;
            }
            else
            {
                throw new Exception(nameof(Messages.YouDoNotHaveEnoughFoodToMakeHotBurger));
            }
            Console.WriteLine(Messages.BonAppetit);
        }
    }
}
