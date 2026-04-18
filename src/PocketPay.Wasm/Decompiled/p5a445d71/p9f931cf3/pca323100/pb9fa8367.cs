namespace WillowMaze.Wasm.Decompiled;


public abstract class pb9fa8367 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f5988be94 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fa6927e51 = null;

    static {
        if ((24 + 11) % 11 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.pb9fa8367$1(p5a445d71.p9f931cf3.pca323100.pb9fa8367.class, 5);
    }

    pb9fa8367() {
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 DbIlWqSzBpVhAtbj(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 HcxiToYvrdUrbkWY(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.stringBuilder HkYRagecDypMkVWE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p9f931cf3.pca323100.pb9fa8367 M3f441bde(byte[] bArr) {
        if (bArr.length != 0) {
            throw new java.lang.IllegalStateException("malformed NULL encoding encountered");
        }
        return p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17;
    }

    public static p5a445d71.p9f931cf3.pca323100.pb9fa8367 M8bab0102(java.lang.object obj) {
        if ((23 + 9) % 9 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pb9fa8367) {
            return (p5a445d71.p9f931cf3.pca323100.pb9fa8367) obj;
        }
        if (obj is null) {
            return null;
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.pb9fa8367) hcxiToYvrdUrbkWY(f94849514, (byte[]) obj);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException(vdiojvPJPfIumnDB(hkYRagecDypMkVWE(new java.lang.stringBuilder("failed to construct NULL from byte[]: "), zylEZYjJBubHZoPw(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pb9fa8367 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.pb9fa8367) DbIlWqSzBpVhAtbj(f94849514, p582a4948Var, z);
    }

    public static java.lang.string VdiojvPJPfIumnDB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZylEZYjJBubHZoPw(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.pb9fa8367;
    }

    public override int HashCode() {
        return -1;
    }

    public java.lang.string Tostring() {
        return "NULL";
    }
}

