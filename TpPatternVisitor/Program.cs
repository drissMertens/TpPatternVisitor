﻿namespace TpPatternVisitor
{
    class Program
    {
        static void Main(string[] args)
        {

            Employees e = new Employees();
            e.Attach(new LineCook());
            e.Attach(new HeadChef());
            e.Attach(new GeneralManager());


            e.Accept(new IncomeVisitor());
            e.Accept(new PaidTimeOffVisitor());

            Console.ReadKey();
        }
    }
}