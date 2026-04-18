namespace WillowMaze.Wasm.Decompiled;

public class Pb3bc2bab : P1748c064
{
    private static int F5ec91c43;
    private static int Fe02f566f;
    private long F041709f4;
    private byte[] F167638b2;
    private long F20c89c64;
    private int F6ef20537;
    private p40c98d93 F7e8a48be;
    private byte[] F9104572a;
    private long F99ad25e9;
    private byte[] F9fb1f92c;
    private int Fa3e75e2d;
    private byte[] Fa90d4ae5;
    private p40c98d93 Fad1943a9;
    private p40c98d93 Fb7d6a752;
    private byte[] Fc0f58624;
    private p40c98d93 Fc1a141f3;
    private byte[] Fdd130240;

    private void M4dca00da()
    {
        // call: p40c98d93.getByteLength
        // call: p40c98d93.update
        // call: p4492081c.m946e4d20
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f041709f4
    }

    private byte[] Mcbfb3f0f(byte[] P0)
    {
        // call: p4492081c.m45d2d6ef
        // call: p40c98d93.getByteLength
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        return default!;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "Output buffer too short"
        // str: " not initialised"
        // call: StringBuilder.append
        // call: p40c98d93.update
        // call: StringBuilder.<init>
        // call: p40c98d93.doFinal
        // call: pb3bc2bab.reset
        // call: StringBuilder.toString
        // call: pb3bc2bab.getAlgorithmName
        // call: pb3bc2bab.m4dca00da
        // call: p2500579c.<init>
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f041709f4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f9fb1f92c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f167638b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        // type: p2500579c
        // type: StringBuilder
        // type: IllegalStateException
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "DSTU7564Mac"
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "Bad parameter passed"
        // call: pb3bc2bab.reset
        // call: IllegalArgumentException.<init>
        // call: p94919be6.getKey
        // call: pb3bc2bab.mcbfb3f0f
        // call: p40c98d93.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f167638b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f9fb1f92c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: p40c98d93.reset
        // call: p40c98d93.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f041709f4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f167638b2
    }

    public void Update(byte P0)
    {
        // call: p40c98d93.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f041709f4
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "Input buffer too short"
        // str: " not initialised"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalStateException.<init>
        // call: p40c98d93.update
        // call: pb3bc2bab.getAlgorithmName
        // call: p96068848.<init>
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f041709f4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.f167638b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pb3bc2bab.fad1943a9
        // type: p96068848
        // type: IllegalStateException
        // type: StringBuilder
    }

}
