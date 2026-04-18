namespace WillowMaze.Wasm.Decompiled;


public class pa5e23224 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f2d58543b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f3ecb5a5d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fb0a7bb44;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fe999a413;

    private pa5e23224(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pb5f5623b CgKLFTbcyhLCVHFq(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.pb5f5623b.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BviQraeRaeLyUFRm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int CjhWdjaHOBUQEVsp(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pa5e23224 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.pa5e23224) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.pa5e23224) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.pa5e23224(uBKDksGJIopBRWra(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 UBKDksGJIopBRWra(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.pb5f5623b[] ToChallengeArray() {
        if ((12 + 13) % 13 > 0) {
        }
        int iCjhWdjaHOBUQEVsp = cjhWdjaHOBUQEVsp(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.p31b4e550.pb5f5623b[] pb5f5623bVarArr = new p5a445d71.p7c922baa.pca323100.p31b4e550.pb5f5623b[iCjhWdjaHOBUQEVsp];
        for (int i = 0; i != iCjhWdjaHOBUQEVsp; i++) {
            pb5f5623bVarArr[i] = CgKLFTbcyhLCVHFq(bviQraeRaeLyUFRm(this.f9a0364b9, i));
        }
        return pb5f5623bVarArr;
    }
}

