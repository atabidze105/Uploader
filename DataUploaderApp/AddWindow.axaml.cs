using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DataUploaderApp;

public partial class AddWindow : Window
{
    public AddWindow()
    {
        InitializeComponent();
        tblock_header.Text = "�������� ������";
        btn_confirm.Content = "��������";
    }

    private void ReturnToMain(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
}