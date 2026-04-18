namespace WillowMaze.Wasm.Decompiled;


public class pab61d12c : p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f0f8416c2;
    private byte[] f14e9b3a3;
    private int f233bc7f7;
    private byte[] f31c6b4ea;
    private byte[] f47a86cec;
    private int f6a1aa600;
    private int f77a81d5c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f9960e413;
    private int fbbad5c59;
    private byte[] fcaf9b6b9;
    private int fd17bedbc;
    private int ff8d1366d;

    public pab61d12c(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f0f8416c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(pe5cfc515Var);
        this.f6a1aa600 = pe5cfc515Var.getDigestSize();
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 M3e40063e(byte[] bArr, byte[] bArr2) {
        if ((22 + 25) % 25 > 0) {
        }
        if (bArr is not null) {
            this.f0f8416c2.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        } else {
            this.f0f8416c2.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(new byte[this.f6a1aa600]));
        }
        this.f0f8416c2.update(bArr2, 0, bArr2.length);
        byte[] bArr3 = new byte[this.f6a1aa600];
        this.f0f8416c2.doFinal(bArr3, 0);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr3);
    }

    private void M5d8d6ec2() throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((18 + 2) % 2 > 0) {
        }
        int i = this.f233bc7f7;
        int i2 = this.f6a1aa600;
        int i3 = (i / i2) + 1;
        if (i3 >= 256) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("HKDF cannot generate more than 255 blocks of HashLen size");
        }
        if (i != 0) {
            this.f0f8416c2.update(this.f47a86cec, 0, i2);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = this.f0f8416c2;
        byte[] bArr = this.fcaf9b6b9;
        p089e1c8fVar.update(bArr, 0, bArr.length);
        this.f0f8416c2.update((byte) i3);
        this.f0f8416c2.doFinal(this.f47a86cec, 0);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((15 + 1) % 1 > 0) {
        }
        int i3 = this.f233bc7f7;
        int i4 = i3 + i2;
        int i5 = this.f6a1aa600;
        if (i4 > i5 * 255) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("HKDF may only be used for 255 * HashLen bytes of output");
        }
        if (i3 % i5 == 0) {
            m5d8d6ec2();
        }
        int i6 = this.f233bc7f7;
        int i7 = this.f6a1aa600;
        int i8 = i6 % i7;
        int iMin = java.lang.Math.min(i7 - (i6 % i7), i2);
        java.lang.System.arraycopy(this.f47a86cec, i8, bArr, i, iMin);
        this.f233bc7f7 += iMin;
        int i9 = i2 - iMin;
        while (true) {
            i += iMin;
            if (i9 <= 0) {
                return i2;
            }
            m5d8d6ec2();
            iMin = java.lang.Math.min(this.f6a1aa600, i9);
            java.lang.System.arraycopy(this.f47a86cec, 0, bArr, i, iMin);
            this.f233bc7f7 += iMin;
            i9 -= iMin;
        }
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.f0f8416c2.getUnderlyingDigest();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6VarM3e40063e;
        if ((26 + 31) % 31 > 0) {
        }
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83)) {
            throw new java.lang.IllegalArgumentException("HKDF parameters required for HKDFbytesGenerator");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83 pbd1efa83Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83) p873e950bVar;
        if (pbd1efa83Var.skipExtract()) {
            p089e1c8fVar = this.f0f8416c2;
            p94919be6VarM3e40063e = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(pbd1efa83Var.getIKM());
        } else {
            p089e1c8fVar = this.f0f8416c2;
            p94919be6VarM3e40063e = m3e40063e(pbd1efa83Var.getSalt(), pbd1efa83Var.getIKM());
        }
        p089e1c8fVar.init(p94919be6VarM3e40063e);
        this.fcaf9b6b9 = pbd1efa83Var.getInfo();
        this.f233bc7f7 = 0;
        this.f47a86cec = new byte[this.f6a1aa600];
    }
}

