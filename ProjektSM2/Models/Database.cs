using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjektSM2.Models
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<WriteModel>();
        }

        public Task<List<WriteModel>> GetWritesAsync()
        {
            return _database.Table<WriteModel>().ToListAsync();
        }
        public Task<int> SaveWriteAsync(WriteModel model)
        {
            return _database.InsertAsync(model);
        }
    }
}
