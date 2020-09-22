using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using System.Linq;

namespace WorldBuilding
{
   public class WorldDB
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public WorldDB()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Worlds).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Worlds)).ConfigureAwait(false);
                }
                 if(!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Locations).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Locations)).ConfigureAwait(false);
                }
                 if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Characters).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Characters)).ConfigureAwait(false);
                }
                 if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Lore).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Lore)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<Worlds>> GetItemsAsync()
        {
            return Database.Table<Worlds>().ToListAsync();
        }

        public Task<List<Locations>> GetAllLocationsAsync()
        {
            return Database.Table<Locations>().ToListAsync();
        }

        public Task<List<Characters>> GetAllCharactersAsync()
        {
            return Database.Table<Characters>().ToListAsync();
        }


        public Task<Worlds> GetItemAsync(int id)
        {
            return Database.Table<Worlds>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<Locations> GetLocationAsync(int id)
        {
            return Database.Table<Locations>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<Characters> GetCharacterAsync(int id)
        {
            return Database.Table<Characters>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Worlds item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> SaveItemAsync(Locations item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> SaveItemAsync(Characters item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Worlds item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
