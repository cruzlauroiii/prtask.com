namespace WillowMaze.Wasm.Decompiled;

public class P4640f1a7
{
    private static string F023e3916;
    private static string F046b6d7e;
    private static string F05ee0753;
    private static string F0b308c8b;
    private static string F0c79369d;
    private static string F12ca886d;
    private static string F13c37e70;
    private static string F20458968;
    private static int F23f6f4e3;
    private static string F24af5f3c;
    private static int F2fe3ddd7;
    private static string F30ea160b;
    private static string F416653e4;
    private static string F4435a5c2;
    private static string F44a7acc7;
    private static string F48487fac;
    private static string F49c61ee7;
    private static string F4e8af47b;
    private static string F54a425b6;
    private static string F5596ff53;
    private static string F58a1e2ee;
    private static string F5b9e3e48;
    private static string F5d1bc71f;
    private static string F63571c7a;
    private static string F64a96c2f;
    private static string[] F661a0959;
    private static string F6eac4389;
    private static string F70d5138c;
    private static string F7478b82d;
    private static string F81030500;
    private static string F855d0ff1;
    private static string F8617823f;
    private static string F876bdb92;
    private static string F8f91f4ac;
    private static string F909ec7b5;
    private static string[] F9230231f;
    private static string F92dc90f0;
    private static string F95d20985;
    private static int F9852b8a4;
    private static string Fa3ed151d;
    private static int Faad9ccef;
    private static string Fab4bf82f;
    private static string Fb8ec8409;
    private static string Fb8f64e24;
    private static string Fb9521d1e;
    private static string Fba2e2460;
    private static string[] Fbc4da2bb;
    private static string Fbd4a20aa;
    private static string Fbe6cef90;
    private static string Fcbff04b1;
    private static int Fccc52d7b;
    private static string[] Fd7ea182c;
    private static string Fd84d6509;
    private static string Fdbd11eec;
    private static string[] Fdc7356e9;
    private static int Fe08dd63c;
    private static string Fe0982184;
    private static int Fe5cb82fc;
    private static string Fe64f6495;
    private static string Fecdf2fe5;
    private static string Ff5878814;
    private static string Fffdbbbdf;

    private static DateTime M13945842(pc446fcff P0, DateTime P1)
    {
        // call: pc446fcff.getValidityDate
        return default!;
    }

    private static void M16e271f8(pcb5fa6f0 P0, HashSet<object> P1, object P2)
    {
        // str: "\""
        // str: "No CRLs found for issuer \""
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p4a23457a.<init>
        // call: StringBuilder.toString
        // call: p73d7b518.getPrincipals
        // call: pcb5fa6f0.getIndex
        // call: HashSet<object>.isEmpty
        // call: pa4116702.toString
        // call: pcb5fa6f0.getCertPath
        // call: pb854d51e.m8b725164
        // call: pd2e37f48.getIssuer
        // field: p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p3647bc84.f76425f17
        // type: p4a23457a
        // type: StringBuilder
    }

    private static void M182c0efb(HashSet<object> P0, p1f30b1ff P1, List<object> P2)
    {
        // str: "Problem while picking certificates from X.509 store."
        // str: "Problem while picking certificates from certificate store."
        // call: p352d4243.<init>
        // call: pfdb0c388.getMatches
        // call: HashSet<object>.addAll
        // call: p1f30b1ff.md72b2fc7
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // type: p352d4243
    }

    private static void M2a683bbe(p0cfd224b P0, ICollection<object> P1, X509CRLSelector P2)
    {
        // str: "CRL issuer information from distribution point cannot be decoded."
        // str: "CRL issuer is omitted from distribution point but no distributionPoint field present."
        // str: "Cannot decode CRL issuer information."
        // call: pf17d2ecd.getName
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: p694426e7.m8bab0102
        // call: List<object>.add
        // call: p0cfd224b.getCRLIssuer
        // call: p0cfd224b.getDistributionPoint
        // call: p352d4243.<init>
        // call: IEnumerator<object>.next
        // call: p694426e7.getEncoded
        // call: X509CRLSelector.addIssuerName
        // call: IEnumerator<object>.hasNext
        // call: List<object>.iterator
        // call: pf17d2ecd.getTagNo
        // call: ICollection<object>.iterator
        // call: List<object>.<init>
        // call: pfb202cf8.getNames
        // type: p352d4243
        // type: List<object>
    }

    private static void M5159139f(DateTime P0, X509CRL P1, object P2, pb82bf363 P3)
    {
        // str: "Reason code CRL entry extension could not be decoded."
        // str: "CRL entry has unsupported critical extensions."
        // str: "Failed check for indirect CRL."
        // call: pb82bf363.setCertStatus
        // call: p694426e7.equals
        // call: p352d4243.<init>
        // call: pb854d51e.me037eb7c
        // call: pe307c42c.ma1dcd3d9
        // call: X509CRLEntry.getRevocationDate
        // call: pb854d51e.m8b725164
        // call: DateTime.getTime
        // call: p4f02e7ce.intValueExact
        // call: p4640f1a7.m94cfb252
        // call: pb82bf363.setRevocationDate
        // call: X509CRL.getRevokedCertificate
        // call: p364bf33a.getId
        // call: p4640f1a7.mb74a4d22
        // call: p4f02e7ce.m8bab0102
        // call: X509CRLEntry.hasUnsupportedCriticalExtension
        // call: X509CRLEntry.hasExtensions
        // call: X509CRLEntry.getCertificateIssuer
        // call: pb854d51e.mc1e8b1fb
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f61cea794
        // type: p352d4243
    }

    private static void M527f6fee(int P0, List<object>[] P1, string P2, Dictionary<string, object> P3, X509Certificate P4)
    {
        // str: "Certificate policies cannot be decoded."
        // str: "bebac82453a934981485bdee5345b0dd4d43f5fb8ef9d3134e59802b9efcd0753e7bac6e2a899b"
        // str: "Policy information cannot be decoded."
        // str: "Policy qualifier info set could not be built."
        // call: Enumeration.hasMoreElements
        // call: string.equals
        // call: p364bf33a.getId
        // call: p28edb599.getPolicyQualifiers
        // call: p4640f1a7.ma76fc2b3
        // call: Dictionary<string, object>.get
        // call: List<object>.iterator
        // call: p352d4243.<init>
        // call: p28edb599.getPolicyIdentifier
        // call: HashSet<object>.contains
        // call: p331d8902.getParent
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: X509Certificate.getCriticalExtensionOIDs
        // call: Enumeration.nextElement
        // call: p28edb599.m8bab0102
        // call: List<object>.add
        // call: p4640f1a7.mb74a4d22
        // call: pb840b7ef.getInstance
        // call: p331d8902.addChild
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.f5b9e3e48
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902.fd10779ce
        // type: p352d4243
        // type: p331d8902
        // type: List<object>
        // type: pf82b098c
    }

    private static p234a7530 M53fd55a2(PublicKey P0)
    {
        // str: "Subject public key cannot be decoded."
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p3cdccfc9.getAlgorithm
        // call: pf82b098c.<init>
        // type: pf82b098c
        return default!;
    }

    private static p331d8902 M57c24a75(p331d8902 P0, List<object>[] P1, p331d8902 P2)
    {
        // call: p4640f1a7.mdc9dd1de
        // call: p331d8902.removeChild
        // call: List<object>.<init>
        // call: p331d8902.getParent
        // type: List<object>
        return default!;
    }

    private static bool M58475441(X509CRL P0)
    {
        // call: HashSet<object>.contains
        // call: X509CRL.getCriticalExtensionOIDs
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968
        return false;
    }

    private static bool M5d05f998(X509Certificate P0)
    {
        // call: object.equals
        // call: X509Certificate.getSubjectDN
        // call: X509Certificate.getIssuerDN
        return false;
    }

    private static ICollection<object> M6daef670(X509Certificate P0, List<object> P1, List<object> P2)
    {
        // str: "Issuer certificate cannot be searched."
        // str: "Subject criteria for certificate selector to find issuer certificate could not be set."
        // call: p1f30b1ff$p2bd4a59b.build
        // call: p352d4243.<init>
        // call: p1f30b1ff$p2bd4a59b.<init>
        // call: HashSet<object>.<init>
        // call: p4640f1a7.m182c0efb
        // call: X509CertSelector.<init>
        // call: pb854d51e.m8b725164
        // call: p694426e7.getEncoded
        // call: X509CertSelector.setSubject
        // call: X509Certificate.getExtensionValue
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: p9746cd54.m8bab0102
        // call: p9746cd54.getKeyIdentifier
        // call: p6f0e511c.<init>
        // call: p6f0e511c.getEncoded
        // call: X509CertSelector.setSubjectKeyIdentifier
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.f30ea160b
        // type: HashSet<object>
        // type: X509CertSelector
        // type: p352d4243
        // type: p1f30b1ff$p2bd4a59b
        // type: p6f0e511c
        return default!;
    }

    private static p301c7ed4 M7bc9c2ce(string P0, byte[] P1)
    {
        // str: "exception processing extension "
        // call: p352d4243.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: p301c7ed4.m89e75c46
        // type: p352d4243
        // type: StringBuilder
        return default!;
    }

    private static bool M81007270(int P0, List<object>[] P1, p364bf33a P2, HashSet<object> P3)
    {
        // call: p364bf33a.getId
        // call: HashSet<object>.contains
        // call: HashSet<object>.add
        // call: p331d8902.addChild
        // call: HashSet<object>.<init>
        // call: List<object>.<init>
        // call: List<object>.add
        // call: List<object>.size
        // call: p331d8902.getExpectedPolicies
        // call: p331d8902.<init>
        // call: List<object>.get
        // type: HashSet<object>
        // type: p331d8902
        // type: List<object>
        return false;
    }

    private static TrustAnchor M810489a3(X509Certificate P0, HashSet<object> P1)
    {
        // call: p4640f1a7.m810489a3
        return default!;
    }

    private static TrustAnchor M810489a3(X509Certificate P0, HashSet<object> P1, string P2)
    {
        // str: "TrustAnchor found but certificate validation failed."
        // call: X500Principal.getEncoded
        // call: X509Certificate.getPublicKey
        // call: TrustAnchor.getTrustedCert
        // call: TrustAnchor.getCAPublicKey
        // call: p352d4243.<init>
        // call: HashSet<object>.iterator
        // call: X509CertSelector.setSubject
        // call: X509Certificate.getIssuerX500Principal
        // call: X509CertSelector.match
        // call: p694426e7.m8bab0102
        // call: TrustAnchor.getCA
        // call: p694426e7.equals
        // call: IEnumerator<object>.hasNext
        // call: p4640f1a7.mfdeaf35e
        // call: TrustAnchor.getCAName
        // call: IEnumerator<object>.next
        // call: X509CertSelector.<init>
        // type: p352d4243
        // type: X509CertSelector
        return default!;
    }

    private static p331d8902 M8e44d802(int P0, List<object>[] P1, string P2, p331d8902 P3)
    {
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.remove
        // call: List<object>.size
        // call: IEnumerator<object>.hasNext
        // call: p4640f1a7.m57c24a75
        // call: List<object>.iterator
        // call: List<object>.get
        // call: p331d8902.hasChildren
        // call: p331d8902.removeChild
        // call: p331d8902.getParent
        // call: p331d8902.getValidPolicy
        // call: string.equals
        return default!;
    }

    private static System.Numerics.BigInteger M94cfb252(object P0)
    {
        // call: X509Certificate.getSerialNumber
        return default!;
    }

    private static void M968c73de(int P0, List<object>[] P1, p364bf33a P2, HashSet<object> P3)
    {
        // str: "adbaedc620aa4e1437d3d818805f956265acf5c4bb7e2d851da062fc933ead9deed89015e3eca8"
        // call: p331d8902.getValidPolicy
        // call: List<object>.add
        // call: p364bf33a.getId
        // call: List<object>.get
        // call: DecryptString.decryptString
        // call: List<object>.size
        // call: p331d8902.addChild
        // call: p331d8902.<init>
        // call: HashSet<object>.add
        // call: List<object>.<init>
        // call: HashSet<object>.<init>
        // call: string.equals
        // type: HashSet<object>
        // type: p331d8902
        // type: List<object>
    }

    private static bool M99772425(HashSet<object> P0)
    {
        // str: "7e8a03dc5ee4ed41ec6dfe0dec1023a4fbcffbdc1d52452fae17a6d2d7d097280860eba233642d"
        // call: HashSet<object>.contains
        // call: HashSet<object>.isEmpty
        // call: DecryptString.decryptString
        return false;
    }

    private static HashSet<object> Ma76fc2b3(p80f8c729 P0)
    {
        // str: "Policy qualifier info cannot be decoded."
        // call: Enumeration.nextElement
        // call: p8bf0ff80.writeObject
        // call: MemoryStream.toByteArray
        // call: PolicyQualifierInfo.<init>
        // call: HashSet<object>.add
        // call: Enumeration.hasMoreElements
        // call: MemoryStream.reset
        // call: p80f8c729.getObjects
        // call: MemoryStream.<init>
        // call: HashSet<object>.<init>
        // call: p8bf0ff80.m76ea0beb
        // call: pf82b098c.<init>
        // type: MemoryStream
        // type: PolicyQualifierInfo
        // type: pf82b098c
        // type: HashSet<object>
        return default!;
    }

    private static DateTime Mb09cfffb(DateTime P0, int P1, CertPath P2, int P3)
    {
        // str: "Date from date of cert gen extension could not be parsed."
        // str: "Date of cert gen extension could not be read."
        // call: CertPath.getCertificates
        // call: List<object>.get
        // call: p364bf33a.getId
        // call: X509Certificate.getExtensionValue
        // call: p301c7ed4.m89e75c46
        // call: pb907b377.m8bab0102
        // call: p352d4243.<init>
        // call: X509Certificate.getNotBefore
        // call: pb907b377.getDate
        // field: p5a445d71.p9f931cf3.pd1efad72.pca323100.p3c1fa01c.pfae77fba.fb7dd122c
        // type: p352d4243
        return default!;
    }

    private static HashSet<object> Mb4ec9b42(pcb5fa6f0 P0, p0cfd224b P1, object P2, pc446fcff P3, DateTime P4)
    {
        // str: "Could not get issuer information from distribution point."
        // call: X509CRLSelector.<init>
        // call: HashSet<object>.<init>
        // call: pb854d51e.me037eb7c
        // call: HashSet<object>.add
        // call: p4640f1a7.m2a683bbe
        // call: p9bcd0c1c$p2bd4a59b.<init>
        // call: X509CRLSelector.setCertificateChecking
        // call: p65d0f559.mafefaea2
        // call: p9bcd0c1c$p2bd4a59b.build
        // call: p9bcd0c1c$p2bd4a59b.setCompleteCRLEnabled
        // call: pc446fcff.getCRLStores
        // call: pc446fcff.getCertStores
        // call: p352d4243.<init>
        // call: p4640f1a7.m16e271f8
        // type: HashSet<object>
        // type: p352d4243
        // type: p9bcd0c1c$p2bd4a59b
        // type: X509CRLSelector
        return default!;
    }

    private static p301c7ed4 Mb74a4d22(X509Extension P0, string P1)
    {
        // call: p4640f1a7.m7bc9c2ce
        // call: X509Extension.getExtensionValue
        return default!;
    }

    private static HashSet<object> Mc73cef58(DateTime P0, X509CRL P1, List<object> P2, List<object> P3, pb3b7fb02 P4)
    {
        // str: "CRL number extension could not be extracted from CRL."
        // str: "X.509"
        // str: "Issuing distribution point extension value could not be read."
        // str: "org.bouncycastle.x509.enableCRLDP"
        // str: "cannot create certificate factory: "
        // str: "Cannot extract issuer from CRL."
        // call: p4640f1a7.m58475441
        // call: p9bcd0c1c$p2bd4a59b.build
        // call: p9bcd0c1c$p2bd4a59b.setIssuingDistributionPointEnabled
        // call: HashSet<object>.isEmpty
        // call: p9fc2d28c.mf2b2f421
        // call: IEnumerator<object>.hasNext
        // call: X509CRL.getExtensionValue
        // call: p352d4243.<init>
        // call: pfb202cf8.m8bab0102
        // call: pe6e3e799.m8bab0102
        // call: pf17d2ecd.getTagNo
        // call: pb3b7fb02.createCertificateFactory
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: System.Numerics.BigInteger.add
        // call: HashSet<object>.<init>
        // call: p9bcd0c1c$p2bd4a59b.setMaxBaseCRLNumber
        // call: p9bcd0c1c$p2bd4a59b.<init>
        // call: p0cfd224b.getDistributionPoint
        // call: X509CRLSelector.setMinCRLNumber
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.f5596ff53
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4640f1a7.f95d20985
        // field: java.util.Collections.EMPTY_LIST
        // type: p9bcd0c1c$p2bd4a59b
        // type: HashSet<object>
        // type: StringBuilder
        // type: p352d4243
        // type: X509CRLSelector
        // type: Uri
        return default!;
    }

    private static bool Mc7b165ab(X509Certificate P0, HashSet<object> P1, string P2)
    {
        // call: p4640f1a7.m810489a3
        return false;
    }

    private static void Mdc9dd1de(List<object>[] P0, p331d8902 P1)
    {
        // call: p4640f1a7.mdc9dd1de
        // call: p331d8902.getChildren
        // call: p331d8902.hasChildren
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: List<object>.remove
        // call: p331d8902.getDepth
    }

    private static ICollection<object> Mdeb6b9c1(paad5c124 P0)
    {
        // str: "No certificate found matching targetConstraints."
        // str: "Error finding target certificate."
        // call: HashSet<object>.isEmpty
        // call: p0c49d6f2.<init>
        // call: CertPathBuilderException.<init>
        // call: pc446fcff.getTargetConstraints
        // call: HashSet<object>.<init>
        // call: pc446fcff.getCertificateStores
        // call: p4640f1a7.m182c0efb
        // call: pc446fcff.getCertStores
        // call: p1f30b1ff.getCertificate
        // call: Collections.singleton
        // call: paad5c124.getBaseParameters
        // type: CertPathBuilderException
        // type: HashSet<object>
        // type: p0c49d6f2
        return default!;
    }

    private static List<object> Me71d5b40(pe6e3e799 P0, Dictionary<string, object> P1, DateTime P2, pb3b7fb02 P3)
    {
        // str: "Distribution points could not be read."
        // str: "X.509"
        // str: "org.bouncycastle.x509.enableCRLDP"
        // str: "cannot create certificate factory: "
        // call: p352d4243.<init>
        // call: pf17d2ecd.getName
        // call: p2d24d5da.getString
        // call: Uri.<init>
        // call: pdf789334.m5953b2a2
        // call: List<object>.add
        // call: p9fc2d28c.mf2b2f421
        // call: List<object>.<init>
        // call: pf17d2ecd.getTagNo
        // call: StringBuilder.append
        // call: pfb202cf8.getNames
        // call: List<object>.isEmpty
        // call: p0cfd224b.getDistributionPoint
        // call: pafc6206d.getType
        // call: pfb202cf8.m8bab0102
        // call: Exception.getMessage
        // call: StringBuilder.toString
        // call: pe6e3e799.getDistributionPoints
        // call: pafc6206d.getName
        // call: pb3b7fb02.createCertificateFactory
        // field: java.util.Collections.EMPTY_LIST
        // type: List<object>
        // type: StringBuilder
        // type: Uri
        // type: p352d4243
        return default!;
    }

    private static PublicKey Me838ebc2(List<object> P0, int P1, pb3b7fb02 P2)
    {
        // str: "DSA parameters cannot be inherited from previous certificate."
        // str: "DSA"
        // call: DSAPublicKey.getParams
        // call: Exception.getMessage
        // call: Exception.<init>
        // call: DSAParams.getG
        // call: CertPathValidatorException.<init>
        // call: List<object>.get
        // call: DSAParams.getP
        // call: DSAPublicKey.getY
        // call: X509Certificate.getPublicKey
        // call: DSAPublicKeySpec.<init>
        // call: pb3b7fb02.createKeyFactory
        // call: KeyFactory.generatePublic
        // call: List<object>.size
        // call: DSAParams.getQ
        // call: Certificate.getPublicKey
        // type: CertPathValidatorException
        // type: Exception
        // type: DSAPublicKeySpec
        return default!;
    }

    private static List<object> Mf4dbe0a3(byte[] P0, Dictionary<string, object> P1)
    {
        // call: Dictionary<string, object>.get
        // call: p11b04310.m8bab0102
        // call: pfb202cf8.m8bab0102
        // call: List<object>.add
        // call: pfb202cf8.getNames
        // call: p11b04310.getOctets
        // call: List<object>.<init>
        // field: java.util.Collections.EMPTY_LIST
        // type: List<object>
        return default!;
    }

    private static void Mfdeaf35e(X509Certificate P0, PublicKey P1, string P2)
    {
        // call: X509Certificate.verify
    }

}
