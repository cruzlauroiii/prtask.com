namespace WillowMaze.Wasm.Decompiled;


public class p6f28bfc7 : p5a445d71.p9f931cf3.pca323100.p0f299841 {
    public p6f28bfc7(java.lang.string str) {
        super(str);
    }

    p6f28bfc7(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.string BfuvoFjNjBceTknN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p6f28bfc7 FZPyUeiKMvBzalJb(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string GGAbBuVLicPUjONV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HUOslRLWGhfPWcCC(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder MwQTPTJYLZLksmxJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 HTajJQnBCnPCfQsd(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.Class ILuRebokjpeWtQYp(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte[] LmZNnlqwJAfRFXyL(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p6f28bfc7 M8bab0102(java.lang.object obj) {
        if ((24 + 30) % 30 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p6f28bfc7)) {
            return (p5a445d71.p9f931cf3.pca323100.p6f28bfc7) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0f299841) {
            return new p5a445d71.p9f931cf3.pca323100.p6f28bfc7(((p5a445d71.p9f931cf3.pca323100.p0f299841) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(BfuvoFjNjBceTknN(owFuqFWOAOHgbxFL(new java.lang.stringBuilder("illegal object in getInstance: "), HUOslRLWGhfPWcCC(iLuRebokjpeWtQYp(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p6f28bfc7) wRUtZauVyePuEllx((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(GGAbBuVLicPUjONV(MwQTPTJYLZLksmxJ(new java.lang.stringBuilder("encoding error in getInstance: "), wgFkwnykldyEojIi(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p6f28bfc7 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarNKggzpxgxXYUUbdd = nKggzpxgxXYUUbdd(p582a4948Var);
        return (z || (p301c7ed4VarNKggzpxgxXYUUbdd is p5a445d71.p9f931cf3.pca323100.p6f28bfc7)) ? FZPyUeiKMvBzalJb(p301c7ed4VarNKggzpxgxXYUUbdd) : new p5a445d71.p9f931cf3.pca323100.p6f28bfc7(lmZNnlqwJAfRFXyL(hTajJQnBCnPCfQsd(p301c7ed4VarNKggzpxgxXYUUbdd)), true);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 NKggzpxgxXYUUbdd(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.stringBuilder OwFuqFWOAOHgbxFL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 WRUtZauVyePuEllx(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string WgFkwnykldyEojIi(java.lang.Exception exc) {
        return exc.tostring();
    }
}

