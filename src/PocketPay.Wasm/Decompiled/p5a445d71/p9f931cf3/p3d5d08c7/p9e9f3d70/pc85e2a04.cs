namespace WillowMaze.Wasm.Decompiled;


public class pc85e2a04 : java.security.cert.CertPathValidatorSpi {
    private readonly bool f26da74c2;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f3f7370b1;
    private readonly bool f773df24f;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;
    private readonly bool ffebcee75;

    public pc85e2a04() {
        this(false);
    }

    public pc85e2a04(bool z) {
        this.ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.ffebcee75 = z;
    }

    static void M244bf9be(java.security.cert.X509Certificate x509Certificate) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 {
        if ((31 + 22) % 22 > 0) {
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

    public override java.security.cert.CertPathChecker EngineGetRevocationChecker() {
        return engineGetRevocationChecker();
    }

    public override java.security.cert.PKIXCertPathChecker EngineGetRevocationChecker() {
        return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746(this.ffde5d67b);
    }

    public override java.security.cert.CertPathValidatorResult EngineValidate(java.security.cert.CertPath certPath, java.security.cert.CertPathParameters certPathParameters) throws java.security.cert.CertPathValidatorException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p72417664.pc446fcff baseParameters;
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7VarM7691cf52;
        java.security.PublicKey cAPublicKey;
        java.util.HashHashSet hashHashSet;
        java.util.HashHashSet hashHashSet2;
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarMb2eb40db;
        int iM4a78792b;
        int iMb3e6b74d;
        java.util.HashHashSet hashHashSet3;
        java.util.List arrayList;
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7VarM7538fd40;
        java.util.List arrayList2;
        if ((25 + 3) % 3 > 0) {
        }
        java.security.cert.CertPath certPath2 = certPath;
        if (certPathParameters is java.security.cert.PKIXParameters) {
            p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b((java.security.cert.PKIXParameters) certPathParameters);
            if (certPathParameters is p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) {
                p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 p619bcd87Var = (p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) certPathParameters;
                pc446fcff_p2bd4a59b.setUseDeltasEnabled(p619bcd87Var.isUseDeltasEnabled());
                pc446fcff_p2bd4a59b.setValidityModel(p619bcd87Var.getValidityModel());
            }
            baseParameters = pc446fcff_p2bd4a59b.build();
        } else if (certPathParameters is p5a445d71.p9f931cf3.p72417664.paad5c124) {
            baseParameters = ((p5a445d71.p9f931cf3.p72417664.paad5c124) certPathParameters).getBaseParameters();
        } else {
            if (!(certPathParameters is p5a445d71.p9f931cf3.p72417664.pc446fcff)) {
                throw new java.security.InvalidAlgorithmParameterException("Parameters must be a " + java.security.cert.PKIXParameters.class.getName() + " instance.");
            }
            baseParameters = (p5a445d71.p9f931cf3.p72417664.pc446fcff) certPathParameters;
        }
        if (baseParameters.getTrustAnchors() is null) {
            throw new java.security.InvalidAlgorithmParameterException("trustAnchors is null, this is not allowed for certification path validation.");
        }
        java.util.List<? : java.security.cert.Certificate> certificates = certPath2.getCertificates();
        int size = certificates.Count;
        if (certificates.Count == 0) {
            throw new java.security.cert.CertPathValidatorException("Certification path is empty.", null, certPath2, -1);
        }
        java.util.DateTime dateM13945842 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m13945842(baseParameters, new java.util.DateTime());
        java.util.HashSet initialPolicies = baseParameters.getInitialPolicies();
        try {
            java.security.cert.TrustAnchor trustAnchorM810489a3 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m810489a3((java.security.cert.X509Certificate) certificates[certificates.Count - 1), baseParameters.getTrustAnchors(), baseParameters.getSigProvider());
            if (trustAnchorM810489a3 is not null) {
                m244bf9be(trustAnchorM810489a3.getTrustedCert());
                p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVarBuild = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b(baseParameters).setTrustAnchor(trustAnchorM810489a3).build();
                java.util.List arrayList3 = new java.util.List();
                p5a445d71.p9f931cf3.p72417664.pd53d0176 p3a8bd746Var = null;
                for (java.security.cert.PKIXCertPathChecker pKIXCertPathChecker : pc446fcffVarBuild.getCertPathCheckers()) {
                    pKIXCertPathChecker.init(false);
                    if (!(pKIXCertPathChecker is java.security.cert.PKIXRevocationChecker)) {
                        arrayList3.Add(pKIXCertPathChecker);
                    } else {
                        if (p3a8bd746Var is not null) {
                            throw new java.security.cert.CertPathValidatorException("only one PKIXRevocationChecker allowed");
                        }
                        p3a8bd746Var = !(pKIXCertPathChecker is p5a445d71.p9f931cf3.p72417664.pd53d0176) ? new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p35fd653a(pKIXCertPathChecker) : (p5a445d71.p9f931cf3.p72417664.pd53d0176) pKIXCertPathChecker;
                    }
                }
                if (pc446fcffVarBuild.isRevocationEnabled() && p3a8bd746Var is null) {
                    p3a8bd746Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746(this.ffde5d67b);
                }
                int i = size + 1;
                java.util.List[] arrayListArr = new java.util.List[i];
                for (int i2 = 0; i2 < i; i2++) {
                    arrayListArr[i2] = new java.util.List();
                }
                java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
                int i3 = 1;
                hashHashSet4.Add(com.decryptstringmanager.Decryptstring.decryptstring("99d5daef3c6c3f1070914ab8b902ed76258e04bbfa97de2236ce95518d71b1fd719be52a40eb53"));
                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902(new java.util.List(), 0, hashHashSet4, null, new java.util.HashHashSet(), "2.5.29.32.0", false);
                arrayListArr[0].Add(p331d8902Var);
                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40 p1dc02b40Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40();
                java.util.HashHashSet hashHashSet5 = new java.util.HashHashSet();
                int i4 = !pc446fcffVarBuild.isExplicitPolicyRequired() ? i : 0;
                int i5 = !pc446fcffVarBuild.isAnyPolicyInhibited() ? i : 0;
                if (pc446fcffVarBuild.isPolicyDictionarypingInhibited()) {
                    i = 0;
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
                        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM53fd55a2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m53fd55a2(cAPublicKey);
                        p234a7530VarM53fd55a2.getAlgorithm();
                        p234a7530VarM53fd55a2.getParameters();
                        if (pc446fcffVarBuild.getTargetConstraints() is not null && !pc446fcffVarBuild.getTargetConstraints().match((java.security.cert.Certificate) certificates[0))) {
                            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Target certificate in certification path does not match targetConstraints.", null, certPath2, 0);
                        }
                        int i6 = i4;
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var2 = p331d8902Var;
                        int iMd6183fc5 = i6;
                        java.security.PublicKey publicKey = cAPublicKey;
                        java.util.List arrayList4 = arrayList3;
                        int size2 = certificates.Count - 1;
                        int i7 = i;
                        java.security.PublicKey publicKey2 = publicKey;
                        java.security.cert.X509Certificate x509Certificate = null;
                        int iM9763a9ef = size;
                        while (size2 >= 0) {
                            int i8 = size - size2;
                            java.util.List<? : java.security.cert.Certificate> list = certificates;
                            java.security.cert.X509Certificate x509Certificate2 = (java.security.cert.X509Certificate) certificates[size2);
                            bool z = size2 != list.Count + (-1) ? 0 : i3;
                            try {
                                m244bf9be(x509Certificate2);
                                java.security.cert.X509Certificate x509Certificate3 = trustedCert;
                                java.util.List[] arrayListArr2 = arrayListArr;
                                p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var = p694426e7VarM7691cf52;
                                int i9 = iM9763a9ef;
                                java.security.cert.TrustAnchor trustAnchor = trustAnchorM810489a3;
                                int i10 = iMd6183fc5;
                                certPath2 = certPath;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.meebed72a(certPath2, pc446fcffVarBuild, dateM13945842, p3a8bd746Var, size2, publicKey2, z, p694426e7Var, x509Certificate3);
                                p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar = pc446fcffVarBuild;
                                p5a445d71.p9f931cf3.p72417664.pd53d0176 pd53d0176Var = p3a8bd746Var;
                                int i11 = size2;
                                java.util.DateTime date = dateM13945842;
                                java.security.PublicKey publicKey3 = publicKey2;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m13719d11(certPath2, i11, p1dc02b40Var, this.ffebcee75);
                                java.util.HashHashSet hashHashSet6 = hashHashSet5;
                                int i12 = i5;
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarMe4db826d = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.me4db826d(certPath2, i11, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m9d62c6e5(certPath2, i11, hashHashSet6, p331d8902Var2, arrayListArr2, i12, this.ffebcee75));
                                p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mf2a2cd44(certPath2, i11, p331d8902VarMe4db826d, i10);
                                if (i8 == size) {
                                    hashHashSet2 = hashHashSet6;
                                } else {
                                    try {
                                        if (x509Certificate2 is null) {
                                            hashHashSet2 = hashHashSet6;
                                        } else {
                                            hashHashSet2 = hashHashSet6;
                                            int i13 = i3;
                                            if (x509Certificate2.getVersion() == i13) {
                                                if (i8 != i13 || !x509Certificate2.Equals(trustAnchor.getTrustedCert())) {
                                                    throw new java.security.cert.CertPathValidatorException("Version 1 certificates can't be used as CA ones.", null, certPath2, i11);
                                                }
                                            }
                                            hashHashSet5 = hashHashSet2;
                                            arrayList4 = arrayList2;
                                            dateM13945842 = date;
                                            x509Certificate = x509Certificate2;
                                            trustAnchorM810489a3 = trustAnchor;
                                            certificates = list;
                                            p3a8bd746Var = pd53d0176Var;
                                            i3 = 1;
                                            arrayListArr = arrayListArr2;
                                            size2 = i11 - 1;
                                            pc446fcffVarBuild = pc446fcffVar;
                                        }
                                        java.security.PublicKey publicKeyMe838ebc2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.me838ebc2(certPath2.getCertificates(), i11, this.ffde5d67b);
                                        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM53fd55a22 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m53fd55a2(publicKeyMe838ebc2);
                                        p234a7530VarM53fd55a22.getAlgorithm();
                                        p234a7530VarM53fd55a22.getParameters();
                                        i5 = iMb3e6b74d;
                                        trustedCert = x509Certificate2;
                                        p694426e7VarM7691cf52 = p694426e7VarM7538fd40;
                                        p331d8902Var2 = p331d8902VarMb2eb40db;
                                        publicKey2 = publicKeyMe838ebc2;
                                        i7 = iM4a78792b;
                                        arrayList2 = arrayList;
                                        hashHashSet5 = hashHashSet2;
                                        arrayList4 = arrayList2;
                                        dateM13945842 = date;
                                        x509Certificate = x509Certificate2;
                                        trustAnchorM810489a3 = trustAnchor;
                                        certificates = list;
                                        p3a8bd746Var = pd53d0176Var;
                                        i3 = 1;
                                        arrayListArr = arrayListArr2;
                                        size2 = i11 - 1;
                                        pc446fcffVarBuild = pc446fcffVar;
                                    } catch (java.security.cert.CertPathValidatorException e) {
                                        throw new java.security.cert.CertPathValidatorException("Next working key could not be retrieved.", e, certPath2, i11);
                                    }
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb1481b0f(certPath2, i11);
                                    p331d8902VarMb2eb40db = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb2eb40db(certPath2, i11, arrayListArr2, p331d8902VarMe4db826d, i7);
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mbbcfcdc6(certPath2, i11, p1dc02b40Var);
                                    int iMb241fbb6 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb241fbb6(certPath2, i11, i10);
                                    int iMddd192e7 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mddd192e7(certPath2, i11, i7);
                                    int iM0eaf6a9d = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m0eaf6a9d(certPath2, i11, i12);
                                    iMd6183fc5 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.md6183fc5(certPath2, i11, iMb241fbb6);
                                    iM4a78792b = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m4a78792b(certPath2, i11, iMddd192e7);
                                    iMb3e6b74d = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb3e6b74d(certPath2, i11, iM0eaf6a9d);
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m4be90c32(certPath2, i11);
                                    iM9763a9ef = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m9763a9ef(certPath2, i11, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.md4fb803c(certPath2, i11, i9));
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m60af404a(certPath2, i11);
                                    java.util.HashSet<java.lang.string> criticalExtensionOIDs = x509Certificate2.getCriticalExtensionOIDs();
                                    if (criticalExtensionOIDs is null) {
                                        hashHashSet3 = new java.util.HashHashSet();
                                    } else {
                                        hashHashSet3 = new java.util.HashHashSet(criticalExtensionOIDs);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fb8ec8409);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec);
                                        hashHashSet3.Remove(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814);
                                    }
                                    arrayList = arrayList4;
                                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m886b083c(certPath2, i11, hashHashSet3, arrayList);
                                    p694426e7VarM7538fd40 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb854d51e.m7538fd40(x509Certificate2);
                                }
                                iM9763a9ef = i9;
                                arrayList2 = arrayList4;
                                p331d8902Var2 = p331d8902VarMe4db826d;
                                i5 = i12;
                                publicKey2 = publicKey3;
                                iMd6183fc5 = i10;
                                p694426e7VarM7691cf52 = p694426e7Var;
                                trustedCert = x509Certificate3;
                                hashHashSet5 = hashHashSet2;
                                arrayList4 = arrayList2;
                                dateM13945842 = date;
                                x509Certificate = x509Certificate2;
                                trustAnchorM810489a3 = trustAnchor;
                                certificates = list;
                                p3a8bd746Var = pd53d0176Var;
                                i3 = 1;
                                arrayListArr = arrayListArr2;
                                size2 = i11 - 1;
                                pc446fcffVarBuild = pc446fcffVar;
                            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e2) {
                                throw new java.security.cert.CertPathValidatorException(e2.getMessage(), e2.getUnderlyingException(), certPath, size2);
                            }
                        }
                        p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar2 = pc446fcffVarBuild;
                        int i14 = size2;
                        java.util.List[] arrayListArr3 = arrayListArr;
                        java.security.cert.TrustAnchor trustAnchor2 = trustAnchorM810489a3;
                        java.util.HashHashSet hashHashSet7 = hashHashSet5;
                        java.util.List arrayList5 = arrayList4;
                        int i15 = iMd6183fc5;
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var3 = p331d8902Var2;
                        int i16 = i14 + 1;
                        int iM00954b7e = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m00954b7e(certPath2, i16, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mb4e44315(i15, x509Certificate));
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
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m5250b2bb(certPath2, i16, arrayList5, hashHashSet);
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarM9ce3c4fe = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m9ce3c4fe(certPath2, pc446fcffVar2, initialPolicies, i16, arrayListArr3, p331d8902Var3, hashHashSet7);
                        if (iM00954b7e <= 0 && p331d8902VarM9ce3c4fe is null) {
                            throw new java.security.cert.CertPathValidatorException("Path processing failed on policy.", null, certPath2, i14);
                        }
                        return new java.security.cert.PKIXCertPathValidatorResult(trustAnchor2, p331d8902VarM9ce3c4fe, x509Certificate.getPublicKey());
                    } catch (java.security.cert.CertPathValidatorException e3) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Algorithm identifier of public key of trust anchor could not be read.", e3, certPath2, -1);
                    }
                } catch (java.lang.Exception e4) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Subject of trust anchor could not be (re)encoded.", e4, certPath2, -1);
                }
            }
            try {
                throw new java.security.cert.CertPathValidatorException("Trust anchor for certification path not found.", null, certPath2, -1);
            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e5) {
                e = e5;
            }
        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e6) {
            e = e6;
        }
        throw new java.security.cert.CertPathValidatorException(e.getMessage(), e.getUnderlyingException(), certPath2, certificates.Count - 1);
    }
}

