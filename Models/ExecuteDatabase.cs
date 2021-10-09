using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EF_C_
{
    public class ExecuteDatabase
    {
        public static async Task CreateDatabase()
        {
            using(var dbcontext = new School_DbContext())
            {
                string DbName = dbcontext.Database.GetDbConnection().Database;
                Console.WriteLine($"Database: {DbName}");
                bool result = await dbcontext.Database.EnsureCreatedAsync();
                string Check = result ? $"Database {DbName} created": $"Database {DbName} already exist";
                Console.WriteLine($"{Check}");  
            }
        }
        public static async Task DropDatabase()
        {
            using(var dbcontext = new School_DbContext())
            {

                string DbName = dbcontext.Database.GetDbConnection().Database;
                bool result = await dbcontext.Database.EnsureDeletedAsync();
                if(result)
                    Console.WriteLine($"{DbName} deleted!");
                else
                    System.Console.WriteLine($"{DbName} already exist");
            }
        }
   
        //add list students => database
        public static void AddListStudents()
        {

        }
    }
}