using System;

namespace CarCheckList.Models;

public class ChecklistItem
{
    public string Title { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsChecked { get; set; }
}
