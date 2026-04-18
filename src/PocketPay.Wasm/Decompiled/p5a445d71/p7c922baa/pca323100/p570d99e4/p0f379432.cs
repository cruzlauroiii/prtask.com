namespace WillowMaze.Wasm.Decompiled;


public class p0f379432 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly java.math.Bigint f4ce8d43a;
    private readonly java.math.Bigint f5af8cf09;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fb6767e2f;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fdcd88ed9;

    private p0f379432(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((21 + 13) % 13 > 0) {
        }
        if (HSnihteLXhPkMubh(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("ASN.1 SEQUENCE should be of length 2");
        }
        this.fb6767e2f = vzMTofzXIunofOSy(jauXsVByTrSXQmew(p80f8c729Var, 0));
        this.f5af8cf09 = EPulJDAHijUOTrDB(xbeXaqHrodlHWQVj(WMzLGGLbKGSYiuoj(p80f8c729Var, 1)));
    }

    public p0f379432(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, int i) {
        this.fb6767e2f = p234a7530Var;
        this.f5af8cf09 = PNxTNJklrbBYAHeY(i);
    }

    public static java.math.Bigint EPulJDAHijUOTrDB(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static int HSnihteLXhPkMubh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.math.Bigint PNxTNJklrbBYAHeY(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WMzLGGLbKGSYiuoj(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GmGvoUxQNKdbayRW(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JauXsVByTrSXQmew(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p0f379432 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p0f379432) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p0f379432) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p0f379432(gmGvoUxQNKdbayRW(obj));
    }

    public static void MOJJJfHvyNPTAOaA(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void TSfeIVuRXxDKYfcz(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 VzMTofzXIunofOSy(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d XbeXaqHrodlHWQVj(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetKeyDerivationFunction() {
        return this.fb6767e2f;
    }

    public java.math.Bigint GetKeyLength() {
        return this.f5af8cf09;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((27 + 31) % 31 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        tSfeIVuRXxDKYfcz(pd6ccb7fcVar, this.fb6767e2f);
        mOJJJfHvyNPTAOaA(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.pf391b73d(this.f5af8cf09));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

