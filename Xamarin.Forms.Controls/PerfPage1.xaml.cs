using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls
{
	public partial class PerfPage1
	{
		public PerfPage1()
		{
			InitializeComponent();

			_performanceProvider = new PerformanceProvider();
			Xamarin.Forms.Internals.Performance.SetProvider(_performanceProvider);
		}

		int counter = 0;
		readonly PerformanceProvider _performanceProvider;

		protected override void OnAppearing()
		{
			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
			{
				lbl.Text = counter++.ToString();
				_performanceProvider.DumpStats();
				return true;
			});
		}
	}
}