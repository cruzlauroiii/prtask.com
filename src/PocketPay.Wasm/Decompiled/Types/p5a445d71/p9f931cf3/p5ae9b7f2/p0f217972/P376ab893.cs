namespace WillowMaze.Wasm.Decompiled;

public class P376ab893 : Pd81e8b93
{
    private pd81e8b93 F08406a6e;
    private byte[] F1d11696f;
    private int F1e7ab154;
    private int F26fed9af;
    private bool F3832b40b;
    private int F3d003c81;
    private bool F47081d8e;
    private int F480d1b61;
    private int F493bdeef;
    private bool F4ad9e387;
    private pd81e8b93 F507365bc;
    private bool F6003cec7;
    private int F61a12938;
    private byte[] F63f0de22;
    private pd81e8b93 F6a297d14;
    private byte[] F6f24978b;
    private int F6f8f5771;
    private byte[] F7d4b9d1f;
    private bool F84d10a1e;
    private bool F9301aa9b;
    private bool F9434f912;
    private byte[] Fb77707e7;
    private int Fbc6a637b;
    private byte[] Fca050e53;
    private byte[] Fe1e1d3d4;
    private bool Fe493dfb7;
    private int Ff25b9814;
    private bool Ffae5fa91;

    private void M1d67e9df()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fb77707e7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f6f8f5771
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fe1e1d3d4
    }

    private void M37ca2bb1(byte[] P0)
    {
        // call: System.arraycopy
        // call: p63a5ff32.m6ea6688c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fe1e1d3d4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f6f8f5771
    }

    private int M53c82eba(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p63a5ff32.m1d623b89
        // call: p63a5ff32.me86b28b5
        // call: p376ab893.m37ca2bb1
        // call: p63a5ff32.ma81c1b38
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fe1e1d3d4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f480d1b61
        return 0;
    }

    private void M7702d37d()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f6f8f5771
    }

    private int M9a2d8ce3(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p63a5ff32.m1d623b89
        // call: pd81e8b93.processBlock
        // call: p376ab893.m37ca2bb1
        // call: p63a5ff32.ma81c1b38
        // call: System.arraycopy
        // call: p63a5ff32.me86b28b5
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fe1e1d3d4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f08406a6e
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/CBC"
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public int GetBlockSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f480d1b61
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Parameter m must blockSize <= m"
        // call: pff43b8de.md329fd77
        // call: p376ab893.m1d67e9df
        // call: System.arraycopy
        // call: p376ab893.m7702d37d
        // call: pd81e8b93.init
        // call: pdd5da44e.getParameters
        // call: pdd5da44e.getIV
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fb77707e7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f6f8f5771
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f84d10a1e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fe1e1d3d4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f480d1b61
        // type: IllegalArgumentException
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p376ab893.m9a2d8ce3
        // call: p376ab893.m53c82eba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f9301aa9b
        return 0;
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f84d10a1e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fe1e1d3d4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p376ab893.fb77707e7
    }

}
