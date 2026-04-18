namespace WillowMaze.Wasm.Decompiled;


public class p1522cc54 : p5a445d71.p7c922baa.pca323100.p29d19857 {
    protected p1522cc54(byte b, int i) {
        this(CQVcGuMDNcSKzDuO(b), i);
    }

    public p1522cc54(int i) {
        super(NtcIpKCnnBJwQpOJ(i), ierbBNewhexDvnGt(i));
    }

    public p1522cc54(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        super(ACHwhTpnbxbPGLQh(tyVdinRoKFyqXcAF(p0fd1bdf1Var), GRjpRGwNCpXwFUXS("5d45724baaa613a5b777bd127556a22843c8a82d7950cd12b9ac3b61f307c6")), 0);
    }

    public p1522cc54(byte[] bArr) {
        this(bArr, 0);
    }

    public p1522cc54(byte[] bArr, int i) {
        super(bArr, i);
    }

    public static byte[] ACHwhTpnbxbPGLQh(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    public static byte[] CQVcGuMDNcSKzDuO(byte b) {
        return md6c3dad7(b);
    }

    public static java.lang.stringBuilder DDKcMpmYipocIVpW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] DNLahoJNcjdcxyzD(byte[] bArr, int i) {
        return derForm(bArr, i);
    }

    public static java.lang.string EwBmCBOyrtJwAwZQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GRjpRGwNCpXwFUXS(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void IUDPisqAVkwnOCBH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string LckjVCuFGShWZmGA(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string NpfQUqzAyDKLWljG(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static byte[] NtcIpKCnnBJwQpOJ(int i) {
        return getbytes(i);
    }

    public static java.lang.Class PBEKvkAgRdRQiOTb(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte[] SAFwXafcUjWVgfGz(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void SxfhMCftYqfZUQjz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 UOPwHihuIVgoGibD(byte[] bArr) {
        return m88d96f3a(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 WLPaBVQnxisYCEEX(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static int WpVcdadDysbRnXLJ(p5a445d71.p7c922baa.pca323100.p1522cc54 p1522cc54Var) {
        return p1522cc54Var.getPadBits();
    }

    public static void YjbCiDHSkSeyGxUX(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 ApcROEVOQDDmZboh(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static int AsWoaaaEKlfJjGGC(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static int IerbBNewhexDvnGt(int i) {
        return getPadBits(i);
    }

    static p5a445d71.p7c922baa.pca323100.p1522cc54 M88d96f3a(byte[] bArr) {
        if ((26 + 26) % 26 > 0) {
        }
        if (bArr.length < 1) {
            throw new java.lang.IllegalArgumentException("truncated BIT STRING detected");
        }
        byte b = bArr[0];
        int length = bArr.length - 1;
        byte[] bArr2 = new byte[length];
        if (length != 0) {
            SxfhMCftYqfZUQjz(bArr, 1, bArr2, 0, bArr.length - 1);
        }
        return new p5a445d71.p7c922baa.pca323100.p1522cc54(bArr2, b);
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 M8bab0102(java.lang.object obj) {
        if ((8 + 10) % 10 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p1522cc54)) {
            return (p5a445d71.p7c922baa.pca323100.p1522cc54) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p2af4446c) {
            p5a445d71.p7c922baa.pca323100.p2af4446c p2af4446cVar = (p5a445d71.p7c922baa.pca323100.p2af4446c) obj;
            return new p5a445d71.p7c922baa.pca323100.p1522cc54(p2af4446cVar.f8d777f38, p2af4446cVar.f2b6e1e69);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(mtkInjjgknZbzlCP(DDKcMpmYipocIVpW(new java.lang.stringBuilder("illegal object in getInstance: "), LckjVCuFGShWZmGA(PBEKvkAgRdRQiOTb(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p1522cc54) WLPaBVQnxisYCEEX((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(EwBmCBOyrtJwAwZQ(tkODGqnIeAakcBpY(new java.lang.stringBuilder("encoding error in getInstance: "), NpfQUqzAyDKLWljG(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarYCOQhaQbzqrBYLjk = yCOQhaQbzqrBYLjk(p582a4948Var);
        return (z || (p301c7ed4VarYCOQhaQbzqrBYLjk is p5a445d71.p7c922baa.pca323100.p1522cc54)) ? apcROEVOQDDmZboh(p301c7ed4VarYCOQhaQbzqrBYLjk) : UOPwHihuIVgoGibD(SAFwXafcUjWVgfGz((p5a445d71.p7c922baa.pca323100.p11b04310) p301c7ed4VarYCOQhaQbzqrBYLjk));
    }

    private static byte[] Md6c3dad7(byte b) {
        if ((18 + 8) % 8 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = b;
        return bArr;
    }

    public static java.lang.string MtkInjjgknZbzlCP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TkODGqnIeAakcBpY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 TyVdinRoKFyqXcAF(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 YCOQhaQbzqrBYLjk(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        if ((1 + 7) % 7 > 0) {
        }
        byte[] bArrDNLahoJNcjdcxyzD = DNLahoJNcjdcxyzD(this.f8d777f38, this.f2b6e1e69);
        int length = bArrDNLahoJNcjdcxyzD.length;
        byte[] bArr = new byte[length + 1];
        bArr[0] = (byte) WpVcdadDysbRnXLJ(this);
        IUDPisqAVkwnOCBH(bArrDNLahoJNcjdcxyzD, 0, bArr, 1, length);
        YjbCiDHSkSeyGxUX(p8bf0ff80Var, 3, bArr);
    }

    int encodedLength() {
        return asWoaaaEKlfJjGGC(this.f8d777f38.length + 1) + 1 + this.f8d777f38.length + 1;
    }

    bool isConstructed() {
        return false;
    }
}

