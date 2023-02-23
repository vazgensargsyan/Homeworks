namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If your office have IT privilege press 1 else 0!!!");
            byte isPrivilege = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your DIRTY salary!!!");
            double cSalary = Double.Parse(Console.ReadLine());
            DirtyToClean(ref cSalary, isPrivilege, out double pct, out double kt, out double dr);
            Console.WriteLine("Clean Salary - " + cSalary);
            Console.WriteLine("Is Privilege - " + isPrivilege);
            Console.WriteLine("Percent - " + pct);
            Console.WriteLine("Mandatory Cumulative Pension System - " + kt);
            Console.WriteLine("Stamp Duties - " + dr);
        }
        static void DirtyToClean(ref double salary, byte isPrivilege, out double pct, out double kt, out double dr)
        {
            pct = 0;
            double tempSalary = salary;
            if(isPrivilege == 1)
            {
                salary -= tempSalary * 0.1;
                pct = tempSalary * 0.1;
            }
            else
            {
                salary -= tempSalary * 0.2;
                pct = tempSalary * 0.2;
            }
            if(tempSalary <= 500000)
            {
                salary -= tempSalary * 0.05;
                kt = tempSalary * 0.05;
            }
            else if(tempSalary > 500000 && salary <= 1125000)
            {
                salary -= 25000;
                kt = 25000;
            }
            else
            {
                salary -= 87500;
                kt = 87500;
            }

            if(tempSalary <= 100000)
            {
                salary -= 1500;
                dr = 1500;
            }
            else if(tempSalary > 100000 && salary < 200000)
            {
                salary -= 3000;
                dr = 3000;
            }
            else if(tempSalary > 200000 && salary <= 500000)
            {
                salary -= 5500;
                dr = 5500;
            }
            else if(tempSalary > 500000 && salary <= 1000000)
            {
                salary -= 8500;
                dr = 8500;
            }
            else
            {
                salary -= 15000;
                dr = 15000;
            }
        }
    }
}