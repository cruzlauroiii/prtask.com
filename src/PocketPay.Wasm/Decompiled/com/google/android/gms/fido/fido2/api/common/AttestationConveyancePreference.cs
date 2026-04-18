namespace WillowMaze.Wasm.Decompiled;


public readonly class AttestationConveyancePreference : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference DIRECT;
    public static readonly com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference INDIRECT;
    public static readonly com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference NONE;
    private static readonly com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((8 + 4) % 4 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference attestationConveyancePreference = new com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference("NONE", 0, "none");
        NONE = attestationConveyancePreference;
        com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference attestationConveyancePreference2 = new com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference("INDIRECT", 1, "indirect");
        INDIRECT = attestationConveyancePreference2;
        com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference attestationConveyancePreference3 = new com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference("DIRECT", 2, "direct");
        DIRECT = attestationConveyancePreference3;
        zza = new com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference[]{attestationConveyancePreference, attestationConveyancePreference2, attestationConveyancePreference3};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzb();
    }

    private AttestationConveyancePreference(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference Fromstring(java.lang.string str) throws com.google.android.gms.fido.fido2.api.common.C0260x5ced43e0 {
        if ((29 + 22) % 22 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference attestationConveyancePreference : pWdZaQJEeJvDLZXa()) {
            if (jILlXolOFaMGPgkT(str, attestationConveyancePreference.zzb)) {
                return attestationConveyancePreference;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.C0260x5ced43e0(str);
    }

    public static bool JILlXolOFaMGPgkT(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void LoOZDbhsBrVSJrHG(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference[] PWdZaQJEeJvDLZXa() {
        return values();
    }

    public static java.lang.object RfWBjwwBKEJJtmDk(com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference[] attestationConveyancePreferenceArr) {
        return attestationConveyancePreferenceArr.clone();
    }

    public static com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference) wfrODFKLUiAfJrJD(com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.AttestationConveyancePreference[]) rfWBjwwBKEJJtmDk(zza);
    }

    public static java.lang.Enum WfrODFKLUiAfJrJD(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        loOZDbhsBrVSJrHG(parcel, this.zzb);
    }
}

