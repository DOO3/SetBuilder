using SetBuilder.Library.Enums;
using System.Collections.Generic;

namespace SetBuilder.Library
{
    public class Item
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<Class> Classes { get; set; }
    }
}
