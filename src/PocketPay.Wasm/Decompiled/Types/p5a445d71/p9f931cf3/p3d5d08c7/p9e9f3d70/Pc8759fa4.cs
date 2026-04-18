namespace WillowMaze.Wasm.Decompiled;

public class Pc8759fa4 : CertPathBuilderSpi
{
    private Exception F7deb52e0;
    private Exception F83a4e9c8;
    private Exception Fbf05adfb;

    private static ICollection<object> M182c0efb(p4329c72d P0, List<object> P1)
    {
        // str: "Problem while picking certificates from X.509 store."
        // call: List<object>.iterator
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // call: p352d4243.<init>
        // call: pfdb0c388.getMatches
        // call: HashSet<object>.addAll
        // call: HashSet<object>.<init>
        // type: p352d4243
        // type: HashSet<object>
        return default!;
    }

    private CertPathBuilderResult Mb0da2755(pd2e37f48 P0, X509Certificate P1, paad5c124 P2, List<object> P3)
    {
        // str: "Certification path could not be validated."
        // str: "Certification path could not be constructed from certificate list."
        // str: "No issuer certificate for certificate in certification path found."
        // str: "Cannot find issuer certificate for certificate in certification path."
        // str: "No additional X.509 stores can be added from certificate locations."
        // str: "X.509"
        // str: "RFC3281"
        // str: "54ea5daaadc7e3bfc2fa5e65ba7140fc03e817e151e76e72762e9eb33533"
        // str: "No valid certification path could be build."
        // str: "Exception creating support classes."
        // call: List<object>.size
        // call: List<object>.remove
        // call: CertificateFactory.generateCertPath
        // call: CertPathValidator.validate
        // call: PKIXCertPathValidatorResult.getTrustAnchor
        // call: PKIXCertPathValidatorResult.getPolicyTree
        // call: PKIXCertPathValidatorResult.getPublicKey
        // call: PKIXCertPathBuilderResult.<init>
        // call: p352d4243.<init>
        // call: List<object>.<init>
        // call: pc446fcff.getCertificateStores
        // call: List<object>.addAll
        // call: p364bf33a.getId
        // call: X509Certificate.getExtensionValue
        // call: pc446fcff.getNamedCertificateStoreMap
        // call: p4640f1a7.mf4dbe0a3
        // call: HashSet<object>.<init>
        // call: pc446fcff.getCertStores
        // call: p4640f1a7.m6daef670
        // call: ICollection<object>.addAll
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc8759fa4.f7deb52e0
        // type: p352d4243
        // type: PKIXCertPathBuilderResult
        // type: List<object>
        // type: HashSet<object>
        // type: Exception
        return default!;
    }

    public CertPathBuilderResult EngineBuild(CertPathParameters P0)
    {
        // str: "4529e3f0d6fdfda4f6577171107e98ea193781c24d2727f92d830a9644"
        // str: "Public key certificate for attribute certificate cannot be found."
        // str: " class."
        // str: "Possible certificate chain could not be validated."
        // str: "Parameters must be an instance of "
        // str: "No attribute certificate found matching targetConstraints."
        // str: "Public key certificate for attribute certificate cannot be searched."
        // str: "Error finding target attribute certificate."
        // str: "cannot encode X500Principal."
        // str: " or "
        // str: "Unable to find certificate chain."
        // str: "TargetConstraints must be an instance of "
        // str: " for "
        // call: StringBuilder.append
        // call: pc8759fa4.mb0da2755
        // call: Type.getName
        // call: IEnumerator<object>.hasNext
        // call: ICollection<object>.iterator
        // call: object.getClass
        // call: InvalidAlgorithmParameterException.<init>
        // call: HashSet<object>.iterator
        // call: p27cbb5a8.<init>
        // call: p0c49d6f2.<init>
        // call: CertPathBuilderException.<init>
        // call: paad5c124$p2bd4a59b.addExcludedCerts
        // call: IEnumerator<object>.next
        // call: p73d7b518.getPrincipals
        // call: HashSet<object>.isEmpty
        // call: StringBuilder.toString
        // call: pc446fcff.getTargetConstraints
        // call: p7ac3b1b7.getStores
        // call: paad5c124.getBaseParameters
        // call: ICollection<object>.isEmpty
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc8759fa4.f7deb52e0
        // type: CertPathBuilderException
        // type: p27cbb5a8
        // type: p4329c72d
        // type: HashSet<object>
        // type: StringBuilder
        // type: List<object>
        // type: PKIXBuilderParameters
        // type: p1f30b1ff$p2bd4a59b
        // type: p0c49d6f2
        // type: paad5c124$p2bd4a59b
        return default!;
    }

}
