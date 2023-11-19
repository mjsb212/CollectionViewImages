
using CollectionViewImages.Models;
using Image = CollectionViewImages.Models.Image;

namespace CollectionViewImages
{
    public partial class MainPage : ContentPage
    {       

        public List<ImageGroup> Images { get; private set; } = new List<ImageGroup>();

        public MainPage()
        {
            InitializeComponent();

            // Randomly generate a Grouped list of Images with 100 Groups

            Random rnd = new Random();            

            for (int i = 0; i < 500; i++)
            {
                int imagesCount = rnd.Next(1, 12);

                var imageList = new List<Image>();

                for (int j = 0; j < imagesCount; j++)
                {
                    var image = new Image();
                    image.Name = $"Image{j}";
                    image.ImageUrl = Helpers.GetRandomImageUrl();
                    imageList.Add(image);

                }

                Images.Add(new ImageGroup($"ImageGroup{i}", imageList));            

            }
        }

        private async void OnGridClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CollectionViewGrid(Images));
        }
        private async void OnLinearClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CollectionViewLinear(Images));
        }
    }


    public static class Helpers
    {
        public static string GetRandomImageUrl(int width = 120, int height = 120)
        {
            return $"https://loremflickr.com/{width}/{height}/nature?random={Guid.NewGuid()}";
        }
    }
}