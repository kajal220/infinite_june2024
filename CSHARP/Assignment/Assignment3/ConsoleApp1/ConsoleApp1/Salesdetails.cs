using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3

{
    
public class Saledetails
    {
       
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public DateTime DateOfSale;
        public int Qty;
        public double TotalAmount;

        
        public Saledetails(int salesNo, int productNo, double price, int Qty, DateTime dateOfSale)
        {
            this.SalesNo = salesNo;
            this.ProductNo = productNo;
            this.Price = price;
            this.Qty = Qty;
            this.DateOfSale = dateOfSale;
            Sales(Qty, price);
        }
        public void Sales(int Qty, double price)
        {
            this.Qty = Qty;
            this.Price = price;
            this.TotalAmount = Qty * price;
        }
        public void ShowData()
        {
            Console.WriteLine($"Sales Number: {SalesNo}");
            Console.WriteLine($"Product Number: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Date of Sale: {DateOfSale.ToShortDateString()}");
            Console.WriteLine($"Total Amount: {TotalAmount}");
        }
        public static void details()
        {
            
            Console.WriteLine("Enter Sales Number:");
            int salesNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Number:");
            int productNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            int Qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Sale (yyyy-MM-dd):");
            DateTime dateOfSale = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

            
            Saledetails sale1 = new Saledetails(salesNo, productNo, price, Qty, dateOfSale);

            Console.WriteLine("\nInitial Sales Details:");
            sale1.ShowData();

            Console.WriteLine("\nEnter updated Quantity:");
            int updatedQty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter updated Price:");
            double updatedPrice = double.Parse(Console.ReadLine());

            sale1.Sales(updatedQty, updatedPrice);

           
            Console.WriteLine("\nUpdated Sales Details:");
            sale1.ShowData();

            
           
        }
    }

}

