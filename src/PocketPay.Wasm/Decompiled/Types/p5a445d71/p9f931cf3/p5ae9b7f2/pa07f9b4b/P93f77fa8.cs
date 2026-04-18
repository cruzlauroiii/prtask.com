namespace WillowMaze.Wasm.Decompiled;

public class P93f77fa8 : Pd81e8b93
{
    private static byte[][] F048a81b9;
    private static byte[][] F0d61f837;
    private static int F1f96ebd0;
    private static byte[] F24a9ab3d;
    private static int F25872339;
    private static byte[] F25d468bd;
    private static byte[] F270ab90f;
    private static byte[] F2832dca5;
    private static byte[] F29b8502a;
    private static byte[] F2cd13c12;
    private static byte[][] F330e14d6;
    private static byte[][] F3c6f1add;
    private static byte[] F4d551bbd;
    private static byte[] F7631fff8;
    private static byte[] F7d9a6761;
    private static byte[] F92f0c99f;
    private static byte[][] Fab498f9e;
    private static int Fb33d69a3;
    private static byte[] Fbdef5e1f;
    private static byte[] Fc240413f;
    private static int Fc75e2054;
    private static byte[] Fea439f1a;
    private static byte[] Ff8df22cc;
    private static byte[] Ff9037d73;
    private static int Ffd838b74;
    private byte[][] Face12d49;
    private byte[][] Fcec01fee;

    private static byte M245fef18(byte P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.fc240413f
        return 0;
    }

    private static byte[][] M43046918(bool P0, byte[] P1)
    {
        // str: "Key length not 128/192/256 bits."
        // call: p93f77fa8.me73812b1
        // call: System.arraycopy
        // call: p93f77fa8.ma3929604
        // call: p93f77fa8.m89f88d21
        // call: p93f77fa8.mc0398fb6
        // call: Array.newInstance
        // call: IllegalArgumentException.<init>
        // call: p93f77fa8.m7fc56270
        // call: p93f77fa8.m6515f660
        // field: java.lang.Byte.TYPE
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.f0d61f837
        // type: IllegalArgumentException
        return default!;
    }

    private static void M4c6a2105(byte[] P0)
    {
        // call: p93f77fa8.mf7fc17e4
        // call: p93f77fa8.m4f0dea75
        // call: p93f77fa8.m245fef18
        // call: p93f77fa8.m9d9c421a
    }

    private static byte M4f0dea75(byte P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.f24a9ab3d
        return 0;
    }

    private static void M6515f660(byte[] P0, byte[] P1)
    {
        // call: p93f77fa8.ma3929604
        // call: p93f77fa8.m4c6a2105
        // call: p93f77fa8.m7fc56270
    }

    private static void M7fc56270(byte[] P0)
    {
    }

    private static void M89f88d21(byte[][] P0)
    {
    }

    private static void M9625ba35(byte[] P0)
    {
        // call: p93f77fa8.m245fef18
        // call: p93f77fa8.mf7fc17e4
        // call: p93f77fa8.m9d9c421a
        // call: p93f77fa8.m4f0dea75
    }

    private static byte M9d9c421a(byte P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.f4d551bbd
        return 0;
    }

    private static void Ma3929604(byte[] P0, byte[] P1)
    {
    }

    private static void Mc0398fb6(byte[] P0, byte[] P1)
    {
        // call: p93f77fa8.m7fc56270
        // call: p93f77fa8.m9625ba35
        // call: p93f77fa8.ma3929604
    }

    private static void Me73812b1(byte[] P0, byte[] P1, byte[] P2, int P3)
    {
    }

    private static byte Mf7fc17e4(byte P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.f25d468bd
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "ARIA"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to ARIA init - "
        // call: object.getClass
        // call: p93f77fa8.m43046918
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: p94919be6.getKey
        // call: Type.getName
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.fcec01fee
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "output buffer too short"
        // str: "input buffer too short"
        // str: "ARIA engine not initialised"
        // call: p93f77fa8.m6515f660
        // call: System.arraycopy
        // call: p93f77fa8.m4c6a2105
        // call: p2500579c.<init>
        // call: p93f77fa8.mc0398fb6
        // call: p93f77fa8.ma3929604
        // call: p96068848.<init>
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p93f77fa8.fcec01fee
        // type: p2500579c
        // type: p96068848
        // type: IllegalStateException
        return 0;
    }

    public void Reset()
    {
    }

}
