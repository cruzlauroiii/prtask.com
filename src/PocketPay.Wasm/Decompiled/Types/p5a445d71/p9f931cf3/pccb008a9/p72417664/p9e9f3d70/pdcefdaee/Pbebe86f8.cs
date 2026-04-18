namespace WillowMaze.Wasm.Decompiled;

public class Pbebe86f8 : P25fa5fcc, P03c3d84c, P756b0dc3
{
    private p23b814a1 F03b6fea1;
    private p23b814a1 F08406a6e;
    private pe5cfc515 F0a677fb5;
    private pe5cfc515 F0a8507ef;
    private p23b814a1 F2769766e;
    private MemoryStream F370beb7f;
    private p23b814a1 F438f2a2b;
    private MemoryStream F73a12053;
    private pe5cfc515 F7b1e59cc;
    private p23b814a1 F854ad9c8;
    private pe5cfc515 Fc10f7796;
    private MemoryStream Fcb7e52b2;
    private pe5cfc515 Fd049e655;

    private int DecryptOutputSize(int P0)
    {
        return 0;
    }

    public byte[] DoFinal(byte[] P0, int P1, int P2)
    {
        // str: "unknown mode in doFinal"
        // call: p23b814a1.messageEncrypt
        // call: BadPaddingException.<init>
        // call: pbebe86f8.update
        // call: p21c8c989.getMessage
        // call: MemoryStream.toByteArray
        // call: IllegalStateException.<init>
        // call: p23b814a1.messageDecrypt
        // call: MemoryStream.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.f08406a6e
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.fcb7e52b2
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.f51235003
        // type: IllegalStateException
        // type: BadPaddingException
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
        // call: p23b814a1.getKeySize
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.f08406a6e
        return 0;
    }

    public string GetName()
    {
        // str: "McElieceFujisakiCipher"
        return string.Empty;
    }

    private void InitCipherDecrypt(Key P0, AlgorithmParameterSpec P1)
    {
        // call: pe5cfc515.reset
        // call: p0d1837a4.m02ea6360
        // call: p23b814a1.init
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.f08406a6e
    }

    private void InitCipherEncrypt(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: p23b814a1.init
        // call: p0d1837a4.mc2499d21
        // call: pe5cfc515.reset
        // call: p4715f007.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.f08406a6e
        // type: p4715f007
    }

    public byte[] Update(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pbebe86f8.fcb7e52b2
        return default!;
    }

}
