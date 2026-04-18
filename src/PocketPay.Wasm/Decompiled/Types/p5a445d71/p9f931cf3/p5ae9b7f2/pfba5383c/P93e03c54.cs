namespace WillowMaze.Wasm.Decompiled;

public class P93e03c54 : P1748c064
{
    public static int F046023af;
    public static int F36e8e00a;
    public static int F3f14a647;
    public static int F44ff5678;
    public static int F5e91785f;
    public static int F65eb9a37;
    public static int F809c4f32;
    public static int F92631949;
    public static int F954029b5;
    public static int Fab908a1d;
    public static int Fb9549d2f;
    public static int Ff2198389;
    private p7acc59b6 F0275149f;
    private p7acc59b6 Fad1943a9;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p7acc59b6.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "79f0452315ac734456e9522590afc094da6d885dce61400ef6a6f5667e"
        // str: "Skein-MAC-"
        // call: p7acc59b6.getBlockSize
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p7acc59b6.getOutputSize
        // call: DecryptString.decryptString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // call: p7acc59b6.getOutputSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "Skein MAC requires a key parameter."
        // str: "Invalid parameter passed to Skein MAC init - "
        // call: p57f0d31f$p2bd4a59b.build
        // call: p7acc59b6.init
        // call: object.getClass
        // call: p57f0d31f$p2bd4a59b.setKey
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p94919be6.getKey
        // call: IllegalArgumentException.<init>
        // call: p57f0d31f$p2bd4a59b.<init>
        // call: StringBuilder.toString
        // call: Type.getName
        // call: p57f0d31f.getKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: p57f0d31f$p2bd4a59b
    }

    public void Reset()
    {
        // call: p7acc59b6.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
    }

    public void Update(byte P0)
    {
        // call: p7acc59b6.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: p7acc59b6.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54.fad1943a9
    }

}
