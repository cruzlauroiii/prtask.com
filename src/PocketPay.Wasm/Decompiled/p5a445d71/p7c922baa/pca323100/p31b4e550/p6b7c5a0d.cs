namespace WillowMaze.Wasm.Decompiled;


public class p6b7c5a0d : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9513d08d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 faee831ee;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fb825f215;

    private p6b7c5a0d(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public p6b7c5a0d(p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pe7f120eaVar);
    }

    public static int DDUsCadHpMfzYCid(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 QFQCAJtmHXhEKdQo(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 HQtHOPaDNbLPQlVQ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p6b7c5a0d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p6b7c5a0d) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p6b7c5a0d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p6b7c5a0d(hQtHOPaDNbLPQlVQ(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea NadcxSXKICZqBwsD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[] GetCertificateLists() {
        if ((31 + 14) % 14 > 0) {
        }
        int iDDUsCadHpMfzYCid = DDUsCadHpMfzYCid(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[] pe7f120eaVarArr = new p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[iDDUsCadHpMfzYCid];
        for (int i = 0; i != iDDUsCadHpMfzYCid; i++) {
            pe7f120eaVarArr[i] = nadcxSXKICZqBwsD(QFQCAJtmHXhEKdQo(this.f9a0364b9, i));
        }
        return pe7f120eaVarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }
}

