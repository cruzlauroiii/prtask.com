namespace WillowMaze.Wasm.Decompiled;

public abstract class P42a46bbe : Pc8f2964b
{
    private int F026250ce;
    private int F25f9919b;
    private int F28ec5959;
    private MemoryStream F2f2a96e0;
    private AlgorithmParameterSpec F303fde02;
    private MemoryStream F52173e04;
    private MemoryStream F6c179620;
    private AlgorithmParameterSpec F84d20b9d;
    private AlgorithmParameterSpec F8df5ccdd;
    private int Fa172f9ee;
    private int Fa659dbe7;
    private MemoryStream Fcb7e52b2;
    private int Febf87cbb;
    private int Ff035630e;

    private void CheckLength(int P0)
    {
        // str: " bytes) is not supported by the cipher (max. "
        // str: "Illegal ciphertext length (expected "
        // str: " bytes)."
        // str: "The length of the plaintext ("
        // str: " bytes, was "
        // call: StringBuilder.append
        // call: IllegalBlockSizeException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: MemoryStream.size
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f25f9919b
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fa172f9ee
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fcb7e52b2
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f51235003
        // type: IllegalBlockSizeException
        // type: StringBuilder
    }

    public int DoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Output buffer too short."
        // call: p42a46bbe.doFinal
        // call: ShortBufferException.<init>
        // call: p42a46bbe.getOutputSize
        // call: System.arraycopy
        // type: ShortBufferException
        return 0;
    }

    public byte[] DoFinal(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.toByteArray
        // call: p42a46bbe.messageDecrypt
        // call: p42a46bbe.messageEncrypt
        // call: MemoryStream.reset
        // call: p42a46bbe.checkLength
        // call: p42a46bbe.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fcb7e52b2
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f51235003
        return default!;
    }

    public int GetBlockSize()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f51235003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fa172f9ee
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f25f9919b
        return 0;
    }

    public byte[] GetIV()
    {
        return default!;
    }

    public int GetOutputSize(int P0)
    {
        // call: p42a46bbe.getBlockSize
        // call: MemoryStream.size
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fcb7e52b2
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fa172f9ee
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f51235003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f25f9919b
        return 0;
    }

    public AlgorithmParameterSpec GetParameters()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f303fde02
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
        // call: p42a46bbe.initDecrypt
        // call: InvalidParameterException.<init>
        // type: InvalidParameterException
    }

    public void InitDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: p42a46bbe.initCipherDecrypt
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f51235003
    }

    public void InitEncrypt(Key P0)
    {
        // str: "This cipher needs algorithm parameters for initialization (cannot be null)."
        // call: InvalidParameterException.<init>
        // call: pa9682fb5.m07091bf1
        // call: p42a46bbe.initEncrypt
        // type: InvalidParameterException
    }

    public void InitEncrypt(Key P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "This cipher needs algorithm parameters for initialization (cannot be null)."
        // call: InvalidParameterException.<init>
        // call: p42a46bbe.initEncrypt
        // type: InvalidParameterException
    }

    public void InitEncrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: pa9682fb5.m07091bf1
        // call: p42a46bbe.initEncrypt
    }

    public void InitEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: p42a46bbe.initCipherEncrypt
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.f51235003
    }

    private byte[] MessageDecrypt(byte[] P0)
    {
        return default!;
    }

    private byte[] MessageEncrypt(byte[] P0)
    {
        return default!;
    }

    private void SetMode(string P0)
    {
    }

    private void SetPadding(string P0)
    {
    }

    public int Update(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: p42a46bbe.update
        return 0;
    }

    public byte[] Update(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p42a46bbe.fcb7e52b2
        return default!;
    }

}
