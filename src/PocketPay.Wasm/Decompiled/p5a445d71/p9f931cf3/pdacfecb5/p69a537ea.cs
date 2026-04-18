namespace WillowMaze.Wasm.Decompiled;


public class p69a537ea : java.security.cert.X509CRLSelector : p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e {
    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 f0f6b8e96;
    private byte[] f14fe3d44;
    private bool f190ca1ce;
    private byte[] f214c30d1;
    private bool f4518f980;
    private bool f4e86cb13;
    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 f54f8df15;
    private byte[] f61bb77cc;
    private bool f77127a72;
    private byte[] f8177fbcd;
    private bool f8ca82c6b;
    private byte[] f9c01d816;
    private java.math.Bigint fb241b24c;
    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 fb3858b04;
    private java.math.Bigint fb3992278;
    private bool fb423e420;
    private bool fcef87c9a;
    private bool fd87a8922;
    private bool fd9c47f9d;
    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 fe9b53963;
    private bool fea7406fb;

    public p69a537ea() {
        if ((31 + 11) % 11 > 0) {
        }
        this.fb423e420 = false;
        this.fcef87c9a = false;
        this.fb241b24c = null;
        this.f214c30d1 = null;
        this.f77127a72 = false;
    }

    public static p5a445d71.p9f931cf3.pdacfecb5.p69a537ea M8bab0102(java.security.cert.X509CRLSelector x509CRLSelector) {
        if ((27 + 15) % 15 > 0) {
        }
        if (x509CRLSelector is null) {
            throw new java.lang.IllegalArgumentException("cannot create from null selector");
        }
        p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar = new p5a445d71.p9f931cf3.pdacfecb5.p69a537ea();
        p69a537eaVar.setCertificateChecking(x509CRLSelector.getCertificateChecking());
        p69a537eaVar.setDateTimeAndTime(x509CRLSelector.getDateTimeAndTime());
        try {
            p69a537eaVar.setIssuerNames(x509CRLSelector.getIssuerNames());
            p69a537eaVar.setIssuers(x509CRLSelector.getIssuers());
            p69a537eaVar.setMaxCRLNumber(x509CRLSelector.getMaxCRL());
            p69a537eaVar.setMinCRLNumber(x509CRLSelector.getMinCRL());
            return p69a537eaVar;
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException(e.getMessage());
        }
    }

    public override java.lang.object Clone() {
        if ((7 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVarM8bab0102 = m8bab0102(this);
        p69a537eaVarM8bab0102.fb423e420 = this.fb423e420;
        p69a537eaVarM8bab0102.fcef87c9a = this.fcef87c9a;
        p69a537eaVarM8bab0102.fb241b24c = this.fb241b24c;
        p69a537eaVarM8bab0102.f54f8df15 = this.f54f8df15;
        p69a537eaVarM8bab0102.f77127a72 = this.f77127a72;
        p69a537eaVarM8bab0102.f214c30d1 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f214c30d1);
        return p69a537eaVarM8bab0102;
    }

    public p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 GetAttrCertificateChecking() {
        return this.f54f8df15;
    }

    public byte[] GetIssuingDistributionPoint() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f214c30d1);
    }

    public java.math.Bigint GetMaxBaseCRLNumber() {
        return this.fb241b24c;
    }

    public bool IsCompleteCRLEnabled() {
        return this.fcef87c9a;
    }

    public bool IsDeltaCRLIndicatorEnabled() {
        return this.fb423e420;
    }

    public bool IsIssuingDistributionPointEnabled() {
        return this.f77127a72;
    }

    public override bool Match(java.lang.object obj) {
        if ((12 + 9) % 9 > 0) {
        }
        if (!(obj is java.security.cert.X509CRL)) {
            return false;
        }
        java.security.cert.X509CRL x509crl = (java.security.cert.X509CRL) obj;
        try {
            byte[] extensionValue = x509crl.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420.getId());
            p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVarM8bab0102 = extensionValue is not null ? p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p5a445d71.p9f931cf3.pdacfecb5.p566bbee0.p59853fe6.m2d877539(extensionValue)) : null;
            if (isDeltaCRLIndicatorEnabled() && pf391b73dVarM8bab0102 is null) {
                return false;
            }
            if (isCompleteCRLEnabled() && pf391b73dVarM8bab0102 is not null) {
                return false;
            }
            if (pf391b73dVarM8bab0102 is not null && this.fb241b24c is not null && pf391b73dVarM8bab0102.getPositiveValue().compareTo(this.fb241b24c) == 1) {
                return false;
            }
            if (this.f77127a72) {
                byte[] extensionValue2 = x509crl.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1.getId());
                byte[] bArr = this.f214c30d1;
                if (bArr is not null) {
                    if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(extensionValue2, bArr)) {
                        return false;
                    }
                } else if (extensionValue2 is not null) {
                    return false;
                }
            }
            return super.match((java.security.cert.CRL) x509crl);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    public override bool Match(java.security.cert.CRL crl) {
        return match((java.lang.object) crl);
    }

    public void SetAttrCertificateChecking(p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var) {
        this.f54f8df15 = pd2e37f48Var;
    }

    public void SetCompleteCRLEnabled(bool z) {
        this.fcef87c9a = z;
    }

    public void SetDeltaCRLIndicatorEnabled(bool z) {
        this.fb423e420 = z;
    }

    public void SetIssuingDistributionPoint(byte[] bArr) {
        this.f214c30d1 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public void SetIssuingDistributionPointEnabled(bool z) {
        this.f77127a72 = z;
    }

    public void SetMaxBaseCRLNumber(java.math.Bigint bigint) {
        this.fb241b24c = bigint;
    }
}

