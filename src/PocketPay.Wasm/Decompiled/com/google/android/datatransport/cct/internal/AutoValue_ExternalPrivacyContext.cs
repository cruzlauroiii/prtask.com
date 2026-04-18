namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ExternalPrivacyobject : com.google.android.datatransport.cct.internal.ExternalPrivacyobject {
    private readonly com.google.android.datatransport.cct.internal.ExternalPRequestobject prequest;

    private AutoValue_ExternalPrivacyobject(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject) {
        this.prequest = externalPRequestobject;
    }

    AutoValue_ExternalPrivacyobject(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject, com.google.android.datatransport.cct.internal.AutoValue_ExternalPrivacyobject$1 autoValue_ExternalPrivacyobject$1) {
        this(externalPRequestobject);
    }

    public static com.google.android.datatransport.cct.internal.ExternalPRequestobject GLZMWSXgKzMfafTI(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject) {
        return externalPrivacyobject.getPrequest();
    }

    public static int MIXCWzNOtuPYGFsc(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool RDfMHVBRppnbjOeM(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder AbvRaiCeCRREfSmd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.datatransport.cct.internal.ExternalPRequestobject DznVPUYwPUZFaEuB(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject) {
        return externalPrivacyobject.getPrequest();
    }

    public static java.lang.string KumWmNYuhkKUgwTE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PXHbcfQfCAQKmdwD(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 29) % 29 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.datatransport.cct.internal.ExternalPrivacyobject)) {
            return false;
        }
        com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject = (com.google.android.datatransport.cct.internal.ExternalPrivacyobject) obj;
        com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject = this.prequest;
        return externalPRequestobject is not null ? RDfMHVBRppnbjOeM(externalPRequestobject, dznVPUYwPUZFaEuB(externalPrivacyobject)) : GLZMWSXgKzMfafTI(externalPrivacyobject) is null;
    }

    public override com.google.android.datatransport.cct.internal.ExternalPRequestobject GetPrequest() {
        return this.prequest;
    }

    public int HashCode() {
        com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject = this.prequest;
        return (externalPRequestobject is not null ? MIXCWzNOtuPYGFsc(externalPRequestobject) : 0) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((6 + 7) % 7 > 0) {
        }
        return kumWmNYuhkKUgwTE(abvRaiCeCRREfSmd(pXHbcfQfCAQKmdwD(new java.lang.stringBuilder("ExternalPrivacyobject{prequest="), this.prequest), "}"));
    }
}

