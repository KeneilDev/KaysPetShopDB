using KaysPets.Data;
using KaysPets.Models;
using System;

namespace KaysPets
{
    class Program
    {
        static void Main(string[] args)
        {
            KysPetsContext context = new KysPetsContext();

            Product squeakyBone = new Product()
            {
                Name = "Squeaky Dog Bone",
                Price = 4.99M
            };

            context.Products.Add(squeakyBone);

            Product tennisBalls = new Product()
            {
                Name = "Tennis Balls 4 Pack",
                Price = 5.99M
            };

            context.Products.Add(tennisBalls);

            context.SaveChanges();
        }
    }
}
