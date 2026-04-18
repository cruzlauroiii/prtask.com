namespace WillowMaze.Wasm.Decompiled;


public class p57f31be0 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f054d4a10;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 f662458be;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 fa001b1c6;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a fbeb37618;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 fcfe55dc4;

    public p57f31be0(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, byte[] bArr) {
        this.fbeb37618 = p364bf33aVar;
        this.fa001b1c6 = new p5a445d71.p7c922baa.pca323100.p6f0e511c(BlwclWPVFZNISRbh(bArr));
    }

    private p57f31be0(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fbeb37618 = MCuSGjVNNmXWOagW(BJswERidhNQBEoCo(p80f8c729Var, 0));
        this.fa001b1c6 = rWUKYyABeQUInoCj(RwfBrGeItWrsBXfd(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BJswERidhNQBEoCo(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] BlwclWPVFZNISRbh(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 LpkinNTrdGveBZyT(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a MCuSGjVNNmXWOagW(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 RwfBrGeItWrsBXfd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] WwTEvwrVYuxfUPOr(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] DhGljuclEChkovsd(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.p57f31be0 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p5360af35.p57f31be0) {
            return (p5a445d71.p7c922baa.pca323100.p5360af35.p57f31be0) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p5360af35.p57f31be0(LpkinNTrdGveBZyT(obj));
    }

    public static void RQqsfDrGloErzRAZ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 RWUKYyABeQUInoCj(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static void XRabtqnwpDTcQRuU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetKeyAlgorithm() {
        return this.fbeb37618;
    }

    public byte[] GetKeybytes() {
        return WwTEvwrVYuxfUPOr(dhGljuclEChkovsd(this.fa001b1c6));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((27 + 4) % 4 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        xRabtqnwpDTcQRuU(pd6ccb7fcVar, this.fbeb37618);
        rQqsfDrGloErzRAZ(pd6ccb7fcVar, this.fa001b1c6);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

