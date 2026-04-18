namespace WillowMaze.Wasm.Decompiled;

public class P594caefa
{
    private static string F0c79369d;
    private static string F29b65b69;
    private static string F3047aec5;
    private static string F4095b206;
    private static string F4c513965;
    private static string F601b5ca9;
    private static string F6b8a9091;
    private static string F7ed60710;
    private static string F8a97e01c;
    private static string F8db27d1d;
    private static string Faa7f586a;
    private static string Fb3094e3c;
    private static string Fba9726ae;
    private static string Fbfa8ca84;
    private static string Fd3d7288b;
    private static string Ff418f35a;
    private static string Ff48d78e0;
    private static string Ffcfea5c9;

    private static void M120a84fc(pd2e37f48 P0, pc446fcff P1, DateTime P2, DateTime P3, X509Certificate P4, List<object> P5, pb3b7fb02 P6)
    {
        // str: "Attribute certificate status could not be determined."
        // str: "Attribute certificate revocation after "
        // str: "No additional CRL locations could be decoded from CRL distribution point extension."
        // str: "Issuer from certificate for CRL could not be reencoded."
        // str: "No rev avail extension is set, but also an AC revocation pointer."
        // str: "No valid CRL found."
        // str: "Distribution points could not be read."
        // str: "CRL distribution point extension could not be read."
        // str: "No valid CRL for distribution point found."
        // str: ", reason: "
        // call: pd2e37f48.getExtensionValue
        // call: List<object>.<init>
        // call: pc446fcff.getNamedCRLStoreMap
        // call: p4640f1a7.me71d5b40
        // call: List<object>.addAll
        // call: pb82bf363.getCertStatus
        // call: p352d4243.<init>
        // call: p40cdc0e2.<init>
        // call: pc446fcff$p2bd4a59b.build
        // call: pb854d51e.me037eb7c
        // call: pf17d2ecd.<init>
        // call: pfb202cf8.<init>
        // call: pafc6206d.<init>
        // call: p0cfd224b.<init>
        // call: pc446fcff.clone
        // call: p594caefa.m2aca15ec
        // call: List<object>.iterator
        // call: pc446fcff$p2bd4a59b.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.ff418f35a
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f661a0959
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.f8a97e01c
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.f0c79369d
        // type: p40cdc0e2
        // type: p0cfd224b
        // type: pafc6206d
        // type: pfb202cf8
        // type: pf17d2ecd
        // type: p352d4243
        // type: CertPathValidatorException
        // type: StringBuilder
        // type: pb82bf363
        // type: pc446fcff$p2bd4a59b
    }

    private static void M2aca15ec(p0cfd224b P0, pd2e37f48 P1, pc446fcff P2, DateTime P3, DateTime P4, X509Certificate P5, pb82bf363 P6, p40cdc0e2 P7, List<object> P8, pb3b7fb02 P9)
    {
        // str: "Validation time is in future."
        // str: "No valid CRL for current time found."
        // call: p364bf33a.getId
        // call: p40cdc0e2.isAllReasons
        // call: pb82bf363.getCertStatus
        // call: IEnumerator<object>.hasNext
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.next
        // call: p4da36ec9.m77217a92
        // call: p40cdc0e2.hasNewReasons
        // call: DateTime.getTime
        // call: p4da36ec9.m54a97b2e
        // call: p4da36ec9.m3b17afbe
        // call: pc446fcff.isUseDeltasEnabled
        // call: pc446fcff.getCertStores
        // call: pc446fcff.getCRLStores
        // call: p4640f1a7.mc73cef58
        // call: p4da36ec9.m6b5e2c6e
        // call: pc446fcff.getValidityModel
        // call: pd2e37f48.getNotAfter
        // call: X509CRL.getThisUpdate
        // call: p352d4243.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb7e3050b.fece7aedf
        // type: pcb5fa6f0
        // type: p352d4243
    }

    private static void M30018d70(pd2e37f48 P0, HashSet<object> P1, HashSet<object> P2)
    {
        // str: "Attribute certificate contains prohibited attribute: "
        // str: "1bee217d309179acb1db9750a870687fa9d83f98c2035b29fcfd649675"
        // str: "Attribute certificate does not contain necessary attribute: "
        // call: StringBuilder.toString
        // call: IEnumerator<object>.next
        // call: StringBuilder.append
        // call: IEnumerator<object>.hasNext
        // call: DecryptString.decryptString
        // call: StringBuilder.<init>
        // call: pd2e37f48.getAttributes
        // call: CertPathValidatorException.<init>
        // call: HashSet<object>.iterator
        // type: StringBuilder
        // type: CertPathValidatorException
    }

    private static void M4f83092b(X509Certificate P0, HashSet<object> P1)
    {
        // str: "RFC2253"
        // str: "Attribute certificate issuer is not directly trusted."
        // call: X500Principal.getName
        // call: IEnumerator<object>.next
        // call: TrustAnchor.getTrustedCert
        // call: X509Certificate.getSubjectX500Principal
        // call: string.equals
        // call: IEnumerator<object>.hasNext
        // call: X509Certificate.equals
        // call: HashSet<object>.iterator
        // call: CertPathValidatorException.<init>
        // call: TrustAnchor.getCAName
        // type: CertPathValidatorException
    }

    private static void M8241c685(pd2e37f48 P0, DateTime P1)
    {
        // str: "Attribute certificate is not valid."
        // call: pd2e37f48.checkValidity
        // call: pf82b098c.<init>
        // type: pf82b098c
    }

    private static CertPathValidatorResult Ma6395764(CertPath P0, pc446fcff P1)
    {
        // str: "Certification path for issuer certificate of attribute certificate could not be validated."
        // str: "Support class could not be created."
        // str: "PKIX"
        // str: "c8fac08efbac2b64510349f94ee0ef68b3e78b02d6ded58f6ddacd16e10b"
        // call: pf82b098c.<init>
        // call: InvalidAlgorithmParameterException.getMessage
        // call: DecryptString.decryptString
        // call: CertPathValidator.getInstance
        // call: CertPathValidator.validate
        // call: Exception.<init>
        // type: pf82b098c
        // type: Exception
        return default!;
    }

    private static void Mcc898399(X509Certificate P0, pc446fcff P1)
    {
        // str: "Attribute certificate issuer public key cannot be used to validate digital signatures."
        // str: "Attribute certificate issuer is also a public key certificate issuer."
        // call: X509Certificate.getBasicConstraints
        // call: CertPathValidatorException.<init>
        // call: X509Certificate.getKeyUsage
        // type: CertPathValidatorException
    }

    private static void Mdc749e28(pd2e37f48 P0, CertPath P1, CertPath P2, pc446fcff P3, HashSet<object> P4)
    {
        // str: "Attribute certificate contains unsupported critical extensions: "
        // str: "Target information extension could not be read."
        // call: StringBuilder.toString
        // call: pca884272.check
        // call: StringBuilder.append
        // call: HashSet<object>.iterator
        // call: StringBuilder.<init>
        // call: IEnumerator<object>.hasNext
        // call: pd2e37f48.getCriticalExtensionOIDs
        // call: CertPathValidatorException.<init>
        // call: pf82b098c.<init>
        // call: HashSet<object>.remove
        // call: IEnumerator<object>.next
        // call: p4640f1a7.mb74a4d22
        // call: pbe98f7e7.m8bab0102
        // call: HashSet<object>.contains
        // call: HashSet<object>.isEmpty
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p594caefa.f4095b206
        // type: pf82b098c
        // type: CertPathValidatorException
        // type: StringBuilder
    }

    private static CertPath Mf4525699(pd2e37f48 P0, pc446fcff P1)
    {
        // str: "Certification path for public key certificate of attribute certificate could not be build."
        // str: "Unable to encode X500 principal."
        // str: "Support class could not be created."
        // str: "Public key certificate specified in base certificate ID for attribute certificate cannot be found."
        // str: "PKIX"
        // str: "df842961e4615c89397b948edacca83fde087b5e7cd924ea5c42ce73f6b4"
        // str: "Public key certificate specified in entity name for attribute certificate cannot be found."
        // str: "Public key certificate for attribute certificate cannot be searched."
        // call: pf82b098c.<init>
        // call: p27cbb5a8.setCertificate
        // call: pd2e37f48.getHolder
        // call: CertPathValidatorException.<init>
        // call: HashSet<object>.<init>
        // call: HashSet<object>.iterator
        // call: pc446fcff$p2bd4a59b.<init>
        // call: p8ac6972f.getEntityNames
        // call: Exception.<init>
        // call: X500Principal.getEncoded
        // call: p27cbb5a8.setIssuer
        // call: p1f30b1ff$p2bd4a59b.<init>
        // call: p1f30b1ff$p2bd4a59b.build
        // call: pc446fcff.getCertStores
        // call: p4640f1a7.m182c0efb
        // call: p8ac6972f.getIssuer
        // call: X509CertSelector.setSerialNumber
        // call: HashSet<object>.isEmpty
        // call: p8ac6972f.getSerialNumber
        // call: InvalidAlgorithmParameterException.getMessage
        // type: pf82b098c
        // type: p27cbb5a8
        // type: p1f30b1ff$p2bd4a59b
        // type: Exception
        // type: pc446fcff$p2bd4a59b
        // type: paad5c124$p2bd4a59b
        // type: X509CertSelector
        // type: HashSet<object>
        // type: CertPathValidatorException
        return default!;
    }

}
