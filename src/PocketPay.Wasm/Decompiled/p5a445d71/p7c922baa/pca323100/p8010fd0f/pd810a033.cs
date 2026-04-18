namespace WillowMaze.Wasm.Decompiled;


public class pd810a033 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly byte[] f1bdcbc54;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f2b621975;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f6984f5ea;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f6afce9c0;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f704aeec9;
    private readonly byte[] f87ccc226;
    private readonly byte[] fec26a98d;

    private pd810a033(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((23 + 4) % 4 > 0) {
        }
        if (qiKRsBvkZBdesVyC(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("incorrect sequence size");
        }
        this.fec26a98d = gUvPPvUsNtVqLcGL(bCoHYJNyAyUaFKQQ(tcAEwmAdxCFkkzIv(NNmNdXrlRnYQaEdL(p80f8c729Var, 0))));
        this.f6984f5ea = RMYpdZpkgsbZxvNC(OfcoCWNMfzvGGmfm(p80f8c729Var, 1));
    }

    public pd810a033(byte[] bArr, p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var) {
        this.fec26a98d = orfKblrDFTLSEkGv(bArr);
        this.f6984f5ea = pb907b377Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 CDuZfiRvBZPlXVdN(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void MiZTIyAhOtVEhSkQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NNmNdXrlRnYQaEdL(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OfcoCWNMfzvGGmfm(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pb907b377 RMYpdZpkgsbZxvNC(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pb907b377.m8bab0102(obj);
    }

    public static byte[] BCoHYJNyAyUaFKQQ(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] GUvPPvUsNtVqLcGL(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pd810a033 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.pd810a033) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.pd810a033) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.pd810a033(CDuZfiRvBZPlXVdN(obj));
    }

    public static byte[] OrfKblrDFTLSEkGv(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void PJdkfPaNnkCBjCBz(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int QiKRsBvkZBdesVyC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 TcAEwmAdxCFkkzIv(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pb907b377 GetPendTime() {
        return this.f6984f5ea;
    }

    public byte[] GetPendToken() {
        return this.fec26a98d;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((27 + 15) % 15 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        pJdkfPaNnkCBjCBz(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p6f0e511c(this.fec26a98d));
        MiZTIyAhOtVEhSkQ(pd6ccb7fcVar, this.f6984f5ea);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

