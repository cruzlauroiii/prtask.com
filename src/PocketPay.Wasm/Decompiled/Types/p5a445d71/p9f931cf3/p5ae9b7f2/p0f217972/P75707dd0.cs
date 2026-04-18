namespace WillowMaze.Wasm.Decompiled;

public class P75707dd0 : P66d30ee8
{
    private static long F0fac4538;
    private static long F1f491cb7;
    private static long F8a184bc8;
    private static long F930d38e2;
    private static long Fab479a5d;
    private static long Fb525a087;
    private static long Fc69e35ea;
    private static long Fcf294901;
    private static long Fe358b745;
    private static long Fe3b7b577;
    private static long Fef6d54d0;
    private readonly int F3f145dce;
    private readonly long F473ee47a;
    private readonly int F480d1b61;
    private readonly long[] F6214e165;
    private int F886bb73b;
    private readonly long[] F97f3d9e8;
    private readonly int F98b4f0fa;
    private readonly long[] Fb7ed52f7;
    private readonly long Fbb58a97b;
    private readonly long[] Fbddea12f;
    private readonly long[] Fcdb5d375;
    private int Fd8416483;
    private readonly long[] Fe0cf24d2;
    private readonly int Fe194d76d;
    private readonly long Fe4ebe613;
    private readonly int Fed163769;
    private readonly long[] Ffa3ecc48;

    private static long Mbaf6680b(int P0)
    {
        // str: "Only 128, 256, and 512 -bit block sizes supported"
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    private static void Mc8827a94(long P0, long[] P1)
    {
    }

    private void Me3ee4228(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "Attempt to process too many blocks"
        // call: p75707dd0.mc8827a94
        // call: IllegalStateException.<init>
        // call: p4492081c.m946e4d20
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.fb7ed52f7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.fbb58a97b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f886bb73b
        // type: IllegalStateException
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p75707dd0.reset
        return 0;
    }

    public int GetOutputSize(int P0)
    {
        return 0;
    }

    public int GetUpdateOutputSize(int P0)
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Invalid parameters passed"
        // str: "Currently only support IVs of exactly one block"
        // call: IllegalArgumentException.<init>
        // call: p4492081c.m59a97823
        // call: pd81e8b93.init
        // call: pdd5da44e.getIV
        // call: pdd5da44e.getParameters
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.fb7ed52f7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.ffa3ecc48
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f886bb73b
        // type: IllegalArgumentException
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // str: "unsupported operation"
        // call: IllegalStateException.<init>
        // type: IllegalStateException
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Input buffer too short"
        // str: "Partial blocks not supported"
        // str: "Output buffer too short"
        // call: p96068848.<init>
        // call: IllegalArgumentException.<init>
        // call: p75707dd0.me3ee4228
        // call: p2500579c.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f480d1b61
        // type: IllegalArgumentException
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f886bb73b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.fb7ed52f7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.ffa3ecc48
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p75707dd0.f08406a6e
    }

}
