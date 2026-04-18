namespace WillowMaze.Wasm.Decompiled;

public class Pf0a29eac : P1748c064
{
    private static int F5b8a69e2;
    private static int F7f054919;
    private static int Fa1a28a45;
    private static int Fe2c0672d;
    private pa24fcebf F02de2c74;
    private pa24fcebf F1f1b6aa4;
    private int F2920612f;
    private readonly int F2ad2447f;
    private int F34df8fee;
    private readonly int F3da538ad;
    private readonly int[] F4e7f9fe0;
    private readonly int[] F5182eace;
    private int F614afaee;
    private readonly int F721f3686;
    private readonly int[] F73708763;
    private pa24fcebf F7d285f98;
    private readonly int[] F870c8d0a;
    private int F87b46c6b;
    private readonly int F9bbf424f;
    private int F9ca282a2;
    private pa24fcebf Fa9e26b8c;
    private readonly int[] Fab91dd42;
    private readonly int[] Fb3a19585;
    private readonly int[] Fb942651d;
    private int Fc40197b6;
    private pa24fcebf Fcddbf8c8;
    private readonly pf0a29eac$pa9dfe031 Fd78daf36;
    private readonly pf0a29eac$pa9dfe031 Fdd24697e;
    private int Fe1d2fb1d;
    private int Fe873b182;
    private readonly int Fe911f58d;
    private readonly int[] Ffdfdfa24;

    private void M00f74901()
    {
        // call: pf0a29eac$pa9dfe031.createKeyStreamWord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f73708763
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f34df8fee
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fd78daf36
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe873b182
    }

    private int M020aa11f(int P0, int P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f34df8fee
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f73708763
        return 0;
    }

    private void M1f60285f()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f73708763
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f34df8fee
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe873b182
    }

    private void Mb544caf8()
    {
        // call: pf0a29eac$pa9dfe031.createKeyStreamWord
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f73708763
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f34df8fee
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fd78daf36
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f4e7f9fe0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe873b182
    }

    private void Mc00c3931(int P0)
    {
        // call: pf0a29eac.m020aa11f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f4e7f9fe0
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pf0a29eac.getMacSize
        // call: pf0a29eac.m1f60285f
        // call: pf0a29eac.reset
        // call: pf0a29eac.mc00c3931
        // call: pa24fcebf.encode32be
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f4e7f9fe0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe873b182
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "Zuc256Mac-"
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe911f58d
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe911f58d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: pf0a29eac$pa9dfe031.init
        // call: pf0a29eac$pa9dfe031.copy
        // call: pf0a29eac.mb544caf8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fd78daf36
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f7d285f98
    }

    public void Reset()
    {
        // call: pf0a29eac.mb544caf8
        // call: pf0a29eac$pa9dfe031.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fd78daf36
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.f7d285f98
    }

    public void Update(byte P0)
    {
        // call: pf0a29eac.m00f74901
        // call: pf0a29eac.mc00c3931
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pf0a29eac.fe873b182
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pf0a29eac.update
    }

}
