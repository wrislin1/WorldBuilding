using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBuilding
{
    public class Lore
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        [ForeignKey(typeof(Worlds))]
        public int WorldID { get; set; }


    }
}
