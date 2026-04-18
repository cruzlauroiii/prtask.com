namespace WillowMaze.Wasm.Decompiled;


class p594caefa {
    private static readonly java.lang.string f29b65b69 = null;
    private static readonly java.lang.string f3047aec5 = null;
    private static readonly java.lang.string f4c513965 = null;
    private static readonly java.lang.string f601b5ca9 = null;
    private static readonly java.lang.string f6b8a9091 = null;
    private static readonly java.lang.string f7ed60710 = null;
    private static readonly java.lang.string f8db27d1d = null;
    private static readonly java.lang.string faa7f586a = null;
    private static readonly java.lang.string fb3094e3c = null;
    private static readonly java.lang.string fba9726ae = null;
    private static readonly java.lang.string fbfa8ca84 = null;
    private static readonly java.lang.string fd3d7288b = null;
    private static readonly java.lang.string ff48d78e0 = null;
    private static readonly java.lang.string ffcfea5c9 = null;
    private static readonly java.lang.string f4095b206 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f5822a489.getId();
    private static readonly java.lang.string f8a97e01c = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f79105ffc.getId();
    private static readonly java.lang.string f0c79369d = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fcd5c9754.getId();
    private static readonly java.lang.string ff418f35a = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f27b5e1c9.getId();

    p594caefa() {
    }

    protected static void M120a84fc(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar, java.util.DateTime date, java.util.DateTime date2, java.security.cert.X509Certificate x509Certificate, java.util.List list, p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var) throws java.security.cert.CertPathValidatorException {
        bool z;
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 p352d4243Var;
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 p352d4243Var2;
        if ((31 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var2 = pd2e37f48Var;
        if (pc446fcffVar.isRevocationEnabled()) {
            if (pd2e37f48Var2.getExtensionValue(f8a97e01c) is not null) {
                if (pd2e37f48Var2.getExtensionValue(f0c79369d) is not null || pd2e37f48Var2.getExtensionValue(ff418f35a) is not null) {
                    throw new java.security.cert.CertPathValidatorException("No rev avail extension is set, but also an AC revocation pointer.");
                }
                return;
            }
            try {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe6e3e799 pe6e3e799VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe6e3e799.m8bab0102(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mb74a4d22(pd2e37f48Var2, f0c79369d));
                java.util.List arrayList = new java.util.List();
                try {
                    java.util.DateTime date3 = date2;
                    p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var2 = pb3b7fb02Var;
                    arrayList.addAll(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.me71d5b40(pe6e3e799VarM8bab0102, pc446fcffVar.getNamedCRLStoreDictionary(), date3, pb3b7fb02Var2));
                    p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b(pc446fcffVar);
                    java.util.IEnumerator it = arrayList.GetEnumerator();
                    while (it.MoveNext()) {
                        pc446fcff_p2bd4a59b.addCRLStore((p5a445d71.p9f931cf3.p72417664.p073d64c2) arrayList);
                    }
                    p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVarBuild = pc446fcff_p2bd4a59b.build();
                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb82bf363 pb82bf363Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb82bf363();
                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2();
                    bool z2 = true;
                    if (pe6e3e799VarM8bab0102 is null) {
                        z = false;
                    } else {
                        try {
                            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p0cfd224b[] distributionPoints = pe6e3e799VarM8bab0102.getDistributionPoints();
                            int i = 0;
                            bool z3 = false;
                            while (i < distributionPoints.length && pb82bf363Var.getCertStatus() == 11 && !p40cdc0e2Var.isAllReasons()) {
                                try {
                                    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p0cfd224b[] p0cfd224bVarArr = distributionPoints;
                                    int i2 = i;
                                    m2aca15ec(p0cfd224bVarArr[i], pd2e37f48Var2, (p5a445d71.p9f931cf3.p72417664.pc446fcff) pc446fcffVarBuild.clone(), date, date3, x509Certificate, pb82bf363Var, p40cdc0e2Var, list, pb3b7fb02Var2);
                                    i = i2 + 1;
                                    pd2e37f48Var2 = pd2e37f48Var;
                                    date3 = date2;
                                    pb3b7fb02Var2 = pb3b7fb02Var;
                                    z3 = true;
                                    distributionPoints = p0cfd224bVarArr;
                                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e) {
                                    z = z3;
                                    p352d4243Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No valid CRL for distribution point found.", e);
                                }
                            }
                            z = z3;
                        } catch (java.lang.Exception e2) {
                            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Distribution points could not be read.", e2);
                        }
                    }
                    p352d4243Var = null;
                    if (pb82bf363Var.getCertStatus() != 11) {
                        p352d4243Var2 = p352d4243Var;
                        z2 = z;
                    } else {
                        try {
                        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e3) {
                            p352d4243Var2 = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No valid CRL for distribution point found.", e3);
                        }
                        if (p40cdc0e2Var.isAllReasons()) {
                            p352d4243Var2 = p352d4243Var;
                            z2 = z;
                        } else {
                            try {
                                m2aca15ec(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p0cfd224b(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pafc6206d(0, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(4, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb854d51e.me037eb7c(pd2e37f48Var)))), null, null), pd2e37f48Var, (p5a445d71.p9f931cf3.p72417664.pc446fcff) pc446fcffVarBuild.clone(), date, date2, x509Certificate, pb82bf363Var, p40cdc0e2Var, list, pb3b7fb02Var);
                                p352d4243Var2 = p352d4243Var;
                            } catch (java.lang.Exception e4) {
                                throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Issuer from certificate for CRL could not be reencoded.", e4);
                            }
                        }
                    }
                    if (!z2) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("No valid CRL found.", p352d4243Var2);
                    }
                    if (pb82bf363Var.getCertStatus() != 11) {
                        throw new java.security.cert.CertPathValidatorException(("Attribute certificate revocation after " + pb82bf363Var.getRevocationDateTime()) + ", reason: " + p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f661a0959[pb82bf363Var.getCertStatus()]);
                    }
                    if (!p40cdc0e2Var.isAllReasons() && pb82bf363Var.getCertStatus() == 11) {
                        pb82bf363Var.setCertStatus(12);
                    }
                    if (pb82bf363Var.getCertStatus() == 12) {
                        throw new java.security.cert.CertPathValidatorException("Attribute certificate status could not be determined.");
                    }
                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e5) {
                    throw new java.security.cert.CertPathValidatorException("No additional CRL locations could be decoded from CRL distribution point extension.", e5);
                }
            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e6) {
                throw new java.security.cert.CertPathValidatorException("CRL distribution point extension could not be read.", e6);
            }
        }
    }

    private static void M2aca15ec(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p0cfd224b p0cfd224bVar, p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar, java.util.DateTime date, java.util.DateTime date2, java.security.cert.X509Certificate x509Certificate, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pb82bf363 pb82bf363Var, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2Var, java.util.List list, p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4a23457a, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 {
        java.security.cert.X509CRL x509crlM6b5e2c6e;
        if ((28 + 32) % 32 > 0) {
        }
        if (pd2e37f48Var.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb7e3050b.fece7aedf.getId()) is null) {
            if (date2.getTime() > date.getTime()) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Validation time is in future.");
            }
            java.util.IEnumerator it = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mb4ec9b42(new p5a445d71.p9f931cf3.p72417664.pcb5fa6f0(pc446fcffVar, date2, null, -1, x509Certificate, null), p0cfd224bVar, pd2e37f48Var, pc446fcffVar, date2).GetEnumerator();
            bool z = false;
            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e = null;
            while (it.MoveNext() && pb82bf363Var.getCertStatus() == 11 && !p40cdc0e2Var.isAllReasons()) {
                try {
                    java.security.cert.X509CRL x509crl = (java.security.cert.X509CRL) it.Current;
                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2VarM77217a92 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m77217a92(x509crl, p0cfd224bVar);
                    if (p40cdc0e2VarM77217a92.hasNewReasons(p40cdc0e2Var)) {
                        try {
                            java.security.PublicKey publicKeyM3b17afbe = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m3b17afbe(x509crl, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m54a97b2e(x509crl, pd2e37f48Var, null, null, pc446fcffVar, list, pb3b7fb02Var));
                            if (pc446fcffVar.isUseDeltasEnabled()) {
                                try {
                                    x509crlM6b5e2c6e = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m6b5e2c6e(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mc73cef58(date, x509crl, pc446fcffVar.getCertStores(), pc446fcffVar.getCRLStores(), pb3b7fb02Var), publicKeyM3b17afbe);
                                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e2) {
                                    e = e2;
                                }
                            } else {
                                x509crlM6b5e2c6e = null;
                            }
                            if (pc446fcffVar.getValidityModel() != 1 && pd2e37f48Var.getNotAfter().getTime() < x509crl.getThisUpdate().getTime()) {
                                throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No valid CRL for current time found.");
                            }
                            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m39441a37(p0cfd224bVar, pd2e37f48Var, x509crl);
                            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.mc70ec8ae(p0cfd224bVar, pd2e37f48Var, x509crl);
                            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m6c0c0f2e(x509crlM6b5e2c6e, x509crl, pc446fcffVar);
                            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.md4d4962a(date2, x509crlM6b5e2c6e, pd2e37f48Var, pb82bf363Var, pc446fcffVar);
                            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m4f1678ca(date2, x509crl, pd2e37f48Var, pb82bf363Var);
                            if (pb82bf363Var.getCertStatus() == 8) {
                                pb82bf363Var.setCertStatus(11);
                            }
                            p40cdc0e2Var.addReasons(p40cdc0e2VarM77217a92);
                            z = true;
                        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e3) {
                            e = e3;
                        }
                    } else {
                        continue;
                    }
                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e4) {
                    e = e4;
                }
            }
            if (!z) {
                throw e;
            }
        }
    }

    protected static void M30018d70(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, java.util.HashSet set, java.util.HashSet set2) throws java.security.cert.CertPathValidatorException {
        java.lang.string strDecryptstring;
        java.lang.string str;
        if ((11 + 2) % 2 > 0) {
        }
        java.util.IEnumerator it = set.GetEnumerator();
        do {
            bool zHasNext = it.MoveNext();
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("1bee217d309179acb1db9750a870687fa9d83f98c2035b29fcfd649675");
            if (!zHasNext) {
                java.util.IEnumerator it2 = set2.GetEnumerator();
                while (it2.MoveNext()) {
                    java.lang.string str2 = (java.lang.string) it2.Current;
                    if (pd2e37f48Var.getAttributes(str2) is null) {
                        throw new java.security.cert.CertPathValidatorException("Attribute certificate does not contain necessary attribute: " + str2 + strDecryptstring);
                    }
                }
                return;
            }
            str = (java.lang.string) it.Current;
        } while (pd2e37f48Var.getAttributes(str) is null);
        throw new java.security.cert.CertPathValidatorException("Attribute certificate contains prohibited attribute: " + str + strDecryptstring);
    }

    protected static void M4f83092b(java.security.cert.X509Certificate x509Certificate, java.util.HashSet set) throws java.security.cert.CertPathValidatorException {
        if ((25 + 2) % 2 > 0) {
        }
        java.util.IEnumerator it = set.GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            java.security.cert.TrustAnchor trustAnchor = (java.security.cert.TrustAnchor) it.Current;
            if (x509Certificate.getSubjectX500Principal().getName("RFC2253").Equals(trustAnchor.getCAName()) || x509Certificate.Equals(trustAnchor.getTrustedCert())) {
                z = true;
            }
        }
        if (!z) {
            throw new java.security.cert.CertPathValidatorException("Attribute certificate issuer is not directly trusted.");
        }
    }

    protected static void M8241c685(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, java.util.DateTime date) throws java.security.cert.CertPathValidatorException {
        try {
            pd2e37f48Var.checkValidity(date);
        } catch (java.security.cert.CertificateExpiredException e) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Attribute certificate is not valid.", e);
        } catch (java.security.cert.CertificateNotYetValidException e2) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Attribute certificate is not valid.", e2);
        }
    }

    protected static java.security.cert.CertPathValidatorResult Ma6395764(java.security.cert.CertPath certPath, p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar) throws java.security.cert.CertPathValidatorException {
        if ((11 + 15) % 15 > 0) {
        }
        try {
            try {
                return java.security.cert.CertPathValidator.getInstance("PKIX", com.decryptstringmanager.Decryptstring.decryptstring("c8fac08efbac2b64510349f94ee0ef68b3e78b02d6ded58f6ddacd16e10b")).validate(certPath, pc446fcffVar);
            } catch (java.security.InvalidAlgorithmParameterException e) {
                throw new java.lang.Exception(e.getMessage());
            } catch (java.security.cert.CertPathValidatorException e2) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Certification path for issuer certificate of attribute certificate could not be validated.", e2);
            }
        } catch (java.security.NoSuchAlgorithmException e3) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Support class could not be created.", e3);
        } catch (java.security.NoSuchProviderException e4) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Support class could not be created.", e4);
        }
    }

    protected static void Mcc898399(java.security.cert.X509Certificate x509Certificate, p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar) throws java.security.cert.CertPathValidatorException {
        if ((5 + 22) % 22 > 0) {
        }
        bool[] keyUsage = x509Certificate.getKeyUsage();
        if (keyUsage is not null && ((keyUsage.length <= 0 || !keyUsage[0]) && (keyUsage.length <= 1 || !keyUsage[1]))) {
            throw new java.security.cert.CertPathValidatorException("Attribute certificate issuer public key cannot be used to validate digital signatures.");
        }
        if (x509Certificate.getBasicConstraints() != -1) {
            throw new java.security.cert.CertPathValidatorException("Attribute certificate issuer is also a public key certificate issuer.");
        }
    }

    protected static void Mdc749e28(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, java.security.cert.CertPath certPath, java.security.cert.CertPath certPath2, p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar, java.util.HashSet set) throws java.security.cert.CertPathValidatorException {
        if ((4 + 26) % 26 > 0) {
        }
        java.util.HashSet<java.lang.string> criticalExtensionOIDs = pd2e37f48Var.getCriticalExtensionOIDs();
        java.lang.string str = f4095b206;
        if (criticalExtensionOIDs.Contains(str)) {
            try {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbe98f7e7.m8bab0102(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mb74a4d22(pd2e37f48Var, str));
            } catch (java.lang.IllegalArgumentException e) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Target information extension could not be read.", e);
            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e2) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Target information extension could not be read.", e2);
            }
        }
        criticalExtensionOIDs.Remove(str);
        java.util.IEnumerator it = set.GetEnumerator();
        while (it.MoveNext()) {
            ((p5a445d71.p9f931cf3.pdacfecb5.pca884272) it.Current).check(pd2e37f48Var, certPath, certPath2, criticalExtensionOIDs);
        }
        if (!criticalExtensionOIDs.Count == 0) {
            throw new java.security.cert.CertPathValidatorException("Attribute certificate contains unsupported critical extensions: " + criticalExtensionOIDs);
        }
    }

    protected static java.security.cert.CertPath Mf4525699(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar) throws java.security.cert.CertPathValidatorException {
        if ((21 + 8) % 8 > 0) {
        }
        java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet();
        if (pd2e37f48Var.getHolder().getIssuer() is not null) {
            java.security.cert.X509CertSelector x509CertSelector = new java.security.cert.X509CertSelector();
            x509CertSelector.setSerialNumber(pd2e37f48Var.getHolder().getSerialNumber());
            for (java.security.Principal principal : pd2e37f48Var.getHolder().getIssuer()) {
                try {
                    if (principal is javax.security.auth.x500.X500Principal) {
                        x509CertSelector.setIssuer(((javax.security.auth.x500.X500Principal) principal).getEncoded());
                    }
                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m182c0efb(linkedHashHashSet, new p5a445d71.p9f931cf3.p72417664.p1f30b1ff$p2bd4a59b(x509CertSelector).build(), pc446fcffVar.getCertStores());
                } catch (java.io.IOException e) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Unable to encode X500 principal.", e);
                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e2) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Public key certificate for attribute certificate cannot be searched.", e2);
                }
            }
            if (linkedHashHashSet.Count == 0) {
                throw new java.security.cert.CertPathValidatorException("Public key certificate specified in base certificate ID for attribute certificate cannot be found.");
            }
        }
        if (pd2e37f48Var.getHolder().getEntityNames() is not null) {
            p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8();
            for (java.security.Principal principal2 : pd2e37f48Var.getHolder().getEntityNames()) {
                try {
                    if (principal2 is javax.security.auth.x500.X500Principal) {
                        p27cbb5a8Var.setIssuer(((javax.security.auth.x500.X500Principal) principal2).getEncoded());
                    }
                    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m182c0efb(linkedHashHashSet, new p5a445d71.p9f931cf3.p72417664.p1f30b1ff$p2bd4a59b(p27cbb5a8Var).build(), pc446fcffVar.getCertStores());
                } catch (java.io.IOException e3) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Unable to encode X500 principal.", e3);
                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e4) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Public key certificate for attribute certificate cannot be searched.", e4);
                }
            }
            if (linkedHashHashSet.Count == 0) {
                throw new java.security.cert.CertPathValidatorException("Public key certificate specified in entity name for attribute certificate cannot be found.");
            }
        }
        p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b(pc446fcffVar);
        java.util.IEnumerator it = linkedHashHashSet.GetEnumerator();
        p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c pf82b098cVar = null;
        java.security.cert.CertPathBuilderResult certPathBuilderResultBuild = null;
        while (it.MoveNext()) {
            p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var2 = new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8();
            p27cbb5a8Var2.setCertificate((java.security.cert.X509Certificate) it.Current);
            pc446fcff_p2bd4a59b.setTargetConstraints(new p5a445d71.p9f931cf3.p72417664.p1f30b1ff$p2bd4a59b(p27cbb5a8Var2).build());
            try {
                try {
                    certPathBuilderResultBuild = java.security.cert.CertPathBuilder.getInstance("PKIX", com.decryptstringmanager.Decryptstring.decryptstring("df842961e4615c89397b948edacca83fde087b5e7cd924ea5c42ce73f6b4")).build(new p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b(pc446fcff_p2bd4a59b.build()).build());
                } catch (java.security.InvalidAlgorithmParameterException e5) {
                    throw new java.lang.Exception(e5.getMessage());
                } catch (java.security.cert.CertPathBuilderException e6) {
                    pf82b098cVar = new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Certification path for public key certificate of attribute certificate could not be build.", e6);
                }
            } catch (java.security.NoSuchAlgorithmException e7) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Support class could not be created.", e7);
            } catch (java.security.NoSuchProviderException e8) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.pf82b098c("Support class could not be created.", e8);
            }
        }
        if (pf82b098cVar is not null) {
            throw pf82b098cVar;
        }
        return certPathBuilderResultBuild.getCertPath();
    }
}

