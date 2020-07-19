using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemovePageReproduction.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls
{
	public partial class MyShell
	{
		public MyShell()
		{
			InitializeComponent();
			Routing.RegisterRoute("introduction", typeof(IntroductionPage));
			Routing.RegisterRoute("middlepage", typeof(MiddlePage));
			Routing.RegisterRoute("lastpage", typeof(LastPage));
		}
	}
}