﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetBuilder.Library
{
    public class ItemsSrorage
    {
        public List<Item> Items { get; set; }

        public ItemsSrorage()
        {
            Items = new List<Item>();
        }
    }
}
