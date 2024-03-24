using System;
using Avalonia.Remote.Protocol.Input;
using JumpRings.Modules;
using Key = Avalonia.Input.Key;

namespace JumpRings.Template;

public class Intro
{
    /**
     * 按下连接按钮执行的功能
     */
    public static void Button_Connect()
    {
        Svc.Print("[Window] 正在尝试连接魔兽世界...");

        if (Svc.Process.Connect("魔兽世界"))
        {
            Svc.Print("[Window] 连接成功!");
        }
        else
        {
            Svc.Print("[Window] 失败, 未能连接到魔兽世界...");
        }
    }

    /**
     * 按下执行按钮执行的功能
     */
    public static void Button_Execute()
    {
        // todo.1 @执行空格键
        // todo.1 @END

        // todo.2 @多个窗口都执行空格键
        // todo.2 @END

        // todo.3 @打日志
        // todo.3 @END
    }
}
