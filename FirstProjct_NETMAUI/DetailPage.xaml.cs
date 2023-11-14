using FirstProjct_NETMAUI.ViewModel;

namespace FirstProjct_NETMAUI;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}