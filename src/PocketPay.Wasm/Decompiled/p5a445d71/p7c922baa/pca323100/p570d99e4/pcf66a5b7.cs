namespace WillowMaze.Wasm.Decompiled;


public class pcf66a5b7 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea f407d3cd5;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea f8484727f;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f87a3cb5c;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f9e6f6b50;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 fc0849077;

    public pcf66a5b7(p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 p32555e78Var) {
        this.f87a3cb5c = p32555e78Var;
    }

    private pcf66a5b7(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((28 + 5) % 5 > 0) {
        }
        this.f87a3cb5c = drFKNbMgavtPAxJG(rwYzLXyeXJFtnXFG(p80f8c729Var, 0));
        if (WRgXahbyjAiKIqAB(p80f8c729Var) != 2) {
            return;
        }
        this.f8484727f = OFqFIGlxuAzIhTcY(EFSFDvZWjuBKemkW(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 CCkfwZgMSzYSEktc(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 EFSFDvZWjuBKemkW(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea OFqFIGlxuAzIhTcY(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea.m8bab0102(obj);
    }

    public static void SMHkfLXsmytHNZCX(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int WRgXahbyjAiKIqAB(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 DrFKNbMgavtPAxJG(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pcf66a5b7(CCkfwZgMSzYSEktc(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 RwYzLXyeXJFtnXFG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void YaPbpxmYdqdNVpoo(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea GetCRL() {
        return this.f8484727f;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea GetCertificateList() {
        return this.f8484727f;
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 GetTimeStampToken() {
        return this.f87a3cb5c;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 25) % 25 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        SMHkfLXsmytHNZCX(pd6ccb7fcVar, this.f87a3cb5c);
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar = this.f8484727f;
        if (pe7f120eaVar is not null) {
            yaPbpxmYdqdNVpoo(pd6ccb7fcVar, pe7f120eaVar);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

