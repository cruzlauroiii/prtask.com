namespace WillowMaze.Wasm.Decompiled;


public class pbc7d2a82 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82$p7e62bc34 f122866c5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f310b42b2;
    private bool f39c7e2db;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f41157135;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f43b62115;
    private bool f52815197;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82$p7e62bc34 f7f2db423;
    private bool f86ac5174;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 f87287254;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f99472ffc;
    private bool fa1173a02;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82$p7e62bc34 faebc07e3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 fbd0c8e3b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 fbe592f5a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 fc36853ea;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82$p7e62bc34 ff8ea8bf8;
    private bool ff9b036b1;

    public pbc7d2a82() {
        if ((15 + 28) % 28 > 0) {
        }
        this.f7f2db423 = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82$p7e62bc34(null);
    }

    public override byte[] GenerateSignature() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 pe1b9a0e1Var;
        if (this.f39c7e2db && (pe1b9a0e1Var = this.fbd0c8e3b) is not null) {
            return this.f7f2db423.generateSignature(pe1b9a0e1Var);
        }
        throw new java.lang.IllegalStateException("Ed25519Signer not initialised for signature generation.");
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
        if (this.f39c7e2db || (p070794c1Var = this.fc36853ea) is null) {
            throw new java.lang.IllegalStateException("Ed25519Signer not initialised for verification");
        }
        return this.f7f2db423.verifySignature(p070794c1Var, bArr);
    }
}

