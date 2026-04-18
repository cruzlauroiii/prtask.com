namespace WillowMaze.Wasm.Decompiled;


public class pfb409ce6 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private byte[] f1504e368;
    private byte[] f3b55019d;
    private byte[] fca8f46a5;
    private byte[] ff9a1f418;

    protected pfb409ce6(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        this(xVryWwunQejmJRcP(p11b04310Var));
    }

    public pfb409ce6(byte[] bArr) {
        this.f3b55019d = QqhnzxgTJydLAtPe(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 GZUuataxHFXglCYA(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static byte[] NEWpmviBgdyAwsKQ(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6 pfb409ce6Var) {
        return pfb409ce6Var.getKeyIdentifier();
    }

    public static byte[] QqhnzxgTJydLAtPe(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 XepuQTQctQZTkmbu(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c p5e2f5f3cVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c.m19ec981e(p5e2f5f3cVar, p364bf33aVar);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6 CxyaYFRfbpQDEupd(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 IZNiXIoxeSshHIWP(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6 IsBfjADiOocUvqfV(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6(GZUuataxHFXglCYA(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return isBfjADiOocUvqfV(iZNiXIoxeSshHIWP(p582a4948Var, z));
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb409ce6 Mba2946ef(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c p5e2f5f3cVar) {
        return cxyaYFRfbpQDEupd(XepuQTQctQZTkmbu(p5e2f5f3cVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f862a7451));
    }

    public static byte[] OunwzNuNfLnvIyFy(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] XVryWwunQejmJRcP(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public byte[] GetKeyIdentifier() {
        return ounwzNuNfLnvIyFy(this.f3b55019d);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(NEWpmviBgdyAwsKQ(this));
    }
}

