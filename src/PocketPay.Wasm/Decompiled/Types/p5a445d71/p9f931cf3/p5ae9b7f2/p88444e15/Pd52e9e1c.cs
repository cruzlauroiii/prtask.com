namespace WillowMaze.Wasm.Decompiled;

public class Pd52e9e1c : P3b80583b
{
    private static byte[][] F69c7c3b3;
    private static byte[][] F75b9a229;
    private readonly byte[] F132f5533;
    private readonly byte[] F2093f93c;
    private int F3262d48d;
    private readonly byte[] F48c5cacb;
    private readonly byte[] F7f2db423;
    private int Fd0071b04;
    private readonly byte[] Fdf6fbd45;
    private int Ffbf3b70b;

    private void M58ff57ef(byte[][] P0, byte[][] P1)
    {
        // call: System.arraycopy
    }

    private int M827c3823(byte[] P0, byte[] P1, int P2)
    {
        // call: pd52e9e1c.aesEnc
        // call: Array.newInstance
        // call: System.arraycopy
        // call: pd52e9e1c.xor
        // call: pd52e9e1c.m58ff57ef
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f75b9a229
        // field: java.lang.Byte.TYPE
        return 0;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "output too short to receive digest"
        // str: "input must be exactly 64 bytes"
        // call: IllegalStateException.<init>
        // call: pd52e9e1c.reset
        // call: pd52e9e1c.m827c3823
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f7f2db423
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f3262d48d
        // type: IllegalArgumentException
        // type: IllegalStateException
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "Haraka-512"
        return string.Empty;
    }

    public void Reset()
    {
        // call: pff43b8de.m01bc6f8e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f3262d48d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f7f2db423
    }

    public void Update(byte P0)
    {
        // str: "total input cannot be more than 64 bytes"
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f7f2db423
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f3262d48d
        // type: IllegalArgumentException
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "total input cannot be more than 64 bytes"
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f7f2db423
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd52e9e1c.f3262d48d
        // type: IllegalArgumentException
    }

}
