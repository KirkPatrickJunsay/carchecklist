using System;
using CarCheckList.Helpers;

namespace CarCheckList.Models;

public class ChecklistItem
{
    public string Title { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsChecked { get; set; } = false;

    public string Status
    {
        get
        {
            return IsChecked ? FontAwesome.CircleCheck : FontAwesome.Circle;
        }
    }
}
