namespace WillowMaze.Wasm.Decompiled;

public class Pa4c34d72 : P1748c064
{
    private readonly pe85be1b2 F08406a6e;
    private readonly int F2a4f258c;
    private readonly int F50c3bf60;
    private readonly int F699b18f9;
    private readonly pe85be1b2 Fc410bab9;
    private readonly pe85be1b2 Fd0e3709b;
    private readonly int Fd6cb61d4;
    private readonly pe85be1b2 Fde2ff84c;
    private readonly pe85be1b2 Fdfcf2176;
    private readonly int Fe81ad63b;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p21c8c989.toString
        // call: pe85be1b2.doFinal
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.f08406a6e
        // type: IllegalStateException
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "-GMAC"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: pe85be1b2.getUnderlyingCipher
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.fe81ad63b
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "GMAC requires ParametersWithIV"
        // call: IllegalArgumentException.<init>
        // call: ped128738.<init>
        // call: pe85be1b2.init
        // call: pdd5da44e.getParameters
        // call: pdd5da44e.getIV
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.fe81ad63b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.f08406a6e
        // type: ped128738
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pe85be1b2.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.f08406a6e
    }

    public void Update(byte P0)
    {
        // call: pe85be1b2.processAADByte
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.f08406a6e
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe85be1b2.processAADBytes
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pa4c34d72.f08406a6e
    }

}
