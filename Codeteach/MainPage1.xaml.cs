using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Codeteach
{
    public partial class MainPage1 : ContentPage
    {
        public MainPage1()
        {

            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Dashboard());

        }
        void Handle_Clicked2(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new Signup());

        }
    }
}

