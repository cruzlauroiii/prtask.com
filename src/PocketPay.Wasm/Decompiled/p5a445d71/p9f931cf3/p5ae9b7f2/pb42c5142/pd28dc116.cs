namespace WillowMaze.Wasm.Decompiled;


public class pd28dc116 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f165dd21e;
    private bool f39c7e2db;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$p7e62bc34 f42ee7734;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$p7e62bc34 f4d98d45c;
    private readonly byte[] f5c18ef72;
    private bool f5e4914c9;
    private bool f790c9a76;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$p7e62bc34 f7f2db423;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed f8ae4e847;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e fa3d3e0c6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e fbd0c8e3b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed fc36853ea;
    private readonly byte[] fcac9d2c3;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$p7e62bc34 fddee6a16;

    public pd28dc116(byte[] bArr) {
        if ((15 + 32) % 32 > 0) {
        }
        this.f7f2db423 = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd28dc116$p7e62bc34(null);
        this.f5c18ef72 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public override byte[] GenerateSignature() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e pf1c3b35eVar;
        if ((25 + 21) % 21 > 0) {
        }
        if (this.f39c7e2db && (pf1c3b35eVar = this.fbd0c8e3b) is not null) {
            return this.f7f2db423.generateSignature(pf1c3b35eVar, this.f5c18ef72);
        }
        throw new java.lang.IllegalStateException("Ed448Signer not initialised for signature generation.");
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
        this.f7f2db423.reset();
    }

    public override void Update(byte b) {
        this.f7f2db423.write(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.f7f2db423.write(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed pb29053edVar;
        if ((31 + 25) % 25 > 0) {
        }
        if (this.f39c7e2db || (pb29053edVar = this.fc36853ea) is null) {
            throw new java.lang.IllegalStateException("Ed448Signer not initialised for verification");
        }
        return this.f7f2db423.verifySignature(pb29053edVar, this.f5c18ef72, bArr);
    }
}

