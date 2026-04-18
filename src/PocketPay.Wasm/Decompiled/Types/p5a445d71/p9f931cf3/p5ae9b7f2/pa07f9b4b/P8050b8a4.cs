namespace WillowMaze.Wasm.Decompiled;

public class P8050b8a4 : Pd81e8b93
{
    private static int F057c2812;
    private static int F0a950184;
    private static int F149a48f5;
    private static int F3d42641d;
    private static int F40ebced8;
    private static int F79453460;
    private static int F7c3e23eb;
    private static int Fbab0cb84;
    private static int Fc0b5150b;
    private static int Fc75e2054;
    private static int Fe7b1a5c8;
    private int[] F0d9d1f7a;
    private int[] F566fa6a8;
    private int[] Fe427fd2c;

    private int M35394226(int P0, int P1)
    {
        return 0;
    }

    private int M4491f70d(int P0)
    {
        return 0;
    }

    private int[] M4bb83c42(int[] P0)
    {
        // call: p8050b8a4.m4491f70d
        // call: p8050b8a4.addInv
        return default!;
    }

    private void M707a37c3(int P0, byte[] P1, int P2)
    {
    }

    private int[] M9e03abad(bool P0, byte[] P1)
    {
        // call: p8050b8a4.mdca58365
        // call: p8050b8a4.m4bb83c42
        return default!;
    }

    private void Md15dca72(int[] P0, byte[] P1, int P2, byte[] P3, int P4)
    {
        // call: p8050b8a4.m707a37c3
        // call: p8050b8a4.m35394226
        // call: p8050b8a4.mdde1faa5
    }

    private int[] Mdca58365(byte[] P0)
    {
        // call: p8050b8a4.mdde1faa5
        // call: System.arraycopy
        return default!;
    }

    private int Mdde1faa5(byte[] P0, int P1)
    {
        return 0;
    }

    private int AddInv(int P0)
    {
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "IDEA"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to IDEA init - "
        // call: object.getClass
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: p8050b8a4.m9e03abad
        // call: p94919be6.getKey
        // call: Type.getName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8050b8a4.f0d9d1f7a
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "output buffer too short"
        // str: "input buffer too short"
        // str: "IDEA engine not initialised"
        // call: IllegalStateException.<init>
        // call: p8050b8a4.md15dca72
        // call: p96068848.<init>
        // call: p2500579c.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p8050b8a4.f0d9d1f7a
        // type: p2500579c
        // type: p96068848
        // type: IllegalStateException
        return 0;
    }

    public void Reset()
    {
    }

}
