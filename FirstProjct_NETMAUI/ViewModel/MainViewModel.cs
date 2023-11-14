

using System.Collections.ObjectModel;
using System.ComponentModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FirstProjct_NETMAUI.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            items = new ObservableCollection<string>();
        }

        //connectivity
        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity)
        {
            items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }


        //collecting the items
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;


            //Network Connect
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh Uh!", "No Internet", "OK");
                return;
            }

            Items.Add(Text);

            // add our item
            Text = string.Empty;

           
        }

        [RelayCommand]
        void Delete(string s) 
        {
            if(Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
       async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }
    }
}
