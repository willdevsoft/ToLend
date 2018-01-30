using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using App_ToLend.Models;

namespace App_ToLend.Database
{
    public class TolendItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TolendItemDatabase(string dbPath) //Méthode création de l'objet database à partir de la class SQLiteAsyncConnection
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TolendItem>().Wait();
        }

        public Task<List<TolendItem>> GetItemsAsync() //La méthode GetItemAsync() renvoie une liste contenant les objets DB TodoItem 
        {
            return database.Table<TolendItem>().ToListAsync();
        }

        public Task<List<TolendItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<TolendItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<TolendItem> GetItemAsync(int id)
        {
            return database.Table<TolendItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(TolendItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(TolendItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
