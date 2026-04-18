namespace WillowMaze.Wasm.Decompiled;

public class P69a537ea : X509CRLSelector, P0c3cd33e
{
    private pd2e37f48 F0f6b8e96;
    private byte[] F14fe3d44;
    private bool F190ca1ce;
    private byte[] F214c30d1;
    private bool F4518f980;
    private bool F4e86cb13;
    private pd2e37f48 F54f8df15;
    private byte[] F61bb77cc;
    private bool F77127a72;
    private byte[] F8177fbcd;
    private bool F8ca82c6b;
    private byte[] F9c01d816;
    private System.Numerics.BigInteger Fb241b24c;
    private pd2e37f48 Fb3858b04;
    private System.Numerics.BigInteger Fb3992278;
    private bool Fb423e420;
    private bool Fcef87c9a;
    private bool Fd87a8922;
    private bool Fd9c47f9d;
    private pd2e37f48 Fe9b53963;
    private bool Fea7406fb;

    public static p69a537ea M8bab0102(X509CRLSelector P0)
    {
        // str: "cannot create from null selector"
        // call: p69a537ea.setDateAndTime
        // call: X509CRLSelector.getIssuerNames
        // call: p69a537ea.setIssuerNames
        // call: p69a537ea.<init>
        // call: X509CRLSelector.getCertificateChecking
        // call: IOException.getMessage
        // call: p69a537ea.setMaxCRLNumber
        // call: X509CRLSelector.getMaxCRL
        // call: p69a537ea.setCertificateChecking
        // call: X509CRLSelector.getDateAndTime
        // call: X509CRLSelector.getMinCRL
        // call: X509CRLSelector.getIssuers
        // call: IllegalArgumentException.<init>
        // call: p69a537ea.setIssuers
        // call: p69a537ea.setMinCRLNumber
        // type: IllegalArgumentException
        // type: p69a537ea
        return default!;
    }

    public object Clone()
    {
        // call: p69a537ea.m8bab0102
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fcef87c9a
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f54f8df15
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f77127a72
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb423e420
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb241b24c
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f214c30d1
        return default!;
    }

    public pd2e37f48 GetAttrCertificateChecking()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f54f8df15
        return default!;
    }

    public byte[] GetIssuingDistributionPoint()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f214c30d1
        return default!;
    }

    public System.Numerics.BigInteger GetMaxBaseCRLNumber()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb241b24c
        return default!;
    }

    public bool IsCompleteCRLEnabled()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fcef87c9a
        return false;
    }

    public bool IsDeltaCRLIndicatorEnabled()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb423e420
        return false;
    }

    public bool IsIssuingDistributionPointEnabled()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f77127a72
        return false;
    }

    public bool Match(object P0)
    {
        // call: X509CRL.getExtensionValue
        // call: p364bf33a.getId
        // call: p59853fe6.m2d877539
        // call: pf391b73d.m8bab0102
        // call: p69a537ea.isCompleteCRLEnabled
        // call: X509CRLSelector.match
        // call: pff43b8de.m2a3f81d2
        // call: System.Numerics.BigInteger.compareTo
        // call: pf391b73d.getPositiveValue
        // call: p69a537ea.isDeltaCRLIndicatorEnabled
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f77127a72
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f214c30d1
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb241b24c
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        return false;
    }

    public bool Match(CRL P0)
    {
        // call: p69a537ea.match
        return false;
    }

    public void SetAttrCertificateChecking(pd2e37f48 P0)
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f54f8df15
    }

    public void SetCompleteCRLEnabled(bool P0)
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fcef87c9a
    }

    public void SetDeltaCRLIndicatorEnabled(bool P0)
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb423e420
    }

    public void SetIssuingDistributionPoint(byte[] P0)
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f214c30d1
    }

    public void SetIssuingDistributionPointEnabled(bool P0)
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.f77127a72
    }

    public void SetMaxBaseCRLNumber(System.Numerics.BigInteger P0)
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p69a537ea.fb241b24c
    }

}
