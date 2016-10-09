using SetBuilder.Library.Enums;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace SetBuilder.Library
{
    public class Item
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public List<Class> Classes { get; set; }      
        public List<KeyValuePair<Stat, int>> Stats { get; set; }
        public int Level { get; set; }
        public string ImagePath { get; set; }

        public Image Image
        {
            get
            {
                return Bitmap.FromFile(ImagePath);
            }
        }
    }
}
