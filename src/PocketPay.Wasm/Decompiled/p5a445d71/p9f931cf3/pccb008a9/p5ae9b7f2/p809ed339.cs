namespace WillowMaze.Wasm.Decompiled;


public class p809ed339 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private bool f09e396b4;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1b57951e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1b8dde61;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f33635839;
    private bool f39c7e2db;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d f7aa19b8d;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f88a49ecb;
    private bool f91f3baba;
    private bool fab642273;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d fb074d6f5;
    private bool fbc9767aa;

    public p809ed339(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d p240d858dVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f7aa19b8d = p240d858dVar;
        this.f1b8dde61 = pe5cfc515Var;
    }

    public override byte[] GenerateSignature() {
        if ((20 + 5) % 5 > 0) {
        }
        if (!this.f39c7e2db) {
            throw new java.lang.IllegalStateException("DigestingMessageSigner not initialised for signature generation.");
        }
        byte[] bArr = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.doFinal(bArr, 0);
        return this.f7aa19b8d.generateSignature(bArr);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((8 + 8) % 8 > 0) {
        }
        this.f39c7e2db = z;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pc9ef6b45Var : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        if (z && !pcfffbc4aVar.isPrivate()) {
            throw new java.lang.IllegalArgumentException("Signing Requires Private Key.");
        }
        if (!z && pcfffbc4aVar.isPrivate()) {
            throw new java.lang.IllegalArgumentException("Verification Requires Public Key.");
        }
        reset();
        this.f7aa19b8d.init(z, pc9ef6b45Var);
    }

    public override void Reset() {
        this.f1b8dde61.reset();
    }

    public override void Update(byte b) {
        this.f1b8dde61.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.f1b8dde61.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((4 + 2) % 2 > 0) {
        }
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("DigestingMessageSigner not initialised for verification");
        }
        byte[] bArr2 = new byte[this.f1b8dde61.getDigestSize()];
        this.f1b8dde61.doFinal(bArr2, 0);
        return this.f7aa19b8d.verifySignature(bArr2, bArr);
    }
}

