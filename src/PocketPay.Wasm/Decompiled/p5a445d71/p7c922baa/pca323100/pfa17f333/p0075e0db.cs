namespace WillowMaze.Wasm.Decompiled;


public class p0075e0db : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d f1394d6e6;
    private bool f17c4fa0a = true;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d f30504ba0;
    private bool f4c72f789;
    private bool f73eeec24;
    private bool ff99eacea;

    public p0075e0db() {
    }

    public p0075e0db(p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d p0b21d33dVar) {
        this.f30504ba0 = p0b21d33dVar;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 BHOyRFmWbGZgsHkw(p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d p0b21d33dVar) {
        return p0b21d33dVar.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p0075e0db M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p0075e0db) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.p0075e0db) obj;
        }
        if ((obj is p5a445d71.p7c922baa.pca323100.pb9fa8367) || yGofyxNoywaMUbPY(obj, 5)) {
            return new p5a445d71.p7c922baa.pca323100.pfa17f333.p0075e0db();
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.p0075e0db(vlxidDeHJDGeTzTI(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d VlxidDeHJDGeTzTI(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d.m8bab0102(obj);
    }

    public static bool YGofyxNoywaMUbPY(java.lang.object obj, int i) {
        return hasEncodedTagValue(obj, i);
    }

    public p5a445d71.p7c922baa.pca323100.pfa17f333.p0b21d33d GetSignaturePolicyId() {
        return this.f30504ba0;
    }

    public bool IsSignaturePolicyImplied() {
        return this.f17c4fa0a;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return !this.f17c4fa0a ? BHOyRFmWbGZgsHkw(this.f30504ba0) : p5a445d71.p7c922baa.pca323100.p4631e342.f76425f17;
    }
}

