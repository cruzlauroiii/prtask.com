namespace WillowMaze.Wasm.Decompiled;

public class P8aa39b1f : P1748c064
{
    private pd81e8b93 F08406a6e;
    private byte[] F140c1f12;
    private p94919be6 F1ca9414d;
    private int F1e4d8879;
    private pa444028e F23cb4172;
    private byte[] F2988a82a;
    private p94919be6 F33d389e3;
    private pa444028e F40b94c5b;
    private byte[] F4e01aefd;
    private int F4fe2f532;
    private pa444028e F5aa050bc;
    private int F611a8b40;
    private byte[] F66afd3d8;
    private int F7c946dda;
    private pd81e8b93 F81720e4f;
    private p94919be6 F8f2b304e;
    private p94919be6 F9eb66900;
    private int Fa3e75e2d;
    private int Fb5f2842e;
    private pa444028e Fb70cdb87;
    private byte[] Fc2e2f83a;
    private byte[] Fcb7e52b2;
    private byte[] Fdc3428ce;
    private p94919be6 Fe282ed0b;
    private p94919be6 Fe2b82c52;
    private byte[] Ff5a9e805;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pd81e8b93.processBlock
        // call: pa444028e.addPadding
        // call: p4803ba84.processBlock
        // call: pd81e8b93.getBlockSize
        // call: p8aa39b1f.reset
        // call: System.arraycopy
        // call: p4803ba84.<init>
        // call: p4803ba84.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fb70cdb87
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fe282ed0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fe2b82c52
        // type: p4803ba84
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "ISO9797Alg3"
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "Key must be either 112 or 168 bit long"
        // str: "params must be an instance of KeyParameter or ParametersWithIV"
        // call: pdd5da44e.getIV
        // call: pd81e8b93.init
        // call: IllegalArgumentException.<init>
        // call: p94919be6.<init>
        // call: pdd5da44e.getParameters
        // call: p8aa39b1f.reset
        // call: pdd5da44e.<init>
        // call: p94919be6.getKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fe282ed0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fe2b82c52
        // type: p94919be6
        // type: IllegalArgumentException
        // type: pdd5da44e
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f08406a6e
    }

    public void Update(byte P0)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f140c1f12
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "Can't have a negative input length!"
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // call: pd81e8b93.getBlockSize
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p8aa39b1f.f140c1f12
        // type: IllegalArgumentException
    }

}
