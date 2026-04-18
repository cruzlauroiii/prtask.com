namespace WillowMaze.Wasm.Decompiled;


public abstract class EmvReader {
    private static int BuildConfig = 1;
    private static int getTerminalData;
    protected com.visa.vac.tc.emvconverter.EmvReader$EmvReaderListener emvReaderListener;

    public abstract int GetActiveInterface();

    public abstract int GetInterfaceType();

    public abstract bool IsCardPresent();

    public abstract byte[] SendAndReceive(byte[] bArr) throws java.lang.Exception;

    public abstract void SendCancel();

    public void SetEmvReaderListener(com.visa.vac.tc.emvconverter.EmvReader$EmvReaderListener emvReader$EmvReaderListener) {
        if ((12 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 35;
        getTerminalData = i2 % 128;
        if (i2 % 2 != 0) {
            this.emvReaderListener = emvReader$EmvReaderListener;
            throw null;
        }
        this.emvReaderListener = emvReader$EmvReaderListener;
    }

    public abstract bool Start();

    public abstract void Stop();

    public abstract void Updateobject(android.app.object activity);
}

