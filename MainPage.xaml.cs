using MauiCommunityToolkit.ReproductionSample.PopupFillBug.Views;
using CommunityToolkit.Maui.Extensions;

namespace MauiCommunityToolkit.ReproductionSample.PopupFillBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenPopupBtn_Clicked(object sender, EventArgs e)
        {
            var popup = new PopupWithFillBug();
            await this.ShowPopupAsync(popup);
        }

        private async void OpenPopupWithWorkaroundBtn_Clicked(object sender, EventArgs e)
        {
            var popup = new PopupWithWorkaround();
            await this.ShowPopupAsync(popup);
        }
    }
}
