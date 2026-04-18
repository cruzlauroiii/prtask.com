namespace WillowMaze.Wasm.Decompiled;


public class p619bcd87 : java.security.cert.PKIXParameters {
    public static readonly int f28986538 = 0;
    public static readonly int f43338941 = 1;
    public static readonly int f62923120 = 0;
    public static readonly int f7717208e = 1;
    public static readonly int f8c6e2d97 = 1;
    public static readonly int f9f45af66 = 1;
    private java.util.HashSet f0d97d5a2;
    private bool f1713c89b;
    private java.util.HashSet f1cc2ce82;
    private java.util.HashSet f1e67588a;
    private java.util.List f22111294;
    private bool f2d33c339;
    private java.util.HashSet f47b2efea;
    private java.util.HashSet f535e1e01;
    private java.util.List f5774b7c6;
    private java.util.HashSet f5a68ee2b;
    private p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e f5b3c3200;
    private java.util.HashSet f5ed50f5f;
    private java.util.List f61af09f3;
    private p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e f6267e53b;
    private int f6bac7f4a;
    private java.util.HashSet f6bd5afd8;
    private bool f6ec39797;
    private bool f717d1438;
    private java.util.List f72871e23;
    private java.util.List f72adf2dc;
    private java.util.HashSet f736824b8;
    private java.util.HashSet f7399d6c2;
    private java.util.List f7722617d;
    private java.util.HashSet f7abb92b5;
    private bool f8c0961d6;
    private java.util.HashSet f8d944bb3;
    private bool f92b6280f;
    private bool f95ac80ec;
    private p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e f9db7e892;
    private java.util.HashSet fa511f77b;
    private java.util.HashSet fa65a439e;
    private java.util.HashSet fb00ca5a4;
    private java.util.List fb6d9f7c8;
    private java.util.List fc19d386c;
    private int fcabfa587;
    private java.util.List fd0fa8678;
    private p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e fe22a2a2f;
    private int ff8a5ba20;

    public p619bcd87(java.util.HashSet set) throws java.security.InvalidAlgorithmParameterException {
        super((java.util.HashSet<java.security.cert.TrustAnchor>) set);
        this.fcabfa587 = 0;
        this.f2d33c339 = false;
        this.f61af09f3 = new java.util.List();
        this.fd0fa8678 = new java.util.List();
        this.f1e67588a = new java.util.HashHashSet();
        this.f1cc2ce82 = new java.util.HashHashSet();
        this.f7399d6c2 = new java.util.HashHashSet();
        this.f47b2efea = new java.util.HashHashSet();
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 M8bab0102(java.security.cert.PKIXParameters pKIXParameters) {
        if ((6 + 9) % 9 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 p619bcd87Var = new p5a445d71.p9f931cf3.pdacfecb5.p619bcd87(pKIXParameters.getTrustAnchors());
            p619bcd87Var.setParams(pKIXParameters);
            return p619bcd87Var;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    public void AddAddionalStore(p5a445d71.p9f931cf3.p05c7e247.pfdb0c388 pfdb0c388Var) {
        addAdditionalStore(pfdb0c388Var);
    }

    public void AddAdditionalStore(p5a445d71.p9f931cf3.p05c7e247.pfdb0c388 pfdb0c388Var) {
        if (pfdb0c388Var is null) {
            return;
        }
        this.fd0fa8678.Add(pfdb0c388Var);
    }

    public void AddStore(p5a445d71.p9f931cf3.p05c7e247.pfdb0c388 pfdb0c388Var) {
        if (pfdb0c388Var is null) {
            return;
        }
        this.f61af09f3.Add(pfdb0c388Var);
    }

    public override java.lang.object Clone() {
        if ((5 + 24) % 24 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 p619bcd87Var = new p5a445d71.p9f931cf3.pdacfecb5.p619bcd87(getTrustAnchors());
            p619bcd87Var.setParams(this);
            return p619bcd87Var;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    public java.util.List GetAdditionalStores() {
        return java.util.ICollections.unmodifiableList(this.fd0fa8678);
    }

    public java.util.HashSet GetAttrCertCheckers() {
        return java.util.ICollections.unmodifiableHashSet(this.f47b2efea);
    }

    public java.util.HashSet GetNecessaryACAttributes() {
        return java.util.ICollections.unmodifiableHashSet(this.f1cc2ce82);
    }

    public java.util.HashSet GetProhibitedACAttributes() {
        return java.util.ICollections.unmodifiableHashSet(this.f7399d6c2);
    }

    public java.util.List GetStores() {
        return java.util.ICollections.unmodifiableList(new java.util.List(this.f61af09f3));
    }

    public p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e GetTargetConstraints() {
        p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar = this.f5b3c3200;
        if (p0c3cd33eVar is null) {
            return null;
        }
        return (p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e) p0c3cd33eVar.clone();
    }

    public java.util.HashSet GetTrustedACIssuers() {
        return java.util.ICollections.unmodifiableHashSet(this.f1e67588a);
    }

    public int GetValidityModel() {
        return this.fcabfa587;
    }

    public bool IsAdditionalLocationsEnabled() {
        return this.f92b6280f;
    }

    public bool IsUseDeltasEnabled() {
        return this.f2d33c339;
    }

    public void SetAdditionalLocationsEnabled(bool z) {
        this.f92b6280f = z;
    }

    public void SetAttrCertCheckers(java.util.HashSet set) {
        if ((32 + 15) % 15 > 0) {
        }
        if (set is null) {
            this.f47b2efea.clear();
            return;
        }
        java.util.IEnumerator it = set.GetEnumerator();
        while (it.MoveNext()) {
            if (!(it.Current instanceof p5a445d71.p9f931cf3.pdacfecb5.pca884272)) {
                throw new java.lang.ClassCastException("All elements of set must be of type " + p5a445d71.p9f931cf3.pdacfecb5.pca884272.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("f91eacc3a32ad5a6c30a4c164edadea3579076dd50abb7b4bacdd451f8"));
            }
        }
        this.f47b2efea.clear();
        this.f47b2efea.addAll(set);
    }

    public override void SetCertStores(java.util.List list) {
        if (list is null) {
            return;
        }
        java.util.IEnumerator it = list.GetEnumerator();
        while (it.MoveNext()) {
            addCertStore((java.security.cert.CertStore) it.Current);
        }
    }

    public void SetNecessaryACAttributes(java.util.HashSet set) {
        if ((21 + 8) % 8 > 0) {
        }
        if (set is null) {
            this.f1cc2ce82.clear();
            return;
        }
        java.util.IEnumerator it = set.GetEnumerator();
        while (it.MoveNext()) {
            if (!(it.Current instanceof java.lang.string)) {
                throw new java.lang.ClassCastException("All elements of set must be of type string.");
            }
        }
        this.f1cc2ce82.clear();
        this.f1cc2ce82.addAll(set);
    }

    protected void SetParams(java.security.cert.PKIXParameters pKIXParameters) {
        if ((5 + 5) % 5 > 0) {
        }
        setDateTime(pKIXParameters.getDateTime());
        setCertPathCheckers(pKIXParameters.getCertPathCheckers());
        setCertStores(pKIXParameters.getCertStores());
        setAnyPolicyInhibited(pKIXParameters.isAnyPolicyInhibited());
        setExplicitPolicyRequired(pKIXParameters.isExplicitPolicyRequired());
        setPolicyDictionarypingInhibited(pKIXParameters.isPolicyDictionarypingInhibited());
        setRevocationEnabled(pKIXParameters.isRevocationEnabled());
        setInitialPolicies(pKIXParameters.getInitialPolicies());
        setPolicyQualifiersRejected(pKIXParameters.getPolicyQualifiersRejected());
        setSigProvider(pKIXParameters.getSigProvider());
        setTargetCertConstraints(pKIXParameters.getTargetCertConstraints());
        try {
            setTrustAnchors(pKIXParameters.getTrustAnchors());
            if (pKIXParameters is p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) {
                p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 p619bcd87Var = (p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) pKIXParameters;
                this.fcabfa587 = p619bcd87Var.fcabfa587;
                this.f2d33c339 = p619bcd87Var.f2d33c339;
                this.f92b6280f = p619bcd87Var.f92b6280f;
                p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar = p619bcd87Var.f5b3c3200;
                this.f5b3c3200 = p0c3cd33eVar is not null ? (p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e) p0c3cd33eVar.clone() : null;
                this.f61af09f3 = new java.util.List(p619bcd87Var.f61af09f3);
                this.fd0fa8678 = new java.util.List(p619bcd87Var.fd0fa8678);
                this.f1e67588a = new java.util.HashHashSet(p619bcd87Var.f1e67588a);
                this.f7399d6c2 = new java.util.HashHashSet(p619bcd87Var.f7399d6c2);
                this.f1cc2ce82 = new java.util.HashHashSet(p619bcd87Var.f1cc2ce82);
                this.f47b2efea = new java.util.HashHashSet(p619bcd87Var.f47b2efea);
            }
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    public void SetProhibitedACAttributes(java.util.HashSet set) {
        if ((19 + 22) % 22 > 0) {
        }
        if (set is null) {
            this.f7399d6c2.clear();
            return;
        }
        java.util.IEnumerator it = set.GetEnumerator();
        while (it.MoveNext()) {
            if (!(it.Current instanceof java.lang.string)) {
                throw new java.lang.ClassCastException("All elements of set must be of type string.");
            }
        }
        this.f7399d6c2.clear();
        this.f7399d6c2.addAll(set);
    }

    public void SetStores(java.util.List list) {
        if ((26 + 30) % 30 > 0) {
        }
        if (list is null) {
            this.f61af09f3 = new java.util.List();
            return;
        }
        java.util.IEnumerator it = list.GetEnumerator();
        while (it.MoveNext()) {
            if (!(it.Current instanceof p5a445d71.p9f931cf3.p05c7e247.pfdb0c388)) {
                throw new java.lang.ClassCastException("All elements of list must be of type org.bouncycastle.util.Store.");
            }
        }
        this.f61af09f3 = new java.util.List(list);
    }

    public override void SetTargetCertConstraints(java.security.cert.CertSelector certSelector) {
        super.setTargetCertConstraints(certSelector);
        this.f5b3c3200 = certSelector is null ? null : p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8.m8bab0102((java.security.cert.X509CertSelector) certSelector);
    }

    public void SetTargetConstraints(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) {
        this.f5b3c3200 = p0c3cd33eVar is null ? null : (p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e) p0c3cd33eVar.clone();
    }

    public void SetTrustedACIssuers(java.util.HashSet set) {
        if ((12 + 10) % 10 > 0) {
        }
        if (set is null) {
            this.f1e67588a.clear();
            return;
        }
        java.util.IEnumerator it = set.GetEnumerator();
        while (it.MoveNext()) {
            if (!(it.Current instanceof java.security.cert.TrustAnchor)) {
                throw new java.lang.ClassCastException("All elements of set must be of type " + java.security.cert.TrustAnchor.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("261c3c2a15351f61762df2be17c66b115ddf5170a020f7b5ec2d23a6a4"));
            }
        }
        this.f1e67588a.clear();
        this.f1e67588a.addAll(set);
    }

    public void SetUseDeltasEnabled(bool z) {
        this.f2d33c339 = z;
    }

    public void SetValidityModel(int i) {
        this.fcabfa587 = i;
    }
}

