namespace WillowMaze.Wasm.Decompiled;

public class P48af168a : P1748c064
{
    private readonly pcf478657 F08406a6e;
    private readonly int F1fe0087e;
    private readonly int F829c20ee;
    private readonly pcf478657 Fbd8e5a4b;
    private readonly int Fd689135a;
    private readonly int Fe81ad63b;
    private readonly pcf478657 Ff433a10b;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pcf478657.doFinal
        // call: IllegalStateException.<init>
        // call: p21c8c989.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.f08406a6e
        // type: IllegalStateException
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "-KGMAC"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pcf478657.getUnderlyingCipher
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.fe81ad63b
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "KGMAC requires ParametersWithIV"
        // call: pdd5da44e.getParameters
        // call: ped128738.<init>
        // call: IllegalArgumentException.<init>
        // call: pdd5da44e.getIV
        // call: pcf478657.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.fe81ad63b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.f08406a6e
        // type: ped128738
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pcf478657.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.f08406a6e
    }

    public void Update(byte P0)
    {
        // call: pcf478657.processAADByte
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.f08406a6e
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pcf478657.processAADBytes
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p48af168a.f08406a6e
    }

}
