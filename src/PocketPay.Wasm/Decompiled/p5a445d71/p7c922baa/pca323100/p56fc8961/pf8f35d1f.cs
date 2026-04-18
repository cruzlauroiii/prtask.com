namespace WillowMaze.Wasm.Decompiled;


public class pf8f35d1f : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p11b04310 f01503556;
    p5a445d71.p7c922baa.pca323100.p11b04310 f0d6abaf0;
    p5a445d71.p7c922baa.pca323100.pf391b73d f1f0cb8ae;
    p5a445d71.p7c922baa.pca323100.pf391b73d f462407ee;
    p5a445d71.p7c922baa.pca323100.pf391b73d f471dacea;
    p5a445d71.p7c922baa.pca323100.p11b04310 f5cd19527;
    p5a445d71.p7c922baa.pca323100.p11b04310 fc176fde4;
    p5a445d71.p7c922baa.pca323100.p11b04310 fceb20772;
    p5a445d71.p7c922baa.pca323100.pf391b73d fdf4f4d26;

    private pf8f35d1f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fceb20772 = (p5a445d71.p7c922baa.pca323100.p11b04310) XvTdMLCGFPhjJTxP(p80f8c729Var, 0);
        this.f471dacea = (p5a445d71.p7c922baa.pca323100.pf391b73d) OQxdUjQIDtSsGOjE(p80f8c729Var, 1);
    }

    public pf8f35d1f(byte[] bArr, int i) {
        if ((14 + 10) % 10 > 0) {
        }
        if (bArr.length != 8) {
            throw new java.lang.IllegalArgumentException("salt length must be 8");
        }
        this.fceb20772 = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
        this.f471dacea = new p5a445d71.p7c922baa.pca323100.pf391b73d(i);
    }

    public static byte[] HDITZHanDPffOxPy(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void IhYiwSdErvgUFbpb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OQxdUjQIDtSsGOjE(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 XvTdMLCGFPhjJTxP(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.math.Bigint LPtLkrhEApcfMLfq(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.pf8f35d1f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.pf8f35d1f) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.pf8f35d1f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.pf8f35d1f(vuknkbtYLwqBQzst(obj));
    }

    public static void RydoHCNXukCqjraf(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VuknkbtYLwqBQzst(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public java.math.Bigint GetIterationCount() {
        return lPtLkrhEApcfMLfq(this.f471dacea);
    }

    public byte[] GetSalt() {
        return HDITZHanDPffOxPy(this.fceb20772);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((2 + 16) % 16 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        rydoHCNXukCqjraf(pd6ccb7fcVar, this.fceb20772);
        IhYiwSdErvgUFbpb(pd6ccb7fcVar, this.f471dacea);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

