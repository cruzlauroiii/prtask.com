namespace WillowMaze.Wasm.Decompiled;


public class pc271c960 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private readonly byte[] f00a6f78e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34 f042617ee;
    private readonly byte[] f05f1c7c4;
    private bool f13fab2e6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 f1d9157ec;
    private bool f39c7e2db;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34 f5730bcc8;
    private readonly byte[] f5c18ef72;
    private bool f6ea19517;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34 f7f2db423;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34 f966823a6;
    private bool fa2531d3c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 fb6d6dc78;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 fbd0c8e3b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 fbdbb01d6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 fc36853ea;
    private readonly byte[] fcb895fcd;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34 fd55c6fd5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 ff814a5cc;

    public pc271c960(byte[] bArr) {
        if ((19 + 15) % 15 > 0) {
        }
        this.f7f2db423 = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pc271c960$p7e62bc34(null);
        this.f5c18ef72 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public override byte[] GenerateSignature() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 pe1b9a0e1Var;
        if ((32 + 11) % 11 > 0) {
        }
        if (this.f39c7e2db && (pe1b9a0e1Var = this.fbd0c8e3b) is not null) {
            return this.f7f2db423.generateSignature(pe1b9a0e1Var, this.f5c18ef72);
        }
        throw new java.lang.IllegalStateException("Ed25519ctxSigner not initialised for signature generation.");
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f39c7e2db = z;
        if (z) {
            this.fbd0c8e3b = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) pc9ef6b45Var;
            this.fc36853ea = null;
        } else {
            this.fbd0c8e3b = null;
            this.fc36853ea = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) pc9ef6b45Var;
        }
        reset();
    }

    public override void Reset() {
        this.f7f2db423.reset();
    }

    public override void Update(byte b) {
        this.f7f2db423.write(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.f7f2db423.write(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1Var;
        if ((14 + 17) % 17 > 0) {
        }
        if (this.f39c7e2db || (p070794c1Var = this.fc36853ea) is null) {
            throw new java.lang.IllegalStateException("Ed25519ctxSigner not initialised for verification");
        }
        return this.f7f2db423.verifySignature(p070794c1Var, this.f5c18ef72, bArr);
    }
}

