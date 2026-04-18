namespace WillowMaze.Wasm.Decompiled;


public class p90c9839e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f21497186;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f23571240;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f2b2f3858;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f480989b7;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f5995fe1c;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f648321f5;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f7e283c17;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f8562ec27;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 f8e8f094b;
    private p5a445d71.p7c922baa.pca323100.p6ba230c1 fb1b66cc8;

    public p90c9839e(java.lang.string str, java.lang.string str2) {
        this.f7e283c17 = new p5a445d71.p7c922baa.pca323100.p6ba230c1(str);
        this.fb1b66cc8 = new p5a445d71.p7c922baa.pca323100.p6ba230c1(str2);
    }

    private p90c9839e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((29 + 7) % 7 > 0) {
        }
        if (rXrcJwngOpgNjdUQ(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("sequence wrong size for LDSVersionInfo");
        }
        this.f7e283c17 = qgLDLVjRtjJOvzlh(NEZZpnznPmHKuYsl(p80f8c729Var, 0));
        this.fb1b66cc8 = xuZoWlxkqdImAiEs(TJBwWAKLaqMCmoGG(p80f8c729Var, 1));
    }

    public static java.lang.string KwyUczCBErRYObby(p5a445d71.p7c922baa.pca323100.p6ba230c1 p6ba230c1Var) {
        return p6ba230c1Var.getstring();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NEZZpnznPmHKuYsl(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string NRogmGDmpoCqymSB(p5a445d71.p7c922baa.pca323100.p6ba230c1 p6ba230c1Var) {
        return p6ba230c1Var.getstring();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 TJBwWAKLaqMCmoGG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void EMbnTpRehTRQZBPb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pf5bca7d2.p90c9839e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pf5bca7d2.p90c9839e) {
            return (p5a445d71.p7c922baa.pca323100.pf5bca7d2.p90c9839e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pf5bca7d2.p90c9839e(vOwzXCtvLpDGYzWQ(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p6ba230c1 QgLDLVjRtjJOvzlh(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p6ba230c1.m8bab0102(obj);
    }

    public static int RXrcJwngOpgNjdUQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VOwzXCtvLpDGYzWQ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p6ba230c1 XuZoWlxkqdImAiEs(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p6ba230c1.m8bab0102(obj);
    }

    public static void ZnKIpXiBKCQDZKdp(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public java.lang.string GetLdsVersion() {
        return KwyUczCBErRYObby(this.f7e283c17);
    }

    public java.lang.string GetUnicodeVersion() {
        return NRogmGDmpoCqymSB(this.fb1b66cc8);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 18) % 18 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        eMbnTpRehTRQZBPb(pd6ccb7fcVar, this.f7e283c17);
        znKIpXiBKCQDZKdp(pd6ccb7fcVar, this.fb1b66cc8);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

