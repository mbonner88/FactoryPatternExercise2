using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine($"Reading data from Mongo database");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine($"Printing data from Mongo database");
        }
    }
}
