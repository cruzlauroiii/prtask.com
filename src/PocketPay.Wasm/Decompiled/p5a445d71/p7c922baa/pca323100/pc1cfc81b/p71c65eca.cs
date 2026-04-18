namespace WillowMaze.Wasm.Decompiled;


public class p71c65eca : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    public static readonly int f00d404c4 = 0;
    public static readonly int f068272f7 = 3;
    public static readonly int f5bea44d2 = 1;
    public static readonly int f705fd729 = 1;
    public static readonly int f7181f32d = 1;
    public static readonly int f7b426c82 = 2;
    public static readonly int f9ae9aa28 = 0;
    public static readonly int f9fd36423 = 1;
    public static readonly int fa49dcc6c = 0;
    public static readonly int fdf291335 = 2;
    public static readonly int fe0d89d5e = 0;
    public static readonly int fe3088709 = 0;
    public static readonly int ff243a470 = 1;
    public static readonly int ff47284de = 3;
    private int f2255b7b8;
    private int f5725d710;
    private int f7e5a925a;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f896251ce;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fa8a2dce7;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fbe8f8018;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fea31a9c1;

    public p71c65eca() {
        this.f5725d710 = 0;
        this.fbe8f8018 = p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
    }

    public p71c65eca(int i, p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d p5b350e2dVar) {
        this.f5725d710 = i;
        this.fbe8f8018 = p5b350e2dVar;
    }

    private p71c65eca(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((18 + 26) % 26 > 0) {
        }
        int iIhgSuGxXpTqbgIxl = IhgSuGxXpTqbgIxl(p582a4948Var);
        this.f5725d710 = iIhgSuGxXpTqbgIxl;
        if (iIhgSuGxXpTqbgIxl == 0) {
            this.fbe8f8018 = p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
            return;
        }
        if (iIhgSuGxXpTqbgIxl == 1) {
            this.fbe8f8018 = ChDOYelXCzHibcpi(p582a4948Var, false);
        } else {
            if (iIhgSuGxXpTqbgIxl != 2 && iIhgSuGxXpTqbgIxl != 3) {
                throw new java.lang.IllegalArgumentException(hkaGQnkRlhQXWUSh(fSFOUGxecqfepsCZ(new java.lang.stringBuilder("unknown tag: "), this.f5725d710)));
            }
            this.fbe8f8018 = sRXhoMQbWABRKnAu(p582a4948Var, true);
        }
    }

    public p71c65eca(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pcd023950 pcd023950Var) {
        this.f5725d710 = 1;
        this.fbe8f8018 = pcd023950Var;
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pcd023950 ChDOYelXCzHibcpi(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.pcd023950.m8bab0102(p582a4948Var, z);
    }

    public static int IhgSuGxXpTqbgIxl(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.stringBuilder IwGBBQbADZzSWxpW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YLFEdqGsXQvkSplb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FSFOUGxecqfepsCZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string HkaGQnkRlhQXWUSh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class JphZgMUuOZWMAdKv(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p71c65eca M8bab0102(java.lang.object obj) {
        if ((9 + 25) % 25 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.p71c65eca)) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.p71c65eca) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p582a4948) {
            return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.p71c65eca((p5a445d71.p7c922baa.pca323100.p582a4948) obj);
        }
        throw new java.lang.IllegalArgumentException(YLFEdqGsXQvkSplb(IwGBBQbADZzSWxpW(new java.lang.stringBuilder("Invalid object: "), sTxSWGwZkzTGqJuM(jphZgMUuOZWMAdKv(obj)))));
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d SRXhoMQbWABRKnAu(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.p5b350e2d.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.string STxSWGwZkzTGqJuM(java.lang.Class cls) {
        return cls.getName();
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Getobject() {
        return this.fbe8f8018;
    }

    public int GetType() {
        return this.f5725d710;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((23 + 22) % 22 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p87af127c(false, this.f5725d710, this.fbe8f8018);
    }
}

