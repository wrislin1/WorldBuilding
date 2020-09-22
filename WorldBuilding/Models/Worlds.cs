using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WorldBuilding
{
    public class Worlds
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
