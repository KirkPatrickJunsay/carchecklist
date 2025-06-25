using CarCheckList.ViewModels;
using CarCheckList.ViewModels.Base;

namespace CarCheckList.Views;

public partial class CarInfoPage : BaseContentPage
{
	public CarInfoPage(CarInfoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}