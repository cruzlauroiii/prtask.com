namespace WillowMaze.Wasm.Decompiled;

public class P4dd96c8a : P1748c064
{
    private byte[] F0338a9f6;
    private byte[] F04593561;
    private p1c43809d F08406a6e;
    private byte[] F140c1f12;
    private pa444028e F22953d76;
    private byte[] F22f6c65b;
    private p1c43809d F379937be;
    private int F4fe2f532;
    private int F52315674;
    private byte[] F59c9d290;
    private int F5d0da82d;
    private byte[] F5f7dc9ec;
    private pa444028e F7b5687b6;
    private p1c43809d F88f00e00;
    private pa444028e F9b208651;
    private byte[] F9e147c10;
    private int Fa3e75e2d;
    private int Fb4e9a7fb;
    private pa444028e Fb70cdb87;
    private byte[] Fcb7e52b2;
    private int Fd82703de;
    private int Fdb558fa8;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p1c43809d.processBlock
        // call: pa444028e.addPadding
        // call: p1c43809d.getBlockSize
        // call: System.arraycopy
        // call: p4dd96c8a.reset
        // call: p1c43809d.getMacBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fb70cdb87
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fa3e75e2d
        return 0;
    }

    public string GetAlgorithmName()
    {
        // call: p1c43809d.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f08406a6e
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: p4dd96c8a.reset
        // call: p1c43809d.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f08406a6e
    }

    public void Reset()
    {
        // call: p1c43809d.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f4fe2f532
    }

    public void Update(byte P0)
    {
        // call: p1c43809d.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f4fe2f532
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "Can't have a negative input length!"
        // call: p1c43809d.processBlock
        // call: System.arraycopy
        // call: p1c43809d.getBlockSize
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p4dd96c8a.f4fe2f532
        // type: IllegalArgumentException
    }

}
