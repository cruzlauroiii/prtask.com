namespace WillowMaze.Wasm.Decompiled;


public class p31f65ce4 : p5a445d71.p9f931cf3.pca323100.p2d118f72 {
    public p31f65ce4(java.lang.string str) {
        super(str);
    }

    p31f65ce4(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.Class GveFiNndQkRbMBFE(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string PISBUuJOqOIJteqd(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string WDDgtVQzovOKtIcG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XNuubkYUiWqsaitd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 ZZFOmUtjLdNKJmwS(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.stringBuilder GBQYeSKUoieWmfCY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KfULPFCJZnTnerOT(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static byte[] LOUxLkZifTsCIIJu(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p31f65ce4 M8bab0102(java.lang.object obj) {
        if ((19 + 6) % 6 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p31f65ce4)) {
            return (p5a445d71.p9f931cf3.pca323100.p31f65ce4) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p2d118f72) {
            return new p5a445d71.p9f931cf3.pca323100.p31f65ce4(((p5a445d71.p9f931cf3.pca323100.p2d118f72) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(WDDgtVQzovOKtIcG(gBQYeSKUoieWmfCY(new java.lang.stringBuilder("illegal object in getInstance: "), PISBUuJOqOIJteqd(GveFiNndQkRbMBFE(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p31f65ce4) kfULPFCJZnTnerOT((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(sXIdjrRnxrYxArFG(XNuubkYUiWqsaitd(new java.lang.stringBuilder("encoding error in getInstance: "), ntPhrMTsoriJZAjd(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p31f65ce4 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarOEVyrDmtPCfbqYQe = oEVyrDmtPCfbqYQe(p582a4948Var);
        return (z || (p301c7ed4VarOEVyrDmtPCfbqYQe is p5a445d71.p9f931cf3.pca323100.p31f65ce4)) ? rtdXIRKKXDhsbIzP(p301c7ed4VarOEVyrDmtPCfbqYQe) : new p5a445d71.p9f931cf3.pca323100.p31f65ce4(lOUxLkZifTsCIIJu(ZZFOmUtjLdNKJmwS(p301c7ed4VarOEVyrDmtPCfbqYQe)), true);
    }

    public static java.lang.string NtPhrMTsoriJZAjd(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 OEVyrDmtPCfbqYQe(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p31f65ce4 RtdXIRKKXDhsbIzP(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string SXIdjrRnxrYxArFG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

