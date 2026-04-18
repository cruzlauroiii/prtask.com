namespace WillowMaze.Wasm.Decompiled;


public class pe8543724 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly java.math.Bigint f071878f8;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd f305f0745;
    private readonly java.math.Bigint f35377ac2;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd f588296b1;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd fcf52b10b;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd fe0ade71a;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd ffbb85711;

    private pe8543724(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((10 + 27) % 27 > 0) {
        }
        if (SJlNRQZDdkLmBRux(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("incorrect sequence size");
        }
        this.ffbb85711 = qxiGukipRTtgtdYc(IknFFlSLVulHndKI(p80f8c729Var, 0));
        this.f071878f8 = tkCQRAzUzzOhRfSh(LGiHzDWULDVAXdmb(dvwrEbhdEUSKDASO(p80f8c729Var, 1)));
    }

    public pe8543724(p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, java.math.Bigint bigint) {
        this.ffbb85711 = pf17d2ecdVar;
        this.f071878f8 = bigint;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IknFFlSLVulHndKI(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d LGiHzDWULDVAXdmb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static int SJlNRQZDdkLmBRux(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void YTAdiebWwsnDmkBQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void AhpTtvlnAslvNtlB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DvwrEbhdEUSKDASO(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pe8543724 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.pe8543724) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.pe8543724) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.pe8543724(uunpaTxCoFIDaisb(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd QxiGukipRTtgtdYc(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(obj);
    }

    public static java.math.Bigint TkCQRAzUzzOhRfSh(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 UunpaTxCoFIDaisb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pf17d2ecd GetIssuerName() {
        return this.ffbb85711;
    }

    public java.math.Bigint GetSerialNumber() {
        return this.f071878f8;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 4) % 4 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        YTAdiebWwsnDmkBQ(pd6ccb7fcVar, this.ffbb85711);
        ahpTtvlnAslvNtlB(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.pf391b73d(this.f071878f8));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

