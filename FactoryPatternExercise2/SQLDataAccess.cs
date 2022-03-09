using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine($"Reading data from SQL database");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine($"Printing data from SQL database");
        }
    }
}
