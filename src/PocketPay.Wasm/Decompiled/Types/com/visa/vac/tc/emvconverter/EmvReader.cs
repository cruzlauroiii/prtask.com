namespace WillowMaze.Wasm.Decompiled;

public abstract class EmvReader
{
    private static int BuildConfig;
    private static int GetTerminalData;
    private EmvReader$EmvReaderListener EmvReaderListener;

    public int GetActiveInterface()
    {
        return 0;
    }

    public int GetInterfaceType()
    {
        return 0;
    }

    public bool IsCardPresent()
    {
        return false;
    }

    public byte[] SendAndReceive(byte[] P0)
    {
        return default!;
    }

    public void SendCancel()
    {
    }

    public void SetEmvReaderListener(EmvReader$EmvReaderListener P0)
    {
        // field: com.visa.vac.tc.emvconverter.EmvReader.BuildConfig
        // field: com.visa.vac.tc.emvconverter.EmvReader.emvReaderListener
        // field: com.visa.vac.tc.emvconverter.EmvReader.getTerminalData
    }

    public bool Start()
    {
        return false;
    }

    public void Stop()
    {
    }

    public void UpdateActivity(object P0)
    {
    }

}
