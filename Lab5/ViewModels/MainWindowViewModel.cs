using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Lab5.Models;
using Lab5.Views;
using ReactiveUI;

namespace Lab5.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _greeting = "Hello, World!";
    
    private InfoModel _selectedItem;
    public InfoModel SelectedItem
    {
        get { return _selectedItem; }
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedItem, value);
            if (value != null)
            {
                var w = new DialogWindow();
                w.DataContext = new DialogViewModel
                {
                    Name = value.Name,
                    Count = value.Count

                };
                w.Show();
            }
        }
    }

    public string Greeting
    {
        get { return _greeting; }
        set { this.RaiseAndSetIfChanged(ref _greeting, value); }
    }

    /*private List<InfoModel> _infoList = new List<InfoModel>()
    {
        new InfoModel
        {
            Count = "0",
            Name = "FirstValue"
        }
    };
    public List<InfoModel> InfoList
    {
        get { return _infoList; }
        set { this.RaiseAndSetIfChanged(ref _infoList, value); }
    }*/

    public ObservableCollection<InfoModel> InfoList { get; set; } = new ObservableCollection<InfoModel>();

    public void DoSmth()
    {
        InfoList.Add(new InfoModel
        {
            Count = InfoList.Count.ToString(),
            Name = "NewValue"
        });
    }

    public async Task DoSmthAsync()
    {
        await Task.Delay(1000);
        InfoList.Add(new InfoModel
        {
            Count = InfoList.Count.ToString(),
            Name = "NewValue"
        });
    }
}