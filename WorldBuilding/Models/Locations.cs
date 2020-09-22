using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace WorldBuilding
{
    public class Locations
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<Characters> Population { get; set; }

        [ForeignKey(typeof(Worlds))]
        public int WorldID { get; set; }


    }
}
