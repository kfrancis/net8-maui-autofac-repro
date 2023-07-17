using Volo.Abp.DependencyInjection;

namespace MauiApp2.Views;

public partial class ListDetailDetailPage : ContentPage, ITransientDependency
{
	public ListDetailDetailPage(ListDetailDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
