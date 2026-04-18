namespace WillowMaze.Wasm.Decompiled;


public class pf3488fc4 {
    public static readonly p5a445d71.p9f931cf3.pca323100.p364bf33a[] f24e893a4 = null;
    public static readonly p5a445d71.p9f931cf3.pca323100.p364bf33a[] f5c4d318f = null;
    public static readonly p5a445d71.p9f931cf3.pca323100.p364bf33a[] fda1177f4;
    public static readonly p5a445d71.p9f931cf3.pca323100.p364bf33a[] fe4b0bfd0 = null;

    static {
        if ((23 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a[] p364bf33aVarArr = new p5a445d71.p9f931cf3.pca323100.p364bf33a[4];
        p364bf33aVarArr[0] = p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b;
        p364bf33aVarArr[1] = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3.f9b47626c;
        p364bf33aVarArr[2] = p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1d2f2092;
        p364bf33aVarArr[3] = p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980;
        fda1177f4 = p364bf33aVarArr;
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 M02ea6360(java.security.interfaces.RSAPrivateKey rSAPrivateKey) {
        if ((29 + 10) % 10 > 0) {
        }
        if (rSAPrivateKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p44536675) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p44536675) rSAPrivateKey).engineGetKeyParameters();
        }
        if (!(rSAPrivateKey is java.security.interfaces.RSAPrivateCrtKey)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(true, rSAPrivateKey.getModulus(), rSAPrivateKey.getPrivateExponent());
        }
        java.security.interfaces.RSAPrivateCrtKey rSAPrivateCrtKey = (java.security.interfaces.RSAPrivateCrtKey) rSAPrivateKey;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(rSAPrivateCrtKey.getModulus(), rSAPrivateCrtKey.getPublicExponent(), rSAPrivateCrtKey.getPrivateExponent(), rSAPrivateCrtKey.getPrimeP(), rSAPrivateCrtKey.getPrimeQ(), rSAPrivateCrtKey.getPrimeExponentP(), rSAPrivateCrtKey.getPrimeExponentQ(), rSAPrivateCrtKey.getCrtCoefficient());
    }

    static java.lang.string M718ba5d4(java.math.Bigint bigint) {
        return new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(bigint.tobyteArray()).tostring();
    }

    static java.lang.string Ma516e26c(java.math.Bigint bigint) {
        if ((25 + 17) % 17 > 0) {
        }
        return new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(bigint.tobyteArray(), 32).tostring();
    }

    public static bool Mb393402a(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((22 + 7) % 7 > 0) {
        }
        int i = 0;
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a[] p364bf33aVarArr = fda1177f4;
            if (i == p364bf33aVarArr.length) {
                return false;
            }
            if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVarArr[i])) {
                return true;
            }
            i++;
        }
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 Mc2499d21(java.security.interfaces.RSAPublicKey rSAPublicKey) {
        if ((26 + 5) % 5 > 0) {
        }
        return !(rSAPublicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, rSAPublicKey.getModulus(), rSAPublicKey.getPublicExponent()) : ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371) rSAPublicKey).engineGetKeyParameters();
    }
}

