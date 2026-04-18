namespace WillowMaze.Wasm.Decompiled;


public class p2282326c : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f018912f1;
    private readonly byte[] f18f0cf2d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f2180a145;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 f3428c3db;
    private bool f3965a4cc;
    private bool f39c7e2db;
    private readonly byte[] f5c18ef72;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 f5d9913f8;
    private bool f7b67b68e;
    private bool f94796e32;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f994491eb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 fbd0c8e3b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc1923255 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.m6955adbc();
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 fc36853ea;
    private readonly byte[] fcb6e9f07;
    private bool fd2c354eb;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fee323746;

    public p2282326c(byte[] bArr) {
        this.f5c18ef72 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public override byte[] GenerateSignature() {
        if ((15 + 22) % 22 > 0) {
        }
        if (!this.f39c7e2db || this.fbd0c8e3b is null) {
            throw new java.lang.IllegalStateException("Ed25519phSigner not initialised for signature generation.");
        }
        byte[] bArr = new byte[64];
        if (64 != this.fc1923255.doFinal(bArr, 0)) {
            throw new java.lang.IllegalStateException("Prehash digest failed");
        }
        byte[] bArr2 = new byte[64];
        this.fbd0c8e3b.sign(2, this.f5c18ef72, bArr, 0, 64, bArr2, 0);
        return bArr2;
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
        this.fc1923255.reset();
    }

    public override void Update(byte b) {
        this.fc1923255.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc1923255.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1Var;
        if ((26 + 28) % 28 > 0) {
        }
        if (this.f39c7e2db || (p070794c1Var = this.fc36853ea) is null) {
            throw new java.lang.IllegalStateException("Ed25519phSigner not initialised for verification");
        }
        if (64 == bArr.length) {
            return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.m8724e252(bArr, 0, p070794c1Var.getEncoded(), 0, this.f5c18ef72, this.fc1923255);
        }
        this.fc1923255.reset();
        return false;
    }
}

