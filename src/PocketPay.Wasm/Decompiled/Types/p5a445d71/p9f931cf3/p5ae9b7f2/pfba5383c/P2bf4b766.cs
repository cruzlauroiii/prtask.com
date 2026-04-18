namespace WillowMaze.Wasm.Decompiled;

public class P2bf4b766 : P1748c064
{
    private static int F5ff2be31;
    private static int F818f47b1;
    private static int Fce3a9f78;
    private static int Fdec7dd14;
    private static int Fe02f566f;
    private p48fd26f6 F05e9cb0e;
    private byte[] F0792a5d6;
    private byte[] F08a0a6f9;
    private int F2bb85616;
    private int F42b1ac7d;
    private byte[] F4543d81b;
    private int F480d1b61;
    private byte[] F4a8a08f0;
    private int F4fe2f532;
    private int F512fe3fc;
    private byte[] F57e4a3f4;
    private byte[] F62282fb8;
    private bool F6e814546;
    private int F7770692d;
    private int F78dde6b3;
    private byte[] F7da8c9e5;
    private int F8dab3e63;
    private byte[] F984bab84;
    private int Fa3e75e2d;
    private bool Fa6bae7c0;
    private p48fd26f6 Fad1943a9;
    private byte[] Fc65e995e;
    private byte[] Fcb7e52b2;
    private byte[] Ff2c88059;
    private byte[] Ff579a59f;
    private bool Ffdc164e9;

    private void Ma3929604(byte[] P0, int P1, byte[] P2, int P3, byte[] P4)
    {
        // str: "some of input buffers too short"
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f480d1b61
        // type: IllegalArgumentException
    }

    private void Me3ee4228(byte[] P0, int P1)
    {
        // call: p2bf4b766.ma3929604
        // call: p48fd26f6.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.ff579a59f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4a8a08f0
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "input must be a multiple of blocksize"
        // str: "output buffer too short"
        // call: System.arraycopy
        // call: p48fd26f6.processBlock
        // call: p2bf4b766.ma3929604
        // call: p2bf4b766.reset
        // call: p2500579c.<init>
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.ff579a59f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fc65e995e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fa3e75e2d
        // type: p2500579c
        // type: p96068848
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "DSTU7624Mac"
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "Invalid parameter passed to DSTU7624Mac"
        // call: p48fd26f6.init
        // call: p2bf4b766.reset
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fa6bae7c0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fad1943a9
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pff43b8de.ma552c747
        // call: p48fd26f6.processBlock
        // call: p48fd26f6.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.ff579a59f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fa6bae7c0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fc65e995e
    }

    public void Update(byte P0)
    {
        // call: p2bf4b766.me3ee4228
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fcb7e52b2
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "can't have a negative input length!"
        // call: IllegalArgumentException.<init>
        // call: p2bf4b766.me3ee4228
        // call: System.arraycopy
        // call: p48fd26f6.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p2bf4b766.fad1943a9
        // type: IllegalArgumentException
    }

}
