namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to work with?");
            Console.WriteLine("Type: SQL");
            Console.WriteLine("Type: Mongo");
            Console.WriteLine("Type: List");

            var userInput = Console.ReadLine();

            IDataAccess database = DataAccessFactory.GetDataAccessType(userInput);

            var products = database.LoadData();
            database.SaveData();

        }
    }
}
