

using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FirstProjct_NETMAUI.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [ICommand]
        void Add()
        {
            // add our item
            Text = string.Empty;
        }
        /*public string Text
        {
            get => text; 
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));*/
    }
}
