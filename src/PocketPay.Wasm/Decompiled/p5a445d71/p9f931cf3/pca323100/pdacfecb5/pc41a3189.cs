namespace WillowMaze.Wasm.Decompiled;


public class pc41a3189 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    public static readonly int f12dafa33 = 0;
    public static readonly int f4c305d95 = 0;
    public static readonly int f524174d5 = 1;
    public static readonly int f686f6f87 = 0;
    public static readonly int f6c44a006 = 0;
    public static readonly int f700d89e9 = 1;
    public static readonly int f934d1c4b = 1;
    public static readonly int f9f321189 = 0;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd f440c818f;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd f52355edd;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd fa5810ca3;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd fb4b3dbdd;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd fd44c9d4e;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd ffd953a80;

    public pc41a3189(int i, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        this(new p5a445d71.p9f931cf3.pca323100.p87af127c(i, pf17d2ecdVar));
    }

    private pc41a3189(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        if ((10 + 12) % 12 > 0) {
        }
        int iGgkCLvAaXtQeZHkd = ggkCLvAaXtQeZHkd(p582a4948Var);
        if (iGgkCLvAaXtQeZHkd == 0) {
            this.fa5810ca3 = rJaNuOrbAdQTohUh(p582a4948Var, true);
        } else {
            if (iGgkCLvAaXtQeZHkd != 1) {
                throw new java.lang.IllegalArgumentException(mJdAiCHNcvXBfWcJ(BLoVoGseNBpMNGvk(new java.lang.stringBuilder("unknown tag: "), EqTDuQvSjLAbSePZ(p582a4948Var))));
            }
            this.f52355edd = RYgDEgwtvyUoEVnh(p582a4948Var, true);
        }
    }

    public static java.lang.stringBuilder BLoVoGseNBpMNGvk(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int EqTDuQvSjLAbSePZ(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.Class JtpiYnzQWotFhhSJ(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder PXuDqETrOKVnQNNy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd RYgDEgwtvyUoEVnh(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.string RcieNeADvZGUSYCE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GgkCLvAaXtQeZHkd(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189 M8bab0102(java.lang.object obj) {
        if ((25 + 19) % 19 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189)) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p582a4948) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189((p5a445d71.p9f931cf3.pca323100.p582a4948) obj);
        }
        throw new java.lang.IllegalArgumentException(RcieNeADvZGUSYCE(PXuDqETrOKVnQNNy(new java.lang.stringBuilder("unknown object in factory: "), JtpiYnzQWotFhhSJ(obj))));
    }

    public static java.lang.string MJdAiCHNcvXBfWcJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd RJaNuOrbAdQTohUh(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(p582a4948Var, z);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd GetTargetGroup() {
        return this.f52355edd;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd GetTargetName() {
        return this.fa5810ca3;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((18 + 31) % 31 > 0) {
        }
        return this.fa5810ca3 is null ? new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f52355edd) : new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fa5810ca3);
    }
}

