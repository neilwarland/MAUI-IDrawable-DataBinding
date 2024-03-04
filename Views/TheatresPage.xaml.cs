using myapp.Models;

namespace myapp;

public partial class TheatresPage : ContentPage
{
    public TheatresPage()
    {
        InitializeComponent();
    }

    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string theatreName = (e.CurrentSelection.FirstOrDefault() as Theatre).TheatreName;
    }
}