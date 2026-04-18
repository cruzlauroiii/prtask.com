namespace WillowMaze.Wasm.Decompiled;


public class p1dd1689b : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f302fb83d;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f9b898ab3;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fa5c0cab7;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 ffe4c0f30;

    public p1dd1689b(p5a445d71.p9f931cf3.pca323100.p1522cc54 p1522cc54Var, p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        if (p1522cc54Var is null) {
            throw new java.lang.IllegalArgumentException("'seed' cannot be null");
        }
        if (pf391b73dVar is null) {
            throw new java.lang.IllegalArgumentException("'pgenCounter' cannot be null");
        }
        this.ffe4c0f30 = p1522cc54Var;
        this.fa5c0cab7 = pf391b73dVar;
    }

    private p1dd1689b(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((16 + 29) % 29 > 0) {
        }
        if (AzYzcFpgFTutamJw(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException(JbMJRNgCaRwzpjwA(WupAdSKIHoQibDWS(new java.lang.stringBuilder("Bad sequence size: "), uKlzbbOpYTZFMvtp(p80f8c729Var))));
        }
        this.ffe4c0f30 = vekhuwPOtDDORlTU(HTCCRIZfwERqPKan(p80f8c729Var, 0));
        this.fa5c0cab7 = ynfuDhYohkrmdPDN(fOWwWTeJxrhgcTnS(p80f8c729Var, 1));
    }

    public p1dd1689b(byte[] bArr, int i) {
        if ((27 + 32) % 32 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("'seed' cannot be null");
        }
        this.ffe4c0f30 = new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr);
        this.fa5c0cab7 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 AZUKludkkKdODsap(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static int AzYzcFpgFTutamJw(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 HTCCRIZfwERqPKan(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string JbMJRNgCaRwzpjwA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] MYAZEepkmEDtBdxE(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getbytes();
    }

    public static void MYIdydGcAZHKWQZp(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.stringBuilder WupAdSKIHoQibDWS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 DVICDqUcLzRrxvxO(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 FOWwWTeJxrhgcTnS(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b(dVICDqUcLzRrxvxO(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return oCQBbEdWWGKLtFtY(AZUKludkkKdODsap(p582a4948Var, z));
    }

    public static void MdAFLDzcHGMAYtKU(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b OCQBbEdWWGKLtFtY(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.math.Bigint QcaPXnKUNsvoCiRH(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getPositiveValue();
    }

    public static int UKlzbbOpYTZFMvtp(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p29d19857 VekhuwPOtDDORlTU(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p29d19857.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d YnfuDhYohkrmdPDN(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public java.math.Bigint GetPgenCounter() {
        return qcaPXnKUNsvoCiRH(this.fa5c0cab7);
    }

    public byte[] GetSeed() {
        return MYAZEepkmEDtBdxE(this.ffe4c0f30);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((20 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        MYIdydGcAZHKWQZp(pd6ccb7fcVar, this.ffe4c0f30);
        mdAFLDzcHGMAYtKU(pd6ccb7fcVar, this.fa5c0cab7);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

