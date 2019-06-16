using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Codeteach
{
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
