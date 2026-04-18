namespace WillowMaze.Wasm.Decompiled;

public class P54608f3d : P1748c064
{
    private int F06367096;
    private int[] F0d5d5908;
    private int[] F0d9d1f7a;
    private byte[] F140c1f12;
    private byte[] F2bc78d4e;
    private byte[] F2c9235b3;
    private byte[] F4798fc6c;
    private int F480d1b61;
    private byte[] F49610f55;
    private int[] F4a9a7dc4;
    private int F4fe2f532;
    private byte[] F54132466;
    private byte[] F550e926a;
    private int F5723b7ed;
    private int F5aad3463;
    private byte[] F5cdcf7f3;
    private byte[] F5dbc98dc;
    private bool F60042ff4;
    private byte[] F657be34f;
    private int F737c4e23;
    private int[] F91fcbe9f;
    private bool F940b027a;
    private byte[] F9fab5e20;
    private byte[] Fa28586e1;
    private bool Fa291341f;
    private int Fa3e75e2d;
    private byte[] Fb7df3404;
    private int Fb86b4cea;
    private int Fc8a18378;
    private bool Fcaf18aa6;
    private byte[] Fcb7e52b2;
    private int Fd2145595;
    private int Fd736939d;
    private int[] Fe3c8f33b;
    private byte[] Ff5dc33a8;
    private byte[] Ff78a2ad3;
    private byte[] Ffe1685da;

    private void M01b0436d(int P0, byte[] P1, int P2)
    {
    }

    private byte[] M56ddf536(byte[] P0, int P1, byte[] P2)
    {
        // call: System.arraycopy
        return default!;
    }

    private int[] M9e03abad(byte[] P0)
    {
        // str: "Key length invalid. Key needs to be 32 byte - 256 bit!!!"
        // call: p54608f3d.mc4dbe288
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return default!;
    }

    private void M9e65bc46(pc9ef6b45 P0)
    {
        // str: "invalid parameter passed to GOST28147 init - "
        // call: p819716a1.getParameters
        // call: StringBuilder.toString
        // call: pdd5da44e.getIV
        // call: p819716a1.getSBox
        // call: p54608f3d.m9e65bc46
        // call: System.arraycopy
        // call: pdd5da44e.getParameters
        // call: IllegalArgumentException.<init>
        // call: p54608f3d.m9e03abad
        // call: Type.getName
        // call: object.getClass
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p94919be6.getKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.ffe1685da
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f5dbc98dc
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    private int Mc4dbe288(byte[] P0, int P1)
    {
        return 0;
    }

    private int Mf22fb24a(int P0, int P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f5dbc98dc
        return 0;
    }

    private void Mfa26aa15(int[] P0, byte[] P1, int P2, byte[] P3, int P4)
    {
        // call: p54608f3d.m01b0436d
        // call: p54608f3d.mf22fb24a
        // call: p54608f3d.mc4dbe288
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p54608f3d.reset
        // call: p54608f3d.m56ddf536
        // call: p54608f3d.mfa26aa15
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fa291341f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f0d9d1f7a
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "GOST28147Mac"
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: p54608f3d.m9e65bc46
        // call: p54608f3d.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.ffe1685da
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fcb7e52b2
    }

    public void Reset()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fa291341f
    }

    public void Update(byte P0)
    {
        // call: p54608f3d.mfa26aa15
        // call: p54608f3d.m56ddf536
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fa291341f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.ffe1685da
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f0d9d1f7a
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "Can't have a negative input length!"
        // call: p54608f3d.m56ddf536
        // call: System.arraycopy
        // call: p54608f3d.mfa26aa15
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.ffe1685da
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d.fa291341f
        // type: IllegalArgumentException
    }

}
