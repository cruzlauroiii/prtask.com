namespace WillowMaze.Wasm.Decompiled;


public class pa3153104 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f2ee69dd7;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a8427a4;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9c378e4d;

    private pa3153104(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public pa3153104(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        this(new p5a445d71.p7c922baa.pca323100.pb840b7ef(new p5a445d71.p7c922baa.pca323100.pb840b7ef(pf391b73dVar)));
        if ((29 + 2) % 2 > 0) {
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 JoETugoAorLVnfcb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d KJyPTngcOoBcNrWD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 SbBzgmWgFHdLINOG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int YrTyDfMeUbsjwUAy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d[] BvPIqOPdZteqVvtp(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return mf793769f(p80f8c729Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pa3153104 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.pa3153104) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.pa3153104) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.pa3153104(JoETugoAorLVnfcb(obj));
    }

    private static p5a445d71.p7c922baa.pca323100.pf391b73d[] Mf793769f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((29 + 23) % 23 > 0) {
        }
        int iWYfpstgCGhtHnrYN = wYfpstgCGhtHnrYN(p80f8c729Var);
        p5a445d71.p7c922baa.pca323100.pf391b73d[] pf391b73dVarArr = new p5a445d71.p7c922baa.pca323100.pf391b73d[iWYfpstgCGhtHnrYN];
        for (int i = 0; i != iWYfpstgCGhtHnrYN; i++) {
            pf391b73dVarArr[i] = KJyPTngcOoBcNrWD(SbBzgmWgFHdLINOG(p80f8c729Var, i));
        }
        return pf391b73dVarArr;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 QeedlzMPdtKelBmz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int WYfpstgCGhtHnrYN(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p7c922baa.pca323100.pf391b73d[][] GetCertReqIds() {
        if ((11 + 21) % 21 > 0) {
        }
        int iYrTyDfMeUbsjwUAy = YrTyDfMeUbsjwUAy(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.pf391b73d[][] pf391b73dVarArr = new p5a445d71.p7c922baa.pca323100.pf391b73d[iYrTyDfMeUbsjwUAy][];
        for (int i = 0; i != iYrTyDfMeUbsjwUAy; i++) {
            pf391b73dVarArr[i] = bvPIqOPdZteqVvtp((p5a445d71.p7c922baa.pca323100.p80f8c729) qeedlzMPdtKelBmz(this.f9a0364b9, i));
        }
        return pf391b73dVarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }
}

