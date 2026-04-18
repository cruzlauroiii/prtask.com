namespace WillowMaze.Wasm.Decompiled;

public class Pa18653cd : P47b78e9d
{
    private int F0cc175b9;
    private byte[] F0d9d1f7a;
    private int[] F0ff902d8;
    private int[] F1706d35a;
    private readonly int F191ecae8;
    private readonly int F22414fb5;
    private byte[] F33caf397;
    private int F3e33f267;
    private int F4a8a08f0;
    private int[] F53e61336;
    private int F63c3d7fb;
    private int F6a992d55;
    private bool F7a2be8c7;
    private int[] F833b91e9;
    private byte[] F85c250af;
    private int F8ef85823;
    private int[] F8f13f7f5;
    private int F92eb5ffe;
    private int[] F9457b3e2;
    private int F99993b6c;
    private int[] Fa328b5e7;
    private bool Fa5692249;
    private readonly int Fa57df88f;
    private int[] Fc41ae2a6;
    private readonly int Fc80da026;
    private bool Fdb1687e1;
    private int Fdb42cc58;
    private byte[] Fe0e031c6;
    private int Fec1a120f;
    private int Fec83c317;
    private int Ff6a12305;
    private bool Ff6c07bf4;
    private readonly int Ffaeafd6d;
    private int Ffb0ebd07;
    private bool Ffe806fa7;

    private void M40939905(byte[] P0)
    {
        // call: p4492081c.m0eef4fb6
        // call: pa18653cd.m84311803
        // call: pa18653cd.mda386e62
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f53e61336
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f92eb5ffe
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f9457b3e2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f0cc175b9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.fdb1687e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f6a992d55
    }

    private void M84311803()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f92eb5ffe
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f0cc175b9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f9457b3e2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f53e61336
    }

    private void Mda386e62(int[] P0)
    {
    }

    public string GetAlgorithmName()
    {
        // str: "ISAAC"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to ISAAC init - "
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: StringBuilder.toString
        // call: p94919be6.getKey
        // call: Type.getName
        // call: pa18653cd.m40939905
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "input buffer too short"
        // str: " not initialised"
        // str: "output buffer too short"
        // call: p2500579c.<init>
        // call: pa18653cd.m84311803
        // call: StringBuilder.append
        // call: p4492081c.m27c2615b
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: pa18653cd.getAlgorithmName
        // call: StringBuilder.toString
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.fdb1687e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f85c250af
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f6a992d55
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f53e61336
        // type: p2500579c
        // type: StringBuilder
        // type: IllegalStateException
        // type: p96068848
        return 0;
    }

    public void Reset()
    {
        // call: pa18653cd.m40939905
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f0d9d1f7a
    }

    public byte ReturnByte(byte P0)
    {
        // call: p4492081c.m27c2615b
        // call: pa18653cd.m84311803
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f6a992d55
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f85c250af
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa18653cd.f53e61336
        return 0;
    }

}
