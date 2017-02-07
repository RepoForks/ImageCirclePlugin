using ImageCircle.Forms.Plugin.Abstractions;
using System;

using Xamarin.Forms;

namespace TestAppsCircles
{
    public class App : Application
    {
        public App()
        {

            CircleImage pink = null;
            var button = new Button
            {
                Text = "Change Colors"
            };

            button.Clicked += (sender, args) =>
            {
                if (pink.BorderColor == Color.Pink)
                {
                    pink.BorderThickness = 20;
                    pink.BorderColor = Color.Maroon;
                    pink.FillColor = Color.Pink;
                }
                else
                {
                    pink.BorderThickness = 3;
                    pink.BorderColor = Color.Pink;
                    pink.FillColor = Color.Olive;
                }
            };

			CircleImage ci = new CircleImage
			{
				BorderColor = Color.Pink,
				FillColor = Color.Olive,
				BorderThickness = 3,
				HeightRequest = 150,
				WidthRequest = 150,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
			};

			Image image = new Image() { Source = "shoppingbagicon.png", WidthRequest =  ci.WidthRequest - 40, HeightRequest = ci.HeightRequest - 40, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, };

			Grid grid = new Grid() {HorizontalOptions = LayoutOptions.Center };
			grid.Children.Add(ci, 0, 1, 0, 1);
			grid.Children.Add(image, 0, 1, 0, 1);

			var stack = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Spacing = 10,
				Padding = 20,
				Children =
				{
					button,
					  (pink = new CircleImage
					  {
						BorderColor = Color.Pink,
						FillColor = Color.Olive,
						BorderThickness = 3,
						HeightRequest = 150,
						WidthRequest = 150,
						Aspect = Aspect.AspectFill,
						HorizontalOptions = LayoutOptions.Center,
                        //Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"))
                      }),
					grid,
					  new CircleImage
					  {
						BackgroundColor = Color.Red,
						BorderColor = Color.Purple,
						FillColor = Color.Transparent,
						BorderThickness = 6,
						HeightRequest = 150,
						WidthRequest = 150,
						Aspect = Aspect.AspectFill,
						HorizontalOptions = LayoutOptions.Center,
						Source = "shoppingbagicon.png"
						//Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/e/ed/Saguinus_tripartitus_-_Golden-mantled_Tamarin.jpg"))
					  },
					  new CircleImage
					  {
						BorderColor = Color.Yellow,
						FillColor = Color.Yellow,
						BorderThickness = 9,
						HeightRequest = 150,
						WidthRequest = 150,
						Aspect = Aspect.AspectFill,
						HorizontalOptions = LayoutOptions.Center,
						Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/5/53/Golden_Lion_Tamarin_Leontopithecus_rosalia.jpg"))
					  },
                }
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = stack
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
