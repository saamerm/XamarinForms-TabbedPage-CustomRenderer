using System;
using Xamarin.Forms;

namespace TabbedPageCustomRenderer
{
	public class Page2 : ContentPage
	{
		public Page2()
		{
			Title = "Page 2";
			Icon = "clock.png";

			var label = new Label { Text = "Page 2" };

			var stack = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = { label
				}
			};

			Content = stack;
		}
	}
}
