namespace WillowMaze.Wasm.Decompiled;

public class P73d7b518 : CertSelector, P0c3cd33e
{
    private readonly p0fd1bdf1 F17844ae5;
    private readonly p0fd1bdf1 F3fcdb73d;
    private readonly p0fd1bdf1 F90a62ca8;
    private readonly p0fd1bdf1 Fac969c6a;

    private object[] M03200c1c()
    {
        // str: "badly formed Name object"
        // call: pfb202cf8.getNames
        // call: List<object>.size
        // call: List<object>.toArray
        // call: pf17d2ecd.getName
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: X500Principal.<init>
        // call: List<object>.add
        // call: pbbb64546.getIssuerName
        // call: pf17d2ecd.getTagNo
        // call: List<object>.<init>
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p73d7b518.f3fcdb73d
        // type: Exception
        // type: X500Principal
        // type: List<object>
        return default!;
    }

    private bool M04117a1f(X500Principal P0, pfb202cf8 P1)
    {
        // call: pf17d2ecd.getTagNo
        // call: pf17d2ecd.getName
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: X500Principal.<init>
        // call: X500Principal.equals
        // call: pfb202cf8.getNames
        // type: X500Principal
        return false;
    }

    public object Clone()
    {
        // call: p73d7b518.<init>
        // call: p62663704.m8bab0102
        // field: p5a445d71.p9f931cf3.pdacfecb5.p73d7b518.f3fcdb73d
        // type: p73d7b518
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: object.equals
        // field: p5a445d71.p9f931cf3.pdacfecb5.p73d7b518.f3fcdb73d
        return false;
    }

    public Principal[] GetPrincipals()
    {
        // call: List<object>.size
        // call: List<object>.add
        // call: p73d7b518.m03200c1c
        // call: List<object>.toArray
        // call: List<object>.<init>
        // type: List<object>
        return default!;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // field: p5a445d71.p9f931cf3.pdacfecb5.p73d7b518.f3fcdb73d
        return 0;
    }

    public bool Match(object P0)
    {
        // call: p73d7b518.match
        return false;
    }

    public bool Match(Certificate P0)
    {
        // call: pcaf0afb6.getIssuer
        // call: pbbb64546.getBaseCertificateID
        // call: p73d7b518.m04117a1f
        // call: pcaf0afb6.getSerial
        // call: X509Certificate.getSubjectX500Principal
        // call: X509Certificate.getSerialNumber
        // call: pf391b73d.hasValue
        // call: X509Certificate.getIssuerX500Principal
        // call: pbbb64546.getIssuerName
        // field: p5a445d71.p9f931cf3.pdacfecb5.p73d7b518.f3fcdb73d
        return false;
    }

}
