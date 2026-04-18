namespace WillowMaze.Wasm.Decompiled;


public class pf149c26b : java.security.cert.CertPathValidatorSpi {
    private readonly bool f09a57d6a;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f8def1af7;
    private readonly bool f94074df6;
    private readonly bool fb62be09b;
    private readonly bool ff2aac69c;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;
    private readonly bool ffebcee75;

    public pf149c26b() {
        this(false);
    }

    public pf149c26b(bool z) {
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.ffebcee75 = z;
    }

    static void M244bf9be(java.security.cert.X509Certificate x509Certificate) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 {
        if ((22 + 6) % 6 > 0) {
        }
        if (x509Certificate is p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be) {
            try {
            } catch (java.lang.Exception e) {
                e = e;
            }
            if (((p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be) x509Certificate).getTBSCertificateNative() is null) {
                e = null;
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("unable to process TBSCertificate", e);
            }
            return;
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c.m8bab0102(x509Certificate.getTBSCertificate());
        } catch (java.lang.IllegalArgumentException e2) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243(e2.getMessage());
        } catch (java.security.cert.CertificateEncodingException e3) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("unable to process TBSCertificate", e3);
        }
    }

    public override java.security.cert.CertPathValidatorResult EngineValidate(java.security.cert.CertPath certPath, java.security.cert.CertPathParameters certPathParameters) throws java.security.cert.CertPathValidatorException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVarBuild;
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7VarM7691cf52;
        java.security.PublicKey cAPublicKey;
        java.util.HashHashSet hashHashSet;
        int iMd6183fc5;
        int iM4a78792b;
        java.util.HashHashSet hashHashSet2;
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7VarM7538fd40;
        java.util.List list;
        if ((6 + 7) % 7 > 0) {
        }
        if (certPathParameters is java.security.cert.PKIXParameters) {
            p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b((java.security.cert.PKIXParameters) certPathParameters);
            if (certPathParameters is p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) {
                p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 p619bcd87Var = (p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) certPathParameters;
                pc446fcff_p2bd4a59b.setUseDeltasEnabled(p619bcd87Var.isUseDeltasEnabled());
                pc446fcff_p2bd4a59b.setValidityModel(p619bcd87Var.getValidityModel());
            }
            pc446fcffVarBuild = pc446fcff_p2bd4a59b.build();
        } else if (certPathParameters is p5a445d71.p9f931cf3.p72417664.paad5c124) {
            pc446fcffVarBuild = ((p5a445d71.p9f931cf3.p72417664.paad5c124) certPathParameters).getBaseParameters();
        } else {
            if (!(certPathParameters is p5a445d71.p9f931cf3.p72417664.pc446fcff)) {
                throw new java.security.InvalidAlgorithmParameterException("Parameters must be a " + java.security.cert.PKIXParameters.class.getName() + " instance.");
            }
            pc446fcffVarBuild = (p5a445d71.p9f931cf3.p72417664.pc446fcff) certPathParameters;
        }
        if (pc446fcffVarBuild.getTrustAnchors() is null) {
            throw new java.security.InvalidAlgorithmParameterException("trustAnchors is null, this is not allowed for certification path validation.");
        }
        java.util.List<? : java.security.cert.Certificate> certificates = certPath.getCertificates();
        int size = certificates.Count;
        int iM53fd55a2 = -1;
        if (certificates.Count == 0) {
            throw new java.security.cert.CertPathValidatorException("Certification path is empty.", null, certPath, -1);
        }
        java.util.DateTime dateM13945842 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m13945842(pc446fcffVarBuild, new java.util.DateTime());
        java.util.HashSet initialPolicies = pc446fcffVarBuild.getInitialPolicies();
        int i = 1;
        try {
            java.security.cert.TrustAnchor trustAnchorM810489a3 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m810489a3((java.security.cert.X509Certificate) certificates[certificates.Count - 1), pc446fcffVarBuild.getTrustAnchors(), pc446fcffVarBuild.getSigProvider());
            if (trustAnchorM810489a3 is not null) {
                m244bf9be(trustAnchorM810489a3.getTrustedCert());
                p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVarBuild2 = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b(pc446fcffVarBuild).setTrustAnchor(trustAnchorM810489a3).build();
                int i2 = size + 1;
                java.util.List[] arrayListArr = new java.util.List[i2];
                for (int i3 = 0; i3 < i2; i3++) {
                    arrayListArr[i3] = new java.util.List();
                }
                java.util.HashHashSet hashHashSet3 = new java.util.HashHashSet();
                hashHashSet3.Add(com.decryptstringmanager.Decryptstring.decryptstring("ab4cc56410f72d11fec4d1d674e609e5850f7ae12cbecefcf90d9b88428150e4251caaaa3ce7d7"));
                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902(new java.util.List(), 0, hashHashSet3, null, new java.util.HashHashSet(), "2.5.29.32.0", false);
                arrayListArr[0].Add(p331d8902Var);
                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40 p1dc02b40Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40();
                java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
                int i4 = !pc446fcffVarBuild2.isExplicitPolicyRequired() ? i2 : 0;
                int i5 = !pc446fcffVarBuild2.isAnyPolicyInhibited() ? i2 : 0;
                if (pc446fcffVarBuild2.isPolicyDictionarypingInhibited()) {
                    i2 = 0;
                }
                java.security.cert.X509Certificate trustedCert = trustAnchorM810489a3.getTrustedCert();
                try {
                    if (trustedCert is null) {
                        p694426e7VarM7691cf52 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb854d51e.m7691cf52(trustAnchorM810489a3);
                        cAPublicKey = trustAnchorM810489a3.getCAPublicKey();
                    } else {
                        p694426e7VarM7691cf52 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb854d51e.m7538fd40(trustedCert);
                        cAPublicKey = trustedCert.getPublicKey();
                    }
                    try {
                        iM53fd55a2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m53fd55a2(cAPublicKey);
                        iM53fd55a2.getAlgorithm();
                        iM53fd55a2.getParameters();
                        if (pc446fcffVarBuild2.getTargetConstraints() is not null && !pc446fcffVarBuild2.getTargetConstraints().match((java.security.cert.Certificate) certificates[0))) {
                            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Target certificate in certification path does not match targetConstraints.", null, certPath, 0);
                        }
                        java.util.List certPathCheckers = pc446fcffVarBuild2.getCertPathCheckers();
                        java.util.IEnumerator it = certPathCheckers.GetEnumerator();
                        while (it.MoveNext()) {
                            ((java.security.cert.PKIXCertPathChecker) it.Current).init(false);
                        }
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p205b5bac p205b5bacVar = !pc446fcffVarBuild2.isRevocationEnabled() ? null : new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p205b5bac(this.ffde5d67b);
                        int i6 = i2;
                        int size2 = certificates.Count - 1;
                        int i7 = i4;
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var2 = p331d8902Var;
                        int iM9763a9ef = size;
                        java.security.cert.X509Certificate x509Certificate = null;
                        while (size2 >= 0) {
                            int i8 = size - size2;
                            java.util.List<? : java.security.cert.Certificate> list2 = certificates;
                            java.security.cert.X509Certificate x509Certificate2 = (java.security.cert.X509Certificate) certificates[size2);
                            bool z = size2 != list2.Count + (-1) ? 0 : i;
                            try {
                                m244bf9be(x509Certificate2);
                                java.security.cert.X509Certificate x509Certificate3 = trustedCert;
                                java.util.List[] arrayListArr2 = arrayListArr;
                                java.security.PublicKey publicKey = cAPublicKey;
                                java.util.List list3 = certPathCheckers;
                                int i9 = i7;
                                int i10 = iM9763a9ef;
                                p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var = p694426e7VarM7691cf52;
                                java.security.cert.TrustAnchor trustAnchor = trustAnchorM810489a3;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40 p1dc02b40Var2 = p1dc02b40Var;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.meebed72a(certPath, pc446fcffVarBuild2, dateM13945842, p205b5bacVar, size2, publicKey, z, p694426e7Var, x509Certificate3);
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p205b5bac p205b5bacVar2 = p205b5bacVar;
                                p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar = pc446fcffVarBuild2;
                                java.util.DateTime date = dateM13945842;
                                int i11 = size2;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m13719d11(certPath, i11, p1dc02b40Var2, this.ffebcee75);
                                java.util.HashHashSet hashHashSet5 = hashHashSet4;
                                int iMb3e6b74d = i5;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarMe4db826d = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.me4db826d(certPath, i11, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m9d62c6e5(certPath, i11, hashHashSet5, p331d8902Var2, arrayListArr2, iMb3e6b74d, this.ffebcee75));
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mf2a2cd44(certPath, i11, p331d8902VarMe4db826d, i9);
                                if (i8 == size) {
                                    hashHashSet4 = hashHashSet5;
                                } else {
                                    try {
                                        if (x509Certificate2 is null) {
                                            hashHashSet4 = hashHashSet5;
                                        } else {
                                            hashHashSet4 = hashHashSet5;
                                            int i12 = i;
                                            if (x509Certificate2.getVersion() == i12) {
                                                if (i8 != i12 || !x509Certificate2.Equals(trustAnchor.getTrustedCert())) {
                                                    throw new java.security.cert.CertPathValidatorException("Version 1 certificates can't be used as CA ones.", null, certPath, i11);
                                                }
                                            }
                                            i5 = iMb3e6b74d;
                                            arrayListArr = arrayListArr2;
                                            p205b5bacVar = p205b5bacVar2;
                                            i = 1;
                                            size2 = i11 - 1;
                                            pc446fcffVarBuild2 = pc446fcffVar;
                                            p1dc02b40Var = p1dc02b40Var2;
                                            trustAnchorM810489a3 = trustAnchor;
                                            p694426e7VarM7691cf52 = p694426e7VarM7538fd40;
                                            certPathCheckers = list;
                                            dateM13945842 = date;
                                            x509Certificate = x509Certificate2;
                                            certificates = list2;
                                        }
                                        java.security.PublicKey publicKeyMe838ebc2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.me838ebc2(certPath.getCertificates(), i11, this.ffde5d67b);
                                        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM53fd55a2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m53fd55a2(publicKeyMe838ebc2);
                                        p234a7530VarM53fd55a2.getAlgorithm();
                                        p234a7530VarM53fd55a2.getParameters();
                                        cAPublicKey = publicKeyMe838ebc2;
                                        trustedCert = x509Certificate2;
                                        list = list3;
                                        i7 = iMd6183fc5;
                                        i6 = iM4a78792b;
                                        i5 = iMb3e6b74d;
                                        arrayListArr = arrayListArr2;
                                        p205b5bacVar = p205b5bacVar2;
                                        i = 1;
                                        size2 = i11 - 1;
                                        pc446fcffVarBuild2 = pc446fcffVar;
                                        p1dc02b40Var = p1dc02b40Var2;
                                        trustAnchorM810489a3 = trustAnchor;
                                        p694426e7VarM7691cf52 = p694426e7VarM7538fd40;
                                        certPathCheckers = list;
                                        dateM13945842 = date;
                                        x509Certificate = x509Certificate2;
                                        certificates = list2;
                                    } catch (java.security.cert.CertPathValidatorException e) {
                                        throw new java.security.cert.CertPathValidatorException("Next working key could not be retrieved.", e, certPath, i11);
                                    }
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb1481b0f(certPath, i11);
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarMb2eb40db = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb2eb40db(certPath, i11, arrayListArr2, p331d8902VarMe4db826d, i6);
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mbbcfcdc6(certPath, i11, p1dc02b40Var2);
                                    int iMb241fbb6 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb241fbb6(certPath, i11, i9);
                                    int iMddd192e7 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mddd192e7(certPath, i11, i6);
                                    int iM0eaf6a9d = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m0eaf6a9d(certPath, i11, iMb3e6b74d);
                                    iMd6183fc5 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.md6183fc5(certPath, i11, iMb241fbb6);
                                    iM4a78792b = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m4a78792b(certPath, i11, iMddd192e7);
                                    iMb3e6b74d = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb3e6b74d(certPath, i11, iM0eaf6a9d);
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m4be90c32(certPath, i11);
                                    iM9763a9ef = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m9763a9ef(certPath, i11, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.md4fb803c(certPath, i11, i10));
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m60af404a(certPath, i11);
                                    java.util.HashSet<java.lang.string> criticalExtensionOIDs = x509Certificate2.getCriticalExtensionOIDs();
                                    if (criticalExtensionOIDs is null) {
                                        hashHashSet2 = new java.util.HashHashSet();
                                    } else {
                                        hashHashSet2 = new java.util.HashHashSet(criticalExtensionOIDs);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fb8ec8409);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec);
                                        hashHashSet2.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814);
                                    }
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m886b083c(certPath, i11, hashHashSet2, list3);
                                    p694426e7VarM7538fd40 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb854d51e.m7538fd40(x509Certificate2);
                                    p331d8902Var2 = p331d8902VarMb2eb40db;
                                }
                                list = list3;
                                iM9763a9ef = i10;
                                p331d8902Var2 = p331d8902VarMe4db826d;
                                i7 = i9;
                                cAPublicKey = publicKey;
                                p694426e7VarM7538fd40 = p694426e7Var;
                                trustedCert = x509Certificate3;
                                i5 = iMb3e6b74d;
                                arrayListArr = arrayListArr2;
                                p205b5bacVar = p205b5bacVar2;
                                i = 1;
                                size2 = i11 - 1;
                                pc446fcffVarBuild2 = pc446fcffVar;
                                p1dc02b40Var = p1dc02b40Var2;
                                trustAnchorM810489a3 = trustAnchor;
                                p694426e7VarM7691cf52 = p694426e7VarM7538fd40;
                                certPathCheckers = list;
                                dateM13945842 = date;
                                x509Certificate = x509Certificate2;
                                certificates = list2;
                            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e2) {
                                throw new java.security.cert.CertPathValidatorException(e2.getMessage(), e2.getUnderlyingException(), certPath, size2);
                            }
                        }
                        p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar2 = pc446fcffVarBuild2;
                        int i13 = size2;
                        java.util.List[] arrayListArr3 = arrayListArr;
                        java.util.List list4 = certPathCheckers;
                        java.security.cert.TrustAnchor trustAnchor2 = trustAnchorM810489a3;
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var3 = p331d8902Var2;
                        int i14 = i13 + 1;
                        int iM00954b7e = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m00954b7e(certPath, i14, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb4e44315(i7, x509Certificate));
                        java.util.HashSet<java.lang.string> criticalExtensionOIDs2 = x509Certificate.getCriticalExtensionOIDs();
                        if (criticalExtensionOIDs2 is null) {
                            hashHashSet = new java.util.HashHashSet();
                        } else {
                            hashHashSet = new java.util.HashHashSet(criticalExtensionOIDs2);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fb8ec8409);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0c79369d);
                            hashHashSet.Remove(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f4f9c212c.getId());
                        }
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m5250b2bb(certPath, i14, list4, hashHashSet);
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarM9ce3c4fe = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m9ce3c4fe(certPath, pc446fcffVar2, initialPolicies, i14, arrayListArr3, p331d8902Var3, hashHashSet4);
                        if (iM00954b7e <= 0 && p331d8902VarM9ce3c4fe is null) {
                            throw new java.security.cert.CertPathValidatorException("Path processing failed on policy.", null, certPath, i13);
                        }
                        return new java.security.cert.PKIXCertPathValidatorResult(trustAnchor2, p331d8902VarM9ce3c4fe, x509Certificate.getPublicKey());
                    } catch (java.security.cert.CertPathValidatorException e3) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Algorithm identifier of public key of trust anchor could not be read.", e3, certPath, -1);
                    }
                } catch (java.lang.Exception e4) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Subject of trust anchor could not be (re)encoded.", e4, certPath, iM53fd55a2);
                }
            }
            try {
                throw new java.security.cert.CertPathValidatorException("Trust anchor for certification path not found.", null, certPath, -1);
            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e5) {
                e = e5;
            }
        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e6) {
            e = e6;
        }
        throw new java.security.cert.CertPathValidatorException(e.getMessage(), e.getUnderlyingException(), certPath, certificates.Count - 1);
    }
}

