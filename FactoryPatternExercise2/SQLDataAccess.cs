using System;
using System.Diagnostics;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }


        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name ="Xbox", Price = 350},
            new Product (){Name ="Guitar", Price = 900},
            new Product (){Name ="Playstation", Price = 500},
            new Product (){Name ="skateboard", Price = 45},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL database");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL database");
        }

        void IDataAccess.LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
