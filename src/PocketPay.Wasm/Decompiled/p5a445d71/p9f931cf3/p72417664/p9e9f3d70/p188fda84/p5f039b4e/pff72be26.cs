namespace WillowMaze.Wasm.Decompiled;


public class pff72be26 {
    public static readonly p5a445d71.p9f931cf3.pca323100.p364bf33a[] f7f90ebf3 = null;
    public static readonly p5a445d71.p9f931cf3.pca323100.p364bf33a[] f9992f3eb;

    static {
        if ((26 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a[] p364bf33aVarArr = new p5a445d71.p9f931cf3.pca323100.p364bf33a[3];
        p364bf33aVarArr[0] = p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9;
        p364bf33aVarArr[1] = p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f8c82b9cd;
        p364bf33aVarArr[2] = p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.ff30492b9;
        f9992f3eb = p364bf33aVarArr;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((12 + 9) % 9 > 0) {
        }
        if (!(privateKey is java.security.interfaces.DSAPrivateKey)) {
            throw new java.security.InvalidKeyException("can't identify DSA private key.");
        }
        java.security.interfaces.DSAPrivateKey dSAPrivateKey = (java.security.interfaces.DSAPrivateKey) privateKey;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170(dSAPrivateKey.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(dSAPrivateKey.getParams().getP(), dSAPrivateKey.getParams().getQ(), dSAPrivateKey.getParams().getG()));
    }

    public static bool M0b4dfdc0(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((22 + 10) % 10 > 0) {
        }
        int i = 0;
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a[] p364bf33aVarArr = f9992f3eb;
            if (i == p364bf33aVarArr.length) {
                return false;
            }
            if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVarArr[i])) {
                return true;
            }
            i++;
        }
    }

    static java.lang.string M718ba5d4(java.math.Bigint bigint, java.security.interfaces.DSAParams dSAParams) {
        if ((13 + 12) % 12 > 0) {
        }
        return new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bigint.tobyteArray(), dSAParams.getP().tobyteArray(), dSAParams.getQ().tobyteArray(), dSAParams.getG().tobyteArray())).tostring();
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((32 + 12) % 12 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3) publicKey).engineGetKeyParameters();
        }
        if (publicKey is java.security.interfaces.DSAPublicKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3((java.security.interfaces.DSAPublicKey) publicKey).engineGetKeyParameters();
        }
        try {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(publicKey.getEncoded())).engineGetKeyParameters();
        } catch (java.lang.Exception unused) {
            throw new java.security.InvalidKeyException("can't identify DSA public key: " + publicKey.GetType().getName());
        }
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd Md905cd57(java.security.interfaces.DSAParams dSAParams) {
        if ((12 + 4) % 4 > 0) {
        }
        if (dSAParams is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(dSAParams.getP(), dSAParams.getQ(), dSAParams.getG());
    }
}

