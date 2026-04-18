namespace WillowMaze.Wasm.Decompiled;


public class p9d79b71f : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    public static readonly int f01d3fcca = 1;
    public static readonly int f0e46430b = 0;
    public static readonly int f3f98ed0e = 0;
    public static readonly int f71a12666 = 0;
    public static readonly int f8b8a92c2 = 2;
    public static readonly int f8d510a38 = 2;
    public static readonly int fa1bab530 = 0;
    public static readonly int fd64e181d = 1;
    public static readonly int fdce8b65f = 2;
    private readonly int f0296734a;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f1e3e3525;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f2063c160;
    private readonly int f2eb99ef0;
    private readonly int f5725d710 = 0;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f6fa16d57;
    private readonly int f77b8ec22;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f8c6389d3;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fd793e9d5;

    public p9d79b71f(p5a445d71.p7c922baa.pca323100.p8010fd0f.pfc2cb1bd pfc2cb1bdVar) {
        this.f2063c160 = pfc2cb1bdVar;
    }

    private p9d79b71f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f2063c160 = p80f8c729Var;
    }

    public p9d79b71f(p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131 p9d37b131Var) {
        this.f2063c160 = p9d37b131Var;
    }

    public static java.lang.stringBuilder AwjdvRgQIqSamEjo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EVKAkYcZFJBxXbtO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131 HdUXDJmchUurvVji(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.string PXvSyQLznxNEwzUa(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class TcVFWbMbFCjbXrFA(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 UfWakmDasikzDVJv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static int XWuLGykAeFXhRYZB(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static int CfHmPOSOfAEqplxY(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pfc2cb1bd DfFtyjfifOaFKVBq(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.pfc2cb1bd.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 FNKPsYDHaNdykvLp(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f IqmGcqZvZxvOypfr(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string LUmmggIeXKpuIryx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f M8bab0102(java.lang.object obj) {
        if ((8 + 14) % 14 > 0) {
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f) obj;
        }
        if (obj is null) {
            return null;
        }
        if (!(obj is p5a445d71.p7c922baa.pca323100.p0fd1bdf1)) {
            if (!(obj is byte[])) {
                throw new java.lang.IllegalArgumentException(lUmmggIeXKpuIryx(AwjdvRgQIqSamEjo(new java.lang.stringBuilder("unknown object in getInstance(): "), PXvSyQLznxNEwzUa(TcVFWbMbFCjbXrFA(obj)))));
            }
            try {
                return iqmGcqZvZxvOypfr(szpHRvzSDlSEJizJ((byte[]) obj));
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("unknown encoding in getInstance()");
            }
        }
        p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948VarFNKPsYDHaNdykvLp = fNKPsYDHaNdykvLp(ncqAIuwXDxsZtJEo((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) obj));
        int iXWuLGykAeFXhRYZB = XWuLGykAeFXhRYZB(p582a4948VarFNKPsYDHaNdykvLp);
        if (iXWuLGykAeFXhRYZB == 0) {
            return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f(dfFtyjfifOaFKVBq(p582a4948VarFNKPsYDHaNdykvLp, false));
        }
        if (iXWuLGykAeFXhRYZB == 1) {
            return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f(HdUXDJmchUurvVji(p582a4948VarFNKPsYDHaNdykvLp, false));
        }
        if (iXWuLGykAeFXhRYZB != 2) {
            throw new java.lang.IllegalArgumentException(ujtsVwjIyoCZkEpv(EVKAkYcZFJBxXbtO(new java.lang.stringBuilder("unknown tag in getInstance(): "), cfHmPOSOfAEqplxY(p582a4948VarFNKPsYDHaNdykvLp))));
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p9d79b71f(UfWakmDasikzDVJv(p582a4948VarFNKPsYDHaNdykvLp, false));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NcqAIuwXDxsZtJEo(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 SzpHRvzSDlSEJizJ(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static java.lang.string UjtsVwjIyoCZkEpv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public int GetTagNo() {
        return this.f5725d710;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((26 + 26) % 26 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p87af127c(false, this.f5725d710, this.f2063c160);
    }
}

