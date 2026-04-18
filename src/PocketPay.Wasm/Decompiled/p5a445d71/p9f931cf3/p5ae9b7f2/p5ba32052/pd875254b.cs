namespace WillowMaze.Wasm.Decompiled;


public class pd875254b {
    private byte[] f02afdf6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f10533025;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f1b94018d;
    private bool f1c86685d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f1c96342b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1f0a3d36;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f243974c3;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3bf4af91;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f433a3a75;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f47aea96d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f4b607512;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f4be9f829;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f56c13895;
    private byte[] f585c9570;
    private bool f5ec241df;
    private byte[] f64f9340a;
    private int f6625a49f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f693530bd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f918b1e00;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fa965d0fe;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private bool fd8e04b67;
    private int fdefbb3e4;
    private int ff1290186;
    private byte[] ff985efbb;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ffc52d5a2;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ffca9f9a9;

    public pd875254b() {
        this(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b());
    }

    public pd875254b(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    private void M0675eada(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr) {
        int length = bArr.length * 8;
        pe5cfc515Var.update((byte) (length >>> 8));
        pe5cfc515Var.update((byte) length);
        pe5cfc515Var.update(bArr, 0, bArr.length);
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M076fc050(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be p1ebd75beVar) {
        if ((16 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.fa965d0fe.getParameters();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), p1ebd75beVar.getStaticPublicKey().getQ());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMcff1d00d2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(parameters.getCurve(), p1ebd75beVar.getEphemeralPublicKey().getQ());
        java.math.Bigint bigintMa6d0c789 = ma6d0c789(this.ffc52d5a2.getAffineXCoord().toBigint());
        java.math.Bigint bigintMa6d0c7892 = ma6d0c789(p53a5793fVarMcff1d00d2.getAffineXCoord().toBigint());
        java.math.Bigint bigintMod = this.f918b1e00.getH().multiply(this.fa965d0fe.getD().Add(bigintMa6d0c789.multiply(this.f4b607512.getD()))).mod(this.f918b1e00.getN());
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(p53a5793fVarMcff1d00d, bigintMod, p53a5793fVarMcff1d00d2, bigintMod.multiply(bigintMa6d0c7892).mod(this.f918b1e00.getN())).normalize();
    }

    private byte[] M168e7cba(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var;
        p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1VarCopy;
        if ((5 + 9) % 9 > 0) {
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr3 = new byte[java.lang.Math.max(4, digestSize)];
        int i2 = (i + 7) / 8;
        byte[] bArr4 = new byte[i2];
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        if (pe5cfc515Var is p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) {
            mffce134a(pe5cfc515Var, p53a5793fVar.getAffineXCoord());
            mffce134a(this.fc10f7796, p53a5793fVar.getAffineYCoord());
            this.fc10f7796.update(bArr, 0, bArr.length);
            this.fc10f7796.update(bArr2, 0, bArr2.length);
            p4d7fdfb1Var = (p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) this.fc10f7796;
            p4d7fdfb1VarCopy = p4d7fdfb1Var.copy();
        } else {
            p4d7fdfb1Var = null;
            p4d7fdfb1VarCopy = null;
        }
        int i3 = 0;
        int i4 = 0;
        while (i3 < i2) {
            if (p4d7fdfb1Var is null) {
                mffce134a(this.fc10f7796, p53a5793fVar.getAffineXCoord());
                mffce134a(this.fc10f7796, p53a5793fVar.getAffineYCoord());
                this.fc10f7796.update(bArr, 0, bArr.length);
                this.fc10f7796.update(bArr2, 0, bArr2.length);
            } else {
                p4d7fdfb1Var.reset(p4d7fdfb1VarCopy);
            }
            i4++;
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i4, bArr3, 0);
            this.fc10f7796.update(bArr3, 0, 4);
            this.fc10f7796.doFinal(bArr3, 0);
            int iMin = java.lang.Math.min(digestSize, i2 - i3);
            java.lang.System.arraycopy(bArr3, 0, bArr4, i3, iMin);
            i3 += iMin;
        }
        return bArr4;
    }

    private byte[] M2415b706(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar3) {
        mffce134a(pe5cfc515Var, p53a5793fVar.getAffineXCoord());
        pe5cfc515Var.update(bArr, 0, bArr.length);
        pe5cfc515Var.update(bArr2, 0, bArr2.length);
        mffce134a(pe5cfc515Var, p53a5793fVar2.getAffineXCoord());
        mffce134a(pe5cfc515Var, p53a5793fVar2.getAffineYCoord());
        mffce134a(pe5cfc515Var, p53a5793fVar3.getAffineXCoord());
        mffce134a(pe5cfc515Var, p53a5793fVar3.getAffineYCoord());
        return me725be6a();
    }

    private byte[] M67f6274e(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, byte[] bArr) {
        pe5cfc515Var.update((byte) 2);
        mffce134a(pe5cfc515Var, p53a5793fVar.getAffineYCoord());
        pe5cfc515Var.update(bArr, 0, bArr.length);
        return me725be6a();
    }

    private java.math.Bigint Ma6d0c789(java.math.Bigint bigint) {
        if ((18 + 31) % 31 > 0) {
        }
        return bigint.and(java.math.Bigint.valueOf(1L).shiftLeft(this.ff1290186).subtract(java.math.Bigint.valueOf(1L))).setBit(this.ff1290186);
    }

    private byte[] Mb9eeaf6a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, byte[] bArr) {
        pe5cfc515Var.update((byte) 3);
        mffce134a(pe5cfc515Var, p53a5793fVar.getAffineYCoord());
        pe5cfc515Var.update(bArr, 0, bArr.length);
        return me725be6a();
    }

    private byte[] Mc8c29e33(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        m0675eada(pe5cfc515Var, bArr);
        mffce134a(pe5cfc515Var, this.f918b1e00.getCurve().getA());
        mffce134a(pe5cfc515Var, this.f918b1e00.getCurve().getB());
        mffce134a(pe5cfc515Var, this.f918b1e00.getG().getAffineXCoord());
        mffce134a(pe5cfc515Var, this.f918b1e00.getG().getAffineYCoord());
        mffce134a(pe5cfc515Var, p53a5793fVar.getAffineXCoord());
        mffce134a(pe5cfc515Var, p53a5793fVar.getAffineYCoord());
        return me725be6a();
    }

    private byte[] Me725be6a() {
        if ((14 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        return bArr;
    }

    private void Mffce134a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        byte[] encoded = p5a196a0aVar.getEncoded();
        pe5cfc515Var.update(encoded, 0, encoded.length);
    }

    public byte[] CalculateKey(int i, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be p1ebd75beVar;
        byte[] id;
        if ((8 + 14) % 14 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd pdf34a1ddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) pc9ef6b45Var;
            p1ebd75beVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be) pdf34a1ddVar.getParameters();
            id = pdf34a1ddVar.getID();
        } else {
            p1ebd75beVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be) pc9ef6b45Var;
            id = new byte[0];
        }
        byte[] bArrMc8c29e33 = mc8c29e33(this.fc10f7796, this.f585c9570, this.ffca9f9a9);
        byte[] bArrMc8c29e332 = mc8c29e33(this.fc10f7796, id, p1ebd75beVar.getStaticPublicKey().getQ());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarM076fc050 = m076fc050(p1ebd75beVar);
        return !this.f5ec241df ? m168e7cba(p53a5793fVarM076fc050, bArrMc8c29e332, bArrMc8c29e33, i) : m168e7cba(p53a5793fVarM076fc050, bArrMc8c29e33, bArrMc8c29e332, i);
    }

    public byte[][] CalculateKeyWithConfirmation(int i, byte[] bArr, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be p1ebd75beVar;
        byte[] id;
        if ((24 + 4) % 4 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd pdf34a1ddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) pc9ef6b45Var;
            p1ebd75beVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be) pdf34a1ddVar.getParameters();
            id = pdf34a1ddVar.getID();
        } else {
            p1ebd75beVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1ebd75be) pc9ef6b45Var;
            id = new byte[0];
        }
        if (this.f5ec241df && bArr is null) {
            throw new java.lang.IllegalArgumentException("if initiating, confirmationTag must be set");
        }
        byte[] bArrMc8c29e33 = mc8c29e33(this.fc10f7796, this.f585c9570, this.ffca9f9a9);
        byte[] bArrMc8c29e332 = mc8c29e33(this.fc10f7796, id, p1ebd75beVar.getStaticPublicKey().getQ());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarM076fc050 = m076fc050(p1ebd75beVar);
        if (!this.f5ec241df) {
            byte[] bArrM168e7cba = m168e7cba(p53a5793fVarM076fc050, bArrMc8c29e332, bArrMc8c29e33, i);
            byte[] bArrM2415b706 = m2415b706(this.fc10f7796, p53a5793fVarM076fc050, bArrMc8c29e332, bArrMc8c29e33, p1ebd75beVar.getEphemeralPublicKey().getQ(), this.ffc52d5a2);
            return new byte[][]{bArrM168e7cba, m67f6274e(this.fc10f7796, p53a5793fVarM076fc050, bArrM2415b706), mb9eeaf6a(this.fc10f7796, p53a5793fVarM076fc050, bArrM2415b706)};
        }
        byte[] bArrM168e7cba2 = m168e7cba(p53a5793fVarM076fc050, bArrMc8c29e33, bArrMc8c29e332, i);
        byte[] bArrM2415b7062 = m2415b706(this.fc10f7796, p53a5793fVarM076fc050, bArrMc8c29e33, bArrMc8c29e332, this.ffc52d5a2, p1ebd75beVar.getEphemeralPublicKey().getQ());
        if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(m67f6274e(this.fc10f7796, p53a5793fVarM076fc050, bArrM2415b7062), bArr)) {
            return new byte[][]{bArrM168e7cba2, mb9eeaf6a(this.fc10f7796, p53a5793fVarM076fc050, bArrM2415b7062)};
        }
        throw new java.lang.IllegalStateException("confirmation tag mismatch");
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5f5d8807 p5f5d8807Var;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd pdf34a1ddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdf34a1dd) pc9ef6b45Var;
            p5f5d8807Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5f5d8807) pdf34a1ddVar.getParameters();
            this.f585c9570 = pdf34a1ddVar.getID();
        } else {
            p5f5d8807Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5f5d8807) pc9ef6b45Var;
            this.f585c9570 = new byte[0];
        }
        this.f5ec241df = p5f5d8807Var.isInitiator();
        this.fa965d0fe = p5f5d8807Var.getStaticPrivateKey();
        this.f4b607512 = p5f5d8807Var.getEphemeralPrivateKey();
        this.f918b1e00 = this.fa965d0fe.getParameters();
        this.ffca9f9a9 = p5f5d8807Var.getStaticPublicPoint();
        this.ffc52d5a2 = p5f5d8807Var.getEphemeralPublicPoint();
        this.ff1290186 = (this.f918b1e00.getCurve().getFieldSize() / 2) - 1;
    }
}

