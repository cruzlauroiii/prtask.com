namespace WillowMaze.Wasm.Decompiled;


public class p46a7aa58 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p11b04310 f445f9e47;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f471dacea;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f7ef42d82;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f86ac5a6b;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fca4ff1e4;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fe106ea38;
    p5a445d71.p9f931cf3.pca323100.p11b04310 ff0b53b2d;

    private p46a7aa58(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.ff0b53b2d = (p5a445d71.p9f931cf3.pca323100.p11b04310) liJUYycJUdevzHVu(p80f8c729Var, 0);
        this.f471dacea = vxNxkVtvVJhFBfIc(OYKInYLNvYfYnirX(p80f8c729Var, 1));
    }

    public p46a7aa58(byte[] bArr, int i) {
        if ((30 + 31) % 31 > 0) {
        }
        this.ff0b53b2d = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
        this.f471dacea = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
    }

    public static java.math.Bigint FmHFCKTqeVoEKSRs(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 MAmcvMyRyWAqyndi(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 OYKInYLNvYfYnirX(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void DYDNLRThhqBGnQLa(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 LiJUYycJUdevzHVu(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58(MAmcvMyRyWAqyndi(obj));
    }

    public static byte[] MVLsmHVNBWxURnuA(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d VxNxkVtvVJhFBfIc(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static void XIuHGLjqvvNoyecV(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public byte[] GetIV() {
        return mVLsmHVNBWxURnuA(this.ff0b53b2d);
    }

    public java.math.Bigint GetIterations() {
        return FmHFCKTqeVoEKSRs(this.f471dacea);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((4 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        xIuHGLjqvvNoyecV(pd6ccb7fcVar, this.ff0b53b2d);
        dYDNLRThhqBGnQLa(pd6ccb7fcVar, this.f471dacea);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

