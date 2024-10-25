using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DataUploaderApp;

public partial class AddWindow : Window
{
    public AddWindow()
    {
        InitializeComponent();
        tblock_header.Text = "Добавить запись";
        btn_confirm.Content = "Добавить";
    }

    private void ReturnToMain(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
}