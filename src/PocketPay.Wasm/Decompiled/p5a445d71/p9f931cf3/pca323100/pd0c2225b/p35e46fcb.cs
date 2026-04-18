namespace WillowMaze.Wasm.Decompiled;


public class p35e46fcb : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2 {
    private static readonly java.math.Bigint f0569d531 = null;
    private static readonly java.math.Bigint f4d0effc1 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint ff2b8625a = null;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f18d30ceb;
    private java.math.Bigint f2134be0f;
    private java.math.Bigint f2510c390;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f25ad4602;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f36fd3ef3;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 f38ceee64;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4efa264f;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f77e01bb6;
    private java.math.Bigint f7b8b965a;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 fa8550135;
    private java.math.Bigint fb00dc87d;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 fb2f5ff47;
    private byte[] fb6976f8a;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 fc1160633;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 fc8d170f9;
    private java.math.Bigint fd781881d;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 fd87f5109;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 fda014452;
    private java.math.Bigint fe64cc2a7;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 febc1b5ed;
    private byte[] ff42596d3;
    private byte[] ffc875f21;
    private byte[] ffe4c0f30;

    static {
        if ((12 + 27) % 27 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public p35e46fcb(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 p713357f2Var, java.math.Bigint bigint) {
        this(pa827ecfaVar, p713357f2Var, bigint, null, null);
        if ((21 + 19) % 19 > 0) {
        }
    }

    public p35e46fcb(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 p713357f2Var, java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(pa827ecfaVar, p713357f2Var, bigint, bigint2, null);
        if ((20 + 26) % 26 > 0) {
        }
    }

    public p35e46fcb(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 p713357f2Var, java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr) {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 pe7d123b3Var;
        this.f4efa264f = pa827ecfaVar;
        this.fb2f5ff47 = p713357f2Var;
        this.f7b8b965a = bigint;
        this.f2510c390 = bigint2;
        this.ffe4c0f30 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        if (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m54e7ca5f(pa827ecfaVar)) {
            pe7d123b3Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3(pa827ecfaVar.getField().getcharistic());
        } else {
            if (!p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m9758923d(pa827ecfaVar)) {
                throw new java.lang.IllegalArgumentException("'curve' is of an unsupported type");
            }
            int[] exponentsPresent = ((p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p7f9339ec) pa827ecfaVar.getField()).getMinimalPolynomial().getExponentsPresent();
            if (exponentsPresent.length == 3) {
                pe7d123b3Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3(exponentsPresent[2], exponentsPresent[1]);
            } else {
                if (exponentsPresent.length != 5) {
                    throw new java.lang.IllegalArgumentException("Only trinomial and pentomial curves are supported");
                }
                pe7d123b3Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3(exponentsPresent[4], exponentsPresent[1], exponentsPresent[2], exponentsPresent[3]);
            }
        }
        this.fd87f5109 = pe7d123b3Var;
    }

    private p35e46fcb(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((8 + 27) % 27 > 0) {
        }
        if (!(p80f8c729Var.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.pf391b73d) || !((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(0)).hasValue(1)) {
            throw new java.lang.IllegalArgumentException("bad version in X9ECParameters");
        }
        this.f7b8b965a = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(4)).getValue();
        if (p80f8c729Var.Count == 6) {
            this.f2510c390 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(5)).getValue();
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.pa34292b1 pa34292b1Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pa34292b1(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3.m8bab0102(p80f8c729Var.getobjectAt(1)), this.f7b8b965a, this.f2510c390, p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p80f8c729Var.getobjectAt(2)));
        this.f4efa264f = pa34292b1Var.getCurve();
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 objectAt = p80f8c729Var.getobjectAt(3);
        if (objectAt is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2) {
            this.fb2f5ff47 = (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2) objectAt;
        } else {
            this.fb2f5ff47 = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(this.f4efa264f, (p5a445d71.p9f931cf3.pca323100.p11b04310) objectAt);
        }
        this.ffe4c0f30 = pa34292b1Var.getSeed();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2 GetBaseEntry() {
        return this.fb2f5ff47;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa GetCurve() {
        return this.f4efa264f;
    }

    public p5a445d71.p9f931cf3.pca323100.pd0c2225b.pa34292b1 GetCurveEntry() {
        if ((30 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pa34292b1(this.f4efa264f, this.ffe4c0f30);
    }

    public p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 GetFieldIDEntry() {
        return this.fd87f5109;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetG() {
        return this.fb2f5ff47.getPoint();
    }

    public java.math.Bigint GetH() {
        return this.f2510c390;
    }

    public java.math.Bigint GetN() {
        return this.f7b8b965a;
    }

    public byte[] GetSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffe4c0f30);
    }

    public bool HasSeed() {
        return this.ffe4c0f30 is not null;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(6);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(fbc21e648));
        pd6ccb7fcVar.Add(this.fd87f5109);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pa34292b1(this.f4efa264f, this.ffe4c0f30));
        pd6ccb7fcVar.Add(this.fb2f5ff47);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f7b8b965a));
        if (this.f2510c390 is not null) {
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f2510c390));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

