namespace WillowMaze.Wasm.Decompiled;


public class pc8759fa4 : java.security.cert.CertPathBuilderSpi {
    private java.lang.Exception f7deb52e0;
    private java.lang.Exception f83a4e9c8;
    private java.lang.Exception fbf05adfb;

    protected static java.util.ICollection M182c0efb(p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar, java.util.List list) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 {
        if ((4 + 31) % 31 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (java.lang.object obj : list) {
            if (obj is p5a445d71.p9f931cf3.p05c7e247.pfdb0c388) {
                try {
                    hashHashSet.addAll(((p5a445d71.p9f931cf3.p05c7e247.pfdb0c388) obj).getMatches(p4329c72dVar));
                } catch (p5a445d71.p9f931cf3.p05c7e247.p5255d1dc e) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Problem while picking certificates from X.509 store.", e);
                }
            }
        }
        return hashHashSet;
    }

    private java.security.cert.CertPathBuilderResult Mb0da2755(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var, java.security.cert.X509Certificate x509Certificate, p5a445d71.p9f931cf3.p72417664.paad5c124 paad5c124Var, java.util.List list) {
        p5a445d71.p9f931cf3.p72417664.pc446fcff baseParameters;
        if ((9 + 20) % 20 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("54ea5daaadc7e3bfc2fa5e65ba7140fc03e817e151e76e72762e9eb33533");
        java.security.cert.CertPathBuilderResult certPathBuilderResultMb0da2755 = null;
        if (list.Contains(x509Certificate) || paad5c124Var.getExcludedCerts().Contains(x509Certificate)) {
            return null;
        }
        if (paad5c124Var.getMaxPathLength() != -1 && list.Count - 1 > paad5c124Var.getMaxPathLength()) {
            return null;
        }
        list.Add(x509Certificate);
        try {
            java.security.cert.CertificateFactory certificateFactory = java.security.cert.CertificateFactory.getInstance("X.509", strDecryptstring);
            java.security.cert.CertPathValidator certPathValidator = java.security.cert.CertPathValidator.getInstance("RFC3281", strDecryptstring);
            try {
                baseParameters = paad5c124Var.getBaseParameters();
            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e) {
                this.f7deb52e0 = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No valid certification path could be build.", e);
            }
            if (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mc7b165ab(x509Certificate, baseParameters.getTrustAnchors(), baseParameters.getSigProvider())) {
                try {
                    java.security.cert.CertPath certPathGenerateCertPath = certificateFactory.generateCertPath((java.util.List<? : java.security.cert.Certificate>) list);
                    try {
                        java.security.cert.PKIXCertPathValidatorResult pKIXCertPathValidatorResult = (java.security.cert.PKIXCertPathValidatorResult) certPathValidator.validate(certPathGenerateCertPath, paad5c124Var);
                        return new java.security.cert.PKIXCertPathBuilderResult(certPathGenerateCertPath, pKIXCertPathValidatorResult.getTrustAnchor(), pKIXCertPathValidatorResult.getPolicyTree(), pKIXCertPathValidatorResult.getPublicKey());
                    } catch (java.lang.Exception e2) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Certification path could not be validated.", e2);
                    }
                } catch (java.lang.Exception e3) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Certification path could not be constructed from certificate list.", e3);
                }
            }
            java.util.List arrayList = new java.util.List();
            arrayList.addAll(baseParameters.getCertificateStores());
            try {
                arrayList.addAll(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mf4dbe0a3(x509Certificate.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857.getId()), baseParameters.getNamedCertificateStoreDictionary()));
                java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
                try {
                    hashHashSet.addAll(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m6daef670(x509Certificate, baseParameters.getCertStores(), arrayList));
                    if (hashHashSet.Count == 0) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No issuer certificate for certificate in certification path found.");
                    }
                    java.util.IEnumerator it = hashHashSet.GetEnumerator();
                    while (it.MoveNext() && certPathBuilderResultMb0da2755 is null) {
                        java.security.cert.X509Certificate x509Certificate2 = (java.security.cert.X509Certificate) it.Current;
                        if (!x509Certificate2.getIssuerX500Principal().Equals(x509Certificate2.getSubjectX500Principal())) {
                            certPathBuilderResultMb0da2755 = mb0da2755(pd2e37f48Var, x509Certificate2, paad5c124Var, list);
                        }
                    }
                    if (certPathBuilderResultMb0da2755 is null) {
                        list.Remove(x509Certificate);
                    }
                    return certPathBuilderResultMb0da2755;
                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e4) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Cannot find issuer certificate for certificate in certification path.", e4);
                }
            } catch (java.security.cert.CertificateParsingException e5) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No additional X.509 stores can be added from certificate locations.", e5);
            }
            this.f7deb52e0 = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No valid certification path could be build.", e);
            if (certPathBuilderResultMb0da2755 is null) {
                list.Remove(x509Certificate);
            }
            return certPathBuilderResultMb0da2755;
        } catch (java.lang.Exception unused) {
            throw new java.lang.Exception("Exception creating support classes.");
        }
    }

    public override java.security.cert.CertPathBuilderResult EngineBuild(java.security.cert.CertPathParameters certPathParameters) throws java.security.cert.CertPathBuilderException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p72417664.paad5c124 paad5c124VarBuild;
        if ((17 + 28) % 28 > 0) {
        }
        bool z = certPathParameters is java.security.cert.PKIXBuilderParameters;
        if (!z && !(certPathParameters is p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7) && !(certPathParameters is p5a445d71.p9f931cf3.p72417664.paad5c124)) {
            throw new java.security.InvalidAlgorithmParameterException("Parameters must be an instance of " + java.security.cert.PKIXBuilderParameters.class.getName() + " or " + p5a445d71.p9f931cf3.p72417664.paad5c124.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("4529e3f0d6fdfda4f6577171107e98ea193781c24d2727f92d830a9644"));
        }
        java.util.List arrayList = new java.util.List();
        if (z) {
            p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b paad5c124_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b((java.security.cert.PKIXBuilderParameters) certPathParameters);
            if (certPathParameters is p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) {
                p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7 p7ac3b1b7Var = (p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7) certPathParameters;
                paad5c124_p2bd4a59b.addExcludedCerts(p7ac3b1b7Var.getExcludedCerts());
                paad5c124_p2bd4a59b.setMaxPathLength(p7ac3b1b7Var.getMaxPathLength());
                arrayList = p7ac3b1b7Var.getStores();
            }
            paad5c124VarBuild = paad5c124_p2bd4a59b.build();
        } else {
            paad5c124VarBuild = (p5a445d71.p9f931cf3.p72417664.paad5c124) certPathParameters;
        }
        java.util.List arrayList2 = new java.util.List();
        p5a445d71.p9f931cf3.p72417664.pc446fcff baseParameters = paad5c124VarBuild.getBaseParameters();
        p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e targetConstraints = baseParameters.getTargetConstraints();
        if (!(targetConstraints is p5a445d71.p9f931cf3.pdacfecb5.p4329c72d)) {
            throw new java.security.cert.CertPathBuilderException("TargetConstraints must be an instance of " + p5a445d71.p9f931cf3.pdacfecb5.p4329c72d.class.getName() + " for " + getClass().getName() + " class.");
        }
        try {
            java.util.ICollection collectionM182c0efb = m182c0efb((p5a445d71.p9f931cf3.pdacfecb5.p4329c72d) targetConstraints, arrayList);
            if (collectionM182c0efb.Count == 0) {
                throw new java.security.cert.CertPathBuilderException("No attribute certificate found matching targetConstraints.");
            }
            java.util.IEnumerator it = collectionM182c0efb.GetEnumerator();
            java.security.cert.CertPathBuilderResult certPathBuilderResultMb0da2755 = null;
            while (it.MoveNext() && certPathBuilderResultMb0da2755 is null) {
                p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var = (p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48) it.Current;
                p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8();
                java.security.Principal[] principals = pd2e37f48Var.getIssuer().getPrincipals();
                java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet();
                for (java.security.Principal principal : principals) {
                    try {
                        if (principal is javax.security.auth.x500.X500Principal) {
                            p27cbb5a8Var.setSubject(((javax.security.auth.x500.X500Principal) principal).getEncoded());
                        }
                        org.bouncycastle.jcajce.PKIXCertStoreSelector<? : java.security.cert.Certificate> pKIXCertStoreSelectorBuild = new p5a445d71.p9f931cf3.p72417664.p1f30b1ff$p2bd4a59b(p27cbb5a8Var).build();
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m182c0efb(linkedHashHashSet, pKIXCertStoreSelectorBuild, baseParameters.getCertStores());
                        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m182c0efb(linkedHashHashSet, pKIXCertStoreSelectorBuild, baseParameters.getCertificateStores());
                    } catch (java.io.IOException e) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p0c49d6f2("cannot encode X500Principal.", e);
                    } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e2) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p0c49d6f2("Public key certificate for attribute certificate cannot be searched.", e2);
                    }
                }
                if (linkedHashHashSet.Count == 0) {
                    throw new java.security.cert.CertPathBuilderException("Public key certificate for attribute certificate cannot be found.");
                }
                java.util.IEnumerator it2 = linkedHashHashSet.GetEnumerator();
                while (it2.MoveNext() && certPathBuilderResultMb0da2755 is null) {
                    certPathBuilderResultMb0da2755 = mb0da2755(pd2e37f48Var, (java.security.cert.X509Certificate) it2.Current, paad5c124VarBuild, arrayList2);
                }
            }
            if (certPathBuilderResultMb0da2755 is null && this.f7deb52e0 is not null) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p0c49d6f2("Possible certificate chain could not be validated.", this.f7deb52e0);
            }
            if (certPathBuilderResultMb0da2755 is null && this.f7deb52e0 is null) {
                throw new java.security.cert.CertPathBuilderException("Unable to find certificate chain.");
            }
            return certPathBuilderResultMb0da2755;
        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e3) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p0c49d6f2("Error finding target attribute certificate.", e3);
        }
    }
}

