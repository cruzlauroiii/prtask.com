namespace WillowMaze.Wasm.Decompiled;


public class p48af168a : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657 f08406a6e;
    private readonly int f1fe0087e;
    private readonly int f829c20ee;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657 fbd8e5a4b;
    private readonly int fd689135a;
    private readonly int fe81ad63b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657 ff433a10b;

    public p48af168a(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var) {
        this.f08406a6e = pcf478657Var;
        this.fe81ad63b = pcf478657Var.getUnderlyingCipher().getBlockSize() * 8;
    }

    public p48af168a(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var, int i) {
        this.f08406a6e = pcf478657Var;
        this.fe81ad63b = i;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        try {
            return this.f08406a6e.doFinal(bArr, i);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new java.lang.IllegalStateException(e.tostring());
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getUnderlyingCipher().getAlgorithmName() + "-KGMAC";
    }

    public override int GetMacSize() {
        return this.fe81ad63b / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((15 + 19) % 19 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("KGMAC requires ParametersWithIV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        this.f08406a6e.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters(), this.fe81ad63b, iv));
    }

    public override void Reset() {
        this.f08406a6e.reset();
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        this.f08406a6e.processAADbyte(b);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        this.f08406a6e.processAADbytes(bArr, i, i2);
    }
}

