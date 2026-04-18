namespace WillowMaze.Wasm.Decompiled;


public class pb82bf363 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f2063c160;
    private int f43b999e5;
    private int f5725d710;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f8da54c40;
    private int f9c7f79cd;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fac29ee93;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ff55b9f4c;

    public pb82bf363() {
        this.f5725d710 = 0;
        this.f2063c160 = p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
    }

    public pb82bf363(int i, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f5725d710 = i;
        this.f2063c160 = p0fd1bdf1Var;
    }

    private pb82bf363(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((18 + 28) % 28 > 0) {
        }
        this.f5725d710 = lXqjEqAuTeEEHCne(p582a4948Var);
        int iVMpKkKiGkIviloJQ = VMpKkKiGkIviloJQ(p582a4948Var);
        if (iVMpKkKiGkIviloJQ == 0) {
            this.f2063c160 = p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
        } else if (iVMpKkKiGkIviloJQ == 1) {
            this.f2063c160 = HTZUpuKEnxLKkdYb(p582a4948Var, false);
        } else {
            if (iVMpKkKiGkIviloJQ != 2) {
                throw new java.lang.IllegalArgumentException(ujdAEdqFwGnYONyB(YgLtqbpeGvsZdJos(new java.lang.stringBuilder("Unknown tag encountered: "), ZzpdxSINWDZTBLfm(p582a4948Var))));
            }
            this.f2063c160 = p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
        }
    }

    public pb82bf363(p5a445d71.p7c922baa.pca323100.p785c9c91.p41e7b048 p41e7b048Var) {
        this.f5725d710 = 1;
        this.f2063c160 = p41e7b048Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pb82bf363 AsWNHsQTAqjVHAfo(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.p41e7b048 HTZUpuKEnxLKkdYb(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p785c9c91.p41e7b048.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.string NOKqOhMHxWWxbFDG(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class SrugTcSBNrsOyIaY(java.lang.object obj) {
        return obj.GetType();
    }

    public static int VMpKkKiGkIviloJQ(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.stringBuilder YgLtqbpeGvsZdJos(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ZzpdxSINWDZTBLfm(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static int LXqjEqAuTeEEHCne(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pb82bf363 M8bab0102(java.lang.object obj) {
        if ((25 + 17) % 17 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p785c9c91.pb82bf363)) {
            return (p5a445d71.p7c922baa.pca323100.p785c9c91.pb82bf363) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p582a4948) {
            return new p5a445d71.p7c922baa.pca323100.p785c9c91.pb82bf363((p5a445d71.p7c922baa.pca323100.p582a4948) obj);
        }
        throw new java.lang.IllegalArgumentException(rVELqNAJsaACQuqR(oXnkfIiCrkxZyejH(new java.lang.stringBuilder("unknown object in factory: "), NOKqOhMHxWWxbFDG(SrugTcSBNrsOyIaY(obj)))));
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pb82bf363 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return AsWNHsQTAqjVHAfo(tnYrNNspmyhAqKLb(p582a4948Var));
    }

    public static java.lang.stringBuilder OXnkfIiCrkxZyejH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RVELqNAJsaACQuqR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 TnYrNNspmyhAqKLb(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string UjdAEdqFwGnYONyB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetStatus() {
        return this.f2063c160;
    }

    public int GetTagNo() {
        return this.f5725d710;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 16) % 16 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p87af127c(false, this.f5725d710, this.f2063c160);
    }
}

