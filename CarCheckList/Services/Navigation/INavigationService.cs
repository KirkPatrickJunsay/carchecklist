using System;

namespace CarCheckList.Services.Navigation;

public interface INavigationService
{
        Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);
        Task PopAsync();
        void ClearNavigationStackAsync();
}
