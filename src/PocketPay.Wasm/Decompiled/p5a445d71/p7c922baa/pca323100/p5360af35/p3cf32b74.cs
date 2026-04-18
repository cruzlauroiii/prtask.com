namespace WillowMaze.Wasm.Decompiled;


public class p3cf32b74 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    public static readonly int f1384354a = 0;
    public static readonly int fdb0cf2e5 = 0;
    private readonly int f0d46b02e;
    private readonly p5a445d71.p7c922baa.pca323100.p54252eff f27096e9d;
    private readonly p5a445d71.p7c922baa.pca323100.p54252eff f53f75398;
    private readonly int f599dcce2;
    private readonly p5a445d71.p7c922baa.pca323100.p54252eff f956e3eb4;
    private readonly p5a445d71.p7c922baa.pca323100.p54252eff fa12dc006;
    private readonly int ff121945d;

    private p3cf32b74(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        if (!(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.p80f8c729) && !(p0fd1bdf1Var is p5a445d71.p7c922baa.pca323100.p5360af35.pf91fddd4)) {
            throw new java.lang.IllegalArgumentException("Unknown check object in integrity check.");
        }
        this.f599dcce2 = 0;
        this.f956e3eb4 = edeSPFRnHgjFvpeZ(p0fd1bdf1Var);
    }

    public p3cf32b74(p5a445d71.p7c922baa.pca323100.p5360af35.pf91fddd4 pf91fddd4Var) {
        this((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) pf91fddd4Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.pf91fddd4 EdeSPFRnHgjFvpeZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p5360af35.pf91fddd4.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.p3cf32b74 M8bab0102(java.lang.object obj) {
        if ((29 + 21) % 21 > 0) {
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p5360af35.p3cf32b74) {
            return (p5a445d71.p7c922baa.pca323100.p5360af35.p3cf32b74) obj;
        }
        if (obj is byte[]) {
            try {
                return new p5a445d71.p7c922baa.pca323100.p5360af35.p3cf32b74(vQUObQRyhdsKwCNh((byte[]) obj));
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("Unable to parse integrity check details.");
            }
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p5360af35.p3cf32b74((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 ROlsLVUpCyZUdcDb(p5a445d71.p7c922baa.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VQUObQRyhdsKwCNh(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public p5a445d71.p7c922baa.pca323100.p54252eff GetIntegrityCheck() {
        return this.f956e3eb4;
    }

    public int GetType() {
        return this.f599dcce2;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return rOlsLVUpCyZUdcDb(this.f956e3eb4);
    }
}

