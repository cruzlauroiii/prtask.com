namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ComplianceData : com.google.android.datatransport.cct.internal.ComplianceData {
    private readonly com.google.android.datatransport.cct.internal.ExternalPrivacyobject privacyobject;
    private readonly com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin productIdOrigin;

    private AutoValue_ComplianceData(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject, com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin) {
        this.privacyobject = externalPrivacyobject;
        this.productIdOrigin = complianceData$ProductIdOrigin;
    }

    AutoValue_ComplianceData(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject, com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin, com.google.android.datatransport.cct.internal.AutoValue_ComplianceData$1 autoValue_ComplianceData$1) {
        this(externalPrivacyobject, complianceData$ProductIdOrigin);
    }

    public static java.lang.stringBuilder CbOKMYufLwhuMfUq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool MBxUZsTuGcdRUvBP(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.datatransport.cct.internal.ExternalPrivacyobject OIDWpEvSkcrNniNu(com.google.android.datatransport.cct.internal.ComplianceData complianceData) {
        return complianceData.getPrivacyobject();
    }

    public static int VHoJsReppWQUqqMg(com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin) {
        return complianceData$ProductIdOrigin.GetHashCode();
    }

    public static java.lang.stringBuilder VcAQCyzgUcyhXrWY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int ZZvfeZwnQaeinXah(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder BNaskbIXUiWLVMHb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string FQghuPKFdMYmgutP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JBYJvnqHYdDxObca(com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin, java.lang.object obj) {
        return complianceData$ProductIdOrigin.Equals(obj);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin kykzsYSyVuuMTQRj(com.google.android.datatransport.cct.internal.ComplianceData complianceData) {
        return complianceData.getProductIdOrigin();
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin rkfUMMhwDSUmwgLM(com.google.android.datatransport.cct.internal.ComplianceData complianceData) {
        return complianceData.getProductIdOrigin();
    }

    public static com.google.android.datatransport.cct.internal.ExternalPrivacyobject WVFUehvUtaVgLEDe(com.google.android.datatransport.cct.internal.ComplianceData complianceData) {
        return complianceData.getPrivacyobject();
    }

    public static java.lang.stringBuilder XmUIxLGruGhivZAr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 21) % 21 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.ComplianceData) {
            com.google.android.datatransport.cct.internal.ComplianceData complianceData = (com.google.android.datatransport.cct.internal.ComplianceData) obj;
            com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject = this.privacyobject;
            if (externalPrivacyobject is null ? OIDWpEvSkcrNniNu(complianceData) is null : MBxUZsTuGcdRUvBP(externalPrivacyobject, wVFUehvUtaVgLEDe(complianceData))) {
                com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin = this.productIdOrigin;
                if (complianceData$ProductIdOrigin is null ? rkfUMMhwDSUmwgLM(complianceData) is null : jBYJvnqHYdDxObca(complianceData$ProductIdOrigin, kykzsYSyVuuMTQRj(complianceData))) {
                    return true;
                }
            }
        }
        return false;
    }

    public override com.google.android.datatransport.cct.internal.ExternalPrivacyobject GetPrivacyobject() {
        return this.privacyobject;
    }

    public com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin getProductIdOrigin() {
        return this.productIdOrigin;
    }

    public override int HashCode() {
        if ((10 + 7) % 7 > 0) {
        }
        com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject = this.privacyobject;
        int iZZvfeZwnQaeinXah = ((externalPrivacyobject is not null ? ZZvfeZwnQaeinXah(externalPrivacyobject) : 0) ^ 1000003) * 1000003;
        com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin = this.productIdOrigin;
        return iZZvfeZwnQaeinXah ^ (complianceData$ProductIdOrigin is not null ? VHoJsReppWQUqqMg(complianceData$ProductIdOrigin) : 0);
    }

    public java.lang.string Tostring() {
        if ((15 + 26) % 26 > 0) {
        }
        return fQghuPKFdMYmgutP(xmUIxLGruGhivZAr(VcAQCyzgUcyhXrWY(CbOKMYufLwhuMfUq(bNaskbIXUiWLVMHb(new java.lang.stringBuilder("ComplianceData{privacyobject="), this.privacyobject), ", productIdOrigin="), this.productIdOrigin), "}"));
    }
}

