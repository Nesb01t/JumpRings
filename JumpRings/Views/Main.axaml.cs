using Avalonia.Controls;
using Avalonia.Interactivity;

namespace JumpRings.Views;

public partial class Main : Window
{
    public Main()
    {
        InitializeWindow();
        InitializeComponent();
    }

    private void InitializeWindow()
    {
        Width = 800;
        Height = 600;
        MinWidth = 800;
        MinHeight = 600;
        MaxWidth = 800;
        MaxHeight = 600;
        CanResize = false;
    }

    public void ButtonLog_Click(object sender, RoutedEventArgs e)
    {
        LogTextBox.Text += "Button 1 clicked\n";
    }
}