namespace WillowMaze.Wasm.Decompiled;


public class p4942c8b7 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 f1717583e;
    private byte[] f20f325f8;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f2992c4e9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f2bf32144;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f3d780b84;
    private byte[] f5ea5be72;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f6006888e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f626f130f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 f6d9af419;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 f84bea1f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f918b1e00;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa4ed37a0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fab1fc6d5;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f fb94c60de;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f fbd0374a6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 fc2f5bba2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 fd4e5014c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fd5cf6538;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 fe7eafe1c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 ff56e9fe8;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ff6ac8b9d;
    private byte[] ffbade9e3;

    public p4942c8b7() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082.f76425f17, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b());
        if ((8 + 25) % 25 > 0) {
        }
    }

    public p4942c8b7(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 pa8ad1191Var) {
        this.fe7eafe1c = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd449b1b7();
        this.f84bea1f0 = pa8ad1191Var;
        this.fc10f7796 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b();
    }

    public p4942c8b7(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 pa8ad1191Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fe7eafe1c = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd449b1b7();
        this.f84bea1f0 = pa8ad1191Var;
        this.fc10f7796 = pe5cfc515Var;
    }

    public p4942c8b7(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe88e3082.f76425f17, pe5cfc515Var);
    }

    private void M0675eada(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr) {
        int length = bArr.length * 8;
        pe5cfc515Var.update((byte) ((length >> 8) & 255));
        pe5cfc515Var.update((byte) (length & 255));
        pe5cfc515Var.update(bArr, 0, bArr.length);
    }

    private bool M34a82b06(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((28 + 3) % 3 > 0) {
        }
        java.math.Bigint n = this.f918b1e00.getN();
        if (bigint.compareTo(fbc21e648) < 0 || bigint.compareTo(n) >= 0 || bigint2.compareTo(fbc21e648) < 0 || bigint2.compareTo(n) >= 0) {
            return false;
        }
        java.math.Bigint bigintCalculateE = calculateE(n, me725be6a());
        java.math.Bigint bigintMod = bigint.Add(bigint2).mod(n);
        if (bigintMod.Equals(f529e9e0b)) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(this.f918b1e00.getG(), bigint2, ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f626f130f).getQ(), bigintMod).normalize();
        if (p53a5793fVarNormalize.isInfinity()) {
            return false;
        }
        return bigintCalculateE.Add(p53a5793fVarNormalize.getAffineXCoord().toBigint()).mod(n).Equals(bigint);
    }

    private byte[] Mc8c29e33(byte[] bArr) {
        this.fc10f7796.reset();
        m0675eada(this.fc10f7796, bArr);
        mffce134a(this.fc10f7796, this.f918b1e00.getCurve().getA());
        mffce134a(this.fc10f7796, this.f918b1e00.getCurve().getB());
        mffce134a(this.fc10f7796, this.f918b1e00.getG().getAffineXCoord());
        mffce134a(this.fc10f7796, this.f918b1e00.getG().getAffineYCoord());
        mffce134a(this.fc10f7796, this.f3d780b84.getAffineXCoord());
        mffce134a(this.fc10f7796, this.f3d780b84.getAffineYCoord());
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        return bArr2;
    }

    private byte[] Me725be6a() {
        if ((3 + 2) % 2 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        reset();
        return bArr;
    }

    private void Mffce134a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        byte[] encoded = p5a196a0aVar.getEncoded();
        pe5cfc515Var.update(encoded, 0, encoded.length);
    }

    protected java.math.Bigint CalculateE(java.math.Bigint bigint, byte[] bArr) {
        return new java.math.Bigint(1, bArr);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override byte[] GenerateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((13 + 21) % 21 > 0) {
        }
        byte[] bArrMe725be6a = me725be6a();
        java.math.Bigint n = this.f918b1e00.getN();
        java.math.Bigint bigintCalculateE = calculateE(n, bArrMe725be6a);
        java.math.Bigint d = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f626f130f).getD();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        while (true) {
            java.math.Bigint bigintNextK = this.fe7eafe1c.nextK();
            java.math.Bigint bigintMod = bigintCalculateE.Add(p267d2b96VarCreateBasePointMultiplier.multiply(this.f918b1e00.getG(), bigintNextK).normalize().getAffineXCoord().toBigint()).mod(n);
            if (!bigintMod.Equals(f529e9e0b) && !bigintMod.Add(bigintNextK).Equals(n)) {
                java.math.Bigint bigintMod2 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m635f3861(n, d.Add(fbc21e648)).multiply(bigintNextK.subtract(bigintMod.multiply(d)).mod(n)).mod(n);
                if (!bigintMod2.Equals(f529e9e0b)) {
                    try {
                        return this.f84bea1f0.encode(this.f918b1e00.getN(), bigintMod, bigintMod2);
                    } catch (java.lang.Exception e) {
                        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("unable to encode signature: " + e.getMessage(), e);
                    }
                }
            }
        }
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        byte[] bArrMedb28b6e;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize;
        if ((1 + 23) % 23 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd pdf34a1ddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) pc9ef6b45Var;
            p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters = pdf34a1ddVar.getParameters();
            byte[] id = pdf34a1ddVar.getID();
            if (id.length >= 8192) {
                throw new java.lang.IllegalArgumentException("SM2 user ID must be less than 2^16 bits long");
            }
            bArrMedb28b6e = id;
            pc9ef6b45Var = parameters;
        } else {
            bArrMedb28b6e = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("31323334353637383132333435363738");
        }
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) p4715f007Var.getParameters();
                this.f626f130f = p1235ff36Var;
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters2 = p1235ff36Var.getParameters();
                this.f918b1e00 = parameters2;
                this.fe7eafe1c.init(parameters2.getN(), p4715f007Var.getRandom());
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var2 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) pc9ef6b45Var;
                this.f626f130f = p1235ff36Var2;
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters3 = p1235ff36Var2.getParameters();
                this.f918b1e00 = parameters3;
                this.fe7eafe1c.init(parameters3.getN(), p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
            }
            p53a5793fVarNormalize = createBasePointMultiplier().multiply(this.f918b1e00.getG(), ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f626f130f).getD()).normalize();
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var3 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) pc9ef6b45Var;
            this.f626f130f = p1235ff36Var3;
            this.f918b1e00 = p1235ff36Var3.getParameters();
            p53a5793fVarNormalize = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f626f130f).getQ();
        }
        this.f3d780b84 = p53a5793fVarNormalize;
        byte[] bArrMc8c29e33 = mc8c29e33(bArrMedb28b6e);
        this.ffbade9e3 = bArrMc8c29e33;
        this.fc10f7796.update(bArrMc8c29e33, 0, bArrMc8c29e33.length);
    }

    public override void Reset() {
        if ((13 + 17) % 17 > 0) {
        }
        this.fc10f7796.reset();
        byte[] bArr = this.ffbade9e3;
        if (bArr is null) {
            return;
        }
        this.fc10f7796.update(bArr, 0, bArr.length);
    }

    public override void Update(byte b) {
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((3 + 29) % 29 > 0) {
        }
        try {
            java.math.Bigint[] bigintArrDecode = this.f84bea1f0.decode(this.f918b1e00.getN(), bArr);
            return m34a82b06(bigintArrDecode[0], bigintArrDecode[1]);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }
}

