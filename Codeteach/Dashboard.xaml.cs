using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Codeteach

{
    public partial class Dashboard :ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this , false);
        }

        void Handle_Clicked1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Java());
        }
        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new C__());
        }
        void Handle_Clicked3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HTML());
        }
        void Handle_Clicked4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new C_());
        }
        void Handle_Clicked5(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Python());
        }
        

    }
}
