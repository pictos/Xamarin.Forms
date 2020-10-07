using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.Controls
{
	//[QueryProperty("Id", "Id")]
	//[QueryProperty("Di", "Di")]
	public class Page2 : ContentPage
	{
		Button lbl;
		string di;
		public long Di
		{
			get;
			set;
		}

		public Page2()
		{
			lbl = new Button() {TextColor = Color.White };
			var stack = new StackLayout();
			stack.Children.Add(lbl);
			Content = stack;

			lbl.Clicked += (_, __) =>
			 Shell.Current.GoToAsync("page3");
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
		}
	}
}
