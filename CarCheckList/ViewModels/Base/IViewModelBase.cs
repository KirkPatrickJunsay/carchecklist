using System;
using CarCheckList.Services.Navigation;

namespace CarCheckList.ViewModels.Base;

 public interface IViewModelBase : IQueryAttributable
    {
        public INavigationService NavigationService { get; }
        Task InitializeAsync(object data);
        Task OnAppearing();
    }
