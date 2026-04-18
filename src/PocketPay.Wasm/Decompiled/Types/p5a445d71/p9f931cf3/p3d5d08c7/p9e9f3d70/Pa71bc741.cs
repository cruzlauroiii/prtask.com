namespace WillowMaze.Wasm.Decompiled;

public class Pa71bc741 : Pd53d0176
{
    private static Dictionary<string, object> F101826d5;
    private static Dictionary<string, object> F190f4507;
    private static int F1f30dcbe;
    private static Dictionary<string, object> F588247ff;
    private static Dictionary<string, object> F62f6b544;
    private static int F6afd7374;
    private static Dictionary<string, object> F9763d6ad;
    private static int F9e7f6c36;
    private static int Fdc938c0f;
    private static int Fea5b394b;
    private static int Ff7f029ac;
    private pcb5fa6f0 F166e64f6;
    private readonly pb3b7fb02 F1d2473f6;
    private pcb5fa6f0 F291565ee;
    private readonly p3a8bd746 F33cebe86;
    private bool F5400f5bb;
    private pcb5fa6f0 F6d1ee0e5;
    private bool F7a2da9f1;
    private string F7af7a867;
    private readonly pb3b7fb02 F813e53e7;
    private pcb5fa6f0 F9f661b45;
    private readonly p3a8bd746 Fd0e45878;
    private readonly pb3b7fb02 Fd1fde34f;
    private string Fdb1cd4c4;
    private bool Fdfd6bc54;
    private string Fe0ce0a82;
    private string Fe2c23789;
    private pcb5fa6f0 Ff1768c28;
    private readonly pb3b7fb02 Ffde5d67b;

    private peb0f48a1 M22abd392()
    {
        // str: "cannot process signing cert: "
        // call: pcb5fa6f0.getCertPath
        // call: Exception.getMessage
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pcb5fa6f0.getSigningCert
        // call: X509Certificate.getEncoded
        // call: peb0f48a1.m8bab0102
        // call: StringBuilder.<init>
        // call: pcb5fa6f0.getIndex
        // call: CertPathValidatorException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.f166e64f6
        // type: StringBuilder
        // type: CertPathValidatorException
        return default!;
    }

    private static byte[] M3a663653(System.Security.Cryptography.HashAlgorithm P0, PublicKey P1)
    {
        // call: PublicKey.getEncoded
        // call: p29d19857.getBytes
        // call: System.Security.Cryptography.HashAlgorithm.digest
        // call: p3cdccfc9.m8bab0102
        // call: p3cdccfc9.getPublicKeyData
        return default!;
    }

    private static string M6d7cc104(p234a7530 P0)
    {
        // str: "WITHRSAANDMGF1"
        // call: Dictionary<string, object>.get
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: pfa0321ce.getHashAlgorithm
        // call: StringBuilder.toString
        // call: p4631e342.equals
        // call: p234a7530.getParameters
        // call: Dictionary<string, object>.containsKey
        // call: pfa0321ce.m8bab0102
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p364bf33a.getId
        // call: pa71bc741.mba8d3a36
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.f9763d6ad
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // type: StringBuilder
        return string.Empty;
    }

    private pc4284d9d M88bb7200(pc4284d9d P0, peb0f48a1 P1, pf391b73d P2)
    {
        // call: pa71bc741.m88bb7200
        // call: pc4284d9d.getHashAlgorithm
        return default!;
    }

    private pc4284d9d M88bb7200(p234a7530 P0, peb0f48a1 P1, pf391b73d P2)
    {
        // str: "problem creating ID: "
        // str: "4fe722282a737d6582188e25c41aea5c45366e2031df9fab8f3aa1479d3cb6"
        // call: CertPathValidatorException.<init>
        // call: p234a7530.getAlgorithm
        // call: p45eb53fe.mba8d3a36
        // call: pb3b7fb02.createMessageDigest
        // call: peb0f48a1.getSubject
        // call: DecryptString.decryptString
        // call: p694426e7.getEncoded
        // call: System.Security.Cryptography.HashAlgorithm.digest
        // call: p6f0e511c.<init>
        // call: peb0f48a1.getSubjectPublicKeyInfo
        // call: p3cdccfc9.getPublicKeyData
        // call: p29d19857.getBytes
        // call: pc4284d9d.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.ffde5d67b
        // type: StringBuilder
        // type: p6f0e511c
        // type: pc4284d9d
        // type: CertPathValidatorException
        return default!;
    }

    private static Uri Ma3028295(X509Certificate P0)
    {
        // call: p364bf33a.getId
        // call: p11b04310.m8bab0102
        // call: X509Certificate.getExtensionValue
        // call: p7c2f3921.m8bab0102
        // call: p09f5c4db.getAccessMethod
        // call: p09f5c4db.getAccessLocation
        // call: pf17d2ecd.getName
        // call: p2d24d5da.getString
        // call: Uri.<init>
        // call: p7c2f3921.getAccessDescriptions
        // call: pf17d2ecd.getTagNo
        // call: p364bf33a.equals
        // call: p11b04310.getOctets
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09f5c4db.f77b38f95
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f27b5e1c9
        // type: Uri
        return default!;
    }

    private static string Mba8d3a36(p364bf33a P0)
    {
        // str: "SHA3"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: string.startsWith
        // call: string.indexOf
        // call: string.substring
        // call: StringBuilder.<init>
        // call: p45eb53fe.mba8d3a36
        // type: StringBuilder
        return string.Empty;
    }

    private static bool Mc69c7d18(p1d095394 P0, X509Certificate P1, pb3b7fb02 P2)
    {
        // str: "SHA1"
        // call: X500Principal.getEncoded
        // call: p694426e7.m8bab0102
        // call: X509Certificate.getSubjectX500Principal
        // call: p1d095394.getName
        // call: pff43b8de.m2a3f81d2
        // call: X509Certificate.getPublicKey
        // call: pb3b7fb02.createMessageDigest
        // call: p1d095394.getKeyHash
        // call: pa71bc741.m3a663653
        // call: p694426e7.equals
        // field: p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.pa4af7c53.f76425f17
        return false;
    }

    private static bool Mdeefcb2c(p4df9607c P0, pcb5fa6f0 P1, byte[] P2, X509Certificate P3, pb3b7fb02 P4)
    {
        // str: "OCSP response failure: "
        // str: "OCSP responder certificate not found"
        // str: "X.509"
        // str: "30c2ff9e7f2eae246ca5e85482045afb3164d0077df62589f579303cf5c74b"
        // str: "nonce mismatch in OCSP response"
        // str: "responder certificate not valid for signing OCSP responses"
        // str: "responder certificate does not match responderID"
        // call: IOException.getMessage
        // call: pcb5fa6f0.getCertPath
        // call: StringBuilder.toString
        // call: pcb5fa6f0.getIndex
        // call: StringBuilder.append
        // call: p4df9607c.getCerts
        // call: p4df9607c.getSignatureAlgorithm
        // call: pa71bc741.m6d7cc104
        // call: pb3b7fb02.createSignature
        // call: pcb5fa6f0.getSigningCert
        // call: pa71bc741.me2b8b788
        // call: CertPathValidatorException.<init>
        // call: X509Certificate.getPublicKey
        // call: Signature.initVerify
        // call: pb3b7fb02.createCertificateFactory
        // call: p80f8c729.getObjectAt
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: MemoryStream.<init>
        // call: CertificateFactory.generateCertificate
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9.ffd8f2e56
        // field: p5a445d71.p9f931cf3.pca323100.p785c9c91.p267f1aae.f390f0ebb
        // type: CertPathValidatorException
        // type: MemoryStream
        // type: StringBuilder
        return false;
    }

    private static X509Certificate Me2b8b788(p4df9607c P0, X509Certificate P1, X509Certificate P2, pb3b7fb02 P3)
    {
        // str: "SHA1"
        // call: p694426e7.m8bab0102
        // call: pf35d6085.getResponderID
        // call: X500Principal.getEncoded
        // call: pff43b8de.m2a3f81d2
        // call: X509Certificate.getPublicKey
        // call: X509Certificate.getSubjectX500Principal
        // call: p4df9607c.getTbsResponseData
        // call: p1d095394.getName
        // call: pa71bc741.m3a663653
        // call: p1d095394.getKeyHash
        // call: p694426e7.equals
        // call: pb3b7fb02.createMessageDigest
        // field: p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.pa4af7c53.f76425f17
        return default!;
    }

    public void Check(Certificate P0)
    {
        // str: "no OCSP response found for certificate"
        // str: "no OCSP response found for any certificate"
        // str: "OCSP response expired"
        // str: "certificate revoked, reason=("
        // str: "), date="
        // str: "certificate revoked, details unknown"
        // str: "OCSP disabled by \"ocsp.enable\" setting"
        // str: "configuration error: "
        // str: "unable to process OCSP response"
        // str: "unable to encode OCSP response"
        // str: "OCSP response failed: "
        // call: pcb5fa6f0.getIndex
        // call: p3a8bd746.getOcspResponder
        // call: pcb5fa6f0.getCertPath
        // call: p8fc67bd0.m416d2462
        // call: p4cc2b84e.getEncoded
        // call: Dictionary<string, object>.put
        // call: p3a8bd746.getOcspExtensions
        // call: p3a8bd746.getOcspResponses
        // call: Dictionary<string, object>.isEmpty
        // call: pa71bc741.ma3028295
        // call: p3a8bd746.getOcspResponderCert
        // call: pf391b73d.<init>
        // call: X509Certificate.getSerialNumber
        // call: p4cc2b84e.getResponseBytes
        // call: Dictionary<string, object>.get
        // call: p4cc2b84e.getResponseStatus
        // call: Extension.getValue
        // call: p4a23457a.<init>
        // call: StringBuilder.toString
        // call: pad1b94ef.getResponse
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.f166e64f6
        // field: p5a445d71.p9f931cf3.pca323100.p785c9c91.p267f1aae.f390f0ebb
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fd0e45878
        // field: p5a445d71.p9f931cf3.pca323100.p785c9c91.p267f1aae.fe1da805e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.ffde5d67b
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fdb1cd4c4
        // field: p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fdfd6bc54
        // type: pf391b73d
        // type: StringBuilder
        // type: p4a23457a
        // type: pf82b098c
        // type: CertPathValidatorException
        // type: Uri
        // type: p234a7530
    }

    public List<object> GetSoftFailExceptions()
    {
        return default!;
    }

    public HashSet<object> GetSupportedExtensions()
    {
        return default!;
    }

    public void Init(bool P0)
    {
        // str: "ocsp.responderURL"
        // str: "ocsp.enable"
        // str: "forward checking not supported"
        // call: p9fc2d28c.mf2b2f421
        // call: CertPathValidatorException.<init>
        // call: p9fc2d28c.mdd414c2a
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fdfd6bc54
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fdb1cd4c4
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.f166e64f6
        // type: CertPathValidatorException
    }

    public void Initialize(pcb5fa6f0 P0)
    {
        // str: "ocsp.responderURL"
        // str: "ocsp.enable"
        // call: p9fc2d28c.mf2b2f421
        // call: p9fc2d28c.mdd414c2a
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.f166e64f6
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fdb1cd4c4
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.fdfd6bc54
    }

    public bool IsForwardCheckingSupported()
    {
        return false;
    }

    public void SetParameter(string P0, object P1)
    {
    }

}
