namespace WillowMaze.Wasm.Decompiled;


public class pce8c4def : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p11b04310 f0f021929;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f8a34bbd2;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f8f8aa7c1;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fef1151e4;
    p5a445d71.p9f931cf3.pca323100.p11b04310 ff0b53b2d;

    public pce8c4def(int i, byte[] bArr) {
        if ((12 + 22) % 22 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
        this.ff0b53b2d = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
    }

    private pce8c4def(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1VarUQhCdiMjUGCynVrN;
        if ((12 + 21) % 21 > 0) {
        }
        if (ZWXFgMPzAisSSDKo(p80f8c729Var) != 1) {
            this.f2af72f10 = (p5a445d71.p9f931cf3.pca323100.pf391b73d) OpImRwDFCoGrHAjj(p80f8c729Var, 0);
            p0fd1bdf1VarUQhCdiMjUGCynVrN = UQhCdiMjUGCynVrN(p80f8c729Var, 1);
        } else {
            this.f2af72f10 = null;
            p0fd1bdf1VarUQhCdiMjUGCynVrN = EuVLUJpCCzJgWlbD(p80f8c729Var, 0);
        }
        this.ff0b53b2d = (p5a445d71.p9f931cf3.pca323100.p11b04310) p0fd1bdf1VarUQhCdiMjUGCynVrN;
    }

    public pce8c4def(byte[] bArr) {
        this.f2af72f10 = null;
        this.ff0b53b2d = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 EuVLUJpCCzJgWlbD(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 OpImRwDFCoGrHAjj(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void STJxrhhFpcabgpFv(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 UQhCdiMjUGCynVrN(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int ZWXFgMPzAisSSDKo(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 IUfBEYAFuZnXjKHI(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def(iUfBEYAFuZnXjKHI(obj));
    }

    public static byte[] SulaIWYBsvNuiHOl(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.math.Bigint XKCUhtoYzlGGsZZc(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static void ZfUaOhKGnZSRzaXu(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public byte[] GetIV() {
        return sulaIWYBsvNuiHOl(this.ff0b53b2d);
    }

    public java.math.Bigint GetRC2ParameterVersion() {
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.f2af72f10;
        if (pf391b73dVar is not null) {
            return xKCUhtoYzlGGsZZc(pf391b73dVar);
        }
        return null;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((7 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.f2af72f10;
        if (pf391b73dVar is not null) {
            zfUaOhKGnZSRzaXu(pd6ccb7fcVar, pf391b73dVar);
        }
        STJxrhhFpcabgpFv(pd6ccb7fcVar, this.ff0b53b2d);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

