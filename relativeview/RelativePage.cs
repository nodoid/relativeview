using Xamarin.Forms;

namespace relativeview
{
    public class RelativePage : ContentPage
    {
        public RelativePage()
        {
            CreateUI();
        }

        void CreateUI()
        {
            // create the image

            var bgImage = new Image
            {
                Source = "gradient.png",
                Aspect = Aspect.AspectFill
            };


            // let's create something on top of it
            var testStack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(8, 8),
                Children =
                {
                    new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                        {
                            new Label {Text = "Hello world"},
                            new Button {Text = "Click me", Command = new Command(async ()=> await DisplayAlert("Hello", "You clicked me!", "OK")) }
                        }
                    }
                }
            };

            // we need to create the relative view
            var relLayout = new RelativeLayout();

            // add the image first (furthest back in the view stack)
            relLayout.Children.Add(bgImage,
                                   Constraint.Constant(0), // x
                                   Constraint.Constant(0), // y
                                   Constraint.RelativeToParent((parent) => App.ScreenSize.Width), // width relative to parent size - in this case, the same
                                   Constraint.RelativeToParent((parent) => App.ScreenSize.Height)); // height relative to parent size - in this case, the same

            // add the next layer forward
            relLayout.Children.Add(testStack,
                                  Constraint.Constant(0), // x
                                   Constraint.Constant(0), // y
                                   Constraint.RelativeToParent((parent) => App.ScreenSize.Width), // width relative to parent size - in this case, the same
                                   Constraint.RelativeToParent((parent) => App.ScreenSize.Height)); // height relative to parent size - in this case, the same

            // add to the page
            Content = relLayout;
        }
    }
}

