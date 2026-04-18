namespace WillowMaze.Wasm.Decompiled;

public class P94012bf9 : CertPathBuilderSpi
{
    private Exception F236b3357;
    private readonly bool F2fc1ac6a;
    private Exception F60a1c3cb;
    private readonly bool F709e7cf2;
    private readonly pb3b7fb02 F74d74f4c;
    private Exception F7a21d4d6;
    private Exception F7deb52e0;
    private Exception F96e6b33c;
    private readonly pb3b7fb02 F9df65293;
    private readonly pb3b7fb02 Fb1f0f2d7;
    private readonly pb3b7fb02 Ffde5d67b;
    private readonly bool Ffebcee75;

    private CertPathBuilderResult Build(X509Certificate P0, paad5c124 P1, List<object> P2)
    {
        // str: "Certification path could not be validated."
        // str: "Certification path could not be constructed from certificate list."
        // str: "No issuer certificate for certificate in certification path found."
        // str: "Cannot find issuer certificate for certificate in certification path."
        // str: "No additional X.509 stores can be added from certificate locations."
        // str: "Exception creating support classes."
        // call: List<object>.remove
        // call: paad5c124.getMaxPathLength
        // call: pc1bfd7d6.engineGenerateCertPath
        // call: pc85e2a04.engineValidate
        // call: PKIXCertPathValidatorResult.getTrustAnchor
        // call: PKIXCertPathValidatorResult.getPolicyTree
        // call: PKIXCertPathValidatorResult.getPublicKey
        // call: PKIXCertPathBuilderResult.<init>
        // call: p352d4243.<init>
        // call: List<object>.<init>
        // call: paad5c124.getBaseParameters
        // call: pc446fcff.getCertificateStores
        // call: List<object>.addAll
        // call: p364bf33a.getId
        // call: X509Certificate.getExtensionValue
        // call: pc446fcff.getNamedCertificateStoreMap
        // call: p4640f1a7.mf4dbe0a3
        // call: HashSet<object>.<init>
        // call: pc446fcff.getCertStores
        // call: p4640f1a7.m6daef670
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p94012bf9.ffebcee75
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p94012bf9.f7deb52e0
        // type: PKIXCertPathBuilderResult
        // type: p352d4243
        // type: List<object>
        // type: HashSet<object>
        // type: Exception
        // type: pc1bfd7d6
        // type: pc85e2a04
        return default!;
    }

    public CertPathBuilderResult EngineBuild(CertPathParameters P0)
    {
        // str: "Possible certificate chain could not be validated."
        // str: "Parameters must be an instance of "
        // str: "12a651927f6dce60cf5314a828bf4e4425e1c0784a95eb0a071b756b56"
        // str: " or "
        // str: "Unable to find certificate chain."
        // call: paad5c124$p2bd4a59b.<init>
        // call: IEnumerator<object>.hasNext
        // call: paad5c124$p2bd4a59b.setMaxPathLength
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.append
        // call: Type.getName
        // call: p7ac3b1b7.getAdditionalStores
        // call: paad5c124$p2bd4a59b.addExcludedCerts
        // call: CertPathBuilderException.<init>
        // call: p94012bf9.build
        // call: p7ac3b1b7.getMaxPathLength
        // call: DecryptString.decryptString
        // call: pc446fcff$p2bd4a59b.<init>
        // call: paad5c124$p2bd4a59b.build
        // call: StringBuilder.toString
        // call: List<object>.iterator
        // call: pc446fcff$p2bd4a59b.build
        // call: Exception.getMessage
        // call: StringBuilder.<init>
        // call: IEnumerator<object>.next
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p94012bf9.f7deb52e0
        // type: StringBuilder
        // type: InvalidAlgorithmParameterException
        // type: CertPathBuilderException
        // type: List<object>
        // type: pc446fcff$p2bd4a59b
        // type: paad5c124$p2bd4a59b
        // type: paad5c124
        // type: PKIXBuilderParameters
        return default!;
    }

    public CertPathChecker EngineGetRevocationChecker()
    {
        // call: p94012bf9.engineGetRevocationChecker
        return default!;
    }

    public PKIXCertPathChecker EngineGetRevocationChecker()
    {
        // call: p3a8bd746.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p94012bf9.ffde5d67b
        // type: p3a8bd746
        return default!;
    }

}
