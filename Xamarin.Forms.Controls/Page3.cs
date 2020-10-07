using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.Controls
{
	public class Page3 : ContentPage
	{
		Button btn;
		public Page3()
		{
			var stack = new StackLayout();
			btn = new Button
			{
				Text = "Back"
			};

			btn.Clicked += (_, __) =>
				 Shell.Current.GoToAsync("..\\..");
			stack.Children.Add(btn);
			Content = stack;

		}
	}
}
