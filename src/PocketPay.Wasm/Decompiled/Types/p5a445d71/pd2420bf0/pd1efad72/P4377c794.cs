namespace WillowMaze.Wasm.Decompiled;

public class P4377c794 : BufferedInputStream
{
    private static int Faf6d3efc;
    private static int Fb90c5314;
    private static int Fd3c7b922;
    private static int Fd580e84b;
    private long F1dc30992;
    private int F2626772c;
    private readonly int F2633dfd2;
    private int F2a149c34;
    private int F4443f8c3;
    private long F45bf8812;
    private bool F53ffe2f0;
    private int F57416c1a;
    private long F5b2a579f;
    private bool F6d23916a;
    private readonly bool F8466ef2c;
    private long F90272dda;
    private long F9bbc14b0;
    private readonly int Fb78e1120;
    private readonly bool Fc08147c9;
    private bool Fc5a8c0f8;
    private long Fc80ea0c0;
    private int Fda065bd3;
    private bool Ffadb7676;

    private bool Mc4bfb2a0()
    {
        // call: System.nanoTime
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.f90272dda
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.f5b2a579f
        return false;
    }

    public static p4377c794 Mccfc59a5(Stream P0, int P1, int P2)
    {
        // call: p4377c794.<init>
        // type: p4377c794
        return default!;
    }

    public int Read(byte[] P0, int P1, int P2)
    {
        // str: "Read timeout"
        // call: SocketTimeoutException.<init>
        // call: BufferedInputStream.read
        // call: Thread.interrupted
        // call: p4377c794.mc4bfb2a0
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.ffadb7676
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.fc08147c9
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.f2626772c
        // type: SocketTimeoutException
        return 0;
    }

    public byte[] ReadToByteBuffer(int P0)
    {
        // str: "maxSize must be 0 (unlimited) or larger"
        // call: MemoryStream.write
        // call: MemoryStream.toByteArray
        // call: p4377c794.read
        // call: pad3d06d0.mda0c5fd7
        // call: MemoryStream.<init>
        // call: byte[].wrap
        // type: MemoryStream
        return default!;
    }

    public void Reset()
    {
        // call: BufferedInputStream.reset
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.f2626772c
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.fb78e1120
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.markpos
    }

    public p4377c794 Timeout(long P0, long P1)
    {
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.f5b2a579f
        // field: p5a445d71.pd2420bf0.pd1efad72.p4377c794.f90272dda
        return default!;
    }

}
