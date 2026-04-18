namespace WillowMaze.Wasm.Decompiled;


public class p6b825a8d : java.security.spec.AlgorithmParameterSpec, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p7cbf3bd3 {
    private java.lang.string f0c44465f;
    private java.lang.string f338e6803;
    private java.lang.string f42c660fd;
    private java.lang.string f44a37ee5;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 f510ec9be;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 f73fbfb7d;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 f9e0b3712;
    private java.lang.string fa8566000;
    private java.lang.string fadf5dd96;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 fc43e5445;
    private java.lang.string fe6a7604a;
    private java.lang.string fe984c0f1;
    private java.lang.string feb4d3c4a;

    public p6b825a8d(java.lang.string str) {
        this(str, p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32.getId(), null);
        if ((19 + 13) % 13 > 0) {
        }
    }

    public p6b825a8d(java.lang.string str, java.lang.string str2) {
        this(str, str2, null);
    }

    public p6b825a8d(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        p5a445d71.p9f931cf3.pca323100.pff670599.p386737ae p386737aeVarMd0402605;
        if ((13 + 20) % 20 > 0) {
        }
        try {
            p386737aeVarMd0402605 = p5a445d71.p9f931cf3.pca323100.pff670599.p4849349c.md0402605(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str));
        } catch (java.lang.IllegalArgumentException unused) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM18da419b = p5a445d71.p9f931cf3.pca323100.pff670599.p4849349c.m18da419b(str);
            if (p364bf33aVarM18da419b is null) {
                p386737aeVarMd0402605 = null;
            } else {
                str = p364bf33aVarM18da419b.getId();
                p386737aeVarMd0402605 = p5a445d71.p9f931cf3.pca323100.pff670599.p4849349c.md0402605(p364bf33aVarM18da419b);
            }
        }
        if (p386737aeVarMd0402605 is null) {
            throw new java.lang.IllegalArgumentException("no key parameter set for passed in name/OID.");
        }
        this.f510ec9be = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417(p386737aeVarMd0402605.getP(), p386737aeVarMd0402605.getQ(), p386737aeVarMd0402605.getA());
        this.f338e6803 = str;
        this.f44a37ee5 = str2;
        this.fe984c0f1 = str3;
    }

    public p6b825a8d(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 p5e745417Var) {
        this.f510ec9be = p5e745417Var;
        this.f44a37ee5 = p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32.getId();
        this.fe984c0f1 = null;
    }

    public static p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d Md6c1e629(p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347Var) {
        if ((18 + 30) % 30 > 0) {
        }
        return p3d5f6347Var.getEncryptionParamHashSet() is null ? new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(p3d5f6347Var.getPublicKeyParamHashSet().getId(), p3d5f6347Var.getDigestParamHashSet().getId()) : new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(p3d5f6347Var.getPublicKeyParamHashSet().getId(), p3d5f6347Var.getDigestParamHashSet().getId(), p3d5f6347Var.getEncryptionParamHashSet().getId());
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 17) % 17 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d p6b825a8dVar = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d) obj;
            if (this.f510ec9be.Equals(p6b825a8dVar.f510ec9be) && this.f44a37ee5.Equals(p6b825a8dVar.f44a37ee5)) {
                java.lang.string str = this.fe984c0f1;
                java.lang.string str2 = p6b825a8dVar.fe984c0f1;
                if (str == str2) {
                    return true;
                }
                if (str is not null && str.Equals(str2)) {
                    return true;
                }
            }
        }
        return false;
    }

    public override java.lang.string GetDigestParamHashSetOID() {
        return this.f44a37ee5;
    }

    public override java.lang.string GetEncryptionParamHashSetOID() {
        return this.fe984c0f1;
    }

    public override java.lang.string GetPublicKeyParamHashSetOID() {
        return this.f338e6803;
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 GetPublicKeyParameters() {
        return this.f510ec9be;
    }

    public int HashCode() {
        if ((12 + 24) % 24 > 0) {
        }
        int iHashCode = this.f510ec9be.GetHashCode() ^ this.f44a37ee5.GetHashCode();
        java.lang.string str = this.fe984c0f1;
        return (str is null ? 0 : str.GetHashCode()) ^ iHashCode;
    }
}

