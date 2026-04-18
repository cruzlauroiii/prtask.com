namespace WillowMaze.Wasm.Decompiled;


public class p147a4cc0 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f160966a8;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f33ec9d4c;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f41529076;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fa862730e;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fe6290326;

    public p147a4cc0(java.math.Bigint bigint) {
        if (bigint is null) {
            throw new java.lang.IllegalArgumentException("'y' cannot be null");
        }
        this.f41529076 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint);
    }

    private p147a4cc0(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        if (pf391b73dVar is null) {
            throw new java.lang.IllegalArgumentException("'y' cannot be null");
        }
        this.f41529076 = pf391b73dVar;
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d LrjXhfrYxLCqpzHO(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.Class OkQXyOZfrNIvUHjv(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0 QwCCjMFugisPDyxc(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.math.Bigint TPeyVlZkAgXtHxZU(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static java.lang.stringBuilder GoKxZdZKBkHXlhae(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0 M8bab0102(java.lang.object obj) {
        if ((2 + 7) % 7 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0)) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0((p5a445d71.p9f931cf3.pca323100.pf391b73d) obj);
        }
        throw new java.lang.IllegalArgumentException(tHmkNFwWBYhkTncP(goKxZdZKBkHXlhae(new java.lang.stringBuilder("Invalid DHPublicKey: "), rNfdukMPFVPxFZbF(OkQXyOZfrNIvUHjv(obj)))));
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return QwCCjMFugisPDyxc(LrjXhfrYxLCqpzHO(p582a4948Var, z));
    }

    public static java.lang.string RNfdukMPFVPxFZbF(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string THmkNFwWBYhkTncP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public java.math.Bigint GetY() {
        return TPeyVlZkAgXtHxZU(this.f41529076);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f41529076;
    }
}

