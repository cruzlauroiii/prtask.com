namespace WillowMaze.Wasm.Decompiled;

public class P4640f1a7
{
    private static string F0b308c8b;
    private static string F137047d3;
    private static string F184e2f9e;
    private static string F19fbd28e;
    private static string F20458968;
    private static string F217dec67;
    private static int F23f6f4e3;
    private static string F25dd0a62;
    private static int F27f74b49;
    private static string F2c97953d;
    private static string F34c451a4;
    private static string[] F36f63bc5;
    private static string[] F3cec2e05;
    private static string F42d78d65;
    private static string F4435a5c2;
    private static string F45a9282c;
    private static string F4ab6b57a;
    private static string F4da61e6b;
    private static string F5596ff53;
    private static string F5b9e3e48;
    private static string F6277bd1b;
    private static string F63571c7a;
    private static string[] F661a0959;
    private static string F6afdf6ae;
    private static string F6f36f433;
    private static string F717ac3e4;
    private static string F71c0bc20;
    private static string[] F7363201e;
    private static string F7748635f;
    private static string F775cb6ec;
    private static string F7b763b64;
    private static string F7c764dc4;
    private static string F7e4056ed;
    private static string F7f39d68f;
    private static string F95d20985;
    private static string F98932083;
    private static string Fab008d1b;
    private static string Fb28beff2;
    private static string Fb683e610;
    private static string Fb8ec8409;
    private static string Fbd4a20aa;
    private static string Fbea8c8a1;
    private static string Fc19818c2;
    private static string Fc49f3547;
    private static string Fc5e0227b;
    private static string Fc64d18c3;
    private static string Fcc5ced68;
    private static string Fd15aa1c7;
    private static string Fd3f84597;
    private static string Fd82d1932;
    private static int Fd990771b;
    private static string Fda6b6536;
    private static string Fdbd11eec;
    private static int Fe08dd63c;
    private static string Fe0982184;
    private static string Fe8f40279;
    private static int Fe8fae90b;
    private static int Feebddf45;
    private static string Ff5878814;
    private static string Ffc82d967;
    private static string Ffd0f91e5;

    private static DateTime M13945842(PKIXParameters P0, DateTime P1)
    {
        // call: PKIXParameters.getDate
        return default!;
    }

    private static ICollection<object> M182c0efb(p1f30b1ff P0, List<object> P1)
    {
        // str: "Problem while picking certificates from certificate store."
        // str: "Problem while picking certificates from X.509 store."
        // call: pfdb0c388.getMatches
        // call: HashSet<object>.addAll
        // call: List<object>.iterator
        // call: p352d4243.<init>
        // call: p1f30b1ff.md72b2fc7
        // call: HashSet<object>.<init>
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // type: p352d4243
        // type: HashSet<object>
        return default!;
    }

    private static ICollection<object> M182c0efb(p27cbb5a8 P0, List<object> P1)
    {
        // str: "Problem while extracting certificates from X.509 store."
        // str: "Problem while picking certificates from X.509 store."
        // str: "Problem while picking certificates from certificate store."
        // str: "Unknown object found in certificate store."
        // call: pc1bfd7d6.<init>
        // call: List<object>.iterator
        // call: HashSet<object>.<init>
        // call: IEnumerator<object>.hasNext
        // call: p352d4243.<init>
        // call: pfdb0c388.getMatches
        // call: ICollection<object>.iterator
        // call: IEnumerator<object>.next
        // call: pec546d1c.getEncoded
        // call: MemoryStream.<init>
        // call: pc1bfd7d6.engineGenerateCertificate
        // call: HashSet<object>.add
        // call: CertStore.getCertificates
        // call: HashSet<object>.addAll
        // type: p352d4243
        // type: HashSet<object>
        // type: MemoryStream
        // type: pc1bfd7d6
        return default!;
    }

    private static ICollection<object> M182c0efb(p4329c72d P0, List<object> P1)
    {
        // str: "Problem while picking certificates from X.509 store."
        // call: p352d4243.<init>
        // call: IEnumerator<object>.next
        // call: List<object>.iterator
        // call: p1502c2ba.getMatches
        // call: HashSet<object>.addAll
        // call: HashSet<object>.<init>
        // call: IEnumerator<object>.hasNext
        // type: HashSet<object>
        // type: p352d4243
        return default!;
    }

    private static void M5159139f(DateTime P0, X509CRL P1, object P2, pb82bf363 P3)
    {
        // str: "Failed check for indirect CRL."
        // str: "Reason code CRL entry extension could not be decoded."
        // call: X509CRLEntry.hasExtensions
        // call: X509CRL.getRevokedCertificate
        // call: p352d4243.<init>
        // call: p4f02e7ce.intValueExact
        // call: p4640f1a7.me037eb7c
        // call: X500Principal.equals
        // call: X509CRLEntry.getCertificateIssuer
        // call: p364bf33a.getId
        // call: p4640f1a7.mb74a4d22
        // call: p4f02e7ce.m8bab0102
        // call: pb82bf363.setRevocationDate
        // call: p4640f1a7.m8b725164
        // call: X509CRLEntry.getRevocationDate
        // call: p4640f1a7.m94cfb252
        // call: pb82bf363.setCertStatus
        // call: p4640f1a7.ma1dcd3d9
        // call: DateTime.getTime
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf801238f.f61cea794
        // type: p352d4243
    }

    private static void M527f6fee(int P0, List<object>[] P1, string P2, Dictionary<string, object> P3, X509Certificate P4)
    {
        // str: "Policy qualifier info set could not be built."
        // str: "Policy information cannot be decoded."
        // str: "Certificate policies cannot be decoded."
        // str: "d59bb4012d56c8efb8bd7c175cf401063af77700c7fe513a63d98ceb39cfc530d693686245cca2"
        // call: X509Certificate.getCriticalExtensionOIDs
        // call: List<object>.iterator
        // call: p28edb599.getPolicyIdentifier
        // call: p331d8902.getValidPolicy
        // call: p364bf33a.getId
        // call: p352d4243.<init>
        // call: p28edb599.getPolicyQualifiers
        // call: p4640f1a7.ma76fc2b3
        // call: DecryptString.decryptString
        // call: string.equals
        // call: p331d8902.<init>
        // call: p331d8902.setExpectedPolicies
        // call: List<object>.add
        // call: Dictionary<string, object>.get
        // call: IEnumerator<object>.next
        // call: pf82b098c.<init>
        // call: p80f8c729.getObjects
        // call: p331d8902.getParent
        // call: Enumeration.hasMoreElements
        // call: HashSet<object>.contains
        // field: p5a445d71.p9f931cf3.pdacfecb5.p4640f1a7.f5b9e3e48
        // type: pf82b098c
        // type: p352d4243
        // type: p331d8902
        // type: List<object>
    }

    private static p234a7530 M53fd55a2(PublicKey P0)
    {
        // str: "Subject public key cannot be decoded."
        // call: pf82b098c.<init>
        // call: PublicKey.getEncoded
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: p3cdccfc9.m8bab0102
        // call: p3cdccfc9.getAlgorithmId
        // type: pd1c2953c
        // type: pf82b098c
        return default!;
    }

    private static p331d8902 M57c24a75(p331d8902 P0, List<object>[] P1, p331d8902 P2)
    {
        // call: List<object>.<init>
        // call: p4640f1a7.mdc9dd1de
        // call: p331d8902.removeChild
        // call: p331d8902.getParent
        // type: List<object>
        return default!;
    }

    private static bool M5d05f998(X509Certificate P0)
    {
        // call: X509Certificate.getIssuerDN
        // call: X509Certificate.getSubjectDN
        // call: object.equals
        return false;
    }

    private static X500Principal M7538fd40(X509Certificate P0)
    {
        // call: X509Certificate.getSubjectX500Principal
        return default!;
    }

    private static p301c7ed4 M7bc9c2ce(string P0, byte[] P1)
    {
        // str: "exception processing extension "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: p11b04310.getOctets
        // call: p352d4243.<init>
        // call: StringBuilder.toString
        // type: p352d4243
        // type: StringBuilder
        // type: pd1c2953c
        return default!;
    }

    private static bool M81007270(int P0, List<object>[] P1, p364bf33a P2, HashSet<object> P3)
    {
        // call: p364bf33a.getId
        // call: List<object>.<init>
        // call: p331d8902.getExpectedPolicies
        // call: p331d8902.<init>
        // call: HashSet<object>.add
        // call: HashSet<object>.contains
        // call: p331d8902.addChild
        // call: List<object>.add
        // call: List<object>.get
        // call: HashSet<object>.<init>
        // call: List<object>.size
        // type: p331d8902
        // type: List<object>
        // type: HashSet<object>
        return false;
    }

    private static X500Principal M8b725164(X509CRL P0)
    {
        // call: X509CRL.getIssuerX500Principal
        return default!;
    }

    private static p331d8902 M8e44d802(int P0, List<object>[] P1, string P2, p331d8902 P3)
    {
        // call: List<object>.get
        // call: p331d8902.removeChild
        // call: p331d8902.getParent
        // call: p331d8902.getValidPolicy
        // call: string.equals
        // call: IEnumerator<object>.hasNext
        // call: List<object>.size
        // call: p331d8902.hasChildren
        // call: IEnumerator<object>.remove
        // call: List<object>.iterator
        // call: p4640f1a7.m57c24a75
        // call: IEnumerator<object>.next
        return default!;
    }

    private static System.Numerics.BigInteger M94cfb252(object P0)
    {
        // call: X509Certificate.getSerialNumber
        // call: pd2e37f48.getSerialNumber
        return default!;
    }

    private static void M968c73de(int P0, List<object>[] P1, p364bf33a P2, HashSet<object> P3)
    {
        // str: "0b911c9e6e659fc220fcaf5df54853b4f5739fb8096329ffdcfdabafee0117762a0a6c060a0b7a"
        // call: p364bf33a.getId
        // call: List<object>.size
        // call: p331d8902.addChild
        // call: List<object>.add
        // call: string.equals
        // call: p331d8902.getValidPolicy
        // call: HashSet<object>.add
        // call: List<object>.get
        // call: HashSet<object>.<init>
        // call: List<object>.<init>
        // call: p331d8902.<init>
        // call: DecryptString.decryptString
        // type: HashSet<object>
        // type: p331d8902
        // type: List<object>
    }

    private static bool M99772425(HashSet<object> P0)
    {
        // str: "40d6b22563d6d17e9faefa34986395f4c1e4e3f368ab46938ca978f855401979b185d4f2c19bb8"
        // call: HashSet<object>.isEmpty
        // call: DecryptString.decryptString
        // call: HashSet<object>.contains
        return false;
    }

    private static bool Ma1dcd3d9(X509CRL P0)
    {
        // str: "Exception reading IssuingDistributionPoint: "
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p364bf33a.getId
        // call: X509CRL.getExtensionValue
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: p781d85ab.m8bab0102
        // call: p781d85ab.isIndirectCRL
        // call: CRLException.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // type: StringBuilder
        // type: CRLException
        return false;
    }

    private static HashSet<object> Ma76fc2b3(p80f8c729 P0)
    {
        // str: "Policy qualifier info cannot be decoded."
        // call: MemoryStream.<init>
        // call: HashSet<object>.<init>
        // call: p80f8c729.getObjects
        // call: Enumeration.nextElement
        // call: p8bf0ff80.writeObject
        // call: MemoryStream.toByteArray
        // call: PolicyQualifierInfo.<init>
        // call: HashSet<object>.add
        // call: p8bf0ff80.m76ea0beb
        // call: MemoryStream.reset
        // call: pf82b098c.<init>
        // call: Enumeration.hasMoreElements
        // type: pf82b098c
        // type: MemoryStream
        // type: PolicyQualifierInfo
        // type: HashSet<object>
        return default!;
    }

    private static p301c7ed4 Mb74a4d22(X509Extension P0, string P1)
    {
        // call: p4640f1a7.m7bc9c2ce
        // call: X509Extension.getExtensionValue
        return default!;
    }

    private static void Mdc9dd1de(List<object>[] P0, p331d8902 P1)
    {
        // call: List<object>.remove
        // call: p4640f1a7.mdc9dd1de
        // call: p331d8902.getDepth
        // call: IEnumerator<object>.next
        // call: p331d8902.hasChildren
        // call: IEnumerator<object>.hasNext
        // call: p331d8902.getChildren
    }

    private static X500Principal Me037eb7c(object P0)
    {
        // call: pd2e37f48.getIssuer
        // call: X509Certificate.getIssuerX500Principal
        // call: p73d7b518.getPrincipals
        return default!;
    }

    private static PublicKey Me838ebc2(List<object> P0, int P1)
    {
        // str: "DSA parameters cannot be inherited from previous certificate."
        // str: "DSA"
        // str: "f76d8f55a494165791dea9da169bf4741c82104fd82609dd9b0030023f54"
        // call: DSAParams.getG
        // call: DSAPublicKey.getParams
        // call: List<object>.get
        // call: Exception.getMessage
        // call: Certificate.getPublicKey
        // call: DSAParams.getP
        // call: List<object>.size
        // call: CertPathValidatorException.<init>
        // call: X509Certificate.getPublicKey
        // call: DSAPublicKey.getY
        // call: DSAParams.getQ
        // call: Exception.<init>
        // call: DSAPublicKeySpec.<init>
        // call: DecryptString.decryptString
        // call: KeyFactory.getInstance
        // call: KeyFactory.generatePublic
        // type: CertPathValidatorException
        // type: DSAPublicKeySpec
        // type: Exception
        return default!;
    }

    private static void Mfdeaf35e(X509Certificate P0, PublicKey P1, string P2)
    {
        // call: X509Certificate.verify
    }

}
