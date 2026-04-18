namespace WillowMaze.Wasm.Decompiled;


public class p9f54f8ae : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f0b44340a;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f15ec2d12;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f452b9d30;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 f54c431ae;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb05d30eb;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fc3238723;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe58d541d;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 fef4c20de;
    private p5a445d71.p9f931cf3.pca323100.p11b04310 ff0b53b2d;

    private p9f54f8ae(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationNdBNacUvubRReJVg = ndBNacUvubRReJVg(p80f8c729Var);
        this.ff0b53b2d = (p5a445d71.p9f931cf3.pca323100.p11b04310) xTdRFkMIuxTHMxRK(enumerationNdBNacUvubRReJVg);
        this.fb05d30eb = (p5a445d71.p9f931cf3.pca323100.p364bf33a) QuFVKjweqMKcRFQK(enumerationNdBNacUvubRReJVg);
    }

    public p9f54f8ae(byte[] bArr, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        this.ff0b53b2d = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
        this.fb05d30eb = p364bf33aVar;
    }

    public static byte[] GetqWmgSckaLeRxL(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae LWKYxJFsMwDKlOYZ(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.object QuFVKjweqMKcRFQK(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void QuKIMjYtRfkLwgMI(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 UYRHfZmdiKvzBKry(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static byte[] DfVfnUJuzvLGlqHd(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void JBiboYiEmvNngIdI(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 LQOxzXbzIxAoiXAO(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae) {
            return (p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae(lQOxzXbzIxAoiXAO(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return LWKYxJFsMwDKlOYZ(UYRHfZmdiKvzBKry(p582a4948Var, z));
    }

    public static java.util.Enumeration NdBNacUvubRReJVg(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static java.lang.object XTdRFkMIuxTHMxRK(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetEncryptionParamHashSet() {
        return this.fb05d30eb;
    }

    public byte[] GetIV() {
        return dfVfnUJuzvLGlqHd(GetqWmgSckaLeRxL(this.ff0b53b2d));
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        jBiboYiEmvNngIdI(pd6ccb7fcVar, this.ff0b53b2d);
        QuKIMjYtRfkLwgMI(pd6ccb7fcVar, this.fb05d30eb);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

