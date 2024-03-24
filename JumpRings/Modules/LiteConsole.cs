using Avalonia.Controls;

namespace JumpRings.Modules;

public class LiteConsole
{
    private TextBox _textBox;

    public LiteConsole(TextBox textBox)
    {
        _textBox = textBox;
    }

    public void Print(string message)
    {
        _textBox.Text += message;
        _textBox.Text += "\n";
    }
}