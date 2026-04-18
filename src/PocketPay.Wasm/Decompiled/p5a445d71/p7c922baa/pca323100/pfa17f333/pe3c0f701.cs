namespace WillowMaze.Wasm.Decompiled;


public class pe3c0f701 {
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 f0970ceef;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 f19cc8703;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 f35134c72;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 f9305b73d;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 fdc226acf;

    public pe3c0f701(p5a445d71.p7c922baa.pca323100.pff11dfb3 pff11dfb3Var) {
        this.f9305b73d = pff11dfb3Var;
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.pe3c0f701 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.pe3c0f701) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.pe3c0f701) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.pff11dfb3) {
            return new p5a445d71.p7c922baa.pca323100.pfa17f333.pe3c0f701(xXYomaJLVwuOGNya(obj));
        }
        return null;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 PjRwCvmJZeYEWvrt(p5a445d71.p7c922baa.pca323100.pff11dfb3 pff11dfb3Var) {
        return pff11dfb3Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.pff11dfb3 XXYomaJLVwuOGNya(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pff11dfb3.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pff11dfb3 GetUri() {
        return this.f9305b73d;
    }

    public p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return pjRwCvmJZeYEWvrt(this.f9305b73d);
    }
}

