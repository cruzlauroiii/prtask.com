namespace WillowMaze.Wasm.Decompiled;

public class P7881436c : Pd81e8b93
{
    private static int F471827d8;
    private static int F48a73da5;
    private static int F63bcabf8;
    private static int F6a1ed1a7;
    private static int F70984b43;
    private static int F88823a3f;
    private static int F8d7e7aa4;
    private static int F99ee1a7a;
    private static int Fb32ebd53;
    private static int Fcf84e453;
    private static int Fe2cbbf7e;
    private static int Ff1d8269c;
    private int F00b80876;
    private int F02fa55a5;
    private bool F0657dfb6;
    private int F14a99b22;
    private int F23dae1c2;
    private bool F56d1a697;
    private int F5c855e09;
    private bool F5d3cc319;
    private bool F6bc6081f;
    private int F6bc94756;
    private int F762d49f8;
    private int F78611330;
    private bool F89738724;
    private int F99450383;
    private int Fa64e543d;
    private bool Fbdf3566b;
    private int Fbe06a308;
    private int Fc716fb29;
    private bool Fd16531b4;
    private int Fd273a0ac;
    private int Fd3ad73a4;
    private int Fd638002e;
    private int Fd6739961;
    private bool Feaed885d;
    private int Fef5d165a;

    private int M38ba9ce4(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p7881436c.m48b764ad
        // call: p7881436c.me5b50b10
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f6bc94756
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f5c855e09
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fc716fb29
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fd3ad73a4
        return 0;
    }

    private void M40939905(byte[] P0)
    {
        // str: "Key size must be 128 bits."
        // call: p7881436c.m48b764ad
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fd3ad73a4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fc716fb29
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f5c855e09
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f6bc94756
        // type: IllegalArgumentException
    }

    private int M48b764ad(byte[] P0, int P1)
    {
        return 0;
    }

    private int M54b8c68b(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p7881436c.m48b764ad
        // call: p7881436c.me5b50b10
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fd3ad73a4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fc716fb29
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f6bc94756
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f5c855e09
        return 0;
    }

    private void Me5b50b10(int P0, byte[] P1, int P2)
    {
    }

    public string GetAlgorithmName()
    {
        // str: "TEA"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to TEA init - "
        // call: StringBuilder.toString
        // call: object.getClass
        // call: p7881436c.m40939905
        // call: IllegalArgumentException.<init>
        // call: Type.getName
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p94919be6.getKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f0657dfb6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fbdf3566b
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: " not initialised"
        // str: "input buffer too short"
        // str: "output buffer too short"
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p2500579c.<init>
        // call: StringBuilder.append
        // call: p7881436c.m38ba9ce4
        // call: p7881436c.getAlgorithmName
        // call: p96068848.<init>
        // call: p7881436c.m54b8c68b
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.f0657dfb6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p7881436c.fbdf3566b
        // type: p2500579c
        // type: IllegalStateException
        // type: StringBuilder
        // type: p96068848
        return 0;
    }

    public void Reset()
    {
    }

}
