﻿namespace Client
{
    using System;
    using System.Collections.Generic;

    using BusinessLogic;

    using DataAccess;
    public class Program
    {
        static void Main(string[] args)
        {
            Convoy convoy;
            List<Operation> operationList;
            using (ConvoyReader convoyReader = new ConvoyReader(@"..\..\..\train1.txt"))
            {
                convoyReader.ReadFile();
                operationList = convoyReader.OperationList;
                foreach (Operation o in operationList)
                    Console.Out.WriteLine(o.Command);
                convoy = new Convoy(convoyReader.LocomotiveInfo);
            }
            Console.Out.WriteLine(convoy.Locomotive);
            Console.Out.WriteLine(convoy.WagonStack.Count);

            foreach (Operation o in operationList)
            {
                Console.Out.WriteLine(convoy.Transaction(o));
                Console.Out.WriteLine(convoy.WagonStack.Count);
            }
            Console.In.ReadLine();
        }
    }
}
