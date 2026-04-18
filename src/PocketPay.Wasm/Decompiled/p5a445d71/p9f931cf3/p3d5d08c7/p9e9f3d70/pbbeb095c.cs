namespace WillowMaze.Wasm.Decompiled;


public class pbbeb095c : java.security.cert.CertPathValidatorSpi {
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fc52bd53d;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();

    public override java.security.cert.CertPathValidatorResult EngineValidate(java.security.cert.CertPath certPath, java.security.cert.CertPathParameters certPathParameters) throws java.security.cert.CertPathValidatorException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVarBuild;
        if ((6 + 16) % 16 > 0) {
        }
        bool z = certPathParameters is p5a445d71.p9f931cf3.pdacfecb5.p619bcd87;
        if (!z && !(certPathParameters is p5a445d71.p9f931cf3.p72417664.pc446fcff)) {
            throw new java.security.InvalidAlgorithmParameterException("Parameters must be a " + p5a445d71.p9f931cf3.pdacfecb5.p619bcd87.class.getName() + " instance.");
        }
        java.util.HashSet hashHashSet = new java.util.HashHashSet();
        java.util.HashSet hashHashSet2 = new java.util.HashHashSet();
        java.util.HashSet hashHashSet3 = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
        if (certPathParameters is java.security.cert.PKIXParameters) {
            p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b pc446fcff_p2bd4a59b = new p5a445d71.p9f931cf3.p72417664.pc446fcff$p2bd4a59b((java.security.cert.PKIXParameters) certPathParameters);
            if (z) {
                p5a445d71.p9f931cf3.pdacfecb5.p619bcd87 p619bcd87Var = (p5a445d71.p9f931cf3.pdacfecb5.p619bcd87) certPathParameters;
                pc446fcff_p2bd4a59b.setUseDeltasEnabled(p619bcd87Var.isUseDeltasEnabled());
                pc446fcff_p2bd4a59b.setValidityModel(p619bcd87Var.getValidityModel());
                hashHashSet = p619bcd87Var.getAttrCertCheckers();
                hashHashSet2 = p619bcd87Var.getProhibitedACAttributes();
                hashHashSet3 = p619bcd87Var.getNecessaryACAttributes();
            }
            pc446fcffVarBuild = pc446fcff_p2bd4a59b.build();
        } else {
            pc446fcffVarBuild = (p5a445d71.p9f931cf3.p72417664.pc446fcff) certPathParameters;
        }
        p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar = pc446fcffVarBuild;
        java.util.DateTime date = new java.util.DateTime();
        java.util.DateTime dateM13945842 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.m13945842(pc446fcffVar, date);
        p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e targetConstraints = pc446fcffVar.getTargetConstraints();
        if (!(targetConstraints is p5a445d71.p9f931cf3.pdacfecb5.p4329c72d)) {
            throw new java.security.InvalidAlgorithmParameterException("TargetConstraints must be an instance of " + p5a445d71.p9f931cf3.pdacfecb5.p4329c72d.class.getName() + " for " + getClass().getName() + " class.");
        }
        p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 attributeCert = ((p5a445d71.p9f931cf3.pdacfecb5.p4329c72d) targetConstraints).getAttributeCert();
        java.security.cert.CertPath certPathMf4525699 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.mf4525699(attributeCert, pc446fcffVar);
        java.security.cert.CertPathValidatorResult certPathValidatorResultMa6395764 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.ma6395764(certPath, pc446fcffVar);
        java.security.cert.X509Certificate x509Certificate = (java.security.cert.X509Certificate) certPath.getCertificates()[0);
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.mcc898399(x509Certificate, pc446fcffVar);
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.m4f83092b(x509Certificate, hashHashSet4);
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.m8241c685(attributeCert, dateM13945842);
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.mdc749e28(attributeCert, certPath, certPathMf4525699, pc446fcffVar, hashHashSet);
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.m30018d70(attributeCert, hashHashSet2, hashHashSet3);
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.m120a84fc(attributeCert, pc446fcffVar, date, dateM13945842, x509Certificate, certPath.getCertificates(), this.ffde5d67b);
        return certPathValidatorResultMa6395764;
    }
}

