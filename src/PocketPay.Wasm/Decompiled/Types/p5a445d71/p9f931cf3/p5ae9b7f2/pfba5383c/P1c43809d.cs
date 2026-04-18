namespace WillowMaze.Wasm.Decompiled;

public class P1c43809d
{
    private pd81e8b93 F08406a6e;
    private int F0bb7c853;
    private int F2f5be80e;
    private byte[] F3274dc68;
    private byte[] F3b308454;
    private int F44c352b9;
    private pd81e8b93 F45119951;
    private pd81e8b93 F46834caa;
    private int F480d1b61;
    private pd81e8b93 F55ac44e2;
    private pd81e8b93 F87693750;
    private byte[] F95ce4e10;
    private byte[] F9729bd4e;
    private byte[] F9ee5d031;
    private byte[] Faa661bab;
    private byte[] Fcf482c58;
    private byte[] Fd9a42cbd;
    private byte[] Ff5c4b221;

    public string GetAlgorithmName()
    {
        // str: "/CFB"
        // call: StringBuilder.toString
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public int GetBlockSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f480d1b61
        return 0;
    }

    private void GetMacBlock(byte[] P0)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f9ee5d031
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f08406a6e
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: System.arraycopy
        // call: pdd5da44e.getIV
        // call: pdd5da44e.getParameters
        // call: pd81e8b93.init
        // call: p1c43809d.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.fcf482c58
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "output buffer too short"
        // str: "input buffer too short"
        // call: p2500579c.<init>
        // call: System.arraycopy
        // call: p96068848.<init>
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f9ee5d031
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.fd9a42cbd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f08406a6e
        // type: p2500579c
        // type: p96068848
        return 0;
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d.f9ee5d031
    }

}
