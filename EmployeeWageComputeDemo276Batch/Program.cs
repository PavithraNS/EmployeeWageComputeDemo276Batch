﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputeDemo276Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            int empHrs = 0;
            int isPresent = 1;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;

            //welcome message
            Console.WriteLine("Welcome to Employee Wage Computation Problem statement");
            //UC1-EMployeeAttendence
            Random random = new Random();
            int employeeAttendence = random.Next(0, 2); //0 or 1
            if (employeeAttendence == isPresent)
            {
                Console.WriteLine("employee attendence is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee attendence is absent");
                //empHrs = 0;
            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is:{0}", empWage);
            //Console.WriteLine("Employee wage is:"+empWage);
            Console.ReadLine();
        }
    }
}
