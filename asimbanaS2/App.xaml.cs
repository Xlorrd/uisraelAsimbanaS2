﻿namespace asimbanaS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.vistaLogin());
        }
    }
}