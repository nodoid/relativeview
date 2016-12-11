using System;

using Xamarin.Forms;

namespace relativeview
{
    public class RelativePage : ContentPage
    {
        public RelativePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

