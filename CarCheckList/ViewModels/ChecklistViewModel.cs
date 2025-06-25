using System;
using System.Collections.ObjectModel;
using CarCheckList.Helpers;
using CarCheckList.Models;
using CarCheckList.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarCheckList.ViewModels;

public partial class ChecklistViewModel:ViewModelBase
{
    [ObservableProperty]
    ObservableCollection<ChecklistItem> checklistItems;

    public override Task OnAppearing()
    {
        GenerateChecklistItems();
        return Task.CompletedTask;
    }
    
    private void GenerateChecklistItems()
    {
        ChecklistItems= new ObservableCollection<ChecklistItem>
        {
            new ChecklistItem { Title = "Battery", Icon = FontAwesome.BatteryFull, Description = "Check the battery charge and terminal connections." },
            new ChecklistItem { Title = "Lights", Icon = FontAwesome.Lightbulb, Description = "Make sure headlights, brake lights, and signals work." },
            new ChecklistItem { Title = "Oil", Icon = FontAwesome.OilCan, Description = "Ensure engine oil is at proper level." },
            new ChecklistItem { Title = "Water", Icon = FontAwesome.Water, Description = "Check radiator coolant and windshield washer fluid." },
            new ChecklistItem { Title = "Brakes", Icon = FontAwesome.BrakeWarning, Description = "Test brake response and check brake fluid level." },
            new ChecklistItem { Title = "Air", Icon = FontAwesome.Lightbulb, Description = "Inspect and adjust tire pressure." },
            new ChecklistItem { Title = "Gas", Icon = FontAwesome.OilCan, Description = "Confirm fuel is enough for the trip." },
            new ChecklistItem { Title = "Engine", Icon = FontAwesome.Water, Description = "Check for leaks, noise, or warning lights." },
            new ChecklistItem { Title = "Tires", Icon = FontAwesome.OilCan, Description = "Look for wear, damage, and proper tread depth." },
            new ChecklistItem { Title = "Self", Icon = FontAwesome.Water, Description = "Ensure your documents, alertness, and PPE readiness." }
        };
    }
}
