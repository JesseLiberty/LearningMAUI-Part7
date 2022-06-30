using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LearningMaui_Part7.ViewModel;

public class ViewModelBase : INotifyPropertyChanged
{
    protected ViewModelBase() { }

    protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
    {
        if (Equals(backingStore, value)) return false;

        backingStore = value;

        OnPropertyChanged(propertyName);

        return true;
    }



    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        var handler = PropertyChanged;
        if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

}
