namespace Csharp.SingletonAndStaticConstructor
{
    public class Database
    {
        Database()
        {
        }

        static Database _database;
        static public Database GetDatabase { 
            get {
                return _database;
            }
        }

        // Static constructor run only one time first initial.
        static Database(){
            Console.Write("Database has been created !");
            _database = new Database();
        }
    }
}