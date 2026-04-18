namespace WillowMaze.Wasm.Decompiled;


public class pe8dcd05e : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    public static readonly int f10298581 = 2;
    public static readonly int f2076b961 = 1;
    public static readonly int f49d656be = 1;
    public static readonly int f4f6367e9 = 1;
    public static readonly int f5b7b13ba = 2;
    public static readonly int f991d5395 = 2;
    public static readonly int f9b22ca34 = 0;
    public static readonly int face626cc = 0;
    public static readonly int fb7964c6d = 0;
    public static readonly int fb97c89be = 1;
    public static readonly int fb9922002 = 2;
    public static readonly int fd08f26b7 = 0;
    public static readonly int fde7bd0f2 = 1;
    public static readonly int ff495a1d3 = 0;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f134231d4;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f2063c160;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f918da444;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fbd789d85;

    public pe8dcd05e(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        this.f2063c160 = p11b04310Var;
    }

    private pe8dcd05e(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((22 + 14) % 14 > 0) {
        }
        int iEkFrKcAoRyYOZfyi = EkFrKcAoRyYOZfyi(p582a4948Var);
        if (iEkFrKcAoRyYOZfyi == 0) {
            this.f2063c160 = hdpukUACWykUUgrP(uBUgZPNglmuzyXqA(p582a4948Var));
        } else if (iEkFrKcAoRyYOZfyi == 1) {
            this.f2063c160 = WWjbetZrGJOEyaDg(p582a4948Var, false);
        } else {
            if (iEkFrKcAoRyYOZfyi != 2) {
                throw new java.lang.IllegalArgumentException(gidHxGhKMxMYxNZK(PvMtxzjnHBSeAJhT(new java.lang.stringBuilder("unknown tag number: "), hXJKouUIsJEXXHaU(p582a4948Var))));
            }
            this.f2063c160 = yePrjlQKHEQJVViR(p582a4948Var, false);
        }
    }

    public pe8dcd05e(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442 pf4b56442Var) {
        this.f2063c160 = pf4b56442Var;
    }

    public pe8dcd05e(bool z) {
        this.f2063c160 = fFWsZlbFTgyNDrrD(z);
    }

    public static int EkFrKcAoRyYOZfyi(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.stringBuilder KoKHWluOHRaqSdCl(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder PvMtxzjnHBSeAJhT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 WWjbetZrGJOEyaDg(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e FFWsZlbFTgyNDrrD(bool z) {
        return p5a445d71.p7c922baa.pca323100.p41bf756e.m8bab0102(z);
    }

    public static java.lang.string GidHxGhKMxMYxNZK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HXJKouUIsJEXXHaU(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442 HdpukUACWykUUgrP(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442.m8bab0102(obj);
    }

    public static java.lang.string KVDuaiHSQckmFbxF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pe8dcd05e M8bab0102(java.lang.object obj) {
        if ((15 + 31) % 31 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pe8dcd05e)) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.pe8dcd05e) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p582a4948) {
            return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pe8dcd05e((p5a445d71.p7c922baa.pca323100.p582a4948) obj);
        }
        throw new java.lang.IllegalArgumentException(kVDuaiHSQckmFbxF(KoKHWluOHRaqSdCl(new java.lang.stringBuilder("unknown object: "), obj)));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 UBUgZPNglmuzyXqA(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e YePrjlQKHEQJVViR(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p41bf756e.m8bab0102(p582a4948Var, z);
    }

    public int GetType() {
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f2063c160;
        if (p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442) {
            return 0;
        }
        return !(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.p11b04310) ? 2 : 1;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((12 + 31) % 31 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f2063c160;
        return !(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442) ? !(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.p11b04310) ? new p5a445d71.p7c922baa.pca323100.p87af127c(false, 2, this.f2063c160) : new p5a445d71.p7c922baa.pca323100.p87af127c(false, 1, this.f2063c160) : new p5a445d71.p7c922baa.pca323100.p87af127c(true, 0, this.f2063c160);
    }
}

