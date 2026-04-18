namespace WillowMaze.Wasm.Decompiled;

public class P76b75934_p52246402_p4f9b2c1e : P1748c064
{
    private int F301cc3af;
    private readonly p33e2fd8f F38de0ff8;
    private int F4656b71e;
    private int F4bc9cd7c;
    private readonly p33e2fd8f Fb42f1990;
    private readonly p33e2fd8f Fb8e7c700;
    private int Fcd59e667;
    private readonly p33e2fd8f Feb7afe3b;

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "exception on doFinal(): "
        // call: p33e2fd8f.doFinal
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: p21c8c989.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fb42f1990
        // type: IllegalStateException
        // type: StringBuilder
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "Mac"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p33e2fd8f.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fb42f1990
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fcd59e667
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: p33e2fd8f.init
        // call: p33e2fd8f.getMac
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fb42f1990
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fcd59e667
    }

    public void Reset()
    {
        // call: p33e2fd8f.reset
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fb42f1990
    }

    public void Update(byte P0)
    {
        // call: p33e2fd8f.processAADByte
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fb42f1990
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: p33e2fd8f.processAADBytes
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$p52246402$p4f9b2c1e.fb42f1990
    }

}
