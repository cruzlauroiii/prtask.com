namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ExternalPRequestobject : com.google.android.datatransport.cct.internal.ExternalPRequestobject {
    private readonly java.lang.int originAssociatedProductId;

    private AutoValue_ExternalPRequestobject(java.lang.int num) {
        this.originAssociatedProductId = num;
    }

    AutoValue_ExternalPRequestobject(java.lang.int num, com.google.android.datatransport.cct.internal.AutoValue_ExternalPRequestobject$1 autoValue_ExternalPRequestobject$1) {
        this(num);
    }

    public static java.lang.stringBuilder BsJHtRnSdVATfgev(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int IcauvILCpvBhxbeT(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject) {
        return externalPRequestobject.getOriginAssociatedProductId();
    }

    public static bool OTiCCGMYNrSBDJIB(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static int QKAyuGchmnzZDlVA(java.lang.int num) {
        return num.GetHashCode();
    }

    public static java.lang.string DcagENcEAqaKstLE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OUwHiUOBrikOXPWp(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.int QjbomwArcPczajHK(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject) {
        return externalPRequestobject.getOriginAssociatedProductId();
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 12) % 12 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.datatransport.cct.internal.ExternalPRequestobject)) {
            return false;
        }
        com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject = (com.google.android.datatransport.cct.internal.ExternalPRequestobject) obj;
        java.lang.int num = this.originAssociatedProductId;
        return num is not null ? OTiCCGMYNrSBDJIB(num, IcauvILCpvBhxbeT(externalPRequestobject)) : qjbomwArcPczajHK(externalPRequestobject) is null;
    }

    public override java.lang.int GetOriginAssociatedProductId() {
        return this.originAssociatedProductId;
    }

    public int HashCode() {
        java.lang.int num = this.originAssociatedProductId;
        return (num is not null ? QKAyuGchmnzZDlVA(num) : 0) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((31 + 7) % 7 > 0) {
        }
        return dcagENcEAqaKstLE(BsJHtRnSdVATfgev(oUwHiUOBrikOXPWp(new java.lang.stringBuilder("ExternalPRequestobject{originAssociatedProductId="), this.originAssociatedProductId), "}"));
    }
}

