using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine($"Reading data from list database");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine($"Printing data from list database");
        }
    }
}
