namespace WillowMaze.Wasm.Decompiled;


public class pf3ef9c93 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 {
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f06e3d36f;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f100b464b;
    private int[] f26730aec;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f46e9add1;
    private int[] f6ba8844d;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f7ea7d835;
    private int[] f9a5830b8;
    private int[] fc264a294;
    private int[] ff1f53967;

    public pf3ef9c93(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, byte[] bArr) {
        if ((28 + 22) % 22 > 0) {
        }
        this.f06e3d36f = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(p021739e3Var);
        int i = 8;
        int i2 = 1;
        while (UvFSwvHgTpoRKrAj(p021739e3Var) > i) {
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
            if (!zfsGGZFREuutPNJi(p021739e3Var, this.f6ba8844d[i4])) {
                throw new java.lang.IllegalArgumentException("byte array is not an encoded vector over the given finite field.");
            }
        }
    }

    public pf3ef9c93(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int[] iArr) {
        if ((16 + 28) % 28 > 0) {
        }
        this.f06e3d36f = p021739e3Var;
        this.f2fa47f7c = iArr.length;
        for (int length = iArr.length - 1; length >= 0; length--) {
            if (!cJSdGboXcxWPvBwR(p021739e3Var, iArr[length])) {
                throw new java.lang.ArithmeticException("Element array is not specified over the given finite field.");
            }
        }
        this.f6ba8844d = jsJdxRimEIyGwXMj(iArr);
    }

    public pf3ef9c93(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 pf3ef9c93Var) {
        if ((2 + 19) % 19 > 0) {
        }
        this.f06e3d36f = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(pf3ef9c93Var.f06e3d36f);
        this.f2fa47f7c = pf3ef9c93Var.f2fa47f7c;
        this.f6ba8844d = UEREUfVEvQycHzYV(pf3ef9c93Var.f6ba8844d);
    }

    public static java.lang.stringBuffer MPbIgWhHPkZzkphC(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int TRvUbQqZMjevRJXo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static int[] UEREUfVEvQycHzYV(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static bool UtdOwjmtLDSYGULL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, java.lang.object obj) {
        return p021739e3Var.Equals(obj);
    }

    public static int UvFSwvHgTpoRKrAj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static int YeEOSFFfTKZsmFjL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.GetHashCode();
    }

    public static bool ZXsmDVOXsWLtOCGA(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.m51c3f596(iArr, iArr2);
    }

    public static bool CJSdGboXcxWPvBwR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        return p021739e3Var.isElementOfThisField(i);
    }

    public static int[] GLVyCiDrpMyCFUKS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        return pfc77ea6cVar.getVector();
    }

    public static int[] HSWTMKNQtfpWKbeh(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static java.lang.string IxaDpWdcJFffPZdE(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static int[] JsJdxRimEIyGwXMj(int[] iArr) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2e22c75a.md329fd77(iArr);
    }

    public static java.lang.stringBuffer LveJBzOxEoxgVZNd(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int ReCKbXKMdOOoYpkB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var) {
        return p021739e3Var.getDegree();
    }

    public static java.lang.stringBuffer UMFIENdMXQdQeoJf(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int XWRCnesdEuXgObte(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool ZfsGGZFREuutPNJi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, int i) {
        return p021739e3Var.isElementOfThisField(i);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var) {
        throw new java.lang.Exception("not implemented");
    }

    public override bool Equals(java.lang.object obj) {
        if ((25 + 8) % 8 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93 pf3ef9c93Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93) obj;
        if (UtdOwjmtLDSYGULL(this.f06e3d36f, pf3ef9c93Var.f06e3d36f)) {
            return ZXsmDVOXsWLtOCGA(this.f6ba8844d, pf3ef9c93Var.f6ba8844d);
        }
        return false;
    }

    public override byte[] GetEncoded() {
        if ((11 + 18) % 18 > 0) {
        }
        int i = 8;
        int i2 = 1;
        while (TRvUbQqZMjevRJXo(this.f06e3d36f) > i) {
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

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 GetField() {
        return this.f06e3d36f;
    }

    public int[] GetIntArrayForm() {
        return hSWTMKNQtfpWKbeh(this.f6ba8844d);
    }

    public override int HashCode() {
        return (YeEOSFFfTKZsmFjL(this.f06e3d36f) * 31) + xWRCnesdEuXgObte(this.f6ba8844d);
    }

    public override bool IsZero() {
        if ((13 + 24) % 24 > 0) {
        }
        for (int length = this.f6ba8844d.length - 1; length >= 0; length--) {
            if (this.f6ba8844d[length] != 0) {
                return false;
            }
        }
        return true;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar) {
        if ((10 + 20) % 20 > 0) {
        }
        int[] iArrGLVyCiDrpMyCFUKS = gLVyCiDrpMyCFUKS(pfc77ea6cVar);
        if (this.f2fa47f7c != iArrGLVyCiDrpMyCFUKS.length) {
            throw new java.lang.ArithmeticException("permutation size and vector size mismatch");
        }
        int[] iArr = new int[this.f2fa47f7c];
        for (int i = 0; i < iArrGLVyCiDrpMyCFUKS.length; i++) {
            iArr[i] = this.f6ba8844d[iArrGLVyCiDrpMyCFUKS[i]];
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf3ef9c93(this.f06e3d36f, iArr);
    }

    public override java.lang.string Tostring() {
        if ((23 + 2) % 2 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        for (int i = 0; i < this.f6ba8844d.length; i++) {
            for (int i2 = 0; i2 < reCKbXKMdOOoYpkB(this.f06e3d36f); i2++) {
                if (((1 << (i2 & 31)) & this.f6ba8844d[i]) == 0) {
                    uMFIENdMXQdQeoJf(stringBuffer, '0');
                } else {
                    MPbIgWhHPkZzkphC(stringBuffer, '1');
                }
            }
            lveJBzOxEoxgVZNd(stringBuffer, ' ');
        }
        return ixaDpWdcJFffPZdE(stringBuffer);
    }
}

