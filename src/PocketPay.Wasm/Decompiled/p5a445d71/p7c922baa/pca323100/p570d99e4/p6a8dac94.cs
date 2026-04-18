namespace WillowMaze.Wasm.Decompiled;


public class p6a8dac94 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f5e42e2c8;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f7382c23d;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f8fcbcfbf;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fb80bb774;

    public p6a8dac94(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        if ((20 + 18) % 18 > 0) {
        }
        this.fb80bb774 = new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, p11b04310Var);
    }

    public p6a8dac94(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        this.fb80bb774 = p301c7ed4Var;
    }

    public p6a8dac94(p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195 pf7b98195Var) {
        this.fb80bb774 = pf7b98195Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195 NabdrUWpFdlbACFM(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 TBwuEszYFjXOOKNj(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 FGUSFIdjBDYgScVS(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string IyQNeiWflgXEWBRh(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class LQaePuJhDFDMOdqZ(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p6a8dac94 M8bab0102(java.lang.object obj) {
        if ((8 + 1) % 1 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p6a8dac94)) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p6a8dac94) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.p6a8dac94((p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195) obj);
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p11b04310) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.p6a8dac94((p5a445d71.p7c922baa.pca323100.p11b04310) obj);
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p301c7ed4) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.p6a8dac94((p5a445d71.p7c922baa.pca323100.p301c7ed4) obj);
        }
        throw new java.lang.IllegalArgumentException(vmUXWPkGQTQcFDTn(nVgGtnQtuIHBzrbC(new java.lang.stringBuilder("Illegal object in RecipientIdentifier: "), iyQNeiWflgXEWBRh(lQaePuJhDFDMOdqZ(obj)))));
    }

    public static java.lang.stringBuilder NVgGtnQtuIHBzrbC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VmUXWPkGQTQcFDTn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetId() {
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.fb80bb774;
        return !(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.p582a4948) ? NabdrUWpFdlbACFM(p0fd1bdf1Var) : TBwuEszYFjXOOKNj((p5a445d71.p7c922baa.pca323100.p582a4948) p0fd1bdf1Var, false);
    }

    public bool IsTagged() {
        return this.fb80bb774 is p5a445d71.p7c922baa.pca323100.p582a4948;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return fGUSFIdjBDYgScVS(this.fb80bb774);
    }
}

