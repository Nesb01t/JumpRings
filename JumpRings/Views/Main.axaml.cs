using Avalonia.Controls;
using Avalonia.Interactivity;
using JumpRings.Modules;
using JumpRings.Template;

namespace JumpRings.Views;

public partial class Main : Window
{
    public Main()
    {
        InitializeWindow();
        InitializeComponent();
        Svc.Console = new LiteConsole(LogTextBox);
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

    public void ButtonClick_Connect(object sender, RoutedEventArgs e)
    {
        Intro.Button_Connect();
    }

    public void ButtonClick_Execute(object sender, RoutedEventArgs e)
    {
        Intro.Button_Execute();
    }
}