using FirstProjct_NETMAUI.ViewModel;

namespace FirstProjct_NETMAUI;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}

