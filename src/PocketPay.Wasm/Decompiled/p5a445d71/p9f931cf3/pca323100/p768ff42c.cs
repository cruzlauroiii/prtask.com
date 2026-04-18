namespace WillowMaze.Wasm.Decompiled;


public class p768ff42c : p5a445d71.p9f931cf3.pca323100.p28e7e5cc {
    public p768ff42c(byte[] bArr) {
        this(bArr, true);
    }

    p768ff42c(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p768ff42c BpLAYPJmEgFVjKKU(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 JhRzkHjBEVuocpLi(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 RhlpafoKqmhtQQcC(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.stringBuilder WukEgdAwHMJsNWac(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XAobloOdNdEBzkQY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p768ff42c M8bab0102(java.lang.object obj) {
        if ((11 + 20) % 20 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p768ff42c)) {
            return (p5a445d71.p9f931cf3.pca323100.p768ff42c) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p28e7e5cc) {
            return new p5a445d71.p9f931cf3.pca323100.p768ff42c(((p5a445d71.p9f931cf3.pca323100.p28e7e5cc) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(mjBjrrXxRRfsEnPK(wFrjiMNQTAPdSLaz(new java.lang.stringBuilder("illegal object in getInstance: "), mCCUMlLMTZUXhONj(pSChYWtIpUFExGkw(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p768ff42c) JhRzkHjBEVuocpLi((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(XAobloOdNdEBzkQY(WukEgdAwHMJsNWac(new java.lang.stringBuilder("encoding error getInstance: "), miTBbSSIxhQquZgY(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p768ff42c M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarZfvFawfuoaJPkdJw = zfvFawfuoaJPkdJw(p582a4948Var);
        return (z || (p301c7ed4VarZfvFawfuoaJPkdJw is p5a445d71.p9f931cf3.pca323100.p768ff42c)) ? BpLAYPJmEgFVjKKU(p301c7ed4VarZfvFawfuoaJPkdJw) : new p5a445d71.p9f931cf3.pca323100.p768ff42c(qvNLKHXNzBJqGyAq(RhlpafoKqmhtQQcC(p301c7ed4VarZfvFawfuoaJPkdJw)), true);
    }

    public static java.lang.string MCCUMlLMTZUXhONj(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string MiTBbSSIxhQquZgY(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.string MjBjrrXxRRfsEnPK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class PSChYWtIpUFExGkw(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte[] QvNLKHXNzBJqGyAq(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.stringBuilder WFrjiMNQTAPdSLaz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZfvFawfuoaJPkdJw(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }
}

