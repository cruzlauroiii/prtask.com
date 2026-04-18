namespace WillowMaze.Wasm.Decompiled;


public class p29ed1a11 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pb9fa8367 f3a6d0284;
    private p5a445d71.p7c922baa.pca323100.pb9fa8367 f427d10f3;

    public p29ed1a11() {
        this.f3a6d0284 = p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
    }

    private p29ed1a11(p5a445d71.p7c922baa.pca323100.pb9fa8367 pb9fa8367Var) {
        this.f3a6d0284 = pb9fa8367Var;
    }

    public static java.lang.Class BzUJqOJYLKlHMuov(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string UfTFCzwCFoASXjWI(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder VCHOTsCvpVEbhizm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p29ed1a11 M8bab0102(java.lang.object obj) {
        if ((1 + 31) % 31 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p29ed1a11)) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p29ed1a11) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.pb9fa8367) {
            return new p5a445d71.p7c922baa.pca323100.p31b4e550.p29ed1a11((p5a445d71.p7c922baa.pca323100.pb9fa8367) obj);
        }
        throw new java.lang.IllegalArgumentException(xzERhAjfWjjcLRNO(VCHOTsCvpVEbhizm(new java.lang.stringBuilder("Invalid object: "), UfTFCzwCFoASXjWI(BzUJqOJYLKlHMuov(obj)))));
    }

    public static java.lang.string XzERhAjfWjjcLRNO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f3a6d0284;
    }
}

