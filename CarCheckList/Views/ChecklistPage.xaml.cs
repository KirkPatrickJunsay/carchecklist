using CarCheckList.ViewModels;
using CarCheckList.ViewModels.Base;

namespace CarCheckList.Views;

public partial class ChecklistPage : BaseContentPage
{
	public ChecklistPage(ChecklistViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}