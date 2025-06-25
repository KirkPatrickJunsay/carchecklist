using CarCheckList.ViewModels;
using CarCheckList.ViewModels.Base;

namespace CarCheckList.Views;

public partial class HistoryPage : BaseContentPage
{
	public HistoryPage(HistoryViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}