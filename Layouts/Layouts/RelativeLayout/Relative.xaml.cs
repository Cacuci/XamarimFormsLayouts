using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts.RelativeLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Relative : ContentPage
    {
        public Relative()
        {
            InitializeComponent();
        }

        private async void BtnExample1_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RelativeExample1(), false);
        }

        private async void BtnExample2_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RelativeExample2(), false);
        }
    }
}