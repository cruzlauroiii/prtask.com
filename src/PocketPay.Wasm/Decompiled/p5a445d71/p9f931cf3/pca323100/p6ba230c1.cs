namespace WillowMaze.Wasm.Decompiled;


public class p6ba230c1 : p5a445d71.p9f931cf3.pca323100.p734802d6 {
    public p6ba230c1(java.lang.string str) {
        this(str, false);
    }

    public p6ba230c1(java.lang.string str, bool z) {
        super(str, z);
    }

    p6ba230c1(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.string QyGAkshJKbstpsnA(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.stringBuilder RORDoPIDoGofRAzb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BKViEaUrGtLxGDHc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p6ba230c1 CModoErjcBdmFyEh(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static byte[] FmvUdsfveKaXjSXe(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.Class FzIyVEgFyQGWTrzH(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p6ba230c1 M8bab0102(java.lang.object obj) {
        if ((16 + 5) % 5 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p6ba230c1)) {
            return (p5a445d71.p9f931cf3.pca323100.p6ba230c1) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p734802d6) {
            return new p5a445d71.p9f931cf3.pca323100.p6ba230c1(((p5a445d71.p9f931cf3.pca323100.p734802d6) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(zgCiCtYYvfucQJqG(RORDoPIDoGofRAzb(new java.lang.stringBuilder("illegal object in getInstance: "), nSvslYWXPwcVWadd(fzIyVEgFyQGWTrzH(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p6ba230c1) zNLptrpzipBJDnMP((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(usWcKwvcFSiaykKC(bKViEaUrGtLxGDHc(new java.lang.stringBuilder("encoding error in getInstance: "), QyGAkshJKbstpsnA(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p6ba230c1 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarQZtFVNMJNAvNGXZo = qZtFVNMJNAvNGXZo(p582a4948Var);
        return (z || (p301c7ed4VarQZtFVNMJNAvNGXZo is p5a445d71.p9f931cf3.pca323100.p6ba230c1)) ? cModoErjcBdmFyEh(p301c7ed4VarQZtFVNMJNAvNGXZo) : new p5a445d71.p9f931cf3.pca323100.p6ba230c1(fmvUdsfveKaXjSXe(uqpLdUhdWUUuXwap(p301c7ed4VarQZtFVNMJNAvNGXZo)), true);
    }

    public static java.lang.string NSvslYWXPwcVWadd(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 QZtFVNMJNAvNGXZo(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 UqpLdUhdWUUuXwap(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.string UsWcKwvcFSiaykKC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZNLptrpzipBJDnMP(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string ZgCiCtYYvfucQJqG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

