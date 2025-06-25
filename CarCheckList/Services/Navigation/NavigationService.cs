using System;

namespace CarCheckList.Services.Navigation;

public class NavigationService : INavigationService
{
    public void ClearNavigationStackAsync()
    {
        foreach(var item in Shell.Current.Navigation.NavigationStack.ToList())
        {
            if (item == null) continue;
                
            Shell.Current.Navigation.RemovePage(item);
        }
    }

    public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        var shellNavigation = new ShellNavigationState(route);

        if (Shell.Current.CurrentState == shellNavigation)
        {
            return Task.CompletedTask;
        }

        return routeParameters != null
            ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
            : Shell.Current.GoToAsync(shellNavigation);
    }

    public Task PopAsync() =>
        Shell.Current.GoToAsync("..");
}
