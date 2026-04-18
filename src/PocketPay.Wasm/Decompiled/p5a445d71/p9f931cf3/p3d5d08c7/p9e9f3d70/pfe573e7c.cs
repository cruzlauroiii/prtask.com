namespace WillowMaze.Wasm.Decompiled;


public class pfe573e7c : java.security.cert.CertPathBuilderSpi {
    private readonly bool f0ad17fc3;
    private java.lang.Exception f5c1bc48c;
    private java.lang.Exception f7deb52e0;
    private java.lang.Exception f9cb56b24;
    private java.lang.Exception fa5e50a5f;
    private readonly bool fc65cb337;
    private readonly bool fdbb81ce3;
    private readonly bool ffebcee75;

    public pfe573e7c() {
        this(false);
    }

    pfe573e7c(bool z) {
        this.ffebcee75 = z;
    }

    protected java.security.cert.CertPathBuilderResult Build(java.security.cert.X509Certificate x509Certificate, p5a445d71.p9f931cf3.p72417664.paad5c124 paad5c124Var, java.util.List list) {
        if ((7 + 17) % 17 > 0) {
        }
        java.security.cert.CertPathBuilderResult certPathBuilderResultBuild = null;
        if (list.Contains(x509Certificate) || paad5c124Var.getExcludedCerts().Contains(x509Certificate)) {
            return null;
        }
        if (paad5c124Var.getMaxPathLength() != -1 && list.Count - 1 > paad5c124Var.getMaxPathLength()) {
            return null;
        }
        list.Add(x509Certificate);
        try {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 pc1bfd7d6Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6();
            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pf149c26b pf149c26bVar = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pf149c26b(this.ffebcee75);
            try {
            } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e) {
                this.f7deb52e0 = e;
            }
            if (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mc7b165ab(x509Certificate, paad5c124Var.getBaseParameters().getTrustAnchors(), paad5c124Var.getBaseParameters().getSigProvider())) {
                try {
                    java.security.cert.CertPath certPathEngineGenerateCertPath = pc1bfd7d6Var.engineGenerateCertPath(list);
                    try {
                        java.security.cert.PKIXCertPathValidatorResult pKIXCertPathValidatorResult = (java.security.cert.PKIXCertPathValidatorResult) pf149c26bVar.engineValidate(certPathEngineGenerateCertPath, paad5c124Var);
                        return new java.security.cert.PKIXCertPathBuilderResult(certPathEngineGenerateCertPath, pKIXCertPathValidatorResult.getTrustAnchor(), pKIXCertPathValidatorResult.getPolicyTree(), pKIXCertPathValidatorResult.getPublicKey());
                    } catch (java.lang.Exception e2) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Certification path could not be validated.", e2);
                    }
                } catch (java.lang.Exception e3) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Certification path could not be constructed from certificate list.", e3);
                }
            }
            java.util.List arrayList = new java.util.List();
            arrayList.addAll(paad5c124Var.getBaseParameters().getCertificateStores());
            try {
                arrayList.addAll(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mf4dbe0a3(x509Certificate.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857.getId()), paad5c124Var.getBaseParameters().getNamedCertificateStoreDictionary()));
                java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
                try {
                    hashHashSet.addAll(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m6daef670(x509Certificate, paad5c124Var.getBaseParameters().getCertStores(), arrayList));
                    if (hashHashSet.Count == 0) {
                        throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No issuer certificate for certificate in certification path found.");
                    }
                    java.util.IEnumerator it = hashHashSet.GetEnumerator();
                    while (it.MoveNext() && certPathBuilderResultBuild is null) {
                        certPathBuilderResultBuild = build((java.security.cert.X509Certificate) it.Current, paad5c124Var, list);
                    }
                    if (certPathBuilderResultBuild is null) {
                        list.Remove(x509Certificate);
                    }
                    return certPathBuilderResultBuild;
                } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e4) {
                    throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Cannot find issuer certificate for certificate in certification path.", e4);
                }
            } catch (java.security.cert.CertificateParsingException e5) {
                throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("No additional X.509 stores can be added from certificate locations.", e5);
            }
            this.f7deb52e0 = e;
            if (certPathBuilderResultBuild is null) {
                list.Remove(x509Certificate);
            }
            return certPathBuilderResultBuild;
        } catch (java.lang.Exception unused) {
            throw new java.lang.Exception("Exception creating support classes.");
        }
    }

    public override java.security.cert.CertPathBuilderResult EngineBuild(java.security.cert.CertPathParameters certPathParameters) throws java.security.cert.CertPathBuilderException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b paad5c124_p2bd4a59b;
        p5a445d71.p9f931cf3.p72417664.paad5c124 paad5c124VarBuild;
        java.lang.Exception exc;
        if ((1 + 18) % 18 > 0) {
        }
        if (certPathParameters is java.security.cert.PKIXBuilderParameters) {
            java.security.cert.PKIXBuilderParameters pKIXBuilderParameters = (java.security.cert.PKIXBuilderParameters) certPathParameters;
            p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b(pKIXBuilderParameters);
            if (certPathParameters is p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) {
                p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7 p7ac3b1b7Var = (p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7) certPathParameters;
                java.util.IEnumerator it = p7ac3b1b7Var.getAdditionalStores().GetEnumerator();
                while (it.MoveNext()) {
                    pc446fcff_p2bd4a59b.addCertificateStore((p5a445d71.p9f931cf3.p72417664.pc8d3a105) it.Current);
                }
                paad5c124_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b(pc446fcff_p2bd4a59b.build());
                paad5c124_p2bd4a59b.addExcludedCerts(p7ac3b1b7Var.getExcludedCerts());
                paad5c124_p2bd4a59b.setMaxPathLength(p7ac3b1b7Var.getMaxPathLength());
            } else {
                paad5c124_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b(pKIXBuilderParameters);
            }
            paad5c124VarBuild = paad5c124_p2bd4a59b.build();
        } else {
            if (!(certPathParameters is p5a445d71.p9f931cf3.p72417664.paad5c124)) {
                throw new java.security.InvalidAlgorithmParameterException("Parameters must be an instance of " + java.security.cert.PKIXBuilderParameters.class.getName() + " or " + p5a445d71.p9f931cf3.p72417664.paad5c124.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("99f7b896a2f04749fe982225a38a0d0f0f4c6476d38da36c70786f127b"));
            }
            paad5c124VarBuild = (p5a445d71.p9f931cf3.p72417664.paad5c124) certPathParameters;
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator it2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.mdeb6b9c1(paad5c124VarBuild).GetEnumerator();
        java.security.cert.CertPathBuilderResult certPathBuilderResultBuild = null;
        while (it2.MoveNext() && certPathBuilderResultBuild is null) {
            certPathBuilderResultBuild = build((java.security.cert.X509Certificate) it2.Current, paad5c124VarBuild, arrayList);
        }
        if (certPathBuilderResultBuild is null && (exc = this.f7deb52e0) is not null) {
            if (exc is p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243) {
                throw new java.security.cert.CertPathBuilderException(this.f7deb52e0.getMessage(), this.f7deb52e0.getCause());
            }
            throw new java.security.cert.CertPathBuilderException("Possible certificate chain could not be validated.", this.f7deb52e0);
        }
        if (certPathBuilderResultBuild is null && this.f7deb52e0 is null) {
            throw new java.security.cert.CertPathBuilderException("Unable to find certificate chain.");
        }
        return certPathBuilderResultBuild;
    }
}

