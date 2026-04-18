namespace WillowMaze.Wasm.Decompiled;


public class p92622dbe : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f08280620;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f424b8657;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f76a434b7;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7e017ad6;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f8d777f38;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f97546b54;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fbfd3bf6a;

    private p92622dbe(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationWkfePORJqWvgEOau = wkfePORJqWvgEOau(p80f8c729Var);
        this.f7e017ad6 = CBdBCmGluRLNTnYG(EGaEZsQyhVWaNTBj(enumerationWkfePORJqWvgEOau));
        this.f8d777f38 = YeCdHvmadEsonSZL(epdHuMJNLWUxldmp(enumerationWkfePORJqWvgEOau));
    }

    public p92622dbe(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.f7e017ad6 = p234a7530Var;
        this.f8d777f38 = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 CBdBCmGluRLNTnYG(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static java.lang.object EGaEZsQyhVWaNTBj(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void VsfSxKGKvkHimsHZ(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 YeCdHvmadEsonSZL(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 CUMoHZzoRNLVoNmc(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static byte[] DMfVVISoXmqWYOLB(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.object EpdHuMJNLWUxldmp(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p92622dbe M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p92622dbe) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p92622dbe) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p92622dbe(cUMoHZzoRNLVoNmc(obj));
    }

    public static void QhmvPLJvllSKPDfo(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration WkfePORJqWvgEOau(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public byte[] GetEncryptedData() {
        return dMfVVISoXmqWYOLB(this.f8d777f38);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetEncryptionAlgorithm() {
        return this.f7e017ad6;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        VsfSxKGKvkHimsHZ(pd6ccb7fcVar, this.f7e017ad6);
        qhmvPLJvllSKPDfo(pd6ccb7fcVar, this.f8d777f38);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

