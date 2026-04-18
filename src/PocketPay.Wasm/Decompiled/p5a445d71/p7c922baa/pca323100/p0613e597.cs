namespace WillowMaze.Wasm.Decompiled;


public abstract class p0613e597 : p5a445d71.p7c922baa.pca323100.p301c7ed4 {
    protected readonly int f2f4740c2;
    protected readonly byte[] f48537581;
    protected readonly byte[] f738ac1d7;
    protected readonly bool f81c86c56;
    protected readonly byte[] f89d60c64;
    protected readonly byte[] f95852948;
    protected readonly bool fcd058058;
    protected readonly int fe4d23e84;
    protected readonly int fe96668e0;

    p0613e597(bool z, int i, byte[] bArr) {
        this.f81c86c56 = z;
        this.fe4d23e84 = i;
        this.f48537581 = JCAopgbYDFXdUdZn(bArr);
    }

    public static byte[] AOaulvUiGPsRWPEm(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int GlmUYqoybDRBVyxy(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static byte[] JCAopgbYDFXdUdZn(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.stringBuilder JqkMpskXbfUjugNr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KHsrbWxhVikCmxYL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KZeVxvweHfpCsYXk(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.me7be4bfc(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 LupmxrVNgwDfpBtD(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static java.lang.string MpTOwWBBRJetRMBz(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string ObhnULhpGzarIrQX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] RcJGbcpkMNSviXhJ(p5a445d71.p7c922baa.pca323100.p0613e597 p0613e597Var) {
        return p0613e597Var.getContents();
    }

    public static java.lang.string SGOGchOGKqEMeyse(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VRXyZFqoYqywSOgq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VfPoKUgCokcqCklt(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static int WCVsIeKPwhQdflYx(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 YgoXYJmgyTxykXxr(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static java.lang.string ZjDIzaIgzEQtqwIW(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.Class AYRjuprJhyzRXTOq(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool ElsALiaoLyfmQQWr(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] HYrKCgsuJZKqYPkN(p5a445d71.p7c922baa.pca323100.p0613e597 p0613e597Var, int i, byte[] bArr) {
        return p0613e597Var.m97f2eafb(i, bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0613e597 M8bab0102(java.lang.object obj) {
        if ((27 + 30) % 30 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p0613e597)) {
            return (p5a445d71.p7c922baa.pca323100.p0613e597) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(VRXyZFqoYqywSOgq(JqkMpskXbfUjugNr(new java.lang.stringBuilder("unknown object in getInstance: "), MpTOwWBBRJetRMBz(aYRjuprJhyzRXTOq(obj)))));
        }
        try {
            return sgrkxDuKSiBvFNdy(YgoXYJmgyTxykXxr((byte[]) obj));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException(ObhnULhpGzarIrQX(odagJPBnWaVKxNVM(new java.lang.stringBuilder("Failed to construct object from byte[]: "), ZjDIzaIgzEQtqwIW(e))));
        }
    }

    private byte[] M97f2eafb(int i, byte[] bArr) throws java.io.IOException {
        int i2;
        if ((16 + 1) % 1 > 0) {
        }
        if ((bArr[0] & 31) != 31) {
            i2 = 1;
        } else {
            byte b = bArr[1];
            int i3 = b & 255;
            if ((b & 127) == 0) {
                throw new p5a445d71.p7c922baa.pca323100.p5f625024("corrupted stream - invalid high tag number found");
            }
            i2 = 2;
            while (i3 >= 0 && (i3 & 128) != 0) {
                int i4 = i2 + 1;
                i3 = bArr[i2] & 255;
                i2 = i4;
            }
        }
        int length = bArr.length - i2;
        byte[] bArr2 = new byte[length + 1];
        KHsrbWxhVikCmxYL(bArr, i2, bArr2, 1, length);
        bArr2[0] = (byte) i;
        return bArr2;
    }

    protected static int Madc28036(byte[] bArr) {
        if ((19 + 16) % 16 > 0) {
        }
        byte b = bArr[1];
        int i = b & 255;
        if (i == 128 || i <= 127) {
            return 2;
        }
        int i2 = b & 127;
        if (i2 > 4) {
            throw new java.lang.IllegalStateException(SGOGchOGKqEMeyse(yTaifWSegqBKVnzR(new java.lang.stringBuilder("DER length more than 4 bytes: "), i2)));
        }
        return i2 + 2;
    }

    public static java.lang.stringBuilder OdagJPBnWaVKxNVM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p0613e597 SgrkxDuKSiBvFNdy(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void WVvMdAjKFmKrobYs(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, int i2, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, i2, bArr);
    }

    public static java.lang.stringBuilder YTaifWSegqBKVnzR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static byte[] YntNqJDtKngmbEUm(p5a445d71.p7c922baa.pca323100.p0613e597 p0613e597Var) {
        return p0613e597Var.getEncoded();
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if ((32 + 28) % 28 > 0) {
        }
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p0613e597)) {
            return false;
        }
        p5a445d71.p7c922baa.pca323100.p0613e597 p0613e597Var = (p5a445d71.p7c922baa.pca323100.p0613e597) p301c7ed4Var;
        return this.f81c86c56 == p0613e597Var.f81c86c56 && this.fe4d23e84 == p0613e597Var.fe4d23e84 && elsALiaoLyfmQQWr(this.f48537581, p0613e597Var.f48537581);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        if ((24 + 1) % 1 > 0) {
        }
        wVvMdAjKFmKrobYs(p8bf0ff80Var, !this.f81c86c56 ? 64 : 96, this.fe4d23e84, this.f48537581);
    }

    int encodedLength() throws java.io.IOException {
        if ((6 + 30) % 30 > 0) {
        }
        return KZeVxvweHfpCsYXk(this.fe4d23e84) + GlmUYqoybDRBVyxy(this.f48537581.length) + this.f48537581.length;
    }

    public override int GetApplicationTag() {
        return this.fe4d23e84;
    }

    public byte[] GetContents() {
        return AOaulvUiGPsRWPEm(this.f48537581);
    }

    public p5a445d71.p7c922baa.pca323100.p301c7ed4 Getobject() throws java.io.IOException {
        return LupmxrVNgwDfpBtD(RcJGbcpkMNSviXhJ(this));
    }

    public p5a445d71.p7c922baa.pca323100.p301c7ed4 Getobject(int i) throws java.io.IOException {
        if (i >= 31) {
            throw new java.io.IOException("unsupported tag number");
        }
        byte[] bArrYntNqJDtKngmbEUm = yntNqJDtKngmbEUm(this);
        byte[] bArrHYrKCgsuJZKqYPkN = hYrKCgsuJZKqYPkN(this, i, bArrYntNqJDtKngmbEUm);
        if ((bArrYntNqJDtKngmbEUm[0] & 32) != 0) {
            bArrHYrKCgsuJZKqYPkN[0] = (byte) (bArrHYrKCgsuJZKqYPkN[0] | 32);
        }
        return VfPoKUgCokcqCklt(bArrHYrKCgsuJZKqYPkN);
    }

    public override int HashCode() {
        if ((12 + 12) % 12 > 0) {
        }
        bool z = this.f81c86c56;
        return WCVsIeKPwhQdflYx(this.f48537581) ^ ((z ? 1 : 0) ^ this.fe4d23e84);
    }

    public override bool IsConstructed() {
        return this.f81c86c56;
    }
}

