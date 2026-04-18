namespace WillowMaze.Wasm.Decompiled;


public class p2af4446c : p5a445d71.p7c922baa.pca323100.p29d19857 {
    protected p2af4446c(byte b, int i) {
        this(fQGIlxLUKsIyMGYq(b), i);
    }

    public p2af4446c(int i) {
        super(NlQRhpFyWnyvdJsW(i), UJxXrJStqUcpkRmI(i));
    }

    public p2af4446c(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        super(rBpScJWgwCXXmssQ(DVhAzEWNEXuzfxEJ(p0fd1bdf1Var), HARcQtWNJtpEuBMx("a944ee6d7f630f806fe9d0fa75f33877fdc45122b314e12158d8f4c07e86ee")), 0);
    }

    public p2af4446c(byte[] bArr) {
        this(bArr, 0);
    }

    public p2af4446c(byte[] bArr, int i) {
        super(bArr, i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 DVhAzEWNEXuzfxEJ(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void DrdBRcborgKzUaXs(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static java.lang.string HARcQtWNJtpEuBMx(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 HffweUCmWxdNnleI(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static int KJSqNiVzoXydBBwl(p5a445d71.p7c922baa.pca323100.p2af4446c p2af4446cVar) {
        return p2af4446cVar.getPadBits();
    }

    public static p5a445d71.p7c922baa.pca323100.p29d19857 NhKhYCmafDTqwFQR(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static byte[] NlQRhpFyWnyvdJsW(int i) {
        return getbytes(i);
    }

    public static java.lang.string PfMrggXnSOgOhjoX(java.lang.Class cls) {
        return cls.getName();
    }

    public static int UJxXrJStqUcpkRmI(int i) {
        return getPadBits(i);
    }

    public static java.lang.string YafYDYzXWLiiJlbs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string APMoNKAUhaLDSXhx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BNxvtzvqsMjVQPmP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 BRMeCwIhOOzvDfOF(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static byte[] CnMYFcNoSWNIMTFK(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] FQGIlxLUKsIyMGYq(byte b) {
        return md6c3dad7(b);
    }

    public static java.lang.string GZJhGsYGXMRRjuei(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int KnqtaZyZFhDXzXtJ(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static java.lang.stringBuilder LtYlFtQOXrNuYngM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p7c922baa.pca323100.p2af4446c M88d96f3a(byte[] bArr) {
        if ((22 + 31) % 31 > 0) {
        }
        if (bArr.length < 1) {
            throw new java.lang.IllegalArgumentException("truncated BIT STRING detected");
        }
        byte b = bArr[0];
        int length = bArr.length - 1;
        byte[] bArr2 = new byte[length];
        if (length != 0) {
            zGMdhocctUqBSmqA(bArr, 1, bArr2, 0, bArr.length - 1);
        }
        return new p5a445d71.p7c922baa.pca323100.p2af4446c(bArr2, b);
    }

    public static p5a445d71.p7c922baa.pca323100.p29d19857 M8bab0102(java.lang.object obj) {
        if ((23 + 18) % 18 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p2af4446c)) {
            return (p5a445d71.p7c922baa.pca323100.p2af4446c) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p1522cc54) {
            return (p5a445d71.p7c922baa.pca323100.p1522cc54) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(YafYDYzXWLiiJlbs(ltYlFtQOXrNuYngM(new java.lang.stringBuilder("illegal object in getInstance: "), PfMrggXnSOgOhjoX(nLyesKOCqHLRSdDw(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p29d19857) bRMeCwIhOOzvDfOF((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(aPMoNKAUhaLDSXhx(vgLizyHmReaxiTKL(new java.lang.stringBuilder("encoding error in getInstance: "), gZJhGsYGXMRRjuei(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p29d19857 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarHffweUCmWxdNnleI = HffweUCmWxdNnleI(p582a4948Var);
        return (z || (p301c7ed4VarHffweUCmWxdNnleI is p5a445d71.p7c922baa.pca323100.p2af4446c)) ? NhKhYCmafDTqwFQR(p301c7ed4VarHffweUCmWxdNnleI) : poACcgoxHIlXNgXx(cnMYFcNoSWNIMTFK((p5a445d71.p7c922baa.pca323100.p11b04310) p301c7ed4VarHffweUCmWxdNnleI));
    }

    private static byte[] Md6c3dad7(byte b) {
        if ((21 + 2) % 2 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = b;
        return bArr;
    }

    public static java.lang.Class NLyesKOCqHLRSdDw(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p2af4446c PoACcgoxHIlXNgXx(byte[] bArr) {
        return m88d96f3a(bArr);
    }

    public static byte[] RBpScJWgwCXXmssQ(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    public static java.lang.stringBuilder VgLizyHmReaxiTKL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZGMdhocctUqBSmqA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        if ((8 + 32) % 32 > 0) {
        }
        byte[] bArr = this.f8d777f38;
        int length = bArr.length;
        byte[] bArr2 = new byte[length + 1];
        bArr2[0] = (byte) KJSqNiVzoXydBBwl(this);
        bNxvtzvqsMjVQPmP(bArr, 0, bArr2, 1, length);
        DrdBRcborgKzUaXs(p8bf0ff80Var, 3, bArr2);
    }

    int encodedLength() {
        return knqtaZyZFhDXzXtJ(this.f8d777f38.length + 1) + 1 + this.f8d777f38.length + 1;
    }

    bool isConstructed() {
        return false;
    }
}

