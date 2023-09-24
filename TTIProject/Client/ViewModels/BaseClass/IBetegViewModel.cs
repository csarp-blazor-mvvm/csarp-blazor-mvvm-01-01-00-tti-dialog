using System.ComponentModel;

namespace TTIProject.Client.ViewModels.BaseClass
{
    public class IBetegViewModel
    {
        bool IsBusy { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
    }
}
