using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBuilding
{
    public class Characters
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(typeof(Worlds))]
        public int WorldID { get; set; }

        [ForeignKey(typeof(Locations))]
        public int? LocationID { get; set; }
    }
}
