using System;
using CarCheckList.Services.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarCheckList.ViewModels.Base;

public class ViewModelBase : ObservableObject, IViewModelBase
{
    public INavigationService NavigationService { get;}

    public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
    {

    }

    public virtual Task InitializeAsync(object data)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnAppearing()
    {
        return Task.CompletedTask;
    }
}
