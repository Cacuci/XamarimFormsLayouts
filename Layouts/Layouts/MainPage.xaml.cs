using Layouts.AbsoluteLayout;
using Layouts.RelativeLayout;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Layouts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/layouts/relative-layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RelativeLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Relative(), false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absolute(), false);
        }
    }
}
