using Volo.Abp.DependencyInjection;

namespace MauiApp2.Views;

public partial class MainPage : ContentPage, ISingletonDependency
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
