namespace WillowMaze.Wasm.Decompiled;

public class P4ecdeb0c : P25fa5fcc, P03c3d84c, P756b0dc3
{
    private p0607d6b0 F08406a6e;
    private pe5cfc515 F2ef824ce;
    private p0607d6b0 F34f272b4;
    private pe5cfc515 F573882fa;
    private MemoryStream F5ee6ce3c;
    private MemoryStream F65bf9a9f;
    private MemoryStream F956d5aee;
    private pe5cfc515 Fa9cd1e4b;
    private MemoryStream Fabe5633d;
    private pe5cfc515 Fc10f7796;
    private MemoryStream Fcb7e52b2;

    private byte[] M4dca00da()
    {
        // call: MemoryStream.reset
        // call: MemoryStream.write
        // call: MemoryStream.toByteArray
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fcb7e52b2
        return default!;
    }

    private byte[] M7d46bda9(byte[] P0)
    {
        // str: "invalid ciphertext"
        // call: System.arraycopy
        // call: BadPaddingException.<init>
        // type: BadPaddingException
        return default!;
    }

    private int DecryptOutputSize(int P0)
    {
        return 0;
    }

    public byte[] DoFinal(byte[] P0, int P1, int P2)
    {
        // str: "unknown mode in doFinal"
        // call: MemoryStream.toByteArray
        // call: MemoryStream.reset
        // call: p0607d6b0.messageDecrypt
        // call: p4ecdeb0c.m7d46bda9
        // call: p0607d6b0.messageEncrypt
        // call: p4ecdeb0c.m4dca00da
        // call: IllegalStateException.<init>
        // call: p4ecdeb0c.update
        // call: BadPaddingException.<init>
        // call: p21c8c989.getMessage
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fcb7e52b2
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.f08406a6e
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.f51235003
        // type: BadPaddingException
        // type: IllegalStateException
        return default!;
    }

    private int EncryptOutputSize(int P0)
    {
        return 0;
    }

    public int GetKeySize(Key P0)
    {
        // call: p0d1837a4.mc2499d21
        // call: p0d1837a4.m02ea6360
        // call: p0607d6b0.getKeySize
        // call: InvalidKeyException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.f08406a6e
        // type: InvalidKeyException
        return 0;
    }

    public string GetName()
    {
        // str: "McElieceKobaraImaiCipher"
        return string.Empty;
    }

    private void InitCipherDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: p0607d6b0.init
        // call: p0d1837a4.m02ea6360
        // call: MemoryStream.reset
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.f08406a6e
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fcb7e52b2
    }

    private void InitCipherEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: p0607d6b0.init
        // call: p0d1837a4.mc2499d21
        // call: pe5cfc515.reset
        // call: p4715f007.<init>
        // call: MemoryStream.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fcb7e52b2
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.f08406a6e
        // type: p4715f007
    }

    public byte[] Update(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p4ecdeb0c.fcb7e52b2
        return default!;
    }

}
