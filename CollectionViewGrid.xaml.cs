using CollectionViewImages.Models;
using CollectionViewImages.ViewModels;

namespace CollectionViewImages
{
    public partial class CollectionViewGrid : ContentPage
    {      
        public CollectionViewGrid(List<ImageGroup> images)
        {
            InitializeComponent();

            BindingContext = new GroupedImagesViewModel(images);
        }

    }
}