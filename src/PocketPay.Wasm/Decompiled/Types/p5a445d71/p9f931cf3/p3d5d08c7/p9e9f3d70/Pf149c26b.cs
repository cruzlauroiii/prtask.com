namespace WillowMaze.Wasm.Decompiled;

public class Pf149c26b : CertPathValidatorSpi
{
    private readonly bool F09a57d6a;
    private readonly pb3b7fb02 F8def1af7;
    private readonly bool F94074df6;
    private readonly bool Fb62be09b;
    private readonly bool Ff2aac69c;
    private readonly pb3b7fb02 Ffde5d67b;
    private readonly bool Ffebcee75;

    private static void M244bf9be(X509Certificate P0)
    {
        // str: "unable to process TBSCertificate"
        // call: X509Certificate.getTBSCertificate
        // call: p8420911c.m8bab0102
        // call: IllegalArgumentException.getMessage
        // call: p352d4243.<init>
        // call: p81e4e5be.getTBSCertificateNative
        // type: p352d4243
    }

    public CertPathValidatorResult EngineValidate(CertPath P0, CertPathParameters P1)
    {
        return default!;
    }

}
