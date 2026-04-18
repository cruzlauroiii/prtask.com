namespace WillowMaze.Wasm.Decompiled;

public class Pe1c1760c : P1748c064
{
    private long F00c88701;
    private int F06c2ebc0;
    private readonly int F1582a542;
    private long F18ffc483;
    private long F1b267619;
    private long F1d766aa9;
    private long F22aa2f61;
    private readonly int F287f180e;
    private long F28d61f7b;
    private long F2f54d8ad;
    private int F40a2a265;
    private readonly int F42ec2b70;
    private long F43a03299;
    private long F4475c445;
    private int F4a7ee5c8;
    private readonly int F4a8a08f0;
    private long F51eadf07;
    private int F61a786a8;
    private long F6327389a;
    private long F6654c734;
    private int F6e40753c;
    private long F6f8f5771;
    private long F7876adef;
    private long F7a7f229f;
    private readonly int F7a9fb7d8;
    private long F7dcb9a55;
    private readonly int F8277e091;
    private int F851ee197;
    private long F9abcde3c;
    private long F9ff988ec;
    private long Fa5d1ef6a;
    private long Fa7a3cc26;
    private long Fb4f1ea07;
    private long Fb637b17a;
    private int Fb9a63890;
    private int Fbcb85a61;
    private readonly int Fcadd0ebe;
    private readonly int Fcc270c30;
    private int Fd2f48ccb;
    private long Fdae24c31;
    private long Fe6219e65;
    private readonly int Fe81010cd;
    private long Fee5a43e1;
    private long Ff91f92fb;
    private long Ff9b89455;
    private readonly int Ffb798b4a;
    private long Ffc88a9ba;

    private static long Mff847a50(long P0, int P1)
    {
        return 0;
    }

    private void ApplySipRounds(int P0)
    {
        // call: pe1c1760c.mff847a50
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f1b267619
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6654c734
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f9abcde3c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f43a03299
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pe1c1760c.doFinal
        // call: p4492081c.m946e4d20
        return 0;
    }

    public long DoFinal()
    {
        // call: pe1c1760c.reset
        // call: pe1c1760c.processMessageWord
        // call: pe1c1760c.applySipRounds
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f9abcde3c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f1b267619
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6f8f5771
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.fd2f48ccb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f43a03299
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f8277e091
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6654c734
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f06c2ebc0
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "SipHash-"
        // str: "87a3eb0c21e870f6d51796c056ce52ccfb70a166362c7beafd236c802b"
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f8277e091
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f4a8a08f0
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "'params' must be an instance of KeyParameter"
        // str: "'params' must be a 128-bit key"
        // call: p4492081c.m59a97823
        // call: IllegalArgumentException.<init>
        // call: p94919be6.getKey
        // call: pe1c1760c.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f28d61f7b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.fb637b17a
        // type: IllegalArgumentException
    }

    private void ProcessMessageWord()
    {
        // call: pe1c1760c.applySipRounds
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.fd2f48ccb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f9abcde3c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f43a03299
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6f8f5771
    }

    public void Reset()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f43a03299
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f06c2ebc0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.fb637b17a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6654c734
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.fd2f48ccb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f28d61f7b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f9abcde3c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f1b267619
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6f8f5771
    }

    public void Update(byte P0)
    {
        // call: pe1c1760c.processMessageWord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6f8f5771
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f06c2ebc0
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: p4492081c.m59a97823
        // call: pe1c1760c.processMessageWord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f06c2ebc0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c.f6f8f5771
    }

}
