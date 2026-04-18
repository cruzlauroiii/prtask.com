namespace WillowMaze.Wasm.Decompiled;

public class P4803ba84 : Pd81e8b93
{
    private static int[] F005072e5;
    private static int[] F065c8777;
    private static int[] F0ac17294;
    private static int[] F0c6cac9d;
    private static int[] F0f182254;
    private static int[] F1011c3f0;
    private static short[] F106f0055;
    private static int[] F12a0d2d2;
    private static short[] F1c95b3af;
    private static int F1d05ba5b;
    private static int[] F26d981b7;
    private static int[] F29981818;
    private static int[] F2b2d7a17;
    private static int F315f78f9;
    private static byte[] F33060995;
    private static int[] F3df04d2d;
    private static int[] F41391f4e;
    private static int[] F443383bb;
    private static int[] F45c02c5a;
    private static int[] F4849b8f4;
    private static int[] F545e4112;
    private static byte[] F59b6407b;
    private static int[] F6b502d72;
    private static short[] F72c425ca;
    private static int[] F77893baf;
    private static byte[] F7c1bd880;
    private static int[] F7d813037;
    private static int[] F8edbf72b;
    private static byte[] F9dfb0ce8;
    private static byte[] Fa1137817;
    private static int Fa290ec3a;
    private static byte[] Fa2ca92a0;
    private static byte[] Fa99acaa3;
    private static int[] Faa802365;
    private static int[] Fb4e3e965;
    private static int[] Fb59e8525;
    private static int[] Fc1d17b64;
    private static byte[] Fc2d41192;
    private static int Fc75e2054;
    private static int[] Fc7ae2402;
    private static short[] Fcc79ac68;
    private static int[] Fcffefb29;
    private static int[] Fd61f2a7a;
    private static int[] Fd8633ebd;
    private static int[] Fda76a786;
    private static int[] Fda9bc1ab;
    private static int[] Fe51b004b;
    private static int[] Fe53cd37e;
    private static int[] Fe9eee470;
    private static int[] Fee90ccae;
    private static int[] Ff5c5ff38;
    private static int Ffdaa0f1d;
    private int[] F0d9d1f7a;
    private int[] F1ddd46aa;
    private int[] F425e5dfa;
    private int[] Fb6723ed0;
    private int[] Fcfc7af70;

    private void DesFunc(int[] P0, byte[] P1, int P2, byte[] P3, int P4)
    {
    }

    private int[] GenerateWorkingKey(bool P0, byte[] P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.f106f0055
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.fb59e8525
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.f33060995
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.f7c1bd880
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.fa1137817
        return default!;
    }

    public string GetAlgorithmName()
    {
        // str: "DES"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to DES init - "
        // str: "DES key too long - should be 8 bytes"
        // call: p4803ba84.generateWorkingKey
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p94919be6.getKey
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: Type.getName
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.f0d9d1f7a
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "input buffer too short"
        // str: "output buffer too short"
        // str: "DES engine not initialised"
        // call: p96068848.<init>
        // call: p2500579c.<init>
        // call: p4803ba84.desFunc
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p4803ba84.f0d9d1f7a
        // type: p96068848
        // type: IllegalStateException
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
    }

}
