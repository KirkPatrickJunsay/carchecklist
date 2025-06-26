using CarCheckList.ViewModels;
using Mopups.Pages;

namespace CarCheckList.Views;

public partial class ChecklistPopup : PopupPage
{
	public ChecklistPopup(ChecklistPopupViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}