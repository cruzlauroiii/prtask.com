namespace WillowMaze.Wasm.Decompiled;


public class p2f179579 : p5a445d71.p9f931cf3.pca323100.p85bbf3a3 {
    public p2f179579(byte[] bArr) {
        this(bArr, true);
    }

    p2f179579(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.string LCgLhPQqJzMytFPg(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.stringBuilder RdqIZvZpmqGfzyBR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RjnSAKWwFvCTfPsS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BbAPSblqcMIOJshL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] COaTjAgVzNswHhWY(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 DLOUKFTXiOSdNEuY(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 FFDNHzANNjrNJVbp(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.string FdEgXzujXNmNGiQL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p2f179579 IxECBdqfXuokNtNw(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p2f179579 M8bab0102(java.lang.object obj) {
        if ((3 + 6) % 6 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p2f179579)) {
            return (p5a445d71.p9f931cf3.pca323100.p2f179579) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p85bbf3a3) {
            return new p5a445d71.p9f931cf3.pca323100.p2f179579(((p5a445d71.p9f931cf3.pca323100.p85bbf3a3) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(fdEgXzujXNmNGiQL(RdqIZvZpmqGfzyBR(new java.lang.stringBuilder("illegal object in getInstance: "), pgiZhCuZiFxRSMaF(zwpUjFUdJGJLznWV(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p2f179579) dLOUKFTXiOSdNEuY((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(RjnSAKWwFvCTfPsS(bbAPSblqcMIOJshL(new java.lang.stringBuilder("encoding error in getInstance: "), LCgLhPQqJzMytFPg(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p2f179579 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarWZaUvFwtcUIdVBXC = wZaUvFwtcUIdVBXC(p582a4948Var);
        return (z || (p301c7ed4VarWZaUvFwtcUIdVBXC is p5a445d71.p9f931cf3.pca323100.p2f179579)) ? ixECBdqfXuokNtNw(p301c7ed4VarWZaUvFwtcUIdVBXC) : new p5a445d71.p9f931cf3.pca323100.p2f179579(cOaTjAgVzNswHhWY(fFDNHzANNjrNJVbp(p301c7ed4VarWZaUvFwtcUIdVBXC)));
    }

    public static java.lang.string PgiZhCuZiFxRSMaF(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 WZaUvFwtcUIdVBXC(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.Class ZwpUjFUdJGJLznWV(java.lang.object obj) {
        return obj.GetType();
    }
}

