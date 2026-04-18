namespace WillowMaze.Wasm.Decompiled;


public class pe05e3ad3 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private int f058586c5;
    private byte[] f24198bba;
    private byte[] f29c22054;
    private byte[] f3f277600;
    private int f462c71e8;
    private int f82d5fdaf;
    private int f858a50e4;
    private byte[] fcb584e44;

    private pe05e3ad3(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((17 + 14) % 14 > 0) {
        }
        this.fcb584e44 = NMfcqTJTjzEEpuKq(lYVudBhtjToveVVA(RiTctixpGkDoidAu(p80f8c729Var, 0)));
        if (XahkFpMBumELEUpL(p80f8c729Var) != 2) {
            this.f058586c5 = 12;
        } else {
            this.f058586c5 = jQZOzxnrCgoFFCCA(EGMEmRrAFaPNZJnL(NyQQojMtViPMsDJU(wETfiTezkNVDojgU(p80f8c729Var, 1))));
        }
    }

    public pe05e3ad3(byte[] bArr, int i) {
        this.fcb584e44 = wXfQNxiWqXDUcoRU(bArr);
        this.f058586c5 = i;
    }

    public static java.math.Bigint EGMEmRrAFaPNZJnL(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static byte[] GIhYNgywZyvZeQij(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void MDhwTHCsIoufPabF(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 MJKfTrSrgwxqshuF(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static byte[] NMfcqTJTjzEEpuKq(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d NyQQojMtViPMsDJU(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 RiTctixpGkDoidAu(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int XahkFpMBumELEUpL(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int JQZOzxnrCgoFFCCA(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 LYVudBhtjToveVVA(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pe05e3ad3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pe05e3ad3) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pe05e3ad3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pe05e3ad3(MJKfTrSrgwxqshuF(obj));
    }

    public static void RDibzKqZZVziOgOc(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WETfiTezkNVDojgU(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] WXfQNxiWqXDUcoRU(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public int GetIcvLen() {
        return this.f058586c5;
    }

    public byte[] GetNonce() {
        return GIhYNgywZyvZeQij(this.fcb584e44);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((26 + 22) % 22 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        MDhwTHCsIoufPabF(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p6f0e511c(this.fcb584e44));
        if (this.f058586c5 != 12) {
            rDibzKqZZVziOgOc(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.pf391b73d(this.f058586c5));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

