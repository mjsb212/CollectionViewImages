using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewImages.Models
{
    public class ImageGroup : List<Image>
    {
        public string Name { get; private set; }

        public ImageGroup(string name, List<Image> image) : base(image)
        {
            Name = name;
        }
    }

    public class Image
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
