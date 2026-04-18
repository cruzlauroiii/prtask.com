namespace WillowMaze.Wasm.Decompiled;

public class P7264d28b_pb9e6032e : P7264d28b$pd185725f
{
    private p05e0a6b0 F08406a6e;
    private pa80e639a$pf0d24f46 F2545002d;
    private pa80e639a$pf0d24f46 F26f22fd1;
    private pa80e639a$pf0d24f46 F3d8db8f7;
    private pa80e639a$pf0d24f46 F8db7f16d;
    private p05e0a6b0 F91cc5939;
    private pa80e639a$pf0d24f46 Fadf05c92;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pa80e639a$pf0d24f46.erase
        // call: pa80e639a$pf0d24f46.getBuf
        // call: pa80e639a$pf0d24f46.size
        // call: p05e0a6b0.processBlock
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f2545002d
        return 0;
    }

    public string GetAlgorithmName()
    {
        // call: p05e0a6b0.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f08406a6e
        return string.Empty;
    }

    public int GetOutputSize(int P0)
    {
        // call: pa80e639a$pf0d24f46.size
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f2545002d
        return 0;
    }

    public pd81e8b93 GetUnderlyingCipher()
    {
        // str: "not applicable for FPE"
        // call: IllegalStateException.<init>
        // type: IllegalStateException
        return default!;
    }

    public int GetUpdateOutputSize(int P0)
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p05e0a6b0.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f08406a6e
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // call: pa80e639a$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f2545002d
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: pa80e639a$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pb9e6032e.f2545002d
        return 0;
    }

    public void UpdateAAD(byte[] P0, int P1, int P2)
    {
        // str: "AAD is not supported in the current mode."
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    public bool WrapOnNoPadding()
    {
        return false;
    }

}
