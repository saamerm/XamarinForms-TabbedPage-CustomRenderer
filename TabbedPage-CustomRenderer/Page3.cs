using System;
using Xamarin.Forms;

namespace TabbedPageCustomRenderer
{
	public class Page3 : ContentPage
	{
		public Page3()
		{
			Title = "Page 3";
			Icon = "clock.png";

			var label = new Label { Text = "Page 3" };

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
