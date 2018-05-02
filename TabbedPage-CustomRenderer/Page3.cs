using System;
using System.Windows.Input;
using Lottie.Forms;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace TabbedPageCustomRenderer
{
	public class Page3 : ContentPage
	{
		AnimationView animationView = new AnimationView()
		{
			Animation = "motorcycle.json",
			Loop = false,
			AutoPlay = false,
			VerticalOptions = LayoutOptions.FillAndExpand,
			HorizontalOptions = LayoutOptions.FillAndExpand
		};

		public Page3()
		{
			Title = "Page 3";
			Icon = "clock.png";

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Margin = new Thickness(5, 0)
			};
			var playButton = new Button()
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Text = "Play"
			};
			stack.Children.Add(playButton);
			stack.Children.Add(animationView);

			playButton.Clicked += (sender, e) => animationView.Play();

			// Not needed for Lottie
			On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
			Content = stack;
		}
	}
}
