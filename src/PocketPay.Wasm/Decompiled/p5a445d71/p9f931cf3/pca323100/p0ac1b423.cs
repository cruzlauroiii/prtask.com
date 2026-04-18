namespace WillowMaze.Wasm.Decompiled;


public class p0ac1b423 : p5a445d71.p9f931cf3.pca323100.pc3f7eb30 {
    public p0ac1b423(java.lang.string str) {
        super(str);
    }

    public p0ac1b423(byte[] bArr) {
        this(bArr, true);
    }

    p0ac1b423(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.string LbmlhyogGSTqxZdu(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 MPTmLOLLGrUTygpe(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 NRuACkcyOROjjvsm(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static byte[] OapvlvlFQQRdnciQ(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.Class SOrSEkZZekzgIZDz(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string WRFxOwGKACdNqOGo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZTSSfBUCSCojCmfP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CuYLtrEpIuYtgoGK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JDaZFZLafOoNujTi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0ac1b423 M8bab0102(java.lang.object obj) {
        if ((14 + 27) % 27 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p0ac1b423)) {
            return (p5a445d71.p9f931cf3.pca323100.p0ac1b423) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pc3f7eb30) {
            return new p5a445d71.p9f931cf3.pca323100.p0ac1b423(((p5a445d71.p9f931cf3.pca323100.pc3f7eb30) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(WRFxOwGKACdNqOGo(jDaZFZLafOoNujTi(new java.lang.stringBuilder("illegal object in getInstance: "), LbmlhyogGSTqxZdu(SOrSEkZZekzgIZDz(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p0ac1b423) MPTmLOLLGrUTygpe((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(cuYLtrEpIuYtgoGK(ZTSSfBUCSCojCmfP(new java.lang.stringBuilder("encoding error in getInstance: "), znznMejiNFPCesTe(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p0ac1b423 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarNRuACkcyOROjjvsm = NRuACkcyOROjjvsm(p582a4948Var);
        return (z || (p301c7ed4VarNRuACkcyOROjjvsm is p5a445d71.p9f931cf3.pca323100.p0ac1b423)) ? slMmcGxdYxhxVXcq(p301c7ed4VarNRuACkcyOROjjvsm) : new p5a445d71.p9f931cf3.pca323100.p0ac1b423(OapvlvlFQQRdnciQ(mFVLgnrrweKJqrtz(p301c7ed4VarNRuACkcyOROjjvsm)), true);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 MFVLgnrrweKJqrtz(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0ac1b423 SlMmcGxdYxhxVXcq(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string ZnznMejiNFPCesTe(java.lang.Exception exc) {
        return exc.tostring();
    }
}

