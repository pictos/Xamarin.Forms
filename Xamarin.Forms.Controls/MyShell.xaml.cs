using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyShell
	{
		public MyShell()
		{
			InitializeComponent();
			Routing.RegisterRoute("page2", typeof(Page2));
			Routing.RegisterRoute("page3", typeof(Page3));
		}

		protected override void OnNavigated(ShellNavigatedEventArgs args)
		{
			base.OnNavigated(args);
		}
	}
}