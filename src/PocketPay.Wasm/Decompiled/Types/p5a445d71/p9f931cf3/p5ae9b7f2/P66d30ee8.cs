namespace WillowMaze.Wasm.Decompiled;

public class P66d30ee8
{
    private bool F01f64f95;
    private pd81e8b93 F08406a6e;
    private byte[] F26ee9b25;
    private bool F2f61baf8;
    private pd81e8b93 F30beb4dc;
    private int F3efeb276;
    private bool F4f02cab3;
    private int F4fe2f532;
    private bool F9301aa9b;
    private int F9c9df21c;
    private bool Fa46df6f8;
    private byte[] Fcb7e52b2;
    private bool Fd2268a9d;
    private bool Fdc78d261;
    private bool Fde1cde13;
    private int Fe945aced;

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "output buffer too short for doFinal()"
        // str: "data not block size aligned"
        // call: p2500579c.<init>
        // call: p66d30ee8.reset
        // call: pd81e8b93.processBlock
        // call: System.arraycopy
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.fa46df6f8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.fcb7e52b2
        // type: p2500579c
        // type: p96068848
        return 0;
    }

    public int GetBlockSize()
    {
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
        return 0;
    }

    public int GetOutputSize(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f4fe2f532
        return 0;
    }

    public pd81e8b93 GetUnderlyingCipher()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
        return default!;
    }

    public int GetUpdateOutputSize(int P0)
    {
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f01f64f95
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p66d30ee8.reset
        // call: pd81e8b93.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.fcb7e52b2
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Can't have a negative input length!"
        // str: "output buffer too short"
        // call: pd81e8b93.processBlock
        // call: p66d30ee8.getUpdateOutputSize
        // call: System.arraycopy
        // call: p2500579c.<init>
        // call: IllegalArgumentException.<init>
        // call: p66d30ee8.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
        // type: IllegalArgumentException
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8.f08406a6e
    }

}
