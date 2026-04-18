namespace WillowMaze.Wasm.Decompiled;


public class p518a5a71 : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p11b04310 f12bcd60d;
    p5a445d71.p7c922baa.pca323100.p11b04310 f2063c160;
    p5a445d71.p7c922baa.pca323100.p11b04310 f5633841b;
    p5a445d71.p7c922baa.pca323100.p11b04310 f6ba58638;

    private p518a5a71(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        this.f2063c160 = p11b04310Var;
    }

    public p518a5a71(byte[] bArr) {
        this(new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr));
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 FfDVQdRYyQBcryHW(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p38107303.p518a5a71 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p38107303.p518a5a71) {
            return (p5a445d71.p7c922baa.pca323100.p38107303.p518a5a71) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p38107303.p518a5a71(FfDVQdRYyQBcryHW(obj));
    }

    public p5a445d71.p7c922baa.pca323100.p11b04310 GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f2063c160;
    }
}

