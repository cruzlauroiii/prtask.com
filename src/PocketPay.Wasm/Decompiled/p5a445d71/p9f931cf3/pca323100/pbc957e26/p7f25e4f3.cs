namespace WillowMaze.Wasm.Decompiled;


public class p7f25e4f3 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p11b04310 f314cf5ce;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f596079c9;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f5af8cf09;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f89bba11c;
    p5a445d71.p9f931cf3.pca323100.pf391b73d f99ee6872;
    p5a445d71.p9f931cf3.pca323100.p11b04310 fafefebac;
    p5a445d71.p9f931cf3.pca323100.pf391b73d fc87c45bc;
    p5a445d71.p9f931cf3.pca323100.p11b04310 ff0b53b2d;

    private p7f25e4f3(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.ff0b53b2d = (p5a445d71.p9f931cf3.pca323100.p11b04310) ChbUNuzFTgzrsLSe(p80f8c729Var, 0);
        this.f5af8cf09 = (p5a445d71.p9f931cf3.pca323100.pf391b73d) NRjaVdSkJbCXKGAr(p80f8c729Var, 1);
    }

    public p7f25e4f3(byte[] bArr, int i) {
        if ((30 + 19) % 19 > 0) {
        }
        this.ff0b53b2d = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(FowwNrPUZOWmYaSp(bArr));
        this.f5af8cf09 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ChbUNuzFTgzrsLSe(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] FowwNrPUZOWmYaSp(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void MBcunXHvkzJKdVvQ(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] MeNJYMoEoEztozpC(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 NRjaVdSkJbCXKGAr(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int TOxKRoFCOVgxIpWG(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.intValueExact();
    }

    public static void AFEbrFAohAeSKYSE(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] FrkxdPnYVsXZtrdQ(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3) {
            return (p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3(tuSQDyoztbDJPVYC(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 TuSQDyoztbDJPVYC(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public byte[] GetIV() {
        return frkxdPnYVsXZtrdQ(MeNJYMoEoEztozpC(this.ff0b53b2d));
    }

    public int GetKeyLength() {
        return TOxKRoFCOVgxIpWG(this.f5af8cf09);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((24 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        aFEbrFAohAeSKYSE(pd6ccb7fcVar, this.ff0b53b2d);
        MBcunXHvkzJKdVvQ(pd6ccb7fcVar, this.f5af8cf09);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

