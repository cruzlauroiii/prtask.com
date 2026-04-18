namespace WillowMaze.Wasm.Decompiled;


public class p4f763293 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f63360c3d;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fb80bb774;

    public p4f763293(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        if ((11 + 31) % 31 > 0) {
        }
        this.fb80bb774 = new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, p11b04310Var);
    }

    public p4f763293(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        this.fb80bb774 = p301c7ed4Var;
    }

    public p4f763293(p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195 pf7b98195Var) {
        this.fb80bb774 = pf7b98195Var;
    }

    public static java.lang.Class FqsotkkUelZtWRrj(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 DnNGDpVsgcFnbYhk(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string LeNxLbORRSdDnWTf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p4f763293 M8bab0102(java.lang.object obj) {
        if ((26 + 25) % 25 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p4f763293)) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p4f763293) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.p4f763293((p5a445d71.p7c922baa.pca323100.p570d99e4.pf7b98195) obj);
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p11b04310) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.p4f763293((p5a445d71.p7c922baa.pca323100.p11b04310) obj);
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p301c7ed4) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.p4f763293((p5a445d71.p7c922baa.pca323100.p301c7ed4) obj);
        }
        throw new java.lang.IllegalArgumentException(leNxLbORRSdDnWTf(uIHcTmXFEiyYFjoW(new java.lang.stringBuilder("Illegal object in SignerIdentifier: "), npvQbmsellzhqQdG(FqsotkkUelZtWRrj(obj)))));
    }

    public static java.lang.string NpvQbmsellzhqQdG(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 QKYkEsXGKRaSQwuN(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.stringBuilder UIHcTmXFEiyYFjoW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetId() {
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.fb80bb774;
        return !(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.p582a4948) ? p0fd1bdf1Var : qKYkEsXGKRaSQwuN((p5a445d71.p7c922baa.pca323100.p582a4948) p0fd1bdf1Var, false);
    }

    public bool IsTagged() {
        return this.fb80bb774 is p5a445d71.p7c922baa.pca323100.p582a4948;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return dnNGDpVsgcFnbYhk(this.fb80bb774);
    }
}

