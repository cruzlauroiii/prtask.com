namespace WillowMaze.Wasm.Decompiled;

public class Pac5cdcfb : P4640f1a7
{
    private static string F18f7ecaf;
    private static string F282d64b0;
    private static string F31d457db;
    private static string F472a9b12;
    private static string F52b3e61a;
    private static string F5ea4a2c2;
    private static string F811f192a;
    private static string Fab62d684;
    private static string Faf5aa284;
    private static string Fbd21af52;
    private static string Fdf63997d;
    private static string Fe3519a30;
    private static string Fe372fd94;
    private static string Fe7808ac6;
    private static string Ff87610ab;
    private PublicKey F00e628e9;
    private PKIXParameters F02752027;
    private List<object>[] F0355795a;
    private List<object>[] F07213a01;
    private List<object>[] F07ef9469;
    private bool F286ec9a1;
    private DateTime F2e490d9a;
    private List<object> F3443e4fe;
    private List<object>[] F351be459;
    private TrustAnchor F357637fa;
    private PolicyNode F35ba79d3;
    private CertPath F365e4dec;
    private List<object>[] F3dedaa0e;
    private DateTime F5486a4ee;
    private DateTime F5501739e;
    private PKIXParameters F5ab6907f;
    private List<object> F5c99e9c5;
    private PolicyNode F5f955118;
    private DateTime F68a7a1aa;
    private PublicKey F7a3ee4f4;
    private int F7b8b965a;
    private bool F7b8e4928;
    private DateTime F7e70f202;
    private bool F8465dfce;
    private bool F84d10a1e;
    private DateTime F9ed2fc55;
    private PKIXParameters Fa9c6dc40;
    private CertPath Fb4f9c165;
    private List<object>[] Fbcb37098;
    private bool Fcd2723b8;
    private PKIXParameters Fd8637199;
    private DateTime Fe0794274;
    private TrustAnchor Fe0f84526;
    private List<object>[] Ff37bd2f6;
    private TrustAnchor Ff681033f;
    private int Ff773abf1;

    private void M0641a4b2()
    {
        // str: "e8f0ac7dcd497d221baa614389df1f90df10b8e284d1a5626b481d2cd2a27b120950f3b48a575020ae3dcfa2ae8aaf7e7..."
        // str: "missingIssuer"
        // str: "CertPathReviewer.crlDistPoint"
        // str: "CertPathReviewer.noCertSign"
        // str: "CertPathReviewer.signatureNotVerified"
        // str: " "
        // str: "CertPathReviewer.pubKeyError"
        // str: "CertPathReviewer.trustDNInvalid"
        // str: "CertPathReviewer.trustPubKeyError"
        // str: "CertPathReviewer.ocspLocation"
        // str: "CertPathReviewer.certificateExpired"
        // str: "CertPathReviewer.trustKeyUsage"
        // str: "CertPathReviewer.certWrongIssuer"
        // str: "CertPathReviewer.noCACert"
        // str: "CertPathReviewer.certificateNotYetValid"
        // str: "CertPathReviewer.rootKeyIsValidButNotATrustAnchor"
        // str: "CertPathReviewer.NoIssuerPublicKey"
        // str: "CertPathReviewer.trustButInvalidCert"
        // str: "CertPathReviewer.unknown"
        // str: " \""
        // call: pac5cdcfb.addError
        // call: IEnumerator<object>.next
        // call: pac5cdcfb.getOCSPUrls
        // call: pd7dc3611.<init>
        // call: List<object>.get
        // call: TrustAnchor.getTrustedCert
        // call: Vector.iterator
        // call: X500Principal.getName
        // call: IEnumerator<object>.hasNext
        // call: p9746cd54.getAuthorityCertIssuer
        // call: Type.getName
        // call: DecryptString.decryptString
        // call: p75aa9a98.<init>
        // call: p11b04310.getOctets
        // call: object.getClass
        // call: pac5cdcfb.isSelfIssued
        // call: X509Certificate.getNotAfter
        // call: GeneralSecurityException.getMessage
        // call: p274e84fa.<init>
        // call: pac5cdcfb.getExtensionValue
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5ab6907f
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7e70f202
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f00e628e9
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f472a9b12
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5c99e9c5
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fdf63997d
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f357637fa
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f0145697d
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5486a4ee
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f63571c7a
        // type: p75aa9a98
        // type: pd7dc3611
        // type: pf335261d
        // type: p274e84fa
        // type: pdf85d900
        // type: X500Principal
    }

    private void M091f5704()
    {
    }

    private bool M2dc5d847(X509Certificate P0, int P1)
    {
        // str: "CertPathReviewer.QcEuCompliance"
        // str: "CertPathReviewer.QcSSCD"
        // str: "CertPathReviewer.QcLimitValueAlpha"
        // str: "CertPathReviewer.QcLimitValueNum"
        // str: "CertPathReviewer.QcUnknownStatement"
        // str: "CertPathReviewer.QcStatementExtError"
        // str: "1fcad9e20a35f2ee3ae0a722c374c29f262f1f2b1091c301ee78ca5501957f7fa101357e88ab45f076dddcdf0b17aa4c6..."
        // call: pac5cdcfb.addError
        // call: pac5cdcfb.getExtensionValue
        // call: p80f8c729.size
        // call: p80f8c729.getObjectAt
        // call: p4e2a4bfd.m8bab0102
        // call: p4e2a4bfd.getStatementId
        // call: p364bf33a.equals
        // call: pd7dc3611.<init>
        // call: pac5cdcfb.addNotification
        // call: p4e2a4bfd.getStatementInfo
        // call: pd6a201eb.m8bab0102
        // call: pd6a201eb.getCurrency
        // call: pd6a201eb.getAmount
        // call: System.Numerics.BigInteger.doubleValue
        // call: pd6a201eb.getExponent
        // call: Math.pow
        // call: p8d03b01b.isAlphabetic
        // call: p8d03b01b.getAlphabetic
        // call: double.<init>
        // call: p75aa9a98.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fab62d684
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd.f8d0108ea
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd.f2a216808
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd.f3233519f
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4e2a4bfd.f8a8bd011
        // type: pd7dc3611
        // type: p75aa9a98
        // type: double
        // type: p274e84fa
        return false;
    }

    private void M4b45549a()
    {
        // str: "31f04eb9f063984796a6f4c9fe2901dcfca5178265f7f8449364418fbc6f8406346a5d7acfde4c315a8970b9436197c75..."
        // str: "CertPathReviewer.processLengthConstError"
        // str: "CertPathReviewer.pathLengthExtended"
        // str: "CertPathReviewer.totalPathLength"
        // call: p44f86c11.getPathLenConstraint
        // call: pac5cdcfb.isSelfIssued
        // call: List<object>.get
        // call: pac5cdcfb.getExtensionValue
        // call: p44f86c11.m8bab0102
        // call: DecryptString.decryptString
        // call: pac5cdcfb.addError
        // call: List<object>.size
        // call: System.Numerics.BigInteger.intValue
        // call: pd7dc3611.<init>
        // call: pf74464bf.m1adac6f4
        // call: pac5cdcfb.addNotification
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5c99e9c5
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f63571c7a
        // type: pd7dc3611
    }

    private void M754b329b()
    {
        // str: "956bb6a527ebb684ceeaf24c5ba3e2349f1747805f314c3bef375abffe215b7f2b3d4f9ee4176491efbe0f2830a69638f..."
        // str: "CertPathReviewer.criticalExtensionError"
        // str: "CertPathReviewer.unknownCriticalExt"
        // str: "CertPathReviewer.certPathCheckerError"
        // call: p39ccca3b.getErrorMessage
        // call: p39ccca3b.getIndex
        // call: pac5cdcfb.addError
        // call: PKIXParameters.getCertPathCheckers
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: PKIXCertPathChecker.init
        // call: List<object>.size
        // call: List<object>.get
        // call: X509Certificate.getCriticalExtensionOIDs
        // call: HashSet<object>.isEmpty
        // call: HashSet<object>.remove
        // call: p364bf33a.getId
        // call: HashSet<object>.contains
        // call: pac5cdcfb.m2dc5d847
        // call: CertPathValidatorException.getMessage
        // call: object.getClass
        // call: Type.getName
        // call: pd7dc3611.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5ab6907f
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5c99e9c5
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fb8ec8409
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5b9e3e48
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f0b308c8b
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f4435a5c2
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5596ff53
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f20458968
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fe0982184
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f63571c7a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fdbd11eec
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff5878814
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f4f9c212c
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fab62d684
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f365e4dec
        // type: pd7dc3611
        // type: p39ccca3b
        // type: p364bf33a
    }

    private void M8e8d55b0()
    {
        // str: "CertPathReviewer.notPermittedEmail"
        // str: "CertPathReviewer.subjAltNameExtError"
        // str: "CertPathReviewer.excludedDN"
        // str: "CertPathReviewer.notPermittedDN"
        // str: "CertPathReviewer.ncSubjectNameError"
        // str: "CertPathReviewer.ncExtError"
        // str: "8638ef5fc4e784bd911256fa1f8a3fd0627e0749a8c5fc233db821eb1b1d3aa71fc455fb9e7c39e549c00dc244dc7ed05..."
        // call: p274e84fa.<init>
        // call: pd7dc3611.<init>
        // call: p39ccca3b.<init>
        // call: X500Principal.getName
        // call: pac5cdcfb.getExtensionValue
        // call: p1acfb6e2.m8bab0102
        // call: p1acfb6e2.getPermittedSubtrees
        // call: p1dc02b40.intersectPermittedSubtree
        // call: p1acfb6e2.getExcludedSubtrees
        // call: p1dc02b40.addExcludedSubtree
        // call: p39ccca3b.getIndex
        // call: p39ccca3b.getErrorMessage
        // call: p80f8c729.size
        // call: p80f8c729.getObjectAt
        // call: pf17d2ecd.m8bab0102
        // call: p1dc02b40.checkPermitted
        // call: p1dc02b40.checkExcluded
        // call: pac5cdcfb.getSubjectPrincipal
        // call: X500Principal.getEncoded
        // call: MemoryStream.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f365e4dec
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff5878814
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.fdbd11eec
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5c99e9c5
        // type: pd7dc3611
        // type: p274e84fa
        // type: p39ccca3b
        // type: pd1c2953c
        // type: MemoryStream
        // type: p1dc02b40
    }

    private X509CRL Ma487b64e(string P0)
    {
        // str: "http"
        // str: "https"
        // str: "X.509"
        // str: "66efdde5d60a35405879e9a501ebd8388f71131b8230a53e0bcf2efc8c20"
        // str: "9985a3120ad8e994309c7189251266ea861a1a3cef0bae813497792b090a027919728e08f5ba7e9c477c45f88638424da..."
        // str: "CertPathReviewer.loadCrlDistPointError"
        // call: pd7dc3611.<init>
        // call: Uri.<init>
        // call: Uri.getProtocol
        // call: string.equals
        // call: Uri.openConnection
        // call: HttpClient.setUseCaches
        // call: HttpClient.setDoInput
        // call: HttpClient.connect
        // call: HttpClient.getResponseCode
        // call: DecryptString.decryptString
        // call: CertificateFactory.getInstance
        // call: HttpClient.getInputStream
        // call: CertificateFactory.generateCRL
        // call: HttpClient.getResponseMessage
        // call: Exception.<init>
        // call: Type.getName
        // call: object.getClass
        // call: Exception.getMessage
        // call: p274e84fa.<init>
        // call: p39ccca3b.<init>
        // type: pd7dc3611
        // type: Uri
        // type: Exception
        // type: p39ccca3b
        // type: p274e84fa
        return default!;
    }

    private string Mf2dd02c6(byte[] P0)
    {
        // call: InetAddress.getByAddress
        // call: InetAddress.getHostAddress
        // call: StringBuilder.append
        // call: int.toHexString
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        return string.Empty;
    }

    private void AddError(pd7dc3611 P0)
    {
        // call: List<object>.add
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
    }

    private void AddError(pd7dc3611 P0, int P1)
    {
        // call: IndexOutOfBoundsException.<init>
        // call: List<object>.add
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
        // type: IndexOutOfBoundsException
    }

    private void AddNotification(pd7dc3611 P0)
    {
        // call: List<object>.add
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff37bd2f6
    }

    private void AddNotification(pd7dc3611 P0, int P1)
    {
        // call: IndexOutOfBoundsException.<init>
        // call: List<object>.add
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff37bd2f6
        // type: IndexOutOfBoundsException
    }

    private void CheckCRLs(PKIXParameters P0, X509Certificate P1, DateTime P2, X509Certificate P3, PublicKey P4, Vector P5, int P6)
    {
        // str: "CertPathReviewer.certRevoked"
        // str: "CertPathReviewer.crlExtractionError"
        // str: "CertPathReviewer.crlOnlyCaCert"
        // str: "CertPathReviewer.deltaCrlExtError"
        // str: "CertPathReviewer.onlineValidCRL"
        // str: "CertPathReviewer.crlNbrExtError"
        // str: "CertPathReviewer.onlineCRLWrongCA"
        // str: "CertPathReviewer.onlineInvalidCRL"
        // str: "CertPathReviewer.noCrlSigningPermited"
        // str: "CertPathReviewer.crlUpdateAvailable"
        // str: "CertPathReviewer.crlOnlyUserCert"
        // str: "CertPathReviewer.localValidCRL"
        // str: "1de65285cc2b7ae56b3d4cafe90c8086d301bb9247748010b5b2f70bca911d61fbdb0ba017dd93dc38a9fff8f1f0a8a1d..."
        // str: "CertPathReviewer.revokedAfterValidation"
        // str: "CertPathReviewer.noBaseCRL"
        // str: "CertPathReviewer.crlNoIssuerPublicKey"
        // str: "CertPathReviewer.noCrlInCertstore"
        // str: "58ce836d931e2f28a2d6e7b6f249931e3375c53f83e57e30bd1165c3ab43"
        // str: "CertPathReviewer.crlIssuerException"
        // str: "CertPathReviewer.crlReasonExtError"
        // call: p39ccca3b.<init>
        // call: pf335261d.<init>
        // call: DateTime.before
        // call: pd7dc3611.<init>
        // call: p75aa9a98.<init>
        // call: X509Certificate.getIssuerX500Principal
        // call: X509CRLEntry.hasExtensions
        // call: pac5cdcfb.addNotification
        // call: pf391b73d.getPositiveValue
        // call: p69a537ea.<init>
        // call: pac5cdcfb.getEncodedIssuerPrincipal
        // call: X500Principal.getEncoded
        // call: p69a537ea.addIssuerName
        // call: X509Certificate.getSerialNumber
        // call: X500Principal.getName
        // call: p274e84fa.<init>
        // call: p364bf33a.getId
        // call: pac5cdcfb.getExtensionValue
        // call: p4f02e7ce.m8bab0102
        // call: X509CRL.getNextUpdate
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f61cea794
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5596ff53
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f63571c7a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f661a0959
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f20458968
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f95d20985
        // type: p39ccca3b
        // type: pd7dc3611
        // type: p75aa9a98
        // type: p274e84fa
        // type: p69a537ea
        // type: pdf85d900
        // type: pf335261d
        // type: List<object>
    }

    private void CheckRevocation(PKIXParameters P0, X509Certificate P1, DateTime P2, X509Certificate P3, PublicKey P4, Vector P5, Vector P6, int P7)
    {
        // call: pac5cdcfb.checkCRLs
    }

    private void DoChecks()
    {
        // str: "Object not initialized. Call init() first."
        // call: List<object>.<init>
        // call: pac5cdcfb.m8e8d55b0
        // call: IllegalStateException.<init>
        // call: pac5cdcfb.m4b45549a
        // call: pac5cdcfb.m754b329b
        // call: pac5cdcfb.m091f5704
        // call: pac5cdcfb.m0641a4b2
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff37bd2f6
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f84d10a1e
        // type: IllegalStateException
        // type: List<object>
    }

    private Vector GetCRLDistUrls(pe6e3e799 P0)
    {
        // call: pf17d2ecd.getTagNo
        // call: pfb202cf8.m8bab0102
        // call: pfb202cf8.getNames
        // call: p0cfd224b.getDistributionPoint
        // call: pe6e3e799.getDistributionPoints
        // call: Vector.<init>
        // call: Vector.add
        // call: pf17d2ecd.getName
        // call: pafc6206d.getType
        // call: p2f096beb.getString
        // call: pafc6206d.getName
        // type: Vector
        return default!;
    }

    public CertPath GetCertPath()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f365e4dec
        return default!;
    }

    public int GetCertPathSize()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        return 0;
    }

    public List<object> GetErrors(int P0)
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
        return default!;
    }

    public List<object>[] GetErrors()
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
        return default!;
    }

    public List<object> GetNotifications(int P0)
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff37bd2f6
        return default!;
    }

    public List<object>[] GetNotifications()
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff37bd2f6
        return default!;
    }

    private Vector GetOCSPUrls(p7c2f3921 P0)
    {
        // call: Vector.<init>
        // call: pf17d2ecd.getName
        // call: p2f096beb.getString
        // call: p09f5c4db.getAccessLocation
        // call: p7c2f3921.getAccessDescriptions
        // call: Vector.add
        // call: pf17d2ecd.getTagNo
        // call: p09f5c4db.getAccessMethod
        // call: p364bf33a.equals
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09f5c4db.f77b38f95
        // type: Vector
        return default!;
    }

    public PolicyNode GetPolicyTree()
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5f955118
        return default!;
    }

    public PublicKey GetSubjectPublicKey()
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f00e628e9
        return default!;
    }

    public TrustAnchor GetTrustAnchor()
    {
        // call: pac5cdcfb.doChecks
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f357637fa
        return default!;
    }

    private ICollection<object> GetTrustAnchors(X509Certificate P0, HashSet<object> P1)
    {
        // str: "CertPathReviewer.trustAnchorIssuerError"
        // str: "dc49d485889342ca54ea5dc0722a457651420a529ed9729c81477091cf49c434ab0000f1bdda9ffd5d53a76b7ae7b36f3..."
        // call: TrustAnchor.getCAPublicKey
        // call: X500Principal.<init>
        // call: HashSet<object>.iterator
        // call: TrustAnchor.getTrustedCert
        // call: pd7dc3611.<init>
        // call: IEnumerator<object>.next
        // call: X509CertSelector.match
        // call: p39ccca3b.<init>
        // call: X500Principal.equals
        // call: TrustAnchor.getCAName
        // call: X509CertSelector.<init>
        // call: pac5cdcfb.getEncodedIssuerPrincipal
        // call: X500Principal.getEncoded
        // call: X509CertSelector.setSubject
        // call: p364bf33a.getId
        // call: X509Certificate.getExtensionValue
        // call: p301c7ed4.m89e75c46
        // call: p11b04310.getOctets
        // call: p9746cd54.m8bab0102
        // call: p9746cd54.getAuthorityCertSerialNumber
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f0145697d
        // type: X500Principal
        // type: p39ccca3b
        // type: List<object>
        // type: pd7dc3611
        // type: X509CertSelector
        return default!;
    }

    public void Init(CertPath P0, PKIXParameters P1)
    {
        // str: "bc5b27fc819e7799122dfe52f06ce55403a9a8a44135317d9bcbeff003136c873a1c7599f32f74565857232b566dd0c8f..."
        // str: "object is already initialized!"
        // str: "CertPathReviewer.emptyCertPath"
        // str: "certPath was null"
        // call: pac5cdcfb.getValidityDate
        // call: DateTime.<init>
        // call: IllegalStateException.<init>
        // call: List<object>.isEmpty
        // call: PKIXParameters.clone
        // call: pd7dc3611.<init>
        // call: List<object>.size
        // call: DecryptString.decryptString
        // call: NullPointerException.<init>
        // call: CertPath.getCertificates
        // call: p39ccca3b.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5c99e9c5
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f365e4dec
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5ab6907f
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f84d10a1e
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f357637fa
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.ff37bd2f6
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5f955118
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7b8b965a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f7e70f202
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f5486a4ee
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f00e628e9
        // type: NullPointerException
        // type: IllegalStateException
        // type: DateTime
        // type: p39ccca3b
        // type: pd7dc3611
    }

    public bool IsValidCertPath()
    {
        // call: pac5cdcfb.doChecks
        // call: List<object>.isEmpty
        // field: p5a445d71.p9f931cf3.pdacfecb5.pac5cdcfb.f07213a01
        return false;
    }

}
