namespace WillowMaze.Wasm.Decompiled;


public class p6ffd7460 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] f21729065;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] f38a05f0b;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] facb4d9f2;

    public p6ffd7460(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar) {
        if ((31 + 17) % 17 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr = new p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[1];
        p8670b90fVarArr[0] = p8670b90fVar;
        this.f38a05f0b = p8670b90fVarArr;
    }

    private p6ffd7460(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f38a05f0b = sdHxEskxXzWCchzx(p80f8c729Var);
    }

    public p6ffd7460(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr) {
        this.f38a05f0b = OkwwOnAyCfgCMZNh(p8670b90fVarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] CiaBAGgmyEpvkhmM(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.md329fd77(p8670b90fVarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] OkwwOnAyCfgCMZNh(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] p8670b90fVarArr) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.md329fd77(p8670b90fVarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 AzZpyBpBhvDLylqA(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p6ffd7460 BBiRZeBtTmBCfHSE(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p6ffd7460 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p6ffd7460) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p6ffd7460) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p6ffd7460(zwKGrXMdPJrwiwvb(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p6ffd7460 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return bBiRZeBtTmBCfHSE(azZpyBpBhvDLylqA(p582a4948Var, z));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] SdHxEskxXzWCchzx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.m443d6f6a(p80f8c729Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 ZwKGrXMdPJrwiwvb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] GetBodyPartIDs() {
        return CiaBAGgmyEpvkhmM(this.f38a05f0b);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(this.f38a05f0b);
    }
}

