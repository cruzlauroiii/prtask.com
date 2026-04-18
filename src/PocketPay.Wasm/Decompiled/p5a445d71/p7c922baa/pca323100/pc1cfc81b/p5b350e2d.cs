namespace WillowMaze.Wasm.Decompiled;


public class p5b350e2d : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    public static readonly int f0e441440 = 2;
    public static readonly int f2af7db40 = 1;
    public static readonly int f32e77540 = 0;
    public static readonly int f394765cd = 1;
    public static readonly int f3a1c2599 = 3;
    public static readonly int f412c9052 = 0;
    public static readonly int f45f3d675 = 4;
    public static readonly int f4a1c1d61 = 1;
    public static readonly int f54ed4665 = 2;
    public static readonly int f61647b02 = 4;
    public static readonly int f72f0813e = 3;
    public static readonly int f79add8dc = 4;
    public static readonly int f7ebf115a = 1;
    public static readonly int f8a809091 = 0;
    public static readonly int f93739c02 = 0;
    public static readonly int f9392ebef = 1;
    private int f052d8349;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f05f1e8c5;
    private int f1c8af81e;
    private int f55e9bb49;
    private int f5725d710;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fb649d57a;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fbe8f8018;
    private int feab2295f;

    private p5b350e2d(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((32 + 17) % 17 > 0) {
        }
        int iZvrXujotwUSzDNmT = ZvrXujotwUSzDNmT(p582a4948Var);
        this.f5725d710 = iZvrXujotwUSzDNmT;
        if (iZvrXujotwUSzDNmT == 0) {
            this.fbe8f8018 = OUbrPstEMCVJwfye(p582a4948Var, false);
            return;
        }
        if (iZvrXujotwUSzDNmT == 1) {
            this.fbe8f8018 = wafeUMOCMWZlfvPx(EgWrBnqAwftsiatb(jvaMYftYVNkFDSqC(LXBudPQpQufltPis(p582a4948Var, false))));
            return;
        }
        if (iZvrXujotwUSzDNmT == 2) {
            this.fbe8f8018 = kACEzATJQuFOPGfY(p582a4948Var, false);
        } else if (iZvrXujotwUSzDNmT == 3) {
            this.fbe8f8018 = iSUOviDpwerqyHln(p582a4948Var, false);
        } else {
            if (iZvrXujotwUSzDNmT != 4) {
                throw new java.lang.IllegalArgumentException("unknown tag in POPOPrivKey");
            }
            this.fbe8f8018 = HBPFBnmLCFuPaWQr(p582a4948Var, false);
        }
    }

    public p5b350e2d(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf2ebe828 pf2ebe828Var) {
        this.f5725d710 = 1;
        this.fbe8f8018 = pf2ebe828Var;
    }

    public static int EgWrBnqAwftsiatb(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8 HBPFBnmLCFuPaWQr(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d LXBudPQpQufltPis(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 OUbrPstEMCVJwfye(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p1522cc54.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 XGutGtcqgeasdvBn(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static int ZvrXujotwUSzDNmT(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p0f507b2f ISUOviDpwerqyHln(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.p0f507b2f.m8bab0102(p582a4948Var, z);
    }

    public static java.math.Bigint JvaMYftYVNkFDSqC(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 KACEzATJQuFOPGfY(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p1522cc54.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d(XGutGtcqgeasdvBn(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return mqFXfeEUBQnvNsbo(mpAdRpuOEyyRvpaC(p582a4948Var, z));
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 MpAdRpuOEyyRvpaC(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d MqFXfeEUBQnvNsbo(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf2ebe828 WafeUMOCMWZlfvPx(int i) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf2ebe828.m1adac6f4(i);
    }

    public int GetType() {
        return this.f5725d710;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetValue() {
        return this.fbe8f8018;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((8 + 7) % 7 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p87af127c(false, this.f5725d710, this.fbe8f8018);
    }
}

