namespace WillowMaze.Wasm.Decompiled;


public class p32555e78 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.p570d99e4.p10860abd {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f5f52ba2f;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f81280edf;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f9075a441;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f9563da7d;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f95bed075;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fc276a5ef;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fdf5feafa;
    private p5a445d71.p7c922baa.pca323100.p364bf33a ff617c391;

    public p32555e78(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.fdf5feafa = p364bf33aVar;
        this.f9a0364b9 = p0fd1bdf1Var;
    }

    public p32555e78(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((15 + 25) % 25 > 0) {
        }
        if (IMHtkeyZGsyknoyp(p80f8c729Var) < 1 || nWgeSggLAGXPakdH(p80f8c729Var) > 2) {
            throw new java.lang.IllegalArgumentException(MVyTaKzWyUsvcqkH(QkNCSZZSvcKaygOD(new java.lang.stringBuilder("Bad sequence size: "), XhiRwSNXLvknRedw(p80f8c729Var))));
        }
        this.fdf5feafa = (p5a445d71.p7c922baa.pca323100.p364bf33a) AVwPdYuhUCJqNTqx(p80f8c729Var, 0);
        if (RoAFTtlazAwfKWgX(p80f8c729Var) <= 1) {
            return;
        }
        p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var = (p5a445d71.p7c922baa.pca323100.p582a4948) MqlKPoYfcZpUSwyM(p80f8c729Var, 1);
        if (!nycfYLUmVwNgoNoC(p582a4948Var) || hqvdbdLVNRtmtjSD(p582a4948Var) != 0) {
            throw new java.lang.IllegalArgumentException("Bad tag for 'content'");
        }
        this.f9a0364b9 = ktAVlTlICtCyKxre(p582a4948Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 AVwPdYuhUCJqNTqx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int IMHtkeyZGsyknoyp(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 IuPdsKUVvaVEMwEZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.string MVyTaKzWyUsvcqkH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MqlKPoYfcZpUSwyM(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.stringBuilder QkNCSZZSvcKaygOD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int RoAFTtlazAwfKWgX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int XhiRwSNXLvknRedw(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 YhDGwBYpnZPfClRM(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static int HqvdbdLVNRtmtjSD(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 KtAVlTlICtCyKxre(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 LjJRwdzBbbfhMiKs(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78(IuPdsKUVvaVEMwEZ(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return ljJRwdzBbbfhMiKs(YhDGwBYpnZPfClRM(p582a4948Var, z));
    }

    public static int NWgeSggLAGXPakdH(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static bool NycfYLUmVwNgoNoC(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.isExplicit();
    }

    public static void RTrWAKnjfsIkdwNb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void ZmMJJXoNcwhrgyVg(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetContent() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetContentType() {
        return this.fdf5feafa;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((18 + 14) % 14 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        zmMJJXoNcwhrgyVg(pd6ccb7fcVar, this.fdf5feafa);
        if (this.f9a0364b9 is not null) {
            rTrWAKnjfsIkdwNb(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.pd0fc91bc(0, this.f9a0364b9));
        }
        return new p5a445d71.p7c922baa.pca323100.p6a819fa7(pd6ccb7fcVar);
    }
}

