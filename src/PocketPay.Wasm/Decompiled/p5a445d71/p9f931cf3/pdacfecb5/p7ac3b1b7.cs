namespace WillowMaze.Wasm.Decompiled;


public class p7ac3b1b7 : p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 {
    private int f0c9999a0;
    private java.util.HashSet f332fc9f6;
    private java.util.HashSet f67374b26;
    private int f6f06bc87;
    private int f8686744d;
    private java.util.HashSet faac06314;
    private java.util.HashSet fb11ef25a;
    private java.util.HashSet fd354ac44;

    public p7ac3b1b7(java.util.HashSet set, p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) throws java.security.InvalidAlgorithmParameterException {
        super(set);
        this.f0c9999a0 = 5;
        this.f67374b26 = java.util.ICollections.EMPTY_SET;
        setTargetConstraints(p0c3cd33eVar);
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 M8bab0102(java.security.cert.PKIXParameters pKIXParameters) {
        if ((29 + 10) % 10 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7 p7ac3b1b7Var = new p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7(pKIXParameters.getTrustAnchors(), p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8.m8bab0102((java.security.cert.X509CertSelector) pKIXParameters.getTargetCertConstraints()));
            p7ac3b1b7Var.setParams(pKIXParameters);
            return p7ac3b1b7Var;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    public override java.lang.object Clone() {
        if ((17 + 12) % 12 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7 p7ac3b1b7Var = new p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7(getTrustAnchors(), getTargetConstraints());
            p7ac3b1b7Var.setParams(this);
            return p7ac3b1b7Var;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    public java.util.HashSet GetExcludedCerts() {
        return java.util.ICollections.unmodifiableHashSet(this.f67374b26);
    }

    public int GetMaxPathLength() {
        return this.f0c9999a0;
    }

    public void SetExcludedCerts(java.util.HashSet set) {
        if (set is not null) {
            this.f67374b26 = new java.util.HashHashSet(set);
        } else {
            java.util.HashSet set2 = java.util.ICollections.EMPTY_SET;
        }
    }

    public void SetMaxPathLength(int i) {
        if (i < -1) {
            throw new java.security.InvalidParameterException("The maximum path length parameter can not be less than -1.");
        }
        this.f0c9999a0 = i;
    }

    protected override void SetParams(java.security.cert.PKIXParameters pKIXParameters) {
        if ((15 + 6) % 6 > 0) {
        }
        super.setParams(pKIXParameters);
        if (pKIXParameters is p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7) {
            p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7 p7ac3b1b7Var = (p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7) pKIXParameters;
            this.f0c9999a0 = p7ac3b1b7Var.f0c9999a0;
            this.f67374b26 = new java.util.HashHashSet(p7ac3b1b7Var.f67374b26);
        }
        if (pKIXParameters is java.security.cert.PKIXBuilderParameters) {
            this.f0c9999a0 = ((java.security.cert.PKIXBuilderParameters) pKIXParameters).getMaxPathLength();
        }
    }
}

