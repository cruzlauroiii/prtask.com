namespace WillowMaze.Wasm.Decompiled;

public class P4da36ec9
{
    public static string F0932978b;
    public static string F0b308c8b;
    public static string F0b7d2c83;
    public static string F0c79369d;
    public static string F18a5f54d;
    public static string F20458968;
    public static string F212fbeb9;
    private static int F23f6f4e3;
    public static string F25c2ddb4;
    private static string[] F2dea89fa;
    public static string F30ea160b;
    public static string F3e5e8132;
    private static Type F3f456e0a;
    public static string F435201a2;
    public static string F4435a5c2;
    public static string F46fe39e7;
    public static string F4c57a406;
    public static string F4f92417f;
    private static Type F5436b64e;
    public static string F5596ff53;
    public static string F58a1e2ee;
    public static string F5954120e;
    public static string F5b50b249;
    public static string F5b9e3e48;
    public static string F63571c7a;
    public static string F647b7bc8;
    private static string[] F661a0959;
    public static string F6676f978;
    public static string F6a7a9513;
    public static string F6c6df11d;
    public static string F70e912ce;
    public static string F71e9fba1;
    public static string F73465b05;
    public static string F737cc36a;
    public static string F819f70fe;
    public static string F8a3c809e;
    public static string F91448bd0;
    public static string F917c551e;
    private static string[] F9363fe0a;
    public static string F9453e8c5;
    public static string F95d20985;
    private static Type F97d5c647;
    private static Type F98a8229a;
    public static string F9982fa92;
    public static string Fa3bbaff5;
    private static int Fac32837d;
    public static string Fb8ec8409;
    public static string Fbd4a20aa;
    public static string Fc87e41db;
    public static string Fcb6bce2b;
    public static string Fdbd11eec;
    private static int Fe08dd63c;
    public static string Fe0982184;
    private static int Fe5d537c7;
    public static string Feea63701;
    public static string Fefcc542f;
    public static string Ff54bfc1d;
    public static string Ff5878814;
    private static Type Ff78e0469;

    private static int M00954b7e(CertPath P0, int P1, int P2)
    {
        // str: "Policy constraints could not be decoded."
        // str: "Policy constraints requireExplicitPolicy field could not be decoded."
        // call: p80f8c729.getObjects
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // call: Enumeration.hasMoreElements
        // call: pf82b098c.<init>
        // call: CertPath.getCertificates
        // call: Enumeration.nextElement
        // call: p582a4948.getTagNo
        // call: pf391b73d.m8bab0102
        // call: pf391b73d.intValueExact
        // call: List<object>.get
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184
        // type: pf82b098c
        return 0;
    }

    private static int M0eaf6a9d(CertPath P0, int P1, int P2)
    {
        // call: List<object>.get
        // call: p4640f1a7.m5d05f998
        // call: CertPath.getCertificates
        return 0;
    }

    private static void M120a84fc(pcb5fa6f0 P0, pc446fcff P1, DateTime P2, DateTime P3, X509Certificate P4, X509Certificate P5, PublicKey P6, List<object> P7, pb3b7fb02 P8)
    {
        // str: "yyyy-MM-dd HH:mm:ss Z"
        // str: "No additional CRL locations could be decoded from CRL distribution point extension."
        // str: "Issuer from certificate for CRL could not be reencoded."
        // str: "CRL distribution point extension could not be read."
        // str: "Certificate status could not be determined."
        // str: "Distribution points could not be read."
        // str: "UTC"
        // str: "No valid CRL found."
        // str: "Certificate revocation after "
        // str: ", reason: "
        // call: p40cdc0e2.isAllReasons
        // call: p352d4243.<init>
        // call: pb82bf363.getCertStatus
        // call: StringBuilder.append
        // call: p40cdc0e2.<init>
        // call: string.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pb854d51e.m8b725164
        // call: pf17d2ecd.<init>
        // call: pfb202cf8.<init>
        // call: pafc6206d.<init>
        // call: p0cfd224b.<init>
        // call: pc446fcff.clone
        // call: p4da36ec9.m2aca15ec
        // call: pb82bf363.setCertStatus
        // call: string.setTimeZone
        // call: pc446fcff$p2bd4a59b.<init>
        // call: pc446fcff.getNamedCRLStoreMap
        // call: p4640f1a7.me71d5b40
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f661a0959
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0c79369d
        // type: p40cdc0e2
        // type: pc446fcff$p2bd4a59b
        // type: StringBuilder
        // type: p352d4243
        // type: p0cfd224b
        // type: pafc6206d
        // type: pfb202cf8
        // type: pf17d2ecd
        // type: string
        // type: pb82bf363
    }

    private static void M13719d11(CertPath P0, int P1, p1dc02b40 P2, bool P3)
    {
        // str: "Subject alternative name extension could not be decoded."
        // str: "Subject alternative name contents could not be decoded."
        // str: "Subtree check for certificate subject alternative email failed."
        // str: "Subtree check for certificate subject alternative name failed."
        // str: "Exception extracting subject name when checking subtrees."
        // str: "Subtree check for certificate subject failed."
        // call: CertPathValidatorException.<init>
        // call: p2d24d5da.getString
        // call: p1dc02b40.checkPermitted
        // call: p1dc02b40.checkExcluded
        // call: CertPath.getCertificates
        // call: pb854d51e.m7538fd40
        // call: p80f8c729.m8bab0102
        // call: p1dc02b40.checkPermittedDN
        // call: p1dc02b40.checkExcludedDN
        // call: p4640f1a7.mb74a4d22
        // call: pfb202cf8.m8bab0102
        // call: p099ecf1e.getFirst
        // call: List<object>.get
        // call: List<object>.size
        // call: p4640f1a7.m5d05f998
        // call: p694426e7.getRDNs
        // call: pfeaff37e.getValue
        // call: pfb202cf8.getNames
        // call: p694426e7.m8bab0102
        // call: pf17d2ecd.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec
        // field: p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p413d4123.f1e674f0d
        // type: CertPathValidatorException
        // type: pf17d2ecd
    }

    private static void M2aca15ec(pcb5fa6f0 P0, p0cfd224b P1, pc446fcff P2, DateTime P3, DateTime P4, X509Certificate P5, X509Certificate P6, PublicKey P7, pb82bf363 P8, p40cdc0e2 P9, List<object> P10, pb3b7fb02 P11)
    {
        // str: "Validation time is in future."
        // str: "No valid CRL for current time found."
        // str: "CRL contains unsupported critical extensions."
        // str: "Delta CRL contains unsupported critical extension."
        // call: HashSet<object>.iterator
        // call: p40cdc0e2.isAllReasons
        // call: IEnumerator<object>.next
        // call: p4da36ec9.m77217a92
        // call: p40cdc0e2.hasNewReasons
        // call: DateTime.getTime
        // call: pb82bf363.getCertStatus
        // call: p4da36ec9.m54a97b2e
        // call: p4da36ec9.m3b17afbe
        // call: pc446fcff.isUseDeltasEnabled
        // call: pc446fcff.getCertStores
        // call: pc446fcff.getCRLStores
        // call: p352d4243.<init>
        // call: IEnumerator<object>.hasNext
        // call: p4640f1a7.mc73cef58
        // call: p4da36ec9.m6b5e2c6e
        // call: pc446fcff.getValidityModel
        // call: X509Certificate.getNotAfter
        // call: X509CRL.getThisUpdate
        // call: p4da36ec9.m39441a37
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        // type: p352d4243
        // type: HashSet<object>
    }

    private static void M39441a37(p0cfd224b P0, object P1, X509CRL P2)
    {
        // str: "CRL issuer information from distribution point cannot be decoded."
        // str: "Cannot find matching CRL issuer for certificate."
        // str: "Exception encoding CRL issuer: "
        // str: "Distribution point contains cRLIssuer field but CRL is not indirect."
        // str: "CRL issuer of CRL does not match CRL issuer of distribution point."
        // call: p352d4243.<init>
        // call: StringBuilder.append
        // call: pfb202cf8.getNames
        // call: pf17d2ecd.getName
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: pff43b8de.m2a3f81d2
        // call: p694426e7.equals
        // call: pb854d51e.me037eb7c
        // call: pb854d51e.m8b725164
        // call: p0cfd224b.getCRLIssuer
        // call: StringBuilder.toString
        // call: p4640f1a7.mb74a4d22
        // call: p781d85ab.m8bab0102
        // call: p781d85ab.isIndirectCRL
        // call: p694426e7.getEncoded
        // call: pf17d2ecd.getTagNo
        // call: StringBuilder.<init>
        // call: IOException.getMessage
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        // type: p352d4243
        // type: StringBuilder
    }

    private static PublicKey M3b17afbe(X509CRL P0, HashSet<object> P1)
    {
        // str: "Cannot verify CRL."
        // call: IEnumerator<object>.next
        // call: HashSet<object>.iterator
        // call: p352d4243.<init>
        // call: IEnumerator<object>.hasNext
        // call: X509CRL.verify
        // type: p352d4243
        return default!;
    }

    private static int M4a78792b(CertPath P0, int P1, int P2)
    {
        // str: "Policy constraints extension cannot be decoded."
        // str: "Policy constraints extension contents cannot be decoded."
        // call: pf82b098c.<init>
        // call: Enumeration.nextElement
        // call: p582a4948.m8bab0102
        // call: p582a4948.getTagNo
        // call: pf391b73d.m8bab0102
        // call: pf391b73d.intValueExact
        // call: CertPath.getCertificates
        // call: Enumeration.hasMoreElements
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // call: p80f8c729.getObjects
        // call: List<object>.get
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184
        // type: pf82b098c
        return 0;
    }

    private static void M4be90c32(CertPath P0, int P1)
    {
        // str: "Basic constraints extension cannot be decoded."
        // str: "Not a CA certificate"
        // str: "Intermediate certificate lacks BasicConstraints"
        // call: CertPath.getCertificates
        // call: CertPathValidatorException.<init>
        // call: p4640f1a7.mb74a4d22
        // call: p44f86c11.m8bab0102
        // call: p44f86c11.isCA
        // call: List<object>.get
        // call: pf82b098c.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a
        // type: CertPathValidatorException
        // type: pf82b098c
    }

    private static void M4f1678ca(DateTime P0, X509CRL P1, object P2, pb82bf363 P3)
    {
        // call: p4640f1a7.m5159139f
        // call: pb82bf363.getCertStatus
    }

    private static void M5250b2bb(CertPath P0, int P1, List<object> P2, HashSet<object> P3)
    {
        // str: "Additional certificate path checker failed."
        // str: "Certificate has unsupported critical extension: "
        // call: CertPathValidatorException.getMessage
        // call: CertPathValidatorException.<init>
        // call: CertPath.getCertificates
        // call: List<object>.iterator
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: pf82b098c.<init>
        // call: StringBuilder.toString
        // call: List<object>.get
        // call: HashSet<object>.isEmpty
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: PKIXCertPathChecker.check
        // type: pf82b098c
        // type: CertPathValidatorException
        // type: StringBuilder
    }

    private static HashSet<object> M54a97b2e(X509CRL P0, object P1, X509Certificate P2, PublicKey P3, pc446fcff P4, List<object> P5, pb3b7fb02 P6)
    {
        // str: "Issuer certificate for CRL cannot be searched."
        // str: "Public key of issuer certificate of CRL could not be retrieved."
        // str: "Cannot find a valid issuer certificate."
        // str: "Issuer certificate key usage extension does not permit CRL signing."
        // str: "CertPath for CRL signer failed to validate."
        // str: "Subject criteria for certificate selector to find issuer certificate for CRL could not be set."
        // call: p352d4243.<init>
        // call: List<object>.<init>
        // call: X509Certificate.getKeyUsage
        // call: List<object>.add
        // call: List<object>.size
        // call: HashSet<object>.<init>
        // call: pc446fcff.getCertificateStores
        // call: p4640f1a7.m182c0efb
        // call: pc446fcff.getCertStores
        // call: IEnumerator<object>.next
        // call: HashSet<object>.isEmpty
        // call: p1f30b1ff$p2bd4a59b.build
        // call: HashSet<object>.add
        // call: X509Certificate.equals
        // call: Exception.getMessage
        // call: List<object>.get
        // call: HashSet<object>.iterator
        // call: X509CertSelector.<init>
        // call: pb854d51e.m8b725164
        // call: p694426e7.getEncoded
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff78e0469
        // type: List<object>
        // type: p352d4243
        // type: HashSet<object>
        // type: p1f30b1ff$p2bd4a59b
        // type: HashSet<object>
        // type: p94012bf9
        // type: pfe573e7c
        // type: X509CertSelector
        // type: pc446fcff$p2bd4a59b
        // type: paad5c124$p2bd4a59b
        return default!;
    }

    private static void M60af404a(CertPath P0, int P1)
    {
        // str: "Issuer certificate keyusage extension is critical and does not permit key signing."
        // call: pf82b098c.<init>
        // call: X509Certificate.getKeyUsage
        // call: List<object>.get
        // call: CertPath.getCertificates
        // type: pf82b098c
    }

    private static X509CRL M6b5e2c6e(HashSet<object> P0, PublicKey P1)
    {
        // str: "Cannot verify delta CRL."
        // call: p352d4243.<init>
        // call: X509CRL.verify
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // type: p352d4243
        return default!;
    }

    private static void M6c0c0f2e(X509CRL P0, X509CRL P1, pc446fcff P2)
    {
        // str: "Complete CRL issuer does not match delta CRL issuer."
        // str: "Issuing distribution point extension could not be decoded."
        // str: "CRL authority key identifier is null."
        // str: "Authority key identifier extension could not be extracted from complete CRL."
        // str: "Delta CRL authority key identifier is null."
        // str: "Issuing distribution point extension from delta CRL could not be decoded."
        // str: "Delta CRL authority key identifier does not match complete CRL authority key identifier."
        // str: "delta CRL has unsupported critical extensions"
        // str: "Authority key identifier extension could not be extracted from delta CRL."
        // str: "Issuing distribution point extension from delta CRL and complete CRL does not match."
        // call: p352d4243.<init>
        // call: pc446fcff.isUseDeltasEnabled
        // call: p4640f1a7.mb74a4d22
        // call: p781d85ab.m8bab0102
        // call: p694426e7.equals
        // call: p301c7ed4.equals
        // call: pb854d51e.m8b725164
        // call: p781d85ab.equals
        // call: X509CRL.hasUnsupportedCriticalExtension
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f30ea160b
        // type: p352d4243
    }

    private static p40cdc0e2 M77217a92(X509CRL P0, p0cfd224b P1)
    {
        // str: "Issuing distribution point extension could not be decoded."
        // call: p0cfd224b.getReasons
        // call: p40cdc0e2.intersect
        // call: p40cdc0e2.<init>
        // call: p352d4243.<init>
        // call: p781d85ab.getOnlySomeReasons
        // call: p4640f1a7.mb74a4d22
        // call: p781d85ab.m8bab0102
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2.f11b4f80e
        // type: p352d4243
        // type: p40cdc0e2
        return default!;
    }

    private static void M886b083c(CertPath P0, int P1, HashSet<object> P2, List<object> P3)
    {
        // str: "Certificate has unsupported critical extension: "
        // call: CertPathValidatorException.getCause
        // call: List<object>.get
        // call: StringBuilder.append
        // call: CertPath.getCertificates
        // call: CertPathValidatorException.getMessage
        // call: StringBuilder.<init>
        // call: IEnumerator<object>.hasNext
        // call: CertPathValidatorException.<init>
        // call: IEnumerator<object>.next
        // call: PKIXCertPathChecker.check
        // call: List<object>.iterator
        // call: StringBuilder.toString
        // call: pf82b098c.<init>
        // call: HashSet<object>.isEmpty
        // type: pf82b098c
        // type: CertPathValidatorException
        // type: StringBuilder
    }

    private static int M9763a9ef(CertPath P0, int P1, int P2)
    {
        // str: "Basic constraints extension cannot be decoded."
        // call: System.Numerics.BigInteger.intValue
        // call: p4640f1a7.mb74a4d22
        // call: p44f86c11.m8bab0102
        // call: CertPath.getCertificates
        // call: p44f86c11.getPathLenConstraint
        // call: pf82b098c.<init>
        // call: List<object>.get
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a
        // type: pf82b098c
        return 0;
    }

    private static p331d8902 M9ce3c4fe(CertPath P0, pc446fcff P1, HashSet<object> P2, int P3, List<object>[] P4, p331d8902 P5, HashSet<object> P6)
    {
        // str: "f33a6e668e02aaf3cc6caed154a178635434daa7eac469e3736ae68b846faf15ee8b4019673c94"
        // str: "Explicit policy requested but none available."
        // call: p4640f1a7.m99772425
        // call: IEnumerator<object>.hasNext
        // call: p331d8902.hasChildren
        // call: p331d8902.getChildren
        // call: IEnumerator<object>.next
        // call: HashSet<object>.iterator
        // call: HashSet<object>.<init>
        // call: CertPath.getCertificates
        // call: p331d8902.getValidPolicy
        // call: pf82b098c.<init>
        // call: HashSet<object>.add
        // call: string.equals
        // call: List<object>.size
        // call: List<object>.get
        // call: pc446fcff.isExplicitPolicyRequired
        // call: DecryptString.decryptString
        // call: p4640f1a7.m57c24a75
        // call: HashSet<object>.contains
        // call: HashSet<object>.isEmpty
        // type: HashSet<object>
        // type: pf82b098c
        return default!;
    }

    private static p331d8902 M9d62c6e5(CertPath P0, int P1, HashSet<object> P2, p331d8902 P3, List<object>[] P4, int P5, bool P6)
    {
        // str: "Could not read certificate policies extension from certificate."
        // str: "Policy qualifier info set could not be build."
        // str: "5f806fcc4c628e14fc4d2dc30bf38d31de1508112b75af6825e30f5786e669a171f12aca992fb5"
        // call: p331d8902.getChildren
        // call: p364bf33a.getId
        // call: p80f8c729.getObjects
        // call: DecryptString.decryptString
        // call: IEnumerator<object>.next
        // call: List<object>.size
        // call: HashSet<object>.iterator
        // call: HashSet<object>.<init>
        // call: HashSet<object>.contains
        // call: List<object>.get
        // call: p331d8902.getValidPolicy
        // call: p28edb599.getPolicyQualifiers
        // call: p4640f1a7.ma76fc2b3
        // call: p4640f1a7.m968c73de
        // call: IEnumerator<object>.hasNext
        // call: pf82b098c.<init>
        // call: p331d8902.setCritical
        // call: HashSet<object>.isEmpty
        // call: p331d8902.hasChildren
        // call: string.equals
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48
        // type: pf82b098c
        // type: List<object>
        // type: HashSet<object>
        // type: p331d8902
        return default!;
    }

    private static void Mb1481b0f(CertPath P0, int P1)
    {
        // str: "de1ec37f7288f1a4dbf9c91ffba4fc5731cc1a8067dd0594c7d54c2a711dddccae2a2e8249484f"
        // str: "IssuerDomainPolicy is anyPolicy"
        // str: "Policy mappings extension contents could not be decoded."
        // str: "Policy mappings extension could not be decoded."
        // str: "SubjectDomainPolicy is anyPolicy"
        // call: CertPath.getCertificates
        // call: CertPathValidatorException.<init>
        // call: pf82b098c.<init>
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // call: p364bf33a.getId
        // call: p80f8c729.getObjectAt
        // call: p364bf33a.m8bab0102
        // call: string.equals
        // call: List<object>.get
        // call: DecryptString.decryptString
        // call: p80f8c729.size
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b
        // type: CertPathValidatorException
        // type: pf82b098c
    }

    private static int Mb241fbb6(CertPath P0, int P1, int P2)
    {
        // call: List<object>.get
        // call: CertPath.getCertificates
        // call: p4640f1a7.m5d05f998
        return 0;
    }

    private static p331d8902 Mb2eb40db(CertPath P0, int P1, List<object>[] P2, p331d8902 P3, int P4)
    {
        // str: "Policy qualifier info set could not be decoded."
        // str: "Policy mappings extension could not be decoded."
        // str: "7a8fe329ffc1cb83e7aafaa6d22f339e866398c820070fa5ca364c0cfb052ba816847c614d1ca0"
        // str: "Policy information could not be decoded."
        // str: "Certificate policies extension could not be decoded."
        // call: Dictionary<string, object>.containsKey
        // call: CertPathValidatorException.<init>
        // call: p80f8c729.getObjects
        // call: p80f8c729.getObjectAt
        // call: HashSet<object>.iterator
        // call: Dictionary<string, object>.<init>
        // call: IEnumerator<object>.next
        // call: X509Certificate.getCriticalExtensionOIDs
        // call: HashSet<object>.contains
        // call: p364bf33a.getId
        // call: List<object>.iterator
        // call: pf82b098c.<init>
        // call: HashSet<object>.<init>
        // call: IEnumerator<object>.hasNext
        // call: List<object>.get
        // call: string.equals
        // call: List<object>.size
        // call: Dictionary<string, object>.get
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902.fd10779ce
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48
        // type: pf82b098c
        // type: Dictionary<string, object>
        // type: CertPathValidatorException
        // type: List<object>
        // type: p331d8902
        // type: HashSet<object>
        return default!;
    }

    private static int Mb3e6b74d(CertPath P0, int P1, int P2)
    {
        // str: "Inhibit any-policy extension cannot be decoded."
        // call: pf391b73d.intValueExact
        // call: List<object>.get
        // call: p4640f1a7.mb74a4d22
        // call: pf391b73d.m8bab0102
        // call: pf82b098c.<init>
        // call: CertPath.getCertificates
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2
        // type: pf82b098c
        return 0;
    }

    private static int Mb4e44315(int P0, X509Certificate P1)
    {
        // call: p4640f1a7.m5d05f998
        return 0;
    }

    private static void Mbbcfcdc6(CertPath P0, int P1, p1dc02b40 P2)
    {
        // str: "Name constraints extension could not be decoded."
        // str: "Permitted subtrees cannot be build from name constraints extension."
        // str: "Excluded subtrees cannot be build from name constraints extension."
        // call: p1dc02b40.addExcludedSubtree
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // call: p1acfb6e2.m8bab0102
        // call: pf82b098c.<init>
        // call: CertPath.getCertificates
        // call: List<object>.get
        // call: p1acfb6e2.getPermittedSubtrees
        // call: p1dc02b40.intersectPermittedSubtree
        // call: p1acfb6e2.getExcludedSubtrees
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814
        // type: pf82b098c
    }

    private static void Mc70ec8ae(p0cfd224b P0, object P1, X509CRL P2)
    {
        // str: "No match for certificate CRL issuing distribution point name to cRLIssuer CRL distribution point."
        // str: "Could not read CRL issuer."
        // str: "End CRL only contains CA certificates."
        // str: "onlyContainsAttributeCerts boolean is asserted."
        // str: "Issuing distribution point extension could not be decoded."
        // str: "CA Cert CRL only contains user certificates."
        // str: "Either the cRLIssuer or the distributionPoint field must be contained in DistributionPoint."
        // str: "Could not read certificate issuer."
        // str: "Basic constraints extension could not be decoded."
        // call: pafc6206d.getType
        // call: p352d4243.<init>
        // call: p4640f1a7.mb74a4d22
        // call: p781d85ab.m8bab0102
        // call: p0cfd224b.getCRLIssuer
        // call: Enumeration.hasMoreElements
        // call: pfb202cf8.getNames
        // call: p44f86c11.isCA
        // call: p44f86c11.m8bab0102
        // call: pf17d2ecd.<init>
        // call: pd6ccb7fc.<init>
        // call: p694426e7.m8bab0102
        // call: p80f8c729.m8bab0102
        // call: p781d85ab.getDistributionPoint
        // call: List<object>.contains
        // call: p80f8c729.getObjects
        // call: pfb202cf8.m8bab0102
        // call: pb840b7ef.<init>
        // call: pf17d2ecd.getName
        // call: p0cfd224b.getDistributionPoint
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a
        // type: p352d4243
        // type: pd6ccb7fc
        // type: pb840b7ef
        // type: List<object>
        // type: pf17d2ecd
    }

    private static void Md4d4962a(DateTime P0, X509CRL P1, object P2, pb82bf363 P3, pc446fcff P4)
    {
        // call: pc446fcff.isUseDeltasEnabled
        // call: p4640f1a7.m5159139f
    }

    private static int Md4fb803c(CertPath P0, int P1, int P2)
    {
        // str: "Max path length not greater than zero"
        // call: List<object>.get
        // call: CertPath.getCertificates
        // call: p4640f1a7.m5d05f998
        // call: pf82b098c.<init>
        // type: pf82b098c
        return 0;
    }

    private static int Md6183fc5(CertPath P0, int P1, int P2)
    {
        // str: "Policy constraints extension contents cannot be decoded."
        // str: "Policy constraints extension cannot be decoded."
        // call: CertPath.getCertificates
        // call: Enumeration.nextElement
        // call: p582a4948.m8bab0102
        // call: p582a4948.getTagNo
        // call: pf391b73d.m8bab0102
        // call: pf391b73d.intValueExact
        // call: pf82b098c.<init>
        // call: p80f8c729.getObjects
        // call: Enumeration.hasMoreElements
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // call: List<object>.get
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184
        // type: pf82b098c
        return 0;
    }

    private static int Mddd192e7(CertPath P0, int P1, int P2)
    {
        // call: List<object>.get
        // call: p4640f1a7.m5d05f998
        // call: CertPath.getCertificates
        return 0;
    }

    private static p331d8902 Me4db826d(CertPath P0, int P1, p331d8902 P2)
    {
        // str: "Could not read certificate policies extension from certificate."
        // call: CertPath.getCertificates
        // call: List<object>.get
        // call: p4640f1a7.mb74a4d22
        // call: p80f8c729.m8bab0102
        // call: pf82b098c.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48
        // type: pf82b098c
        return default!;
    }

    private static void Meebed72a(CertPath P0, pc446fcff P1, DateTime P2, pd53d0176 P3, int P4, PublicKey P5, bool P6, p694426e7 P7, X509Certificate P8)
    {
        // str: ") does not match SubjectName("
        // str: "IssuerName("
        // str: "Could not validate certificate signature."
        // str: "Could not validate certificate: "
        // str: "Could not validate time of certificate."
        // str: ") of signing certificate."
        // call: CertificateNotYetValidException.getMessage
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pcb5fa6f0.<init>
        // call: pc446fcff.getValidityModel
        // call: p4640f1a7.mb09cfffb
        // call: X509Certificate.checkValidity
        // call: pc446fcff.getSigProvider
        // call: p4640f1a7.mfdeaf35e
        // call: StringBuilder.append
        // call: pf82b098c.<init>
        // call: CertPath.getCertificates
        // call: pd53d0176.initialize
        // call: CertificateExpiredException.getMessage
        // call: pb854d51e.m8b725164
        // call: pd53d0176.check
        // call: List<object>.get
        // call: p694426e7.equals
        // type: pf82b098c
        // type: StringBuilder
        // type: pcb5fa6f0
    }

    private static void Mf2a2cd44(CertPath P0, int P1, p331d8902 P2, int P3)
    {
        // str: "No valid policy tree found when one expected."
        // call: pf82b098c.<init>
        // type: pf82b098c
    }

}
