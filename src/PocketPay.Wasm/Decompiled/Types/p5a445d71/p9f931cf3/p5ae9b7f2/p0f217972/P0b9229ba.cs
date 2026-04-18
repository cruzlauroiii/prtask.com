namespace WillowMaze.Wasm.Decompiled;

public class P0b9229ba : Pe3d43295, Pbd6909f5
{
    private int F00e1ad96;
    private readonly pd81e8b93 F08406a6e;
    private byte[] F26f41d8c;
    private readonly pd81e8b93 F2842ab68;
    private byte[] F360cd6ab;
    private byte[] F444f440d;
    private readonly int F480d1b61;
    private readonly int F4df74d4e;
    private readonly pd81e8b93 F73883db7;
    private readonly pd81e8b93 F7950a72f;
    private byte[] F7acd3242;
    private byte[] F886bb73b;
    private int Fa43ef6d6;
    private readonly pd81e8b93 Fa477e1db;
    private byte[] Fcf482c58;
    private readonly int Fd16a497d;
    private byte[] Fd379102f;
    private byte[] Ff7bdae3c;
    private byte[] Ff81a77e3;

    private void M09eb96ef()
    {
        // str: "Counter in CTR/SIC mode out of range."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        // type: IllegalStateException
    }

    private void M5b1a4669(int P0)
    {
        // call: p0b9229ba.mdc669dcd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
    }

    private void Mae3fb02e(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
    }

    private void Mc7849b48()
    {
        // str: "Counter in CTR/SIC mode out of range."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f480d1b61
        // type: IllegalStateException
    }

    private void Mcace8067(long P0)
    {
        // call: p0b9229ba.mae3fb02e
        // call: p0b9229ba.m5b1a4669
        // call: p0b9229ba.mdc669dcd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f480d1b61
    }

    private void Mdc669dcd(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
    }

    private byte CalculateByte(byte P0)
    {
        // call: pd81e8b93.processBlock
        // call: p0b9229ba.mc7849b48
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f360cd6ab
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/SIC"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public int GetBlockSize()
    {
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        return 0;
    }

    public long GetPosition()
    {
        // call: System.arraycopy
        // call: p4492081c.m2e446b8f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: " bytes."
        // str: "CTR/SIC mode requires ParametersWithIV"
        // str: "CTR/SIC mode requires IV of at least: "
        // str: "CTR/SIC mode requires IV no greater than: "
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: pd81e8b93.init
        // call: pdd5da44e.getParameters
        // call: pdd5da44e.getIV
        // call: pff43b8de.md329fd77
        // call: p0b9229ba.reset
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "input buffer too small"
        // str: "output buffer too short"
        // call: p0b9229ba.mc7849b48
        // call: p96068848.<init>
        // call: pd81e8b93.processBlock
        // call: p2500579c.<init>
        // call: p0b9229ba.processBytes
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f360cd6ab
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "input buffer too small"
        // str: "output buffer too short"
        // call: p2500579c.<init>
        // call: p96068848.<init>
        // call: pd81e8b93.processBlock
        // call: p0b9229ba.mc7849b48
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f360cd6ab
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
        // call: System.arraycopy
        // call: pd81e8b93.reset
        // call: pff43b8de.ma552c747
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.fa43ef6d6
    }

    public long SeekTo(long P0)
    {
        // call: p0b9229ba.skip
        // call: p0b9229ba.reset
        return 0;
    }

    public long Skip(long P0)
    {
        // call: p0b9229ba.mcace8067
        // call: pd81e8b93.processBlock
        // call: p0b9229ba.m09eb96ef
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f360cd6ab
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba.f886bb73b
        return 0;
    }

}
