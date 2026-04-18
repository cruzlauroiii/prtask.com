namespace WillowMaze.Wasm.Decompiled;

public class Pf0169d62 : P3b80583b
{
    private static byte[][] F2eb5f040;
    private static byte[][] F75b9a229;
    private static byte[][] F774034b0;
    private readonly byte[] F15177273;
    private int F3262d48d;
    private int F4041a9e7;
    private int F51113a0b;
    private readonly byte[] F7f2db423;
    private readonly byte[] F851022d0;
    private readonly byte[] F9e3a4005;
    private readonly byte[] Fa577a229;
    private int Fd1678819;

    private int Mc174303f(byte[] P0, byte[] P1, int P2)
    {
        // call: pf0169d62.aesEnc
        // call: Array.newInstance
        // call: pf0169d62.mf502e2a1
        // call: System.arraycopy
        // call: pf0169d62.xor
        // field: java.lang.Byte.TYPE
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f75b9a229
        return 0;
    }

    private void Mf502e2a1(byte[][] P0, byte[][] P1)
    {
        // call: System.arraycopy
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "input must be exactly 32 bytes"
        // str: "output too short to receive digest"
        // call: pf0169d62.reset
        // call: IllegalArgumentException.<init>
        // call: pf0169d62.mc174303f
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f3262d48d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f7f2db423
        // type: IllegalStateException
        // type: IllegalArgumentException
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "Haraka-256"
        return string.Empty;
    }

    public void Reset()
    {
        // call: pff43b8de.m01bc6f8e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f3262d48d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f7f2db423
    }

    public void Update(byte P0)
    {
        // str: "total input cannot be more than 32 bytes"
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f7f2db423
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f3262d48d
        // type: IllegalArgumentException
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "total input cannot be more than 32 bytes"
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f3262d48d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf0169d62.f7f2db423
        // type: IllegalArgumentException
    }

}
