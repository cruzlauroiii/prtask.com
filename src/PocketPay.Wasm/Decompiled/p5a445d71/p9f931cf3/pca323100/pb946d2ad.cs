namespace WillowMaze.Wasm.Decompiled;


public class pb946d2ad : p5a445d71.p9f931cf3.pca323100.pab4c71c9 {
    public pb946d2ad(java.lang.string str) {
        this(str, false);
    }

    public pb946d2ad(java.lang.string str, bool z) {
        super(str, z);
    }

    pb946d2ad(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.string COqxcrYWsbCdPABH(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KteUYXPYBfHicONW(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb946d2ad QsdJJtKHxZihggPE(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 GDzSBpSfAWSHdoEh(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.Class JPuoHKNGtVtgImpE(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string JUoILAbtnUFJtwdt(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pb946d2ad M8bab0102(java.lang.object obj) {
        if ((16 + 21) % 21 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pb946d2ad)) {
            return (p5a445d71.p9f931cf3.pca323100.pb946d2ad) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pab4c71c9) {
            return new p5a445d71.p9f931cf3.pca323100.pb946d2ad(((p5a445d71.p9f931cf3.pca323100.pab4c71c9) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(umoSnoCVauJUHfeM(oBLmRqztHkQgnDfT(new java.lang.stringBuilder("illegal object in getInstance: "), COqxcrYWsbCdPABH(jPuoHKNGtVtgImpE(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.pb946d2ad) KteUYXPYBfHicONW((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(nloBAyTWNqwRDhmT(nsopsCFMvTplZgGC(new java.lang.stringBuilder("encoding error in getInstance: "), jUoILAbtnUFJtwdt(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pb946d2ad M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarGDzSBpSfAWSHdoEh = gDzSBpSfAWSHdoEh(p582a4948Var);
        return (z || (p301c7ed4VarGDzSBpSfAWSHdoEh is p5a445d71.p9f931cf3.pca323100.pb946d2ad)) ? QsdJJtKHxZihggPE(p301c7ed4VarGDzSBpSfAWSHdoEh) : new p5a445d71.p9f931cf3.pca323100.pb946d2ad(qANLtvBVPcBTBbXC(mnZiIGJxRoVSbVDy(p301c7ed4VarGDzSBpSfAWSHdoEh)), true);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 MnZiIGJxRoVSbVDy(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.string NloBAyTWNqwRDhmT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NsopsCFMvTplZgGC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OBLmRqztHkQgnDfT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] QANLtvBVPcBTBbXC(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.string UmoSnoCVauJUHfeM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

