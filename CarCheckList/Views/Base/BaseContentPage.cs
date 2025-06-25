using System;

namespace CarCheckList.ViewModels.Base;

public class BaseContentPage:ContentPage
{
        public BaseContentPage()
        {
            this.BackgroundColor = Color.FromArgb("#EFF2F4");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext != null &&
                BindingContext is ViewModelBase viewModel)
            {
                viewModel?.OnAppearing();
            }
        }
}
