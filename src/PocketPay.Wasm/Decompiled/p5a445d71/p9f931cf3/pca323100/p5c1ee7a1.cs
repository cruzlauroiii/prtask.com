namespace WillowMaze.Wasm.Decompiled;


public class p5c1ee7a1 : p5a445d71.p9f931cf3.pca323100.pc936eca9 {
    public p5c1ee7a1(byte[] bArr) {
        this(bArr, true);
    }

    p5c1ee7a1(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 DfYKtPxvdpIQoIxa(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string EtGPianrKlKUUhEz(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 JMbAxKNAwGiGyjyl(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KUQrDMlgyLCDZOpZ(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string LMYTHJIGDqeaICDn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string NIFdiiujJvstNcVQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OeLdzTQCNBLfFTyb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class SylAxNCjryoLnMto(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string YIZPftPBXbbOECOj(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder ZPdiDPnkEFxDPvMI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] JoeYJaWYZHNbQePW(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p5c1ee7a1 KKMAJkAYclykXpxs(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5c1ee7a1 M8bab0102(java.lang.object obj) {
        if ((1 + 18) % 18 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p5c1ee7a1)) {
            return (p5a445d71.p9f931cf3.pca323100.p5c1ee7a1) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pc936eca9) {
            return new p5a445d71.p9f931cf3.pca323100.p5c1ee7a1(((p5a445d71.p9f931cf3.pca323100.pc936eca9) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(LMYTHJIGDqeaICDn(OeLdzTQCNBLfFTyb(new java.lang.stringBuilder("illegal object in getInstance: "), YIZPftPBXbbOECOj(SylAxNCjryoLnMto(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p5c1ee7a1) DfYKtPxvdpIQoIxa((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(NIFdiiujJvstNcVQ(ZPdiDPnkEFxDPvMI(new java.lang.stringBuilder("encoding error in getInstance: "), EtGPianrKlKUUhEz(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p5c1ee7a1 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarKUQrDMlgyLCDZOpZ = KUQrDMlgyLCDZOpZ(p582a4948Var);
        return (z || (p301c7ed4VarKUQrDMlgyLCDZOpZ is p5a445d71.p9f931cf3.pca323100.p5c1ee7a1)) ? kKMAJkAYclykXpxs(p301c7ed4VarKUQrDMlgyLCDZOpZ) : new p5a445d71.p9f931cf3.pca323100.p5c1ee7a1(joeYJaWYZHNbQePW(JMbAxKNAwGiGyjyl(p301c7ed4VarKUQrDMlgyLCDZOpZ)));
    }
}

