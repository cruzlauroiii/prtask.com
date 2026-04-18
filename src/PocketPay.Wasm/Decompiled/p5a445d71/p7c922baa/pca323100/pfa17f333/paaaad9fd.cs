namespace WillowMaze.Wasm.Decompiled;


public class paaaad9fd : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pb907b377 f3b3885d0;
    private p5a445d71.p7c922baa.pca323100.pb907b377 f8c2930da;
    private p5a445d71.p7c922baa.pca323100.pb907b377 fbf74d668;
    private p5a445d71.p7c922baa.pca323100.p785c9c91.p1d095394 fe040c09c;
    private p5a445d71.p7c922baa.pca323100.pb907b377 fe9de23c3;
    private p5a445d71.p7c922baa.pca323100.p785c9c91.p1d095394 feee40bd6;

    public paaaad9fd(p5a445d71.p7c922baa.pca323100.p785c9c91.p1d095394 p1d095394Var, p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var) {
        this.feee40bd6 = p1d095394Var;
        this.fbf74d668 = pb907b377Var;
    }

    private paaaad9fd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((8 + 12) % 12 > 0) {
        }
        if (PmpBulXreOkxMDzF(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException(jPhjKdYuVxAhcSnu(zYjeiCJJDWtMNRxT(new java.lang.stringBuilder("Bad sequence size: "), sMPfDIuPXUsBMacL(p80f8c729Var))));
        }
        this.feee40bd6 = ziJapbAkjpSaIYut(PBiXDVoKrZaUCpGO(p80f8c729Var, 0));
        this.fbf74d668 = (p5a445d71.p7c922baa.pca323100.pb907b377) ikaYTxeHEKzgVsyf(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PBiXDVoKrZaUCpGO(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int PmpBulXreOkxMDzF(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IkaYTxeHEKzgVsyf(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string JPhjKdYuVxAhcSnu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JyTrTOiUyhULUGjr(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.paaaad9fd M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.paaaad9fd) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.paaaad9fd) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.paaaad9fd(oUygQXrjuaecdyCJ(obj));
    }

    public static void NEOOJJrglaZgMEjK(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 OUygQXrjuaecdyCJ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static int SMPfDIuPXUsBMacL(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.stringBuilder ZYjeiCJJDWtMNRxT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.p1d095394 ZiJapbAkjpSaIYut(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p785c9c91.p1d095394.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p785c9c91.p1d095394 GetOcspResponderID() {
        return this.feee40bd6;
    }

    public p5a445d71.p7c922baa.pca323100.pb907b377 GetProducedAt() {
        return this.fbf74d668;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((8 + 18) % 18 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        jyTrTOiUyhULUGjr(pd6ccb7fcVar, this.feee40bd6);
        nEOOJJrglaZgMEjK(pd6ccb7fcVar, this.fbf74d668);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

