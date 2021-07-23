using System;
using System.Collections.Generic;
using Entities;
namespace _17.Manual.Lambda.Delegates.Linq {
    class Program {
        static void Main(string[] args) {

            List<Products> list = new List<Products>();

            list.Add(new Products("TV", 900.00));
            list.Add(new Products("Notebook", 1200.00));
            list.Add(new Products("Tablet", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Products p in list) {
                Console.WriteLine(p);
            }
        }
    }
}
