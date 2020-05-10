using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App13.ViewModels;

namespace App13
{
	public partial class MainPage : ContentPage
	{
        MainPageViewModel vm;
		public MainPage()
		{
            vm = new MainPageViewModel();
			InitializeComponent();
            this.BindingContext = vm;
		}

        private async void btnPieCharts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PieChart());
        }
    }
}
