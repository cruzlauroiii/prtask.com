namespace WillowMaze.Wasm.Decompiled;


public class p14febf43 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f f014d6e81;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 f3cbb2ac0;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f f7cd87af9;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f f81f241d7;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 f84893b2a;

    public p14febf43(p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 p5557b824Var) {
        this.f7cd87af9 = null;
        this.f84893b2a = p5557b824Var;
    }

    public p14febf43(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar) {
        this.f7cd87af9 = p8670b90fVar;
        this.f84893b2a = null;
    }

    public static java.lang.string CTKwRBVQBIFtgIEK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f EwvXPOSXiJhYbwyM(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 KMGqXvVetnziPHMc(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar) {
        return p8670b90fVar.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 LVGKoZpvoKdrAQMH(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 LsOLqTUFYrlhSRbj(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824.m8bab0102(obj);
    }

    public static java.lang.string LxsPbNgUXdWxQtRZ(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 OxhbjvbHCLwcgBMv(p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 p5557b824Var) {
        return p5557b824Var.toASN1Primitive();
    }

    public static java.lang.stringBuilder PPPfhwspzoMMuZCs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43 JgCXSzXHfJjXPAjr(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 KQbRSSVSMXaKiies(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43 M8bab0102(java.lang.object obj) {
        if ((15 + 22) % 22 > 0) {
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43) obj;
        }
        if (obj is null) {
            return null;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p0fd1bdf1) {
            p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarLVGKoZpvoKdrAQMH = LVGKoZpvoKdrAQMH((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarLVGKoZpvoKdrAQMH is p5a445d71.p7c922baa.pca323100.pf391b73d) {
                return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43(EwvXPOSXiJhYbwyM(p301c7ed4VarLVGKoZpvoKdrAQMH));
            }
            if (p301c7ed4VarLVGKoZpvoKdrAQMH is p5a445d71.p7c922baa.pca323100.p80f8c729) {
                return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43(LsOLqTUFYrlhSRbj(p301c7ed4VarLVGKoZpvoKdrAQMH));
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(CTKwRBVQBIFtgIEK(PPPfhwspzoMMuZCs(new java.lang.stringBuilder("unknown object in getInstance(): "), LxsPbNgUXdWxQtRZ(nbFFCBZIqUxSRKEp(obj)))));
        }
        try {
            return jgCXSzXHfJjXPAjr(kQbRSSVSMXaKiies((byte[]) obj));
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("unknown encoding in getInstance()");
        }
    }

    public static java.lang.Class NbFFCBZIqUxSRKEp(java.lang.object obj) {
        return obj.GetType();
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f GetBodyPartID() {
        return this.f7cd87af9;
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p5557b824 GetBodyPartPath() {
        return this.f84893b2a;
    }

    public bool IsBodyPartID() {
        return this.f7cd87af9 is not null;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar = this.f7cd87af9;
        return p8670b90fVar is null ? OxhbjvbHCLwcgBMv(this.f84893b2a) : KMGqXvVetnziPHMc(p8670b90fVar);
    }
}

