namespace WillowMaze.Wasm.Decompiled;


public class pff11dfb3 : p5a445d71.p9f931cf3.pca323100.p2f096beb {
    public pff11dfb3(java.lang.string str) {
        this(str, false);
    }

    public pff11dfb3(java.lang.string str, bool z) {
        super(str, z);
    }

    pff11dfb3(byte[] bArr, bool z) {
        super(bArr, z);
    }

    public static java.lang.stringBuilder CFtyxYrIUQYJxJoz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] RdkWfGEcIrMgJIwW(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 TDiogMCQucBtlHqK(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string TpszofcbjIAPiovc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string EAZOPmlwcgABGkEZ(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pff11dfb3 GDhvKPLFwWdCGvda(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string GEZAHgfHUJCpQVyj(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p9f931cf3.pca323100.pff11dfb3 M8bab0102(java.lang.object obj) {
        if ((26 + 23) % 23 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pff11dfb3)) {
            return (p5a445d71.p9f931cf3.pca323100.pff11dfb3) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p2f096beb) {
            return new p5a445d71.p9f931cf3.pca323100.pff11dfb3(((p5a445d71.p9f931cf3.pca323100.p2f096beb) obj).f98bf7d8c, false);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(TpszofcbjIAPiovc(CFtyxYrIUQYJxJoz(new java.lang.stringBuilder("illegal object in getInstance: "), gEZAHgfHUJCpQVyj(sKBKkfrQiQuSiGwq(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.pff11dfb3) TDiogMCQucBtlHqK((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(mfIwKjQCJveMGyiX(qaknTKpXAKAizNHu(new java.lang.stringBuilder("encoding error in getInstance: "), eAZOPmlwcgABGkEZ(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pff11dfb3 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarQIQfKgXXiSRJggSQ = qIQfKgXXiSRJggSQ(p582a4948Var);
        return (z || (p301c7ed4VarQIQfKgXXiSRJggSQ is p5a445d71.p9f931cf3.pca323100.pff11dfb3)) ? gDhvKPLFwWdCGvda(p301c7ed4VarQIQfKgXXiSRJggSQ) : new p5a445d71.p9f931cf3.pca323100.pff11dfb3(RdkWfGEcIrMgJIwW(wyOugxGjwCNuonkD(p301c7ed4VarQIQfKgXXiSRJggSQ)), true);
    }

    public static java.lang.string MfIwKjQCJveMGyiX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 QIQfKgXXiSRJggSQ(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.stringBuilder QaknTKpXAKAizNHu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class SKBKkfrQiQuSiGwq(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 WyOugxGjwCNuonkD(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }
}

