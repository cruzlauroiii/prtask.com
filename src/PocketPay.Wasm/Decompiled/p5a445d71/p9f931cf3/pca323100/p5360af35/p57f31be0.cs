namespace WillowMaze.Wasm.Decompiled;


public class p57f31be0 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f0f09fa83;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f2315f674;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f56bb0e36;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f60466443;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fa001b1c6;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a fbeb37618;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a fd3da9677;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fdd7e9353;

    public p57f31be0(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, byte[] bArr) {
        this.fbeb37618 = p364bf33aVar;
        this.fa001b1c6 = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(yFSPpiFRhdpcYiSA(bArr));
    }

    private p57f31be0(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fbeb37618 = BKXIJcduMwpYnoGe(DYLIprSUwYGgfuFU(p80f8c729Var, 0));
        this.fa001b1c6 = KuvOPKNJzSgveCUQ(VhQBvuookLmqRrrl(p80f8c729Var, 1));
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a BKXIJcduMwpYnoGe(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 DYLIprSUwYGgfuFU(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 KuvOPKNJzSgveCUQ(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static byte[] LpKnhjiAeZDOtacS(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void OUIPgXGJLYYbPjUv(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 VhQBvuookLmqRrrl(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] FyyXuDLKSxhILcHs(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p57f31be0 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p5360af35.p57f31be0) {
            return (p5a445d71.p9f931cf3.pca323100.p5360af35.p57f31be0) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p5360af35.p57f31be0(vjTkLRRDTIvdpbdX(obj));
    }

    public static void VIlHQqqvCFgOvSZH(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 VjTkLRRDTIvdpbdX(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static byte[] YFSPpiFRhdpcYiSA(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetKeyAlgorithm() {
        return this.fbeb37618;
    }

    public byte[] GetKeybytes() {
        return fyyXuDLKSxhILcHs(LpKnhjiAeZDOtacS(this.fa001b1c6));
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((9 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        OUIPgXGJLYYbPjUv(pd6ccb7fcVar, this.fbeb37618);
        vIlHQqqvCFgOvSZH(pd6ccb7fcVar, this.fa001b1c6);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

