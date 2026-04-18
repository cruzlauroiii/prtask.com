namespace WillowMaze.Wasm.Decompiled;

public abstract class Pe86c57ec : P085a71d0, P4d7fdfb1
{
    private static int F081d3cab;
    private static int F718f7bba;
    private static int F7c3cb6b3;
    private readonly byte[] F5a6404ce;
    private long F5d03ffc1;
    private int F62a1af01;
    private long F7a639aed;
    private long F98f48f9f;
    private long Fa43ef6d6;
    private int Fb73bd1ba;
    private readonly byte[] Fd595625c;

    private void CopyIn(pe86c57ec P0)
    {
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fb73bd1ba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.f5a6404ce
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fa43ef6d6
    }

    public void Finish()
    {
        // call: pe86c57ec.processBlock
        // call: pe86c57ec.processLength
        // call: pe86c57ec.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fb73bd1ba
    }

    public int GetByteLength()
    {
        return 0;
    }

    private void PopulateState(byte[] P0)
    {
        // call: p4492081c.m27c2615b
        // call: p4492081c.m38b01934
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fb73bd1ba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.f5a6404ce
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fa43ef6d6
    }

    private void ProcessBlock()
    {
    }

    private void ProcessLength(long P0)
    {
    }

    private void ProcessWord(byte[] P0, int P1)
    {
    }

    public void Reset()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fb73bd1ba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.f5a6404ce
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fa43ef6d6
    }

    public void Update(byte P0)
    {
        // call: pe86c57ec.processWord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fb73bd1ba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.f5a6404ce
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: Math.max
        // call: pe86c57ec.processWord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fb73bd1ba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.f5a6404ce
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec.fa43ef6d6
    }

}
