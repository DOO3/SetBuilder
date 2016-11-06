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
        public List<MyKeyValuePair<Stat, int>> Stats { get; set; }
        public int Level { get; set; }
        public string ImagePath { get; set; }

        public Image Image
        {
            get
            {
                return ImagePath == null ? null : Bitmap.FromFile(ImagePath);
            }
        }
    }
}
