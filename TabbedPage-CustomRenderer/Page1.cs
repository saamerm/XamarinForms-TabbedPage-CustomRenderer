using Xamarin.Forms;

using System;
namespace TabbedPageCustomRenderer
{
	public class Page1 : ContentPage
	{
		public Page1()
		{
			Title = "Page 1";
			Icon = "clock.png";
			var label = new Label { Text = "Page 1" };

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
