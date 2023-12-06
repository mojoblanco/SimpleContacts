using SimpleContacts.ViewModels;

namespace MauiApp1;

public partial class ContactDetailsPage : ContentPage
{
	public ContactDetailsPage()
	{
		InitializeComponent();

		ContactDetailsViewModel vm = new()
		{
			Id = 1,
			FirstName = "Jane",
			LastName = "Doe",
			Email = "janedoe@example.com",
			Phone = "+1234567"
		};

		BindingContext = vm;
	}
}