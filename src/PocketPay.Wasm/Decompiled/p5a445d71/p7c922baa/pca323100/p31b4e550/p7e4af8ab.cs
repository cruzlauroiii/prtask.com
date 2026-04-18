namespace WillowMaze.Wasm.Decompiled;


public class p7e4af8ab : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f593e056b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f7ce8f91b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f848a90b7;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;

    private p7e4af8ab(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 NOwqTvCDfLqZcHOc(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pb82bf363 JHLRJpnXICFFgxBj(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.pb82bf363.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p7e4af8ab M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p7e4af8ab) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p7e4af8ab) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p7e4af8ab(NOwqTvCDfLqZcHOc(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WUHwRFRiEbibNVSt(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int WvcvdPotAwEOFkgU(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.pb82bf363[] ToCertStatusArray() {
        if ((2 + 24) % 24 > 0) {
        }
        int iWvcvdPotAwEOFkgU = wvcvdPotAwEOFkgU(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.p31b4e550.pb82bf363[] pb82bf363VarArr = new p5a445d71.p7c922baa.pca323100.p31b4e550.pb82bf363[iWvcvdPotAwEOFkgU];
        for (int i = 0; i != iWvcvdPotAwEOFkgU; i++) {
            pb82bf363VarArr[i] = jHLRJpnXICFFgxBj(wUHwRFRiEbibNVSt(this.f9a0364b9, i));
        }
        return pb82bf363VarArr;
    }
}

