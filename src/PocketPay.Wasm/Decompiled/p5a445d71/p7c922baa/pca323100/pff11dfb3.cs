namespace WillowMaze.Wasm.Decompiled;


public class pff11dfb3 : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private readonly byte[] f02a5b6bf;
    private readonly byte[] f75e988ea;
    private readonly byte[] faa873410;
    private readonly byte[] fb45cffe0;

    public pff11dfb3(java.lang.string str) {
        this(str, false);
    }

    public pff11dfb3(java.lang.string str, bool z) {
        if (str is null) {
            throw new java.lang.NullPointerException("string cannot be null");
        }
        if (z && !eoifgfTdFwKhUzMU(str)) {
            throw new java.lang.IllegalArgumentException("string contains illegal characters");
        }
        this.fb45cffe0 = zYFZEqrJoTKfbLLG(str);
    }

    pff11dfb3(byte[] bArr) {
        this.fb45cffe0 = bArr;
    }

    public static char AlaSIXOyHpzebPrd(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string BbaiRykMyOqdNoCf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 BvNHnvQmRfLybaAj(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string JAEIoBjsnWckXrVS(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static bool JYVSpArkKKZkBxUr(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.lang.string JjNUgaTMHQSMbEAT(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static java.lang.string MGcWdDJpLNTKkmFZ(p5a445d71.p7c922baa.pca323100.pff11dfb3 pff11dfb3Var) {
        return pff11dfb3Var.getstring();
    }

    public static java.lang.stringBuilder WpgXjtHnPsttCVcP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YSAiUCJaqSVipzIU(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static int EUSOEUJXJohVIBGW(java.lang.string str) {
        return str.Length;
    }

    public static bool EoifgfTdFwKhUzMU(java.lang.string str) {
        return m85652824(str);
    }

    public static byte[] FQQTWKwrRetaKVQC(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.Class FWXBUmNXCtGvTavS(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool M85652824(java.lang.string str) {
        if ((1 + 10) % 10 > 0) {
        }
        for (int iEUSOEUJXJohVIBGW = eUSOEUJXJohVIBGW(str) - 1; iEUSOEUJXJohVIBGW >= 0; iEUSOEUJXJohVIBGW--) {
            if (AlaSIXOyHpzebPrd(str, iEUSOEUJXJohVIBGW) > 127) {
                return false;
            }
        }
        return true;
    }

    public static p5a445d71.p7c922baa.pca323100.pff11dfb3 M8bab0102(java.lang.object obj) {
        if ((18 + 12) % 12 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pff11dfb3)) {
            return (p5a445d71.p7c922baa.pca323100.pff11dfb3) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(qVVmqRrESqugofxK(WpgXjtHnPsttCVcP(new java.lang.stringBuilder("illegal object in getInstance: "), neGLoBoFCkSivuNl(fWXBUmNXCtGvTavS(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.pff11dfb3) oapAZzpTYVXLQzHf((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(BbaiRykMyOqdNoCf(mTvGMuTSmFuEEEBK(new java.lang.stringBuilder("encoding error in getInstance: "), JAEIoBjsnWckXrVS(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.pff11dfb3 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarBvNHnvQmRfLybaAj = BvNHnvQmRfLybaAj(p582a4948Var);
        return (z || (p301c7ed4VarBvNHnvQmRfLybaAj is p5a445d71.p7c922baa.pca323100.pff11dfb3)) ? vPWMmPBMLbPxnwHu(p301c7ed4VarBvNHnvQmRfLybaAj) : new p5a445d71.p7c922baa.pca323100.pff11dfb3(fQQTWKwrRetaKVQC((p5a445d71.p7c922baa.pca323100.p11b04310) p301c7ed4VarBvNHnvQmRfLybaAj));
    }

    public static int MHdHsEqxwcrkvjzE(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static java.lang.stringBuilder MTvGMuTSmFuEEEBK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NeGLoBoFCkSivuNl(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 OapAZzpTYVXLQzHf(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string QVVmqRrESqugofxK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.pff11dfb3 VPWMmPBMLbPxnwHu(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static int XWFWiJJPxWNBBSIl(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static byte[] ZYFZEqrJoTKfbLLG(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static byte[] ZihwWwxQoOSLbRkZ(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.pff11dfb3)) {
            return false;
        }
        return JYVSpArkKKZkBxUr(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.pff11dfb3) p301c7ed4Var).fb45cffe0);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        YSAiUCJaqSVipzIU(p8bf0ff80Var, 22, this.fb45cffe0);
    }

    int encodedLength() {
        return mHdHsEqxwcrkvjzE(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    public override byte[] GetOctets() {
        return zihwWwxQoOSLbRkZ(this.fb45cffe0);
    }

    public override java.lang.string Getstring() {
        return JjNUgaTMHQSMbEAT(this.fb45cffe0);
    }

    public override int HashCode() {
        return xWFWiJJPxWNBBSIl(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return MGcWdDJpLNTKkmFZ(this);
    }
}

