using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " Eklendi!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " Güncellendi!");

        }


    }
}
