using Avalonia.Controls;
using Avalonia.Interactivity;

namespace JumpRings.Views;

public partial class Main : Window
{
    public Main()
    {
        InitializeComponent();
        Width = 800;
        Height = 600;
        MinWidth = 800;
        MinHeight = 600;
        MaxWidth = 800;
        MaxHeight = 600;
        CanResize = false;
    }

    public void Button1_Click(object sender, RoutedEventArgs e)
    {
        LogTextBox.Text += "Button 1 clicked\n";
    }

    public void Button2_Click(object sender, RoutedEventArgs e)
    {
        LogTextBox.Text += "Button 2 clicked\n";
    }

    public void Button3_Click(object sender, RoutedEventArgs e)
    {
        LogTextBox.Text += "Button 3 clicked\n";
    }
}