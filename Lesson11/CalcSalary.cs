namespace OOP_6_2
{
    internal class CalcSalary
    {
        public decimal ClearSalary { get; set; }
        public delegate decimal MyDelegate(decimal salary, byte isPrivilege);
        public CalcSalary(decimal salary, byte isPrivilege)
        {
            ClearSalary = salary;
            MyDelegate myDelegate = new MyDelegate(Percent);
            myDelegate += KensaToshak;
            myDelegate += Droshmanish;
            myDelegate(salary, isPrivilege);
        }
        public decimal Percent(decimal salary, byte isPrivilege)
        {
            if (isPrivilege == 1)
            {
                ClearSalary -= salary * 0.1m;
            }
            else
            {
                ClearSalary -= salary * 0.2m;
            }
            return ClearSalary;
        }
        public decimal KensaToshak(decimal salary, byte isPrivilege)
        {
            if (salary <= 500000)
            {
                ClearSalary -= salary * 0.05m;
            }
            else if (salary > 500000 && salary <= 1125000)
            {
                ClearSalary -= 25000;
            }
            else
            {
                ClearSalary -= 87500;
            }
            return ClearSalary;
        }
        public decimal Droshmanish(decimal salary, byte isPrivilege)
        {
            if (salary <= 100000)
            {
                ClearSalary -= 1500;
            }
            else if (salary > 100000 && salary < 200000)
            {
                ClearSalary -= 3000;
            }
            else if (salary > 200000 && salary <= 500000)
            {
                ClearSalary -= 5500;
            }
            else if (salary > 500000 && salary <= 1000000)
            {
                ClearSalary -= 8500;
            }
            else
            {
                ClearSalary -= 15000;
            }
            return ClearSalary;
        }
        public decimal ReturnInfo()
        {
            return ClearSalary;
        }
    }
}
