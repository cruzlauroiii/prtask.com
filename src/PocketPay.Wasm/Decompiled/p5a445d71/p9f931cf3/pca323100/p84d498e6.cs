namespace WillowMaze.Wasm.Decompiled;


public class p84d498e6 : p5a445d71.p9f931cf3.pca323100.p20484344 {
    public p84d498e6(java.lang.string str) {
        super(str);
    }

    p84d498e6(byte[] bArr) {
        super(bArr);
    }

    p84d498e6(char[] cArr) {
        super(cArr);
    }

    public static java.lang.string AHPBLAThnuwiuoaN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 AcnaonfakYOdXzRn(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.string CgULgWsExgxuwKSu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] TosoKqsobXDWNRGk(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZnIKDVnhAXuNHltc(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.stringBuilder BUDZtpPrOIbXIeAf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HDumzLTZvKlSPelW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 JypAUXobsqLBnugw(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string LwTfxlnSbZHeidtq(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p84d498e6 M8bab0102(java.lang.object obj) {
        if ((6 + 3) % 3 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p84d498e6)) {
            return (p5a445d71.p9f931cf3.pca323100.p84d498e6) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p20484344) {
            return new p5a445d71.p9f931cf3.pca323100.p84d498e6(((p5a445d71.p9f931cf3.pca323100.p20484344) obj).fb45cffe0);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(CgULgWsExgxuwKSu(hDumzLTZvKlSPelW(new java.lang.stringBuilder("illegal object in getInstance: "), mFPnaOnuXCrwHWcT(sXyTAcpSbhiPYzhn(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p84d498e6) jypAUXobsqLBnugw((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(AHPBLAThnuwiuoaN(bUDZtpPrOIbXIeAf(new java.lang.stringBuilder("encoding error in getInstance: "), lwTfxlnSbZHeidtq(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p84d498e6 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarZnIKDVnhAXuNHltc = ZnIKDVnhAXuNHltc(p582a4948Var);
        return (z || (p301c7ed4VarZnIKDVnhAXuNHltc is p5a445d71.p9f931cf3.pca323100.p84d498e6)) ? zBsfpVGtCNkeBdyZ(p301c7ed4VarZnIKDVnhAXuNHltc) : new p5a445d71.p9f931cf3.pca323100.p84d498e6(TosoKqsobXDWNRGk(AcnaonfakYOdXzRn(p301c7ed4VarZnIKDVnhAXuNHltc)));
    }

    public static java.lang.string MFPnaOnuXCrwHWcT(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class SXyTAcpSbhiPYzhn(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p84d498e6 ZBsfpVGtCNkeBdyZ(java.lang.object obj) {
        return m8bab0102(obj);
    }
}

