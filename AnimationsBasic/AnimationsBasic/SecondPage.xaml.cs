using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimationsBasic
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		}
        private bool ShowDetails = false;
        private async void Animate_Clicked(object sender, EventArgs e)
        {
            var boxToShow = ShowDetails ? card : details;
            var boxToHide = ShowDetails ? details: card;

            if(boxToHide.AnimationIsRunning("RotateYTo"))return;

            boxToShow.HasShadow = false;
            boxToHide.HasShadow = false;

            await boxToHide.RotateYTo(90,125);
            boxToHide.IsVisible = false;

            boxToShow.RotationY = -90;
            boxToShow.IsVisible = true;
            
            await boxToShow.RotateYTo(0,125);

            boxToShow.HasShadow = true;
            boxToHide.HasShadow = true;

            ShowDetails =!ShowDetails;
        }
    }
}