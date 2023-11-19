using CollectionViewImages.Models;
using CollectionViewImages.ViewModels;

namespace CollectionViewImages
{
    public partial class CollectionViewLinear : ContentPage
    {      
        public CollectionViewLinear(List<ImageGroup> images)
        {
            InitializeComponent();

            BindingContext = new GroupedImagesViewModel(images);
        }

    }
}