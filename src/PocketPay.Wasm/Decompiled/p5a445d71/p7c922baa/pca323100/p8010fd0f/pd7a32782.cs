namespace WillowMaze.Wasm.Decompiled;


public class pd7a32782 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f0e0f3e1d;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae f1f73c67f;
    private readonly p5a445d71.p7c922baa.pca323100.p2dfa03b7 f3558de09;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f632eab11;
    private readonly p5a445d71.p7c922baa.pca323100.p2dfa03b7 f6890da6d;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f6b283440;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f982d2705;
    private readonly p5a445d71.p7c922baa.pca323100.p2dfa03b7 fa2dd6227;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae fac94a122;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae fc281bbe8;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 fcc60f61f;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae fd5f8d732;
    private readonly p5a445d71.p7c922baa.pca323100.p2dfa03b7 fe02f949a;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 fe52e3d7c;
    private readonly p5a445d71.p7c922baa.pca323100.p2dfa03b7 ff14aa2a1;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 ffd5f014a;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 ffdce7a34;

    pd7a32782(p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae p95aae2aeVar, p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, p5a445d71.p7c922baa.pca323100.p2dfa03b7 p2dfa03b7Var, p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 pd7a32782_p60ec1058) {
        this.f1f73c67f = p95aae2aeVar;
        this.fcc60f61f = p80f8c729Var;
        this.f3558de09 = p2dfa03b7Var;
        this.ffdce7a34 = pd7a32782_p60ec1058;
    }

    private pd7a32782(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((16 + 10) % 10 > 0) {
        }
        if (BNTsDSWjKWuwbJax(p80f8c729Var) < 2 || gyjsRWlbBxmRfMzd(p80f8c729Var) > 4) {
            throw new java.lang.IllegalArgumentException("incorrect sequence size");
        }
        this.f1f73c67f = omYWXbrmKmaPySwU(aclhnyiWTqRhiIgH(p80f8c729Var, 0));
        this.fcc60f61f = prklvIDaHEjVtdIS(wJkMwRQVJKzeqCdM(p80f8c729Var, 1));
        if (PGCooHVGaACAhNYh(p80f8c729Var) > 3) {
            this.f3558de09 = LFKjqTgyuFQlTgsX(UcnQZmxdnZoWYOuN(p80f8c729Var, 2));
            this.ffdce7a34 = gLsKdDBhVJLejGFk(wOFObAUFFUMjTApN(p80f8c729Var, 3));
        } else if (ywavQWcAuYKTByVO(p80f8c729Var) <= 2) {
            this.f3558de09 = null;
            this.ffdce7a34 = null;
        } else if (uZDPlyxwupOSluis(p80f8c729Var, 2) instanceof p5a445d71.p7c922baa.pca323100.p2dfa03b7) {
            this.f3558de09 = rAMGxLzSeLTdTsPC(yrpuSNZYIuniqIFG(p80f8c729Var, 2));
            this.ffdce7a34 = null;
        } else {
            this.f3558de09 = null;
            this.ffdce7a34 = hSdFEYgOMHxkdtkE(NXwmphEUoSAZynwd(p80f8c729Var, 2));
        }
    }

    public static int BNTsDSWjKWuwbJax(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void CKfUeGihHMqjMUbR(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p2dfa03b7 LFKjqTgyuFQlTgsX(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p2dfa03b7.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NXwmphEUoSAZynwd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void NyyMVimSAtpKhTpf(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int PGCooHVGaACAhNYh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void SbOVUflSTLLAsbye(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UcnQZmxdnZoWYOuN(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 YkmwTlgQDxRMASuT(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 AclhnyiWTqRhiIgH(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] EgWgpJBnEHuoDSYH(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pa470a233.m443d6f6a(p80f8c729Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 gLsKdDBhVJLejGFk(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058.mf23e8626(obj);
    }

    public static void GfKSOcvqXNpcVfBr(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int GyjsRWlbBxmRfMzd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 hSdFEYgOMHxkdtkE(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058.mf23e8626(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782(YkmwTlgQDxRMASuT(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae OmYWXbrmKmaPySwU(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 PrklvIDaHEjVtdIS(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p2dfa03b7 RAMGxLzSeLTdTsPC(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p2dfa03b7.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UZDPlyxwupOSluis(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WJkMwRQVJKzeqCdM(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WOFObAUFFUMjTApN(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YrpuSNZYIuniqIFG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int YwavQWcAuYKTByVO(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f[] GetBodyList() {
        return egWgpJBnEHuoDSYH(this.fcc60f61f);
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p95aae2ae GetCMCStatus() {
        return this.f1f73c67f;
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 getOtherInfo() {
        return this.ffdce7a34;
    }

    public p5a445d71.p7c922baa.pca323100.p2dfa03b7 GetStatusstring() {
        return this.f3558de09;
    }

    public bool HasOtherInfo() {
        return this.ffdce7a34 is not null;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 18) % 18 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        CKfUeGihHMqjMUbR(pd6ccb7fcVar, this.f1f73c67f);
        gfKSOcvqXNpcVfBr(pd6ccb7fcVar, this.fcc60f61f);
        p5a445d71.p7c922baa.pca323100.p2dfa03b7 p2dfa03b7Var = this.f3558de09;
        if (p2dfa03b7Var is not null) {
            SbOVUflSTLLAsbye(pd6ccb7fcVar, p2dfa03b7Var);
        }
        p5a445d71.p7c922baa.pca323100.p8010fd0f.pd7a32782$p60ec1058 pd7a32782_p60ec1058 = this.ffdce7a34;
        if (pd7a32782_p60ec1058 is not null) {
            NyyMVimSAtpKhTpf(pd6ccb7fcVar, pd7a32782_p60ec1058);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

