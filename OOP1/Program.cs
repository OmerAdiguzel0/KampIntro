using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.Name = "Kalem";
            product1.UnitPrice = 15;
            product1.Stock = 4;

            Product product2 = new Product
            {
                ID = 2,
                CategoryID = 2,
                Name = "Silgi",
                UnitPrice = 10,
                Stock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);



        }
    }
}