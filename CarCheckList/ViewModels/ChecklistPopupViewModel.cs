using System;
using CarCheckList.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mopups.Services;

namespace CarCheckList.ViewModels;

public partial class ChecklistPopupViewModel : ObservableObject
{
    private readonly ChecklistItem _item;

    public ChecklistPopupViewModel(ChecklistItem item)
    {
        _item = item;

        Title = item.Title;
        Description = item.Description;
        AnimationFile = $"{item.Title.ToLowerInvariant()}.json";
    }

    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private string description;

    [ObservableProperty]
    private string animationFile;

    [RelayCommand]
    private async Task Pass()
    {
        _item.IsChecked = true;
        await MopupService.Instance.PopAsync();
    }

    [RelayCommand]
    private async Task Fail()
    {
        _item.IsChecked = false;
        await MopupService.Instance.PopAsync();
    }
}
