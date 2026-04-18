namespace WillowMaze.Wasm.Decompiled;

public class Pe383f632 : P1748c064
{
    private byte[] F018a5185;
    private pd81e8b93 F08406a6e;
    private pd81e8b93 F0fc3fd85;
    private byte[] F1267f5b0;
    private byte[] F140c1f12;
    private byte[] F1cf4e7b5;
    private byte[] F2be07173;
    private byte[] F32ecb870;
    private int F3e04301c;
    private int F4cf37299;
    private byte[] F4f128ab3;
    private int F4fe2f532;
    private byte[] F51e2bd75;
    private byte[] F6212d912;
    private byte[] F65510794;
    private byte[] F6926eb66;
    private byte[] F6cde157e;
    private byte[] F76765a93;
    private byte[] F8cbd6f5f;
    private byte[] F9489ef64;
    private int F968688c3;
    private byte[] F9baa28de;
    private int Fa3e75e2d;
    private byte[] Fa66e9ab6;
    private byte[] Fb3a17f7c;
    private byte[] Fc505a69e;
    private byte[] Fcb7e52b2;
    private byte[] Fec8a091e;
    private byte[] Fffa28705;
    private byte[] Fffbe3d4b;

    private byte[] M0083cd1a(byte[] P0)
    {
        // call: pe383f632.mb3c44417
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fc505a69e
        return default!;
    }

    private static byte[] M0e6b1c54(int P0)
    {
        // str: "Unknown block size for CMAC: "
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: p4492081c.m27c2615b
        // call: StringBuilder.append
        // call: object.getSystemService
        // field: android.content.pm.ActivityInfo.applicationInfo
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private static int Mb3c44417(byte[] P0, byte[] P1)
    {
        return 0;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pd81e8b93.processBlock
        // call: pd50b36f1.addPadding
        // call: pd50b36f1.<init>
        // call: System.arraycopy
        // call: pe383f632.reset
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f9baa28de
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fb3a17f7c
        // type: pd50b36f1
        return 0;
    }

    public string GetAlgorithmName()
    {
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f08406a6e
        return string.Empty;
    }

    public int GetMacSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fa3e75e2d
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // call: pd81e8b93.init
        // call: pe383f632.m0083cd1a
        // call: pe383f632.reset
        // call: pd81e8b93.processBlock
        // call: pe383f632.validate
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fb3a17f7c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f9baa28de
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f6926eb66
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fcb7e52b2
    }

    public void Update(byte P0)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f08406a6e
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // str: "Can't have a negative input length!"
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // call: pd81e8b93.getBlockSize
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f140c1f12
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe383f632.f4fe2f532
        // type: IllegalArgumentException
    }

    private void Validate(pc9ef6b45 P0)
    {
        // str: "CMac mode only permits key to be set."
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

}
