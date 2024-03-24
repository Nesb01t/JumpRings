using System;
using Avalonia.Remote.Protocol.Input;

namespace JumpRings.Modules;

public static class Svc
{
    public static ProcessConfigurator Process = new();
    public static LiteConsole Console;


    public static void Print(string msg)
    {
        Console.Print(msg);
    }

    public static void Debug()
    {
    }

    /**
     * 参照表格 https://blog.csdn.net/cuoban/article/details/70597636
     */
    public static void KeyPress(int keyCode)
    {
        User32.PostMessageW(Process.hWnd, User32.WM_KEYDOWN, (IntPtr)keyCode, IntPtr.Zero);
        User32.PostMessageW(Process.hWnd, User32.WM_KEYUP, (IntPtr)keyCode, IntPtr.Zero);
    }
}
