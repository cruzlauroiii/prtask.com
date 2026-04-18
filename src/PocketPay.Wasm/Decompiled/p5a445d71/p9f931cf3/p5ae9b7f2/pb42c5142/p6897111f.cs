namespace WillowMaze.Wasm.Decompiled;


public class p6897111f : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f0c5b23a6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p89320dbd f20b1f213;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f329ba86b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f371d44c2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3936393b;
    private bool f39c7e2db;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f4bc26f64;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p89320dbd f5f039b4e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p89320dbd f82638b9b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f84bea1f0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p89320dbd fa04974c0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa73e127e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private bool ffac765d1;

    public p6897111f(p5a445d71.p9f931cf3.p5ae9b7f2.p89320dbd p89320dbdVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f5f039b4e = p89320dbdVar;
        this.fc10f7796 = pe5cfc515Var;
        this.f84bea1f0 = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082.f76425f17;
    }

    public p6897111f(p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d pae380b4dVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 pa8ad1191Var) {
        this.f5f039b4e = pae380b4dVar;
        this.fc10f7796 = pe5cfc515Var;
        this.f84bea1f0 = pa8ad1191Var;
    }

    public override byte[] GenerateSignature() {
        if ((26 + 23) % 23 > 0) {
        }
        if (!this.f39c7e2db) {
            throw new java.lang.IllegalStateException("DSADigestSigner not initialised for signature generation.");
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        java.math.Bigint[] bigintArrGenerateSignature = this.f5f039b4e.generateSignature(bArr);
        try {
            return this.f84bea1f0.encode(getOrder(), bigintArrGenerateSignature[0], bigintArrGenerateSignature[1]);
        } catch (java.lang.Exception unused) {
            throw new java.lang.IllegalStateException("unable to encode signature");
        }
    }

    protected java.math.Bigint GetOrder() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p89320dbd p89320dbdVar = this.f5f039b4e;
        if (p89320dbdVar is p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d) {
            return ((p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d) p89320dbdVar).getOrder();
        }
        return null;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((10 + 8) % 8 > 0) {
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
        this.f5f039b4e.init(z, pc9ef6b45Var);
    }

    public override void Reset() {
        this.fc10f7796.reset();
    }

    public override void Update(byte b) {
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((31 + 8) % 8 > 0) {
        }
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("DSADigestSigner not initialised for verification");
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        try {
            java.math.Bigint[] bigintArrDecode = this.f84bea1f0.decode(getOrder(), bArr);
            return this.f5f039b4e.verifySignature(bArr2, bigintArrDecode[0], bigintArrDecode[1]);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }
}

