using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace TestAlgolia.Model
{
    public class ProductInitializer
    {
        private static Random random = new Random();

        public  List<Product> GetProducts()
        {
            var products = new List<Product>();
            for(int i=0;i<random.Next(100,1000); i++)
            {
                Product pr = new Product();
                pr.Name = RandomString(random.Next(5,10));
                pr.Prise = random.Next(100, 250).ToString() + "$";
                products.Add(pr);
            }
            

            return products;
        }
        private string RandomString(int Size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

    }
}