namespace WillowMaze.Wasm.Decompiled;

public class P48357ead : P1748c064
{
    private pd81e8b93 F08406a6e;
    private byte[] F140c1f12;
    private byte[] F23a71000;
    private byte[] F271f358a;
    private int F4b3a45b4;
    private pd81e8b93 F4d5baef8;
    private int F4fe2f532;
    private pd81e8b93 F75f97aa7;
    private byte[] F7e996a6d;
    private pd81e8b93 F80e168a4;
    private byte[] F867e228b;
    private byte[] F8c1e8654;
    private int F8d6431f5;
    private int Fa3e75e2d;
    private pd81e8b93 Fab648447;
    private pa444028e Fb70cdb87;
    private byte[] Fcb7e52b2;
    private byte[] Fd7e1f8ba;
    private pa444028e Ffe4eec6b;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pa444028e.addPadding
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // call: p48357ead.reset
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fb70cdb87
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f4fe2f532
        return 0;
    }

    public string GetAlgorithmName()
    {
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f08406a6e
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: p48357ead.reset
        // call: pd81e8b93.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f08406a6e
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fcb7e52b2
    }

    public void Update(byte P0)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f140c1f12
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "Can't have a negative input length!"
        // call: pd81e8b93.processBlock
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48357ead.f140c1f12
        // type: IllegalArgumentException
    }

}
