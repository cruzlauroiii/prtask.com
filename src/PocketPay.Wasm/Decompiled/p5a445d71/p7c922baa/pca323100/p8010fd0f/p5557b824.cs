namespace WillowMaze.Wasm.Decompiled;


public class p5557b824 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] f215abd35;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] f38a05f0b;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] f9bc98c5d;

    public p5557b824(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar) {
        if ((21 + 23) % 23 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr = new p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[1];
        p8670b90fVarArr[0] = p8670b90fVar;
        this.f38a05f0b = p8670b90fVarArr;
    }

    private p5557b824(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f38a05f0b = uvvWubVlZEpMcDew(p80f8c729Var);
    }

    public p5557b824(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr) {
        this.f38a05f0b = eapIFhKjJkCcoanL(p8670b90fVarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 IjNMYfLGnMufFezK(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 WgggruKwxesjocMl(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 YSajpnOiaycRlamZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] EapIFhKjJkCcoanL(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.md329fd77(p8670b90fVarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824(YSajpnOiaycRlamZ(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return WgggruKwxesjocMl(IjNMYfLGnMufFezK(p582a4948Var, z));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] URwfvisBKFBunXfd(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.md329fd77(p8670b90fVarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] UvvWubVlZEpMcDew(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.m443d6f6a(p80f8c729Var);
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] GetBodyPartIDs() {
        return uRwfvisBKFBunXfd(this.f38a05f0b);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(this.f38a05f0b);
    }
}

