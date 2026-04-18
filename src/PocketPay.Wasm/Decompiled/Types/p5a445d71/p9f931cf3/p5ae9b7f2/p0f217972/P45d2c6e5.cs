namespace WillowMaze.Wasm.Decompiled;

public class P45d2c6e5 : P66d30ee8
{
    public static int F030ec6dc;
    public static int F24a446ee;
    public static int F3d3f2d1c;
    public static int F810df8c3;
    public static int F8647f61f;
    public static int F8c4e5641;
    public static int F8ea4c9ac;
    public static int F90811a4d;
    public static int Fae4df16c;
    public static int Faef7a4e1;
    public static int Ffa45035f;
    private readonly int F480d1b61;
    private readonly int F599dcce2;
    private readonly int F6ccb5e82;
    private readonly int F7abbb85f;
    private readonly int F971f1652;

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "need at least one block of input for CTS"
        // str: "output buffer to small in doFinal"
        // str: "need at least one block of input for NISTCTS"
        // call: p2500579c.<init>
        // call: p45d2c6e5.reset
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // call: pc5fbce64.getUnderlyingCipher
        // call: p96068848.<init>
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f599dcce2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f9301aa9b
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public int GetOutputSize(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f4fe2f532
        return 0;
    }

    public int GetUpdateOutputSize(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f4fe2f532
        return 0;
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // call: pd81e8b93.processBlock
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.fcb7e52b2
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Can't have a negative input length!"
        // str: "output buffer too short"
        // call: p45d2c6e5.getBlockSize
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // call: p45d2c6e5.getUpdateOutputSize
        // call: IllegalArgumentException.<init>
        // call: p2500579c.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p45d2c6e5.f08406a6e
        // type: p2500579c
        // type: IllegalArgumentException
        return 0;
    }

}
