namespace WillowMaze.Wasm.Decompiled;

public class P9bcd0c1c : P0c3cd33e
{
    private readonly CRLSelector F023a185e;
    private readonly System.Numerics.BigInteger F0a26f99a;
    private readonly bool F13064680;
    private readonly bool F1d28bdc6;
    private readonly byte[] F214c30d1;
    private readonly bool F225b9f24;
    private readonly bool F41c0238d;
    private readonly byte[] F442d36c7;
    private readonly byte[] F6d905ac4;
    private readonly CRLSelector F744ac2e1;
    private readonly bool F77127a72;
    private readonly bool F8a10dc8c;
    private readonly CRLSelector Fa6fa22b9;
    private readonly System.Numerics.BigInteger Fb241b24c;
    private readonly bool Fb423e420;
    private readonly System.Numerics.BigInteger Fb6492472;
    private readonly bool Fb690899a;
    private readonly bool Fc3718ecd;
    private readonly System.Numerics.BigInteger Fc4815c96;
    private readonly CRLSelector Fc8294519;
    private readonly bool Fccb84d6e;
    private readonly CRLSelector Fce94bf2a;
    private readonly bool Fcef87c9a;
    private readonly System.Numerics.BigInteger Fda94470a;

    private static CRLSelector M13fe7af4(p9bcd0c1c P0)
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fce94bf2a
        return default!;
    }

    public static ICollection<object> M891cdc9e(p9bcd0c1c P0, CertStore P1)
    {
        // call: p9bcd0c1c$pd8a96257.<init>
        // call: CertStore.getCRLs
        // type: p9bcd0c1c$pd8a96257
        return default!;
    }

    public object Clone()
    {
        return default!;
    }

    public X509Certificate GetCertificateChecking()
    {
        // call: X509CRLSelector.getCertificateChecking
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fce94bf2a
        return default!;
    }

    public byte[] GetIssuingDistributionPoint()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.f214c30d1
        return default!;
    }

    public System.Numerics.BigInteger GetMaxBaseCRLNumber()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fb241b24c
        return default!;
    }

    public bool IsCompleteCRLEnabled()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fcef87c9a
        return false;
    }

    public bool IsDeltaCRLIndicatorEnabled()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fb423e420
        return false;
    }

    public bool IsIssuingDistributionPointEnabled()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.f77127a72
        return false;
    }

    public bool Match(object P0)
    {
        // call: p9bcd0c1c.match
        return false;
    }

    public bool Match(CRL P0)
    {
        // call: p9bcd0c1c.isDeltaCRLIndicatorEnabled
        // call: p364bf33a.getId
        // call: p9bcd0c1c.isCompleteCRLEnabled
        // call: pf391b73d.getPositiveValue
        // call: pff43b8de.m2a3f81d2
        // call: System.Numerics.BigInteger.compareTo
        // call: X509CRL.getExtensionValue
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: pf391b73d.m8bab0102
        // call: CRLSelector.match
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.f214c30d1
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fb241b24c
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.fce94bf2a
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        // field: p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.f77127a72
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        return false;
    }

}
