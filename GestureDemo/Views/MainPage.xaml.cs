using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureDemo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnTap.Clicked += async(sender, e) => {
                await Navigation.PushAsync(new TapDemo());
            };
            btnPinch.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
            btnPan.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PanDemo());
            };
            btnSwipe.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SwipeDemo());
            };
        }
    }
}
