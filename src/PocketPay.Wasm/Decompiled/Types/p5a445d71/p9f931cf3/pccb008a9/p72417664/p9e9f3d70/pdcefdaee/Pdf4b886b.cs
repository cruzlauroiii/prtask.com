namespace WillowMaze.Wasm.Decompiled;

public class Pdf4b886b : P25fa5fcc, P03c3d84c, P756b0dc3
{
    private p1cf86070 F08406a6e;
    private MemoryStream F6da333e7;
    private MemoryStream F841ff0fa;
    private p1cf86070 Fb533640d;
    private pe5cfc515 Fc10f7796;
    private p1cf86070 Fc3a9d448;
    private MemoryStream Fcb7e52b2;
    private p1cf86070 Fd92acc3d;
    private pe5cfc515 Ff37ddab0;

    private int DecryptOutputSize(int P0)
    {
        return 0;
    }

    public byte[] DoFinal(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.toByteArray
        // call: BadPaddingException.<init>
        // call: p1cf86070.messageEncrypt
        // call: pdf4b886b.update
        // call: p1cf86070.messageDecrypt
        // call: p21c8c989.getMessage
        // call: MemoryStream.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.f51235003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.f08406a6e
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.fcb7e52b2
        // type: BadPaddingException
        return default!;
    }

    private int EncryptOutputSize(int P0)
    {
        return 0;
    }

    public int GetKeySize(Key P0)
    {
        // call: p1cf86070.getKeySize
        // call: p0d1837a4.mc2499d21
        // call: p0d1837a4.m02ea6360
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.f08406a6e
        return 0;
    }

    public string GetName()
    {
        // str: "McEliecePointchevalCipher"
        return string.Empty;
    }

    private void InitCipherDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: pe5cfc515.reset
        // call: p0d1837a4.m02ea6360
        // call: p1cf86070.init
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.f08406a6e
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.fc10f7796
    }

    private void InitCipherEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: p0d1837a4.mc2499d21
        // call: p4715f007.<init>
        // call: pe5cfc515.reset
        // call: p1cf86070.init
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.f08406a6e
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.fc10f7796
        // type: p4715f007
    }

    public byte[] Update(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdf4b886b.fcb7e52b2
        return default!;
    }

}
