using LearningMaui_Part7.ViewModel;

namespace LearningMaui_Part7;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		BindingContext = new MainViewModel();
		InitializeComponent();
	}

}

