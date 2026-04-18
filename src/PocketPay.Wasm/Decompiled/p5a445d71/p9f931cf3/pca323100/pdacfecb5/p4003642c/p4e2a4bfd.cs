namespace WillowMaze.Wasm.Decompiled;


public class p4e2a4bfd : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.pb97c537b, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p687d5786 {
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f10847d85;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f1948863a;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f206eaeba;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f52edd648;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f9aa66f2e;
    p5a445d71.p9f931cf3.pca323100.p364bf33a fd4c1f93a;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fe6753d82;
    p5a445d71.p9f931cf3.pca323100.p364bf33a fefc8b704;

    public p4e2a4bfd(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        this.fd4c1f93a = p364bf33aVar;
        this.f1948863a = null;
    }

    public p4e2a4bfd(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.fd4c1f93a = p364bf33aVar;
        this.f1948863a = p0fd1bdf1Var;
    }

    private p4e2a4bfd(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationJXDyKLdzyzUNCZvr = jXDyKLdzyzUNCZvr(p80f8c729Var);
        this.fd4c1f93a = pHTEKaezjdbwECMl(qaKgCvjMoXAEjtGO(enumerationJXDyKLdzyzUNCZvr));
        if (OqQpEvYHkiVcMJDe(enumerationJXDyKLdzyzUNCZvr)) {
            this.f1948863a = (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) SJAYXadMBVextsdr(enumerationJXDyKLdzyzUNCZvr);
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 LiuocUMpxVDHcZuY(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static bool OqQpEvYHkiVcMJDe(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.lang.object SJAYXadMBVextsdr(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.util.Enumeration JXDyKLdzyzUNCZvr(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd(LiuocUMpxVDHcZuY(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a PHTEKaezjdbwECMl(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static void PHXITPYXKEPpHUce(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object QaKgCvjMoXAEjtGO(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void SMzuvaQByNjrSEdX(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetStatementId() {
        return this.fd4c1f93a;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetStatementInfo() {
        return this.f1948863a;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((10 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        pHXITPYXKEPpHUce(pd6ccb7fcVar, this.fd4c1f93a);
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f1948863a;
        if (p0fd1bdf1Var is not null) {
            sMzuvaQByNjrSEdX(pd6ccb7fcVar, p0fd1bdf1Var);
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

