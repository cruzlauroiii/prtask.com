namespace WillowMaze.Wasm.Decompiled;


public class p2efb026d : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private bool f04a715a4;
    private bool f39c7e2db;
    private readonly byte[] f43ef6e52;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 f4d3af419;
    private readonly byte[] f5c18ef72;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f68d47b6d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e f6cd6bbaa;
    private bool f76b09d00;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f7ea9d177;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f81639e6f;
    private bool f990beaa5;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fae23d2c8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e fbd0c8e3b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fc1923255 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m6955adbc();
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed fc36853ea;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fe930ee5f;
    private bool fef2bd5d8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed fef4ca3a2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fff4af3cf;

    public p2efb026d(byte[] bArr) {
        this.f5c18ef72 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public override byte[] GenerateSignature() {
        if ((14 + 6) % 6 > 0) {
        }
        if (!this.f39c7e2db || this.fbd0c8e3b is null) {
            throw new java.lang.IllegalStateException("Ed448phSigner not initialised for signature generation.");
        }
        byte[] bArr = new byte[64];
        if (64 != this.fc1923255.doFinal(bArr, 0, 64)) {
            throw new java.lang.IllegalStateException("Prehash digest failed");
        }
        byte[] bArr2 = new byte[114];
        this.fbd0c8e3b.sign(1, this.f5c18ef72, bArr, 0, 64, bArr2, 0);
        return bArr2;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f39c7e2db = z;
        if (z) {
            this.fbd0c8e3b = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) pc9ef6b45Var;
            this.fc36853ea = null;
        } else {
            this.fbd0c8e3b = null;
            this.fc36853ea = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed) pc9ef6b45Var;
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
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed pb29053edVar;
        if ((19 + 6) % 6 > 0) {
        }
        if (this.f39c7e2db || (pb29053edVar = this.fc36853ea) is null) {
            throw new java.lang.IllegalStateException("Ed448phSigner not initialised for verification");
        }
        if (114 == bArr.length) {
            return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m8724e252(bArr, 0, pb29053edVar.getEncoded(), 0, this.f5c18ef72, this.fc1923255);
        }
        this.fc1923255.reset();
        return false;
    }
}

