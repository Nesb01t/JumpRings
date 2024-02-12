using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using JumpRings.Models;

namespace JumpRings.Views;

public partial class Main : Window
{
    private ProcessConfigurator _processConfigurator = new();

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
        String val = "Connect Process... \n";
        if (_processConfigurator.Connect("Wow"))
        {
            val += "Connected to World of warcraft process! \n";
        }
        else
        {
            val += "Failed to connect to World of warcraft process! \n";
        }

        LogTextBox.Text += val;
    }
}