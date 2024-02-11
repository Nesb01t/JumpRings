using Memory;

namespace JumpRings.Models;

public class ProcessConfigurator
{
    private readonly Mem _mem = new();

    private bool _connected;

    public bool Connect(string procName)
    {
        if (!_connected)
        {
            _connected = _mem.OpenProcess(procName);
        }

        return _connected;
    }
}