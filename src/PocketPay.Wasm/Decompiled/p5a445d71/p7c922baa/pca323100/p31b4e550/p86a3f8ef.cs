namespace WillowMaze.Wasm.Decompiled;


public class p86a3f8ef : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.p54252eff f04c4d1f3;
    private int f1491a63e;
    private p5a445d71.p7c922baa.pca323100.p54252eff f58fe5b51;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 f6a064925;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 f736a1e7b;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 f94614de6;
    private int fa0c8633b;
    private int fcbf0ec7c;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 fd252d3ee;
    private int fdb76225d;

    public p86a3f8ef(int i, p5a445d71.p7c922baa.pca323100.p54252eff p54252effVar) {
        this.fcbf0ec7c = i;
        this.f04c4d1f3 = p54252effVar;
    }

    public p86a3f8ef(p5a445d71.p7c922baa.pca323100.pdacfecb5.p15bd1150 p15bd1150Var) {
        this(1, p15bd1150Var);
    }

    public p86a3f8ef(p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var) {
        if ((13 + 3) % 3 > 0) {
        }
        if (sQZHAjmuOHeSCJIX(peb0f48a1Var) != 3) {
            throw new java.lang.IllegalArgumentException("only version 3 certificates allowed");
        }
        this.f736a1e7b = peb0f48a1Var;
    }

    public static int DdDeSDCfbPHAysBO(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.lang.string LWgYsCkXMjNPjGLd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NqkTLqucIpQkBrWz(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string VtIQXGzuCPHQkYxO(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 ZUVxdHGVHMzPwVbh(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static java.lang.Class EinfKwGzbZAahbQv(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p15bd1150 FLSnxokgxlelyqIX(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p15bd1150.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef M8bab0102(java.lang.object obj) {
        if ((9 + 13) % 13 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef)) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef) obj;
        }
        if (obj is byte[]) {
            try {
                obj = ZUVxdHGVHMzPwVbh((byte[]) obj);
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("Invalid encoding in CMPCertificate");
            }
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p80f8c729) {
            return new p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef(oUTGezlvByfJSuCr(obj));
        }
        if (!(obj is p5a445d71.p7c922baa.pca323100.p582a4948)) {
            throw new java.lang.IllegalArgumentException(LWgYsCkXMjNPjGLd(mmWFCIjjPqcAtcpM(new java.lang.stringBuilder("Invalid object: "), VtIQXGzuCPHQkYxO(einfKwGzbZAahbQv(obj)))));
        }
        p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var = (p5a445d71.p7c922baa.pca323100.p582a4948) obj;
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef(DdDeSDCfbPHAysBO(p582a4948Var), NqkTLqucIpQkBrWz(p582a4948Var));
    }

    public static java.lang.stringBuilder MmWFCIjjPqcAtcpM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 OUTGezlvByfJSuCr(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1.m8bab0102(obj);
    }

    public static int SQZHAjmuOHeSCJIX(p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var) {
        return peb0f48a1Var.getVersionNumber();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 UriMHjqXWZGZjWAt(p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var) {
        return peb0f48a1Var.toASN1Primitive();
    }

    public p5a445d71.p7c922baa.pca323100.p54252eff GetOtherCert() {
        return this.f04c4d1f3;
    }

    public int GetOtherCertTag() {
        return this.fcbf0ec7c;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p15bd1150 GetX509v2AttrCert() {
        return fLSnxokgxlelyqIX(this.f04c4d1f3);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.peb0f48a1 GetX509v3PKCert() {
        return this.f736a1e7b;
    }

    public bool IsX509v3PKCert() {
        return this.f736a1e7b is not null;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((8 + 16) % 16 > 0) {
        }
        return this.f04c4d1f3 is null ? uriMHjqXWZGZjWAt(this.f736a1e7b) : new p5a445d71.p7c922baa.pca323100.p87af127c(true, this.fcbf0ec7c, this.f04c4d1f3);
    }
}

