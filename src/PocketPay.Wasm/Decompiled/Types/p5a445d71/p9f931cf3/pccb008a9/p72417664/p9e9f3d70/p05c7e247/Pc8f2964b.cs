namespace WillowMaze.Wasm.Decompiled;

public abstract class Pc8f2964b : CipherSpi
{
    public static int F0bb3e1e1;
    public static int F80d4b06f;
    public static int F8abb66a9;
    public static int F8de7fee3;
    public static int F9a328249;
    public static int Fef8f6b20;
    public static int Ff72cc0d2;
    private int F51235003;
    private int F518c9fa0;
    private int Fa4bc07e2;
    private int Ff368d03f;

    public int DoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        return 0;
    }

    public byte[] DoFinal()
    {
        // call: pc8f2964b.doFinal
        return default!;
    }

    public byte[] DoFinal(byte[] P0)
    {
        // call: pc8f2964b.doFinal
        return default!;
    }

    public byte[] DoFinal(byte[] P0, int P1, int P2)
    {
        return default!;
    }

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: pc8f2964b.doFinal
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // call: pc8f2964b.doFinal
        return default!;
    }

    private int EngineGetBlockSize()
    {
        // call: pc8f2964b.getBlockSize
        return 0;
    }

    private byte[] EngineGetIV()
    {
        // call: pc8f2964b.getIV
        return default!;
    }

    private int EngineGetKeySize(Key P0)
    {
        // str: "Unsupported key."
        // call: pc8f2964b.getKeySize
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        // call: pc8f2964b.getOutputSize
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // call: pc8f2964b.engineInit
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: InvalidParameterException.<init>
        // call: InvalidAlgorithmParameterException.getMessage
        // call: pc8f2964b.engineInit
        // type: InvalidParameterException
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // call: InvalidKeyException.<init>
        // call: InvalidAlgorithmParameterException.<init>
        // call: pc8f2964b.initDecrypt
        // call: pc8f2964b.initEncrypt
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.pc8f2964b.f51235003
        // type: InvalidAlgorithmParameterException
        // type: InvalidKeyException
    }

    private void EngineSetMode(string P0)
    {
        // call: pc8f2964b.setMode
    }

    private void EngineSetPadding(string P0)
    {
        // call: pc8f2964b.setPadding
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: pc8f2964b.update
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pc8f2964b.update
        return default!;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public byte[] GetIV()
    {
        return default!;
    }

    public int GetKeySize(Key P0)
    {
        return 0;
    }

    public string GetName()
    {
        return string.Empty;
    }

    public int GetOutputSize(int P0)
    {
        return 0;
    }

    public AlgorithmParameterSpec GetParameters()
    {
        return default!;
    }

    public void InitDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
    }

    public void InitEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
    }

    private void SetMode(string P0)
    {
    }

    private void SetPadding(string P0)
    {
    }

    public int Update(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        return 0;
    }

    public byte[] Update(byte[] P0)
    {
        // call: pc8f2964b.update
        return default!;
    }

    public byte[] Update(byte[] P0, int P1, int P2)
    {
        return default!;
    }

}
