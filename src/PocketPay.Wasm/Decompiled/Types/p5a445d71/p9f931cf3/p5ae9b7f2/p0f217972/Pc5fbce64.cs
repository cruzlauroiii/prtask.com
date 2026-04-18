namespace WillowMaze.Wasm.Decompiled;

public class Pc5fbce64 : Pd81e8b93
{
    private pd81e8b93 F08406a6e;
    private pd81e8b93 F101b660a;
    private int F480d1b61;
    private byte[] F4dd0e646;
    private int F598082c8;
    private int F59afa81b;
    private int F5a27341c;
    private bool F624f2eac;
    private bool F7148bf34;
    private bool F72bab29c;
    private bool F74fa6a33;
    private bool F78e3449f;
    private byte[] F7b9491a1;
    private byte[] F84fe5136;
    private pd81e8b93 F852b015d;
    private byte[] F97dce255;
    private pd81e8b93 F9b3461e2;
    private byte[] Fcc8eb5bb;
    private byte[] Fcf482c58;
    private pd81e8b93 Fe3f1ad1f;
    private byte[] Ff7c54bb3;
    private byte[] Fffca4608;

    private int M38ba9ce4(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "input buffer too short"
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.fcc8eb5bb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f480d1b61
        // type: p96068848
        return 0;
    }

    private int M54b8c68b(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "input buffer too short"
        // call: p96068848.<init>
        // call: pd81e8b93.processBlock
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.fcc8eb5bb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f97dce255
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
        // type: p96068848
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/CBC"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public int GetBlockSize()
    {
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
        return 0;
    }

    public pd81e8b93 GetUnderlyingCipher()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "cannot change encrypting state without providing key."
        // str: "initialisation vector must be the same length as block size"
        // call: pd81e8b93.init
        // call: pdd5da44e.getParameters
        // call: pc5fbce64.reset
        // call: pdd5da44e.getIV
        // call: System.arraycopy
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f78e3449f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
        // type: IllegalArgumentException
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: pc5fbce64.m38ba9ce4
        // call: pc5fbce64.m54b8c68b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f78e3449f
        return 0;
    }

    public void Reset()
    {
        // call: pff43b8de.ma552c747
        // call: pd81e8b93.reset
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f97dce255
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.fcf482c58
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.fcc8eb5bb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64.f08406a6e
    }

}
