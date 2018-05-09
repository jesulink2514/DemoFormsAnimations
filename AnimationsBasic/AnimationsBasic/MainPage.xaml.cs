using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnimationsBasic
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void Animate_Clicked(object sender, EventArgs e)
        {
            await box.RelRotateTo(90);
        }
    }
}
