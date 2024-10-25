using Avalonia.Controls;

namespace DataUploaderApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenAddWindow(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
            this.Close();
        }
    }
}