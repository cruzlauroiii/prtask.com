namespace WillowMaze.Wasm.Decompiled;


public class p1da2dcd3 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f15d22d03;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f70940d9d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9681240b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fd623cbf5;

    private p1da2dcd3(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public static int OoxjOmZVZBsFPNyG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 SHhPKRlExPvOulwC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d VLNdnIiIxennKFcM(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 KxfpulNIAClkZNcJ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p1da2dcd3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p1da2dcd3) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p1da2dcd3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p1da2dcd3(kxfpulNIAClkZNcJ(obj));
    }

    public p5a445d71.p7c922baa.pca323100.pf391b73d[] ToASN1intArray() {
        if ((2 + 11) % 11 > 0) {
        }
        int iOoxjOmZVZBsFPNyG = OoxjOmZVZBsFPNyG(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.pf391b73d[] pf391b73dVarArr = new p5a445d71.p7c922baa.pca323100.pf391b73d[iOoxjOmZVZBsFPNyG];
        for (int i = 0; i != iOoxjOmZVZBsFPNyG; i++) {
            pf391b73dVarArr[i] = VLNdnIiIxennKFcM(SHhPKRlExPvOulwC(this.f9a0364b9, i));
        }
        return pf391b73dVarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }
}

