namespace WillowMaze.Wasm.Decompiled;


public class p38bc363a : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pf391b73d f2af72f10;
    private byte[] f3b6922bd;
    private byte[] f3c74ddda;
    private byte[] f46420ce5;
    private byte[] f77dc8f2d;
    private p5a445d71.p7c922baa.pca323100.pf391b73d f8d81354a;
    private p5a445d71.p7c922baa.pca323100.pf391b73d fbbabc846;
    private p5a445d71.p7c922baa.pca323100.pf391b73d fbc52d891;
    private byte[] fc36853ea;

    private p38bc363a(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((12 + 21) % 21 > 0) {
        }
        if (QsWXEvZkTuZKlTof(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException(HtxmxZGgWIfPkWcA(QmMTVAxFmOzJuvCD(new java.lang.stringBuilder("size of seq = "), ZewYvNmDDvFysMHq(p80f8c729Var))));
        }
        this.f2af72f10 = ngQOiPEgEfzGVvyx(YRupHGSElpoNeuGO(p80f8c729Var, 0));
        this.fc36853ea = TeIaTxzCNixdwzOX(JQzriLYNuLzRCIlz(qRqoeJWNfgnRtSKG(p80f8c729Var, 1)));
    }

    public p38bc363a(byte[] bArr) {
        if ((28 + 16) % 16 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p7c922baa.pca323100.pf391b73d(0L);
        this.fc36853ea = bArr;
    }

    public static void EGcHsypfwGkwzDdL(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.string HtxmxZGgWIfPkWcA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 JQzriLYNuLzRCIlz(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 LcOXKNZkKeZXuRTj(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.stringBuilder QmMTVAxFmOzJuvCD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int QsWXEvZkTuZKlTof(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static byte[] TeIaTxzCNixdwzOX(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] UkXdgWBSSUZGyKOQ(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YRupHGSElpoNeuGO(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int ZewYvNmDDvFysMHq(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void BJErJOghIUsxNzJc(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.pca323100.p38bc363a M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pccb008a9.pca323100.p38bc363a) {
            return (p5a445d71.p7c922baa.pccb008a9.pca323100.p38bc363a) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pccb008a9.pca323100.p38bc363a(LcOXKNZkKeZXuRTj(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d NgQOiPEgEfzGVvyx(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 QRqoeJWNfgnRtSKG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public byte[] GetPublicKey() {
        return UkXdgWBSSUZGyKOQ(this.fc36853ea);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((29 + 3) % 3 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        EGcHsypfwGkwzDdL(pd6ccb7fcVar, this.f2af72f10);
        bJErJOghIUsxNzJc(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p6f0e511c(this.fc36853ea));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

