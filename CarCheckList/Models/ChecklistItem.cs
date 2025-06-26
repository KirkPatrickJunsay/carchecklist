using System;
using CarCheckList.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarCheckList.Models;

public partial class ChecklistItem: ObservableObject
{
    [ObservableProperty]
    string title;

    [ObservableProperty]
    string icon;

    [ObservableProperty]
    string description;

    [ObservableProperty]
    bool isChecked = false;

    public string Status
    {
        get
        {
            return IsChecked ? FontAwesome.CircleCheck : FontAwesome.Circle;
        }
    }
}
