using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Doctor
    {
        public string regnNo;
        public string name;
        public double feesCharged;
        public Doctor(string regnNo, string name, double feesCharged)
        {
            this.regnNo = regnNo;
            this.name = name;
            this.feesCharged = feesCharged;
        }
        public string RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Registration Number: {regnNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Fees Charged: {feesCharged}");
        }

        public static void info()
        {

            Console.Write("Registration Number: ");
            string regnNo = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Fees Charged: ");
            double feesCharged = double.Parse(Console.ReadLine());

            Doctor doctor1 = new Doctor(regnNo, name, feesCharged);

            doctor1.Display();

        }
    }
}


        


       
            


   

