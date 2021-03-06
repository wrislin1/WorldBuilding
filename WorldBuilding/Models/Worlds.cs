﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using WorldBuilding;

namespace WorldBuilding
{
    public class Worlds
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [OneToMany]
        public List<Characters> Population { get; set; }

        [OneToMany]
        public List<Lore> History { get; set; }

        [OneToMany]
        public List<Locations> Regions { get; set; }

    }
}
