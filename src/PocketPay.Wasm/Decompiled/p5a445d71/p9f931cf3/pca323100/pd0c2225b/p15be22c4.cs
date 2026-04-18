namespace WillowMaze.Wasm.Decompiled;


public class p15be22c4 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 f21ffce5b;
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 f439df7f6;

    private p15be22c4(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        this.f21ffce5b = p301c7ed4Var;
    }

    public p15be22c4(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        this.f21ffce5b = p364bf33aVar;
    }

    public p15be22c4(p5a445d71.p9f931cf3.pca323100.pb9fa8367 pb9fa8367Var) {
        this.f21ffce5b = pb9fa8367Var;
    }

    public p15be22c4(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        this.f21ffce5b = null;
        this.f21ffce5b = UKDbczwNdwGDzgMv(p35e46fcbVar);
    }

    public static java.lang.string BFDygFieXVqMgVgL(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static java.lang.string IFqocuKxlnwNGDti(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 UKDbczwNdwGDzgMv(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        return p35e46fcbVar.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 XtdcVJcdVPwhBfrK(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 AgIanFwHtmLxWnXC(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FbBFdpHxuhdwcZLa(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 M8bab0102(java.lang.object obj) {
        if ((18 + 11) % 11 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4)) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p301c7ed4) {
            return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.p301c7ed4) obj);
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException("unknown object in getInstance()");
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(agIanFwHtmLxWnXC((byte[]) obj));
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(IFqocuKxlnwNGDti(pgnLxHeSjIbboWjV(new java.lang.stringBuilder("unable to parse encoded data: "), BFDygFieXVqMgVgL(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return XtdcVJcdVPwhBfrK(fbBFdpHxuhdwcZLa(p582a4948Var));
    }

    public static java.lang.stringBuilder PgnLxHeSjIbboWjV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetParameters() {
        return this.f21ffce5b;
    }

    public bool IsImplicitlyCA() {
        return this.f21ffce5b is p5a445d71.p9f931cf3.pca323100.pb9fa8367;
    }

    public bool IsNamedCurve() {
        return this.f21ffce5b is p5a445d71.p9f931cf3.pca323100.p364bf33a;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f21ffce5b;
    }
}

