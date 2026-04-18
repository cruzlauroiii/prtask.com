namespace WillowMaze.Wasm.Decompiled;

public class Pfe573e7c : CertPathBuilderSpi
{
    private readonly bool F0ad17fc3;
    private Exception F5c1bc48c;
    private Exception F7deb52e0;
    private Exception F9cb56b24;
    private Exception Fa5e50a5f;
    private readonly bool Fc65cb337;
    private readonly bool Fdbb81ce3;
    private readonly bool Ffebcee75;

    private CertPathBuilderResult Build(X509Certificate P0, paad5c124 P1, List<object> P2)
    {
        // str: "Certification path could not be validated."
        // str: "Certification path could not be constructed from certificate list."
        // str: "No issuer certificate for certificate in certification path found."
        // str: "Cannot find issuer certificate for certificate in certification path."
        // str: "No additional X.509 stores can be added from certificate locations."
        // str: "Exception creating support classes."
        // call: paad5c124.getMaxPathLength
        // call: List<object>.contains
        // call: Exception.<init>
        // call: List<object>.size
        // call: List<object>.remove
        // call: List<object>.add
        // call: pc1bfd7d6.<init>
        // call: pf149c26b.<init>
        // call: paad5c124.getBaseParameters
        // call: pc446fcff.getTrustAnchors
        // call: pc446fcff.getSigProvider
        // call: p4640f1a7.mc7b165ab
        // call: pc1bfd7d6.engineGenerateCertPath
        // call: pf149c26b.engineValidate
        // call: PKIXCertPathValidatorResult.getTrustAnchor
        // call: PKIXCertPathValidatorResult.getPolicyTree
        // call: PKIXCertPathValidatorResult.getPublicKey
        // call: PKIXCertPathBuilderResult.<init>
        // call: p352d4243.<init>
        // call: List<object>.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pfe573e7c.f7deb52e0
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pfe573e7c.ffebcee75
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857
        // type: pc1bfd7d6
        // type: pf149c26b
        // type: PKIXCertPathBuilderResult
        // type: p352d4243
        // type: List<object>
        // type: HashSet<object>
        // type: Exception
        return default!;
    }

    public CertPathBuilderResult EngineBuild(CertPathParameters P0)
    {
        // str: "Possible certificate chain could not be validated."
        // str: "99f7b896a2f04749fe982225a38a0d0f0f4c6476d38da36c70786f127b"
        // str: "Unable to find certificate chain."
        // str: "Parameters must be an instance of "
        // str: " or "
        // call: p4640f1a7.mdeb6b9c1
        // call: StringBuilder.append
        // call: paad5c124$p2bd4a59b.setMaxPathLength
        // call: StringBuilder.<init>
        // call: paad5c124$p2bd4a59b.build
        // call: List<object>.iterator
        // call: IEnumerator<object>.next
        // call: p7ac3b1b7.getMaxPathLength
        // call: pc446fcff$p2bd4a59b.<init>
        // call: Exception.getCause
        // call: p7ac3b1b7.getAdditionalStores
        // call: paad5c124$p2bd4a59b.addExcludedCerts
        // call: StringBuilder.toString
        // call: Exception.getMessage
        // call: CertPathBuilderException.<init>
        // call: InvalidAlgorithmParameterException.<init>
        // call: paad5c124$p2bd4a59b.<init>
        // call: IEnumerator<object>.hasNext
        // call: Type.getName
        // call: pc446fcff$p2bd4a59b.addCertificateStore
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pfe573e7c.f7deb52e0
        // type: CertPathBuilderException
        // type: paad5c124$p2bd4a59b
        // type: PKIXBuilderParameters
        // type: pc446fcff$p2bd4a59b
        // type: List<object>
        // type: paad5c124
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
        return default!;
    }

}
