using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool conditional = false;
            do
            {
                Console.WriteLine("Select database type: List, SQL, or Mongo");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                conditional = answer == "list" || answer == "sql" || answer == "mongo";
            } while (!conditional);
            IDataAccess database = DataAccessFactory.GetDataAccessType(answer);
            database.SaveData();
            database.LoadData();
        }
    }
}
