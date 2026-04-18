namespace WillowMaze.Wasm.Decompiled;


public class pce8c4def : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.pf391b73d f2af72f10;
    p5a445d71.p7c922baa.pca323100.pf391b73d f593beec6;
    p5a445d71.p7c922baa.pca323100.p11b04310 f8766c56f;
    p5a445d71.p7c922baa.pca323100.pf391b73d f8f8099ed;
    p5a445d71.p7c922baa.pca323100.pf391b73d fc0009002;
    p5a445d71.p7c922baa.pca323100.p11b04310 ff0b53b2d;

    public pce8c4def(int i, byte[] bArr) {
        if ((18 + 19) % 19 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p7c922baa.pca323100.pf391b73d(i);
        this.ff0b53b2d = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
    }

    private pce8c4def(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((29 + 7) % 7 > 0) {
        }
        if (fhLWVutVGnXjvAXN(p80f8c729Var) != 1) {
            this.f2af72f10 = (p5a445d71.p7c922baa.pca323100.pf391b73d) DiqJlIYikfOsLjgG(p80f8c729Var, 0);
            this.ff0b53b2d = (p5a445d71.p7c922baa.pca323100.p11b04310) biZuNfWkvUKWEwyP(p80f8c729Var, 1);
        } else {
            this.f2af72f10 = null;
            this.ff0b53b2d = (p5a445d71.p7c922baa.pca323100.p11b04310) gVnuhfRpqIJwtFHj(p80f8c729Var, 0);
        }
    }

    public pce8c4def(byte[] bArr) {
        this.f2af72f10 = null;
        this.ff0b53b2d = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DiqJlIYikfOsLjgG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.math.Bigint JEUwddpSccSIWGDj(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 RJcOpbCLhIWjzzWN(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void TtwUTmwmNddyIuzh(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BiZuNfWkvUKWEwyP(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int FhLWVutVGnXjvAXN(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GVnuhfRpqIJwtFHj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.pce8c4def M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.pce8c4def) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.pce8c4def) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.pce8c4def(RJcOpbCLhIWjzzWN(obj));
    }

    public static void RONmdByJOUIdQGRd(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] VRdqIighhJpJViiW(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public byte[] GetIV() {
        return vRdqIighhJpJViiW(this.ff0b53b2d);
    }

    public java.math.Bigint GetRC2ParameterVersion() {
        p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar = this.f2af72f10;
        if (pf391b73dVar is not null) {
            return JEUwddpSccSIWGDj(pf391b73dVar);
        }
        return null;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((22 + 24) % 24 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar = this.f2af72f10;
        if (pf391b73dVar is not null) {
            rONmdByJOUIdQGRd(pd6ccb7fcVar, pf391b73dVar);
        }
        TtwUTmwmNddyIuzh(pd6ccb7fcVar, this.ff0b53b2d);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

