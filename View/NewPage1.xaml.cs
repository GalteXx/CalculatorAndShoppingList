using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new ShoppingListViewModel();
	}
}