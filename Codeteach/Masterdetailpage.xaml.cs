using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Codeteach
{
    public partial class Masterdetailpage : ContentPage
    {
        public Masterdetailpage()
        {
            InitializeComponent();
        }

        void Handle_Clicked3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        void Handle_clicked4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Signup());
        }
    }
}
