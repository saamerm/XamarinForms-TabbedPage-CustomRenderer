﻿using System;
using BottomBar;
using BottomBar.XamarinForms;
using Xamarin.Forms;

namespace TabbedPageCustomRenderer
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var content = new BottomBarPage
			{
				Title = "TabbedPage-CustomRenderer",
				Children = { new Page1(), new Page2(), new Page3() }
			};

			MainPage = content;
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
