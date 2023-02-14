namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 15;
            double b = 25;
            double c = 35;
            //////////////  21  //////////////
            if (a > b && a > c)
            {
                Console.WriteLine("Max - "+ a);
            }
            else if(b > a && b > c)
            {
                Console.WriteLine("Max - " + b);
            }
            else
            {
                Console.WriteLine("Max - " + c);
            }
            //////////////  22  //////////////
            if (a < b && a < c)
            {
                Console.WriteLine("Min - "+ a);
            }
            else if(b < a && b < c)
            {
                Console.WriteLine("Min - " + b);
            }
            else
            {
                Console.WriteLine("Min - " + c);
            }
            //////////////  23  //////////////
            if (a == 1 || b == 1 || c == 1)
            {
                Console.WriteLine("1 - true");
            }
            else
            {
                Console.WriteLine("1 - false");
            }
            //////////////  24  //////////////
            if ((a == 2 && b == 2 && c != 2) || (a == 2 && c == 2 && b != 2) || (b == 2 && c == 2 && a != 2))
            {
                Console.WriteLine("2 - true");
            }
            else
            {
                Console.WriteLine("2 - false");
            }
            //////////////  25  //////////////
            if((a + b > c) || (a + c > b) || (b + c > a))
            {
                Console.WriteLine("y = 1");
            }
            else
            {
                Console.WriteLine("y = 2");
            }
            //////////////  26  //////////////
            if((a % 2 == 0) || (b % 2 == 0) || (c % 2 == 0))
            {
                Console.WriteLine("Couple - 1");
            }
            else
            {
                Console.WriteLine("Couple - 2");
            }
            //////////////  27  //////////////
            if(c - b == b - a)
            {
                Console.WriteLine("Tvabanakan P - true");
            }
            else
            {
                Console.WriteLine("Tvabanakan P - false");
            }
            //////////////  28  //////////////
            if(c / b == b / a)
            {
                Console.WriteLine("Yerkrachapakan P - true");
            }
            else
            {
                Console.WriteLine("Yerkrachapakan P - false");
            }
            //////////////  29, 30  //////////////
            if(a > b && a > c && b > c)
            {
                Console.WriteLine("Min to max - " + c + " " + b + " " + a);
                Console.WriteLine("Max to min - " + a + " " + b + " " + c);
            }
            else if(a > b && a > c && b < c)
            {
                Console.WriteLine("Min to max - " + b + " " + c + " " + a);
                Console.WriteLine("Max to min - " + a + " " + c + " " + b);
            }
            else if(b > a && b > c && a > c)
            {
                Console.WriteLine("Min to max - " + c + " " + a + " " + b);
                Console.WriteLine("Max to min - " + b + " " + a + " " + c);
            }
            else if(b > a && b > c && a < c)
            {
                Console.WriteLine("Min to max - " + a + " " + c + " " + b);
                Console.WriteLine("Max to min - " + b + " " + c + " " + a);
            }
            else if(c > a && c > b && b > a)
            {
                Console.WriteLine("Min to max - " + a + " " + b + " " + c);
                Console.WriteLine("Max to min - " + c + " " + b + " " + a);
            }
            else if(c > a && c > b && b < a)
            {
                Console.WriteLine("Min to max - " + b + " " + a + " " + c);
                Console.WriteLine("Max to min - " + c + " " + a + " " + b);
            }
            //////////////  31, 32  //////////////
            int a1 = 36;
            int b1 = 54;
            int c1 = 89;
            int d1 = 100;
            int[] ints1 = new int[] { a1, b1, c1, d1 };
            int max = ints1[0];
            int min = ints1[0];
            for(int i = 1; i < ints1.Length; i++)
            {
                if (ints1[i] > max)
                {
                    max = ints1[i];
                }
                if (ints1[i] < min)
                {
                    max = ints1[i];
                }
            }
            Console.WriteLine("Max - " + max);
            Console.WriteLine("Min - " + min);
            //////////////  33  //////////////
            bool one = false;
            for(int i = 0; i < ints1.Length; i++)
            {
                if (ints1[i] == 1)
                {
                    one = true;
                }
            }
            Console.WriteLine("1 - " + one);
            //////////////  34  //////////////
            if(a1 + b1 == c1 + d1)
            {
                Console.WriteLine("2 + 2 - true");
            }
            else if(a1 + c1 == b1 + d1)
            {
                Console.WriteLine("2 + 2 - true");
            }
            else if(a1 + d1 == b1 + c1)
            {
                Console.WriteLine("2 + 2 - true");
            }
            else
            {
                Console.WriteLine("2 + 2 - false");
            }
            //////////////  35  //////////////
            if(a1 == b1 + c1 + d1)
            {
                Console.WriteLine("1 + 3 - true");
            }
            else if(b1 == a1 + c1 +d1)
            {
                Console.WriteLine("1 + 3 - true");
            }
            else if(c1 == a1 + b1 + d1)
            {
                Console.WriteLine("1 + 3 - true");
            }
            else if(d1 == a1 + b1 + c1) 
            {
                Console.WriteLine("1 + 3 - true");
            }
            else
            {
                Console.WriteLine("1 + 3 - false");
            }
            //////////////  36  //////////////
            int j = 0;
            for(int i = 0; i < ints1.Length; i++)
            {
                if (ints1[i] % 2 != 0)
                {
                    j++;
                }
            }
            if(j >= 2)
            {
                Console.WriteLine("Even 2 - 1");
            }
            else
            {
                Console.WriteLine("Even 2 - 2");
            }
            //////////////  51  //////////////
            int myInt = 163;
            bool t = false;
            int har = myInt / 100;
            int tas = myInt % 100 / 10;
            int mek = myInt % 100 % 10;
            int[] myIntArray = new int[] { har, tas, mek };
            if(mek == har + tas)
            {
                t = true;
            }
            Console.WriteLine("har + tas = mek - " + t);
            //////////////  52  //////////////
            if(har == tas || har == mek || tas == mek)
            {
                t = true;
            }
            Console.WriteLine("har == tas == mek kamerov - " + t);
            //////////////  53  //////////////
            Random r = new Random();
            int k = r.Next(10, 300);
            double har1 = (double)myInt / (har + tas + mek);
            if (myInt > k)
            {
                Console.WriteLine("Haraberutyun 1 -" + har1);
            }
            else
            {
                double har2 = (double)mek / myInt;
                Console.WriteLine("Haraberutyun 2 -" + har2);
            }
            //////////////  54  //////////////
            int max1 = myIntArray[0];
            for(int i = 1; i < myIntArray.Length; i++)
            {
                if (myIntArray[i] > max1) 
                {
                    max1 = myIntArray[i];
                }
            }
            Console.WriteLine(max1);
            //////////////  55  //////////////
            int min1 = myIntArray[0];
            for(int i = 1; i < myIntArray.Length; i++)
            {
                if (myIntArray[i] < min1) 
                {
                    min1 = myIntArray[i];
                }
            }
            Console.WriteLine(min1);
            //////////////  56  //////////////
            if(mek > tas)
            {
                double har3 = (double)(har + tas + mek) / myInt;
                Console.WriteLine("har3");
                Console.WriteLine(har3);
            }
            else
            {
                Console.WriteLine(myInt);
            }
            //////////////  57  //////////////
            if(myInt > 300)
            {
                double har4 = (double)tas / mek;
                Console.WriteLine(har4);
            }
            else
            {
                double har5 = (double)har / mek;
                Console.WriteLine(har5);
            }
            //////////////  58  //////////////
            char f;
            if(tas + har < 5)
            {
                f = 'a';
            }
            else
            {
                f = 'b';
            }
            Console.WriteLine(f);
            //////////////  59,60  //////////////
            if(har > tas && har > mek && tas > mek)
            {
                Console.WriteLine(har + " " + tas + " " + mek);
                Console.WriteLine(mek + " " + tas + " " + har);
            }
            else if (har > tas && har > mek && tas < mek)
            {
                Console.WriteLine(har + " " + mek + " " + tas);
                Console.WriteLine(tas + " " + mek + " " + har);
            }
            else if (tas > har && tas > mek && har > mek)
            {
                Console.WriteLine(tas + " " + har + " " + mek);
                Console.WriteLine(mek + " " + har + " " + tas);
            }
            else if (tas > har && tas > mek && har < mek)
            {
                Console.WriteLine(tas + " " + mek + " " + har);
                Console.WriteLine(har + " " + mek + " " + tas);
            }
            else if (mek > har && mek > tas && har > tas)
            {
                Console.WriteLine(mek + " " + har + " " + tas);
                Console.WriteLine(tas + " " + har + " " + mek);
            }
            else if (mek > har && mek > tas && har < tas)
            {
                Console.WriteLine(mek + " " + tas + " " + har);
                Console.WriteLine(har + " " + tas + " " + mek);
            }
            //////////////  61  //////////////
            int myInt1 = 4689;
            int haz1 = myInt1 / 1000;
            int haru1 = myInt1 % 1000 / 100;
            int tas1 = myInt1 % 1000 % 100 / 10;
            int mek1 = myInt1 % 1000 % 100 % 10;
            int[] myIntArray1 = new int[] {haz1, haru1, tas1, mek1};
            bool t1 = false;
            if(haz1 + haru1 == tas1 + mek1)
            {
                t1 = true;
            }
            Console.WriteLine(t1);
            //////////////  62  //////////////
            double har6;
            if(myInt1 < 5000)
            {
                har6 = (double)myInt1 / (mek1 + haru1);
            }
            else
            {
                har6 = (double)myInt1 / (haz1 + tas1);
            }
            Console.WriteLine(har6);
            //////////////  63  //////////////
            byte t2 = 0;
            for(int i = 0; i < myIntArray1.Length; i++)
            {
                if (myIntArray1[i] == 1)
                {
                    t2 = 1;
                    break;
                }
            }
            Console.WriteLine(t2);
            //////////////  64  //////////////
            char y;
            if(mek1 + tas1 == 5)
            {
                y = 's';
            }
            else
            {
                y = 'd';
            }
            Console.WriteLine(y);
            //////////////  65  //////////////
            if(mek1 * tas1 == 12)
            {
                Console.WriteLine("y = 12");
            }
            else
            {
                Console.WriteLine("y = 0");
            }
            //////////////  66  //////////////
            if(haz1 == 4 || mek1 == 4)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //////////////  67  //////////////
            if(myInt1 == (haz1 + haru1 + tas1 +mek1)*(haz1 + haru1 + tas1 + mek1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //////////////  68  //////////////
            if(mek1 > tas1)
            {
                Console.WriteLine(mek1 * haru1);
            }
            else
            {
                Console.WriteLine(1);
            }
            //////////////  69  //////////////
            byte y1;
            if(haz1 + haru1 +tas1 + mek1 > 20)
            {
                y1 = 1;
            }
            else
            {
                y1 = 0;
            }
            Console.WriteLine(y1);
            //////////////  70  //////////////
            byte y2;
            if(haz1 * haru1 * tas1 * mek1 > 200)
            {
                y2 = 0;
            }
            else
            {
                y2 = 1;
            }
            Console.WriteLine(y2);

        }
    }
}