using Volo.Abp.DependencyInjection;

namespace MauiApp2.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailDetailViewModel : BaseViewModel, ITransientDependency
{
	[ObservableProperty]
	SampleItem item;
}
