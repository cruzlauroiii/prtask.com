namespace WillowMaze.Wasm.Decompiled;

public class P75802e5b : Pe229a672
{
    private p54608f3d F01f26b49;
    private p54608f3d F05709c1c;
    private p9682f740 F08406a6e;
    private p54608f3d F140c1f12;
    private p9682f740 F9d7ada42;
    private p54608f3d Fc49be79f;

    public string GetAlgorithmName()
    {
        // str: "GOST28147Wrap"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p473e31bf.getParameters
        // call: pdd5da44e.<init>
        // call: p9682f740.init
        // call: p4715f007.getParameters
        // call: p473e31bf.getUKM
        // call: p54608f3d.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b.f08406a6e
        // type: pdd5da44e
    }

    public byte[] Unwrap(byte[] P0, int P1, int P2)
    {
        // str: "mac mismatch"
        // call: p54608f3d.getMacSize
        // call: p9682f740.processBlock
        // call: IllegalStateException.<init>
        // call: System.arraycopy
        // call: p54608f3d.doFinal
        // call: p54608f3d.update
        // call: pff43b8de.m66e765de
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b.f08406a6e
        // type: IllegalStateException
        return default!;
    }

    public byte[] Wrap(byte[] P0, int P1, int P2)
    {
        // call: p54608f3d.update
        // call: p54608f3d.getMacSize
        // call: p9682f740.processBlock
        // call: p54608f3d.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b.f140c1f12
        return default!;
    }

}
