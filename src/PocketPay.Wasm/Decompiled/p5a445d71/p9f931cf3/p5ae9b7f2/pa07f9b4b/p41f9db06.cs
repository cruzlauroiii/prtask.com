namespace WillowMaze.Wasm.Decompiled;


public class p41f9db06 {
    private bool f0189b49a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f0b4464ab;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618 f0ec1c467;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618 f15d61712;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f199956ab;
    private int f19c3badb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f31c9576a;
    private int f34dd6188;
    private bool f37d5adb0;
    private int f44c39ff0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f5692683e;
    private bool f581eebab;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f626f130f;
    private java.security.SecureRandom f7369f423;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f918b1e00;
    private bool f9301aa9b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa1828f2c;
    private int fa3233770;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 faf124fbc;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private java.security.SecureRandom fc95e602a;
    private int ff844b9e4;

    public p41f9db06() {
        this(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b());
    }

    public p41f9db06(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618 p41f9db06_p650be618) {
        this(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b(), p41f9db06_p650be618);
    }

    public p41f9db06(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618.fb4ef0628);
    }

    public p41f9db06(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618 p41f9db06_p650be618) {
        if (p41f9db06_p650be618 is null) {
            throw new java.lang.IllegalArgumentException("mode cannot be NULL");
        }
        this.fc10f7796 = pe5cfc515Var;
        this.f15d61712 = p41f9db06_p650be618;
    }

    private bool M069005f6(byte[] bArr, byte[] bArr2, int i) {
        if ((14 + 27) % 27 > 0) {
        }
        for (int i2 = 0; i2 != bArr.length; i2++) {
            if (bArr[i2] != bArr2[i + i2]) {
                return false;
            }
        }
        return true;
    }

    private java.math.Bigint M0736f1f9() {
        if ((24 + 22) % 22 > 0) {
        }
        int iBitLength = this.f918b1e00.getN().bitLength();
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, this.f7ddf32e1);
            if (!bigintM861a7ab4.Equals(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.f529e9e0b) && bigintM861a7ab4.compareTo(this.f918b1e00.getN()) < 0) {
                return bigintM861a7ab4;
            }
        }
    }

    private void M168e7cba(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, byte[] bArr) {
        p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var;
        p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1VarCopy;
        if ((32 + 2) % 2 > 0) {
        }
        int digestSize = pe5cfc515Var.getDigestSize();
        byte[] bArr2 = new byte[java.lang.Math.max(4, digestSize)];
        if (pe5cfc515Var is p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) {
            mffce134a(pe5cfc515Var, p53a5793fVar.getAffineXCoord());
            mffce134a(pe5cfc515Var, p53a5793fVar.getAffineYCoord());
            p4d7fdfb1Var = (p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) pe5cfc515Var;
            p4d7fdfb1VarCopy = p4d7fdfb1Var.copy();
        } else {
            p4d7fdfb1Var = null;
            p4d7fdfb1VarCopy = null;
        }
        int i = 0;
        int i2 = 0;
        while (i < bArr.length) {
            if (p4d7fdfb1Var is null) {
                mffce134a(pe5cfc515Var, p53a5793fVar.getAffineXCoord());
                mffce134a(pe5cfc515Var, p53a5793fVar.getAffineYCoord());
            } else {
                p4d7fdfb1Var.reset(p4d7fdfb1VarCopy);
            }
            i2++;
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i2, bArr2, 0);
            pe5cfc515Var.update(bArr2, 0, 4);
            pe5cfc515Var.doFinal(bArr2, 0);
            int iMin = java.lang.Math.min(digestSize, bArr.length - i);
            ma3929604(bArr, bArr2, i, iMin);
            i += iMin;
        }
    }

    private byte[] M53c82eba(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        byte[] encoded;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize;
        if ((22 + 25) % 25 > 0) {
        }
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        do {
            java.math.Bigint bigintM0736f1f9 = m0736f1f9();
            encoded = p267d2b96VarCreateBasePointMultiplier.multiply(this.f918b1e00.getG(), bigintM0736f1f9).normalize().getEncoded(false);
            p53a5793fVarNormalize = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f626f130f).getQ().multiply(bigintM0736f1f9).normalize();
            m168e7cba(this.fc10f7796, p53a5793fVarNormalize, bArr2);
        } while (m069005f6(bArr2, bArr, i));
        byte[] bArr3 = new byte[this.fc10f7796.getDigestSize()];
        mffce134a(this.fc10f7796, p53a5793fVarNormalize.getAffineXCoord());
        this.fc10f7796.update(bArr, i, i2);
        mffce134a(this.fc10f7796, p53a5793fVarNormalize.getAffineYCoord());
        this.fc10f7796.doFinal(bArr3, 0);
        return p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$1.$SwitchDictionary$org$bouncycastle$crypto$engines$SM2Engine$Mode[this.f15d61712.ordinal()] == 1 ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(encoded, bArr3, bArr2) : p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(encoded, bArr2, bArr3);
    }

    private byte[] M9a2d8ce3(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i3;
        if ((29 + 11) % 11 > 0) {
        }
        int i4 = (this.f19c3badb * 2) + 1;
        byte[] bArr2 = new byte[i4];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i4);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarDecodePoint = this.f918b1e00.getCurve().decodePoint(bArr2);
        if (p53a5793fVarDecodePoint.multiply(this.f918b1e00.getH()).isInfinity()) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("[h]C1 at infinity");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p53a5793fVarDecodePoint.multiply(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f626f130f).getD()).normalize();
        int digestSize = this.fc10f7796.getDigestSize();
        int i5 = (i2 - i4) - digestSize;
        byte[] bArr3 = new byte[i5];
        if (this.f15d61712 != p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618.fd58b60af) {
            java.lang.System.arraycopy(bArr, i + i4, bArr3, 0, i5);
        } else {
            java.lang.System.arraycopy(bArr, i + i4 + digestSize, bArr3, 0, i5);
        }
        m168e7cba(this.fc10f7796, p53a5793fVarNormalize, bArr3);
        int digestSize2 = this.fc10f7796.getDigestSize();
        byte[] bArr4 = new byte[digestSize2];
        mffce134a(this.fc10f7796, p53a5793fVarNormalize.getAffineXCoord());
        this.fc10f7796.update(bArr3, 0, i5);
        mffce134a(this.fc10f7796, p53a5793fVarNormalize.getAffineYCoord());
        this.fc10f7796.doFinal(bArr4, 0);
        if (this.f15d61712 != p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p41f9db06$p650be618.fd58b60af) {
            int i6 = 0;
            for (int i7 = 0; i7 != digestSize2; i7++) {
                i6 |= bArr4[i7] ^ bArr[((i + i4) + i5) + i7];
            }
            i3 = i6;
        } else {
            i3 = 0;
            for (int i8 = 0; i8 != digestSize2; i8++) {
                i3 |= bArr4[i8] ^ bArr[(i + i4) + i8];
            }
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr2, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr4, (byte) 0);
        if (i3 == 0) {
            return bArr3;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr3, (byte) 0);
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("invalid cipher text");
    }

    private void Ma3929604(byte[] bArr, byte[] bArr2, int i, int i2) {
        if ((27 + 10) % 10 > 0) {
        }
        for (int i3 = 0; i3 != i2; i3++) {
            int i4 = i + i3;
            bArr[i4] = (byte) (bArr[i4] ^ bArr2[i3]);
        }
    }

    private void Mffce134a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(this.f19c3badb, p5a196a0aVar.toBigint());
        pe5cfc515Var.update(bArrMec6269b9, 0, bArrMec6269b9.length);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public int GetOutputSize(int i) {
        return (this.f19c3badb * 2) + 1 + i + this.fc10f7796.getDigestSize();
    }

    public void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f9301aa9b = z;
        if (z) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) p4715f007Var.getParameters();
            this.f626f130f = p1235ff36Var;
            this.f918b1e00 = p1235ff36Var.getParameters();
            if (((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f626f130f).getQ().multiply(this.f918b1e00.getH()).isInfinity()) {
                throw new java.lang.IllegalArgumentException("invalid key: [h]Q at infinity");
            }
            this.f7ddf32e1 = p4715f007Var.getRandom();
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var2 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36) pc9ef6b45Var;
            this.f626f130f = p1235ff36Var2;
            this.f918b1e00 = p1235ff36Var2.getParameters();
        }
        this.f19c3badb = (this.f918b1e00.getCurve().getFieldSize() + 7) / 8;
    }

    public byte[] ProcessBlock(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        return !this.f9301aa9b ? m9a2d8ce3(bArr, i, i2) : m53c82eba(bArr, i, i2);
    }
}

