using CollectionViewImages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewImages.ViewModels
{
    public class GroupedImagesViewModel
    {
        public List<ImageGroup> Images { get; private set; } = new List<ImageGroup>();

        public GroupedImagesViewModel(List<ImageGroup> images) 
        {

            this.Images = images;
        
        }

    }
}
