namespace WillowMaze.Wasm.Decompiled;

public abstract class P25fa5fcc : Pc8f2964b
{
    private AlgorithmParameterSpec F303fde02;
    private AlgorithmParameterSpec F63e5fd07;
    private AlgorithmParameterSpec Fe61cb404;
    private AlgorithmParameterSpec Fec033191;

    private int DecryptOutputSize(int P0)
    {
        return 0;
    }

    public int DoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Output buffer too short."
        // call: ShortBufferException.<init>
        // call: System.arraycopy
        // call: p25fa5fcc.getOutputSize
        // call: p25fa5fcc.doFinal
        // type: ShortBufferException
        return 0;
    }

    public byte[] DoFinal(byte[] P0, int P1, int P2)
    {
        return default!;
    }

    private int EncryptOutputSize(int P0)
    {
        return 0;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public byte[] GetIV()
    {
        return default!;
    }

    public int GetOutputSize(int P0)
    {
        // call: p25fa5fcc.decryptOutputSize
        // call: p25fa5fcc.encryptOutputSize
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p25fa5fcc.f51235003
        return 0;
    }

    public AlgorithmParameterSpec GetParameters()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p25fa5fcc.f303fde02
        return default!;
    }

    private void InitCipherDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
    }

    private void InitCipherEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
    }

    public void InitDecrypt(Key P0)
    {
        // str: "This cipher needs algorithm parameters for initialization (cannot be null)."
        // call: p25fa5fcc.initDecrypt
        // call: InvalidParameterException.<init>
        // type: InvalidParameterException
    }

    public void InitDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: p25fa5fcc.initCipherDecrypt
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p25fa5fcc.f51235003
    }

    public void InitEncrypt(Key P0)
    {
        // str: "This cipher needs algorithm parameters for initialization (cannot be null)."
        // call: InvalidParameterException.<init>
        // call: pa9682fb5.m07091bf1
        // call: p25fa5fcc.initEncrypt
        // type: InvalidParameterException
    }

    public void InitEncrypt(Key P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "This cipher needs algorithm parameters for initialization (cannot be null)."
        // call: p25fa5fcc.initEncrypt
        // call: InvalidParameterException.<init>
        // type: InvalidParameterException
    }

    public void InitEncrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: pa9682fb5.m07091bf1
        // call: p25fa5fcc.initEncrypt
    }

    public void InitEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: p25fa5fcc.initCipherEncrypt
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p25fa5fcc.f51235003
    }

    private void SetMode(string P0)
    {
    }

    private void SetPadding(string P0)
    {
    }

    public int Update(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output"
        // call: System.arraycopy
        // call: ShortBufferException.<init>
        // call: p25fa5fcc.update
        // call: p25fa5fcc.getOutputSize
        // type: ShortBufferException
        return 0;
    }

    public byte[] Update(byte[] P0, int P1, int P2)
    {
        return default!;
    }

}
