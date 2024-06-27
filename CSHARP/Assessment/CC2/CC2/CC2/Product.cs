using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    class Products : IComparable<Products>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public int CompareTo(Products p)
        {
            if (p == null) return 1;
            return this.Price.CompareTo(p.Price);
        }



        public static void product_details()
        {
            Products[] products = new Products[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product :");
                products[i] = new Products();

                Console.Write("Product ID: ");
                products[i].ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                products[i].ProductName = Console.ReadLine();

                Console.Write("Price: ");
                products[i].Price = Convert.ToDouble(Console.ReadLine());
            }
            Array.Sort(products);

            Console.WriteLine("after sorting");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }


        }
    }
}