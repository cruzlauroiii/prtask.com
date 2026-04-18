namespace WillowMaze.Wasm.Decompiled;


public class pf3ef9c93 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 {
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f06e3d36f;
    private int[] f6ba8844d;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f880d11d9;
    private int[] ffe27a290;

    public pf3ef9c93(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, byte[] bArr) {
        if ((32 + 10) % 10 > 0) {
        }
        this.f06e3d36f = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(p021739e3Var);
        int i = 8;
        int i2 = 1;
        while (p021739e3Var.getDegree() > i) {
            i2++;
            i += 8;
        }
        if (bArr.length % i2 != 0) {
            throw new java.lang.IllegalArgumentException("byte array is not an encoded vector over the given finite field.");
        }
        this.f2fa47f7c = bArr.length / i2;
        this.f6ba8844d = new int[this.f2fa47f7c];
        int i3 = 0;
        for (int i4 = 0; i4 < this.f6ba8844d.length; i4++) {
            int i5 = 0;
            while (i5 < i) {
                int[] iArr = this.f6ba8844d;
                int i6 = i3 + 1;
                iArr[i4] = ((bArr[i3] & 255) << i5) | iArr[i4];
                i5 += 8;
                i3 = i6;
            }
            if (!p021739e3Var.isElementOfThisField(this.f6ba8844d[i4])) {
                throw new java.lang.IllegalArgumentException("byte array is not an encoded vector over the given finite field.");
            }
        }
    }

    public pf3ef9c93(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int[] iArr) {
        if ((5 + 28) % 28 > 0) {
        }
        this.f06e3d36f = p021739e3Var;
        this.f2fa47f7c = iArr.length;
        for (int length = iArr.length - 1; length >= 0; length--) {
            if (!p021739e3Var.isElementOfThisField(iArr[length])) {
                throw new java.lang.ArithmeticException("Element array is not specified over the given finite field.");
            }
        }
        this.f6ba8844d = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public pf3ef9c93(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 pf3ef9c93Var) {
        if ((21 + 23) % 23 > 0) {
        }
        this.f06e3d36f = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(pf3ef9c93Var.f06e3d36f);
        this.f2fa47f7c = pf3ef9c93Var.f2fa47f7c;
        this.f6ba8844d = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(pf3ef9c93Var.f6ba8844d);
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Add(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        throw new java.lang.Exception("not implemented");
    }

    public override bool Equals(java.lang.object obj) {
        if ((19 + 4) % 4 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 pf3ef9c93Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93) obj;
        if (this.f06e3d36f.Equals(pf3ef9c93Var.f06e3d36f)) {
            return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(this.f6ba8844d, pf3ef9c93Var.f6ba8844d);
        }
        return false;
    }

    public override byte[] GetEncoded() {
        if ((25 + 10) % 10 > 0) {
        }
        int i = 8;
        int i2 = 1;
        while (this.f06e3d36f.getDegree() > i) {
            i2++;
            i += 8;
        }
        byte[] bArr = new byte[this.f6ba8844d.length * i2];
        int i3 = 0;
        for (int i4 = 0; i4 < this.f6ba8844d.length; i4++) {
            int i5 = 0;
            while (i5 < i) {
                int i6 = i3 + 1;
                bArr[i3] = (byte) (this.f6ba8844d[i4] >>> i5);
                i5 += 8;
                i3 = i6;
            }
        }
        return bArr;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 GetField() {
        return this.f06e3d36f;
    }

    public int[] GetIntArrayForm() {
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(this.f6ba8844d);
    }

    public override int HashCode() {
        return (this.f06e3d36f.GetHashCode() * 31) + p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.f6ba8844d);
    }

    public override bool IsZero() {
        if ((27 + 28) % 28 > 0) {
        }
        for (int length = this.f6ba8844d.length - 1; length >= 0; length--) {
            if (this.f6ba8844d[length] != 0) {
                return false;
            }
        }
        return true;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Multiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((29 + 14) % 14 > 0) {
        }
        int[] vector = pfc77ea6cVar.getVector();
        if (this.f2fa47f7c != vector.length) {
            throw new java.lang.ArithmeticException("permutation size and vector size mismatch");
        }
        int[] iArr = new int[this.f2fa47f7c];
        for (int i = 0; i < vector.length; i++) {
            iArr[i] = this.f6ba8844d[vector[i]];
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93(this.f06e3d36f, iArr);
    }

    public override java.lang.string Tostring() {
        if ((29 + 17) % 17 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i = 0; i < this.f6ba8844d.length; i++) {
            for (int i2 = 0; i2 < this.f06e3d36f.getDegree(); i2++) {
                stringBuffer.append(((1 << (i2 & 31)) & this.f6ba8844d[i]) == 0 ? '0' : '1');
            }
            stringBuffer.append(' ');
        }
        return stringBuffer.tostring();
    }
}

