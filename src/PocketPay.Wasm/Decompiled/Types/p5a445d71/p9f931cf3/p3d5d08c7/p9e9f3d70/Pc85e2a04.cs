namespace WillowMaze.Wasm.Decompiled;

public class Pc85e2a04 : CertPathValidatorSpi
{
    private readonly bool F26da74c2;
    private readonly pb3b7fb02 F3f7370b1;
    private readonly bool F773df24f;
    private readonly pb3b7fb02 Ffde5d67b;
    private readonly bool Ffebcee75;

    private static void M244bf9be(X509Certificate P0)
    {
        // str: "unable to process TBSCertificate"
        // call: X509Certificate.getTBSCertificate
        // call: p8420911c.m8bab0102
        // call: IllegalArgumentException.getMessage
        // call: p81e4e5be.getTBSCertificateNative
        // call: p352d4243.<init>
        // type: p352d4243
    }

    public CertPathChecker EngineGetRevocationChecker()
    {
        // call: pc85e2a04.engineGetRevocationChecker
        return default!;
    }

    public PKIXCertPathChecker EngineGetRevocationChecker()
    {
        // call: p3a8bd746.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc85e2a04.ffde5d67b
        // type: p3a8bd746
        return default!;
    }

    public CertPathValidatorResult EngineValidate(CertPath P0, CertPathParameters P1)
    {
        // str: "Version 1 certificates can't be used as CA ones."
        // str: "Trust anchor for certification path not found."
        // str: "only one PKIXRevocationChecker allowed"
        // str: "Subject of trust anchor could not be (re)encoded."
        // str: "Path processing failed on policy."
        // str: "2.5.29.32.0"
        // str: " instance."
        // str: "99d5daef3c6c3f1070914ab8b902ed76258e04bbfa97de2236ce95518d71b1fd719be52a40eb53"
        // str: "trustAnchors is null, this is not allowed for certification path validation."
        // str: "Parameters must be a "
        // str: "Certification path is empty."
        // str: "Algorithm identifier of public key of trust anchor could not be read."
        // str: "Target certificate in certification path does not match targetConstraints."
        // str: "Next working key could not be retrieved."
        // call: HashSet<object>.remove
        // call: pc446fcff.getInitialPolicies
        // call: p4da36ec9.md6183fc5
        // call: p4da36ec9.m4a78792b
        // call: DecryptString.decryptString
        // call: List<object>.<init>
        // call: p3a8bd746.<init>
        // call: CertPathValidatorException.<init>
        // call: p234a7530.getAlgorithm
        // call: pc446fcff$p2bd4a59b.setTrustAnchor
        // call: HashSet<object>.<init>
        // call: p4da36ec9.m60af404a
        // call: p1dc02b40.<init>
        // call: List<object>.iterator
        // call: p352d4243.getMessage
        // call: pc446fcff.isAnyPolicyInhibited
        // call: IEnumerator<object>.hasNext
        // call: p352d4243.getUnderlyingException
        // call: p364bf33a.getId
        // call: X509Certificate.getCriticalExtensionOIDs
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0c79369d
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fb8ec8409
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc85e2a04.ffebcee75
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc85e2a04.ffde5d67b
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f4f9c212c
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968
        // type: List<object>
        // type: CertPathValidatorException
        // type: HashSet<object>
        // type: pc446fcff$p2bd4a59b
        // type: PKIXCertPathValidatorResult
        // type: p1dc02b40
        // type: p331d8902
        // type: p35fd653a
        // type: PKIXParameters
        // type: InvalidAlgorithmParameterException
        return default!;
    }

}
