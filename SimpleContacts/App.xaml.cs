﻿using MauiApp1;

namespace SimpleContacts;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		// MainPage = new AppShell();
		MainPage = new  ContactDetailsPage();
	}
}
