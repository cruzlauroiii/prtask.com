namespace WillowMaze.Wasm.Decompiled;

public class P1e87fa68
{
    private readonly p42a46bbe F08406a6e;
    private readonly p42a46bbe F0b5f4aa3;
    private readonly p42a46bbe F17e34c06;
    private int F47755427;
    private int F4fe2f532;
    private int F5a453c8c;
    private readonly p42a46bbe F97f27ee6;
    private readonly p42a46bbe F9f027018;
    private byte[] Fc99f5a1d;
    private byte[] Fcb7e52b2;
    private int Fce221ca0;
    private int Ff370cc76;
    private byte[] Ff7eec346;

    public static int CVeQSgoNhxlqEkvz(p42a46bbe P0)
    {
        // call: p42a46bbe.getOutputBlockSize
        return 0;
    }

    public static void EpEUqUWmUExicRwf(object P0, int P1, object P2, int P3, int P4)
    {
        // call: System.arraycopy
    }

    public static void JGcJeLYnuVaroSGI(p42a46bbe P0, bool P1, pc9ef6b45 P2)
    {
        // call: p42a46bbe.init
    }

    public static int SHCRNCNaohyLLalO(p42a46bbe P0)
    {
        // call: p42a46bbe.getInputBlockSize
        return 0;
    }

    public static void SiDtXylipANbcMOr(p1e87fa68 P0)
    {
        // call: p1e87fa68.reset
    }

    public static int HIZEWEwRNmYBRjig(p42a46bbe P0)
    {
        // call: p42a46bbe.getInputBlockSize
        return 0;
    }

    public static void HKMmfRHZuyUOlHSE(p1e87fa68 P0)
    {
        // call: p1e87fa68.reset
    }

    public static byte[] QkbRCRcTBnTfPGCY(p42a46bbe P0, byte[] P1, int P2, int P3)
    {
        // call: p42a46bbe.processBlock
        return default!;
    }

    public byte[] DoFinal()
    {
        // call: p1e87fa68.hKMmfRHZuyUOlHSE
        // call: p1e87fa68.qkbRCRcTBnTfPGCY
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f4fe2f532
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f08406a6e
        return default!;
    }

    public int GetBufferPosition()
    {
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f4fe2f532
        return 0;
    }

    public int GetInputBlockSize()
    {
        // call: p1e87fa68.hIZEWEwRNmYBRjig
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f08406a6e
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p1e87fa68.CVeQSgoNhxlqEkvz
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f08406a6e
        return 0;
    }

    public p42a46bbe GetUnderlyingCipher()
    {
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f08406a6e
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p1e87fa68.SHCRNCNaohyLLalO
        // call: p1e87fa68.SiDtXylipANbcMOr
        // call: p1e87fa68.JGcJeLYnuVaroSGI
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f08406a6e
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f4fe2f532
    }

    public void ProcessByte(byte P0)
    {
        // str: "attempt to process message too long for cipher"
        // call: p96068848.<init>
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f4fe2f532
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // type: p96068848
    }

    public void ProcessBytes(byte[] P0, int P1, int P2)
    {
        // str: "attempt to process message too long for cipher"
        // str: "Can't have a negative input length!"
        // call: p1e87fa68.EpEUqUWmUExicRwf
        // call: p96068848.<init>
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f4fe2f532
        // type: IllegalArgumentException
        // type: p96068848
    }

    public void Reset()
    {
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68.f4fe2f532
    }

}
