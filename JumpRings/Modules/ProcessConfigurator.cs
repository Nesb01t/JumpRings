using System;

namespace JumpRings.Modules;

public class ProcessConfigurator
{
    public IntPtr hWnd = IntPtr.Zero;

    public bool connected;

    public bool Connect(string procName)
    {
        if (!connected)
        {
            hWnd = User32.FindWindow(null, procName);
            if (!hWnd.Equals(IntPtr.Zero))
            {
                connected = true;
                return true;
            }
        }

        return connected;
    }
}
