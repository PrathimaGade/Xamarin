using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Codeteach
{
    public partial class Masterdetalipage : MasterDetailPage { 
        public Masterdetalipage()
    {
        InitializeComponent();

        Detail = new NavigationPage(new Dashboard());

        IsPresented = false;
    }

    void Handle_Clicked6(object sender, System.EventArgs e)
    {
        Detail = new NavigationPage(new My_Profile());
    }
    void Handle_Clicked7(object sender, System.EventArgs e)
    {
        Detail = new NavigationPage(new Dashboard());
    }
    void Handle_Clicked8(object sender, System.EventArgs e)
    {
        Detail = new NavigationPage(new Messages());


    }
    void Handle_Clicked9(object sender, System.EventArgs e)
    {
        Detail = new NavigationPage(new Notifications());
    }
    void Handle_Clicked10(object sender, System.EventArgs e)
    {
        Detail = new NavigationPage(new Settings());
    }
    void Handle_Clicked11(object sender, System.EventArgs e)
    {
        Detail = new NavigationPage(new Search());
    }
}
}