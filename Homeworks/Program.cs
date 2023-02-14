namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte1 = 10;
            byte myByte2 = 20;
            byte myByte3 = 30;
            int myByte = myByte1 + myByte2 + myByte3;
            float myByteFloat = myByte1 + myByte2 + myByte3;
            double myByteDouble = myByte1 + myByte2 + myByte3;
            decimal myByteDecimal = myByte1 + myByte2 + myByte3;
            Console.WriteLine(myByte);
            Console.WriteLine(myByteFloat);
            Console.WriteLine(myByteDouble);
            Console.WriteLine(myByteDecimal);

            sbyte mysByte1 = 40;
            sbyte mysByte2 = 50;
            sbyte mysByte3 = 60;
            int mysByte = mysByte1 + mysByte2 + mysByte3;
            float mysByteFloat = mysByte1 + mysByte2 + mysByte3;
            double mysByteDouble = mysByte1 + mysByte2 + mysByte3;
            decimal mysByteDecimal = mysByte1 + mysByte2 + mysByte3;
            Console.WriteLine(mysByte);
            Console.WriteLine(mysByteFloat);
            Console.WriteLine(mysByteDouble);
            Console.WriteLine(mysByteDecimal);

            short myShort1 = 70;
            short myShort2 = 80;
            short myShort3 = 90;
            int myShort = myShort1 + myShort2 + myShort3;
            float myShortFloat = myShort1 + myShort2 + myShort3;
            double myShortDouble = myShort1 + myShort2 + myShort3;
            decimal myShortDecimal = myShort1 + myShort2 + myShort3;
            Console.WriteLine(myShort);
            Console.WriteLine(myShortFloat);
            Console.WriteLine(myShortDouble);
            Console.WriteLine(myShortDecimal);

            int myInt1 = 100;
            int myInt2 = 110;
            int myInt3 = 120;
            int myInt = myInt1 + myInt2 + myInt3;
            float myIntFloat = myInt1 + myInt2 + myInt3;
            double myIntDouble = myInt1 + myInt2 + myInt3;
            decimal myIntDecimal = myInt1 + myInt2 + myInt3;
            Console.WriteLine(myInt);
            Console.WriteLine(myIntFloat);
            Console.WriteLine(myIntDouble);
            Console.WriteLine(myIntDecimal);

            long myLong1 = 130;
            long myLong2 = 140;
            long myLong3 = 150;
            long myLong = myLong1 + myLong2 + myLong3;
            float myLongFloat = myLong1 + myLong2 + myLong3;
            double myLongDouble = myLong1 + myLong2 + myLong3;
            decimal myLongDecimal = myLong1 + myLong2 + myLong3;
            Console.WriteLine(myLong);
            Console.WriteLine(myLongFloat);
            Console.WriteLine(myLongDouble);
            Console.WriteLine(myLongDecimal);

            float myFloat1 = 2.4f;
            float myFloat2 = 1.6f;
            float myFloat3 = 1.9f;
            float myFloat = myFloat1 + myFloat2 + myFloat3;
            Console.WriteLine(myFloat);

            double myDouble1 = 1.465;
            double myDouble2 = 1.6985;
            double myDouble3 = 1.98745;
            double myDouble = myDouble1 + myDouble2 + myDouble3;
            Console.WriteLine(myDouble);

            decimal myDecimal1 = 128.456m;
            decimal myDecimal2 = 1.6985m;
            decimal myDecimal3 = 1.98745m;
            decimal myDecimal = myDecimal1 + myDecimal2 + myDecimal3;
            Console.WriteLine(myDecimal);

            char myChar1 = 'a';
            char myChar2 = 'b';
            char myChar3 = 'c';
            int myChar = myChar1 + myChar2 + myChar3;
            Console.WriteLine(myChar);

            string myString1 = "aaa";
            string myString2 = "bbb";
            string myString3 = "ccc";
            string myString = myString1 + myString2 + myString3;
            Console.WriteLine(myString);

            var x = myByte1 + mysByte1 + myShort1 + myInt1 + myLong1 + myChar1 + myString1;
            Console.WriteLine(x);

            long a = 9223372036854775807;
            long b = 9223372036854775807;
            float y = a + b;
            Console.WriteLine(y);
        }
    }
}