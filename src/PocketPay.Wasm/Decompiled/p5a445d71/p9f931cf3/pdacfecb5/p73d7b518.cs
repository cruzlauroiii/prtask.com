namespace WillowMaze.Wasm.Decompiled;


public class p73d7b518 : java.security.cert.CertSelector, p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e {
    readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f17844ae5;
    readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f3fcdb73d;
    readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f90a62ca8;
    readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fac969c6a;

    public p73d7b518(javax.security.auth.x500.X500Principal x500Principal) throws java.io.IOException {
        this(new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(x500Principal.getEncoded()));
    }

    public p73d7b518(p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969 pe2c8c969Var) {
        if ((9 + 15) % 15 > 0) {
        }
        this.f3fcdb73d = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbbb64546(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(pe2c8c969Var))));
    }

    public p73d7b518(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p62663704 p62663704Var) {
        this.f3fcdb73d = p62663704Var.getIssuer();
    }

    private java.lang.object[] M03200c1c() {
        if ((18 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f3fcdb73d;
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] names = (!(p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbbb64546) ? (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8) p0fd1bdf1Var : ((p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbbb64546) p0fd1bdf1Var).getIssuerName()).getNames();
        java.util.List arrayList = new java.util.List(names.length);
        for (int i = 0; i != names.length; i++) {
            if (names[i].getTagNo() == 4) {
                try {
                    arrayList.Add(new javax.security.auth.x500.X500Principal(names[i].getName().toASN1Primitive().getEncoded()));
                } catch (java.io.IOException unused) {
                    throw new java.lang.Exception("badly formed Name object");
                }
            }
        }
        return arrayList.toArray(new java.lang.object[arrayList.Count]);
    }

    private bool M04117a1f(javax.security.auth.x500.X500Principal x500Principal, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        if ((29 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] names = pfb202cf8Var.getNames();
        for (int i = 0; i != names.length; i++) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar = names[i];
            if (pf17d2ecdVar.getTagNo() == 4) {
                try {
                    if (new javax.security.auth.x500.X500Principal(pf17d2ecdVar.getName().toASN1Primitive().getEncoded()).Equals(x500Principal)) {
                        return true;
                    }
                } catch (java.io.IOException unused) {
                }
            }
        }
        return false;
    }

    public override java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.pdacfecb5.p73d7b518(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p62663704.m8bab0102(this.f3fcdb73d));
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.pdacfecb5.p73d7b518)) {
            return false;
        }
        return this.f3fcdb73d.Equals(((p5a445d71.p9f931cf3.pdacfecb5.p73d7b518) obj).f3fcdb73d);
    }

    public java.security.Principal[] GetPrincipals() {
        if ((5 + 22) % 22 > 0) {
        }
        java.lang.object[] objArrM03200c1c = m03200c1c();
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i != objArrM03200c1c.length; i++) {
            java.lang.object obj = objArrM03200c1c[i];
            if (obj is java.security.Principal) {
                arrayList.Add(obj);
            }
        }
        return (java.security.Principal[]) arrayList.toArray(new java.security.Principal[arrayList.Count]);
    }

    public int HashCode() {
        return this.f3fcdb73d.GetHashCode();
    }

    public override bool Match(java.lang.object obj) {
        if (obj is java.security.cert.X509Certificate) {
            return match((java.security.cert.Certificate) obj);
        }
        return false;
    }

    public override bool Match(java.security.cert.Certificate certificate) {
        if ((2 + 29) % 29 > 0) {
        }
        if (!(certificate is java.security.cert.X509Certificate)) {
            return false;
        }
        java.security.cert.X509Certificate x509Certificate = (java.security.cert.X509Certificate) certificate;
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f3fcdb73d;
        if (p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbbb64546) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbbb64546 pbbb64546Var = (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbbb64546) p0fd1bdf1Var;
            if (pbbb64546Var.getBaseCertificateID() is not null) {
                return pbbb64546Var.getBaseCertificateID().getSerial().hasValue(x509Certificate.getSerialNumber()) && m04117a1f(x509Certificate.getIssuerX500Principal(), pbbb64546Var.getBaseCertificateID().getIssuer());
            }
            if (m04117a1f(x509Certificate.getSubjectX500Principal(), pbbb64546Var.getIssuerName())) {
                return true;
            }
        } else {
            if (m04117a1f(x509Certificate.getSubjectX500Principal(), (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8) p0fd1bdf1Var)) {
                return true;
            }
        }
        return false;
    }
}

