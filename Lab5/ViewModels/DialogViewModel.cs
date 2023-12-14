using ReactiveUI;

namespace Lab5.ViewModels;

public sealed class DialogViewModel:ViewModelBase
{
    private string _name = "Name";
    private string _count = "Count";

    public string Count
    {
        get => _count;
        set => this.RaiseAndSetIfChanged(ref _count, value);
    }

    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }
}