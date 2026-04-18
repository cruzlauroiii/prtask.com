namespace WillowMaze.Wasm.Decompiled;


public class p1d095394 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f2063c160;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f65646f42;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fb5755fff;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ff16a7fb9;

    public p1d095394(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        this.f2063c160 = p11b04310Var;
    }

    public p1d095394(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        this.f2063c160 = p694426e7Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 BLXBDbCTihXjBvIF(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(obj);
    }

    public static int GeDAVTYvVCwxGaoy(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static byte[] IqrLpuChCijtIUap(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 LyNciDOXthuJObaa(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 PEkVOHEgIGqOfreN(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 GYlsIDRdtxJoYYVy(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 JtUzBbKsVckjqPeu(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394 M8bab0102(java.lang.object obj) {
        if ((9 + 21) % 21 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394) {
            return (p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p6f0e511c) {
            return new p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394((p5a445d71.p9f931cf3.pca323100.p6f0e511c) obj);
        }
        if (!(obj is p5a445d71.p9f931cf3.pca323100.p582a4948)) {
            return new p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394(BLXBDbCTihXjBvIF(obj));
        }
        p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var = (p5a445d71.p9f931cf3.pca323100.p582a4948) obj;
        return GeDAVTYvVCwxGaoy(p582a4948Var) != 1 ? new p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394(jtUzBbKsVckjqPeu(p582a4948Var, true)) : new p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394(PEkVOHEgIGqOfreN(p582a4948Var, true));
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return uGbMBfUyvHkSfHKc(gYlsIDRdtxJoYYVy(p582a4948Var));
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.p1d095394 UGbMBfUyvHkSfHKc(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public byte[] GetKeyHash() {
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f2063c160;
        if (p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.p11b04310) {
            return IqrLpuChCijtIUap((p5a445d71.p9f931cf3.pca323100.p11b04310) p0fd1bdf1Var);
        }
        return null;
    }

    public p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 GetName() {
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f2063c160;
        if (p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.p11b04310) {
            return null;
        }
        return LyNciDOXthuJObaa(p0fd1bdf1Var);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((25 + 18) % 18 > 0) {
        }
        return !(this.f2063c160 is p5a445d71.p9f931cf3.pca323100.p11b04310) ? new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 1, this.f2063c160) : new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 2, this.f2063c160);
    }
}

