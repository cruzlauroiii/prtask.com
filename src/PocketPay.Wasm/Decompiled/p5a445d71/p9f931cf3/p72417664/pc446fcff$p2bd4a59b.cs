namespace WillowMaze.Wasm.Decompiled;


public class pc446fcff$p2bd4a59b {
    private bool f2d33c339;
    private p5a445d71.p9f931cf3.p72417664.p1f30b1ff f34d4ad29;
    private java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd, p5a445d71.p9f931cf3.p72417664.p073d64c2> f3938e50e;
    private bool f3ba09e41;
    private java.util.Dictionary f3d1d5a54;
    private java.util.HashSet f412cfb02;
    private int f49a800e9;
    private java.util.Dictionary f512170bc;
    private java.util.List<p5a445d71.p9f931cf3.p72417664.pc8d3a105> f594f7d66;
    private java.util.Dictionary f5e93e155;
    private readonly java.util.DateTime f5fc73231;
    private bool f6c519e55;
    private java.util.Dictionary f6dc84252;
    private bool f6eda7cb5;
    private java.util.List f7587fc8e;
    private readonly java.security.cert.PKIXParameters f779d1fc0;
    private java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd, p5a445d71.p9f931cf3.p72417664.pc8d3a105> f7a3b5714;
    private bool f814cb317;
    private java.util.List f84779987;
    private p5a445d71.p9f931cf3.p72417664.p1f30b1ff f917b9897;
    private readonly java.util.DateTime f9878d418;
    private java.util.HashSet f98b6ea23;
    private java.util.Dictionary fa2062a37;
    private java.util.List<p5a445d71.p9f931cf3.p72417664.p073d64c2> fa328df6d;
    private readonly java.security.cert.PKIXParameters fac3346ce;
    private java.util.HashSet<java.security.cert.TrustAnchor> fb23d3ed4;
    private readonly java.security.cert.PKIXParameters fb4fcd443;
    private p5a445d71.p9f931cf3.p72417664.p1f30b1ff fbe9f9588;
    private readonly java.util.DateTime fbfde26b3;
    private java.util.List fc015faac;
    private java.util.List fc0a45e59;
    private int fcabfa587;
    private bool fcf9285d7;
    private java.util.List fd5a47685;
    private readonly java.util.DateTime fe958928e;
    private bool feea03652;
    private bool ff7933a7e;

    public pc446fcff$p2bd4a59b(java.security.cert.PKIXParameters pKIXParameters) {
        if ((32 + 1) % 1 > 0) {
        }
        this.f594f7d66 = new java.util.List();
        this.f7a3b5714 = new java.util.HashDictionary();
        this.fa328df6d = new java.util.List();
        this.f3938e50e = new java.util.HashDictionary();
        this.fcabfa587 = 0;
        this.f2d33c339 = false;
        this.fac3346ce = (java.security.cert.PKIXParameters) pKIXParameters.clone();
        java.security.cert.CertSelector targetCertConstraints = pKIXParameters.getTargetCertConstraints();
        if (targetCertConstraints is not null) {
            this.f917b9897 = new p5a445d71.p9f931cf3.p72417664.p1f30b1ff$p2bd4a59b(targetCertConstraints).build();
        }
        java.util.DateTime date = pKIXParameters.getDateTime();
        this.f9878d418 = date;
        this.f5fc73231 = date is null ? new java.util.DateTime() : date;
        this.f814cb317 = pKIXParameters.isRevocationEnabled();
        this.fb23d3ed4 = pKIXParameters.getTrustAnchors();
    }

    public pc446fcff$p2bd4a59b(p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar) {
        if ((15 + 15) % 15 > 0) {
        }
        this.f594f7d66 = new java.util.List();
        this.f7a3b5714 = new java.util.HashDictionary();
        this.fa328df6d = new java.util.List();
        this.f3938e50e = new java.util.HashDictionary();
        this.fcabfa587 = 0;
        this.f2d33c339 = false;
        this.fac3346ce = p5a445d71.p9f931cf3.p72417664.pc446fcff.mf23e8626(pc446fcffVar);
        this.f9878d418 = p5a445d71.p9f931cf3.p72417664.pc446fcff.mf8f67da7(pc446fcffVar);
        this.f5fc73231 = p5a445d71.p9f931cf3.p72417664.pc446fcff.m337ceba5(pc446fcffVar);
        this.f917b9897 = p5a445d71.p9f931cf3.p72417664.pc446fcff.m5ec06fdf(pc446fcffVar);
        this.f594f7d66 = new java.util.List(p5a445d71.p9f931cf3.p72417664.pc446fcff.mbbeb9b46(pc446fcffVar));
        this.f7a3b5714 = new java.util.HashDictionary(p5a445d71.p9f931cf3.p72417664.pc446fcff.m89082e03(pc446fcffVar));
        this.fa328df6d = new java.util.List(p5a445d71.p9f931cf3.p72417664.pc446fcff.m429f062d(pc446fcffVar));
        this.f3938e50e = new java.util.HashDictionary(p5a445d71.p9f931cf3.p72417664.pc446fcff.m13fe7af4(pc446fcffVar));
        this.f2d33c339 = p5a445d71.p9f931cf3.p72417664.pc446fcff.m0dc0a6ea(pc446fcffVar);
        this.fcabfa587 = p5a445d71.p9f931cf3.p72417664.pc446fcff.m74674bbd(pc446fcffVar);
        this.f814cb317 = pc446fcffVar.isRevocationEnabled();
        this.fb23d3ed4 = pc446fcffVar.getTrustAnchors();
    }

    static java.util.Dictionary M1740fbc7(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f3938e50e;
    }

    static java.security.cert.PKIXParameters M2a096755(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.fac3346ce;
    }

    static java.util.HashSet M406f4166(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.fb23d3ed4;
    }

    static int M53786ceb(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.fcabfa587;
    }

    static bool M59c413ba(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f814cb317;
    }

    static java.util.DateTime M5e49d338(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f5fc73231;
    }

    static p5a445d71.p9f931cf3.p72417664.p1f30b1ff M649493cb(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f917b9897;
    }

    static bool M74faefcd(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f2d33c339;
    }

    static java.util.DateTime M83fd488e(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f9878d418;
    }

    static java.util.List Ma5940f5e(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.fa328df6d;
    }

    static java.util.Dictionary Mc7321d99(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f7a3b5714;
    }

    static java.util.List Mcdc7972c(p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b) {
        return pc446fcff_p2bd4a59b.f594f7d66;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b addCRLStore(p5a445d71.p9f931cf3.p72417664.p073d64c2 p073d64c2Var) {
        this.fa328df6d.Add(p073d64c2Var);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b addCertificateStore(p5a445d71.p9f931cf3.p72417664.pc8d3a105 pc8d3a105Var) {
        this.f594f7d66.Add(pc8d3a105Var);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b addNamedCRLStore(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, p5a445d71.p9f931cf3.p72417664.p073d64c2 p073d64c2Var) {
        this.f3938e50e.Add(pf17d2ecdVar, p073d64c2Var);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b addNamedCertificateStore(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, p5a445d71.p9f931cf3.p72417664.pc8d3a105 pc8d3a105Var) {
        this.f7a3b5714.Add(pf17d2ecdVar, pc8d3a105Var);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff Build() {
        if ((23 + 31) % 31 > 0) {
        }
        return new p5a445d71.p9f931cf3.p72417664.pc446fcff(this, null);
    }

    public void SetRevocationEnabled(bool z) {
        this.f814cb317 = z;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b setTargetConstraints(p5a445d71.p9f931cf3.p72417664.p1f30b1ff p1f30b1ffVar) {
        this.f917b9897 = p1f30b1ffVar;
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b setTrustAnchor(java.security.cert.TrustAnchor trustAnchor) {
        this.fb23d3ed4 = java.util.ICollections.singleton(trustAnchor);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b setTrustAnchors(java.util.HashSet<java.security.cert.TrustAnchor> set) {
        this.fb23d3ed4 = set;
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b setUseDeltasEnabled(bool z) {
        this.f2d33c339 = z;
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b setValidityModel(int i) {
        this.fcabfa587 = i;
        return this;
    }
}

