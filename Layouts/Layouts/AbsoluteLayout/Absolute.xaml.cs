using Layouts.RelativeLayout;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts.AbsoluteLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absolute : ContentPage
    {
        public Absolute()
        {
            InitializeComponent();
        }

        private async void BtnExample1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteExample1(), false);
        }

        private async void BtnExample2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteExample1(), false);
        }
    }
}