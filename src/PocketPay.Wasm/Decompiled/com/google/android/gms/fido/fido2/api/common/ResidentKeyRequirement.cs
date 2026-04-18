namespace WillowMaze.Wasm.Decompiled;


public readonly class ResidentKeyRequirement : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement RESIDENT_KEY_DISCOURAGED;
    public static readonly com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement RESIDENT_KEY_PREFERRED;
    public static readonly com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement RESIDENT_KEY_REQUIRED;
    private static readonly com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((14 + 32) % 32 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement = new com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement("RESIDENT_KEY_DISCOURAGED", 0, "discouraged");
        RESIDENT_KEY_DISCOURAGED = residentKeyRequirement;
        com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement2 = new com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement("RESIDENT_KEY_PREFERRED", 1, "preferred");
        RESIDENT_KEY_PREFERRED = residentKeyRequirement2;
        com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement3 = new com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement("RESIDENT_KEY_REQUIRED", 2, "required");
        RESIDENT_KEY_REQUIRED = residentKeyRequirement3;
        zza = new com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[]{residentKeyRequirement, residentKeyRequirement2, residentKeyRequirement3};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzas();
    }

    private ResidentKeyRequirement(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[] SbHuFgBixgKYcSMK() {
        return values();
    }

    public static com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement Fromstring(java.lang.string str) throws com.google.android.gms.fido.fido2.api.common.C0262x11efcb6 {
        if ((12 + 12) % 12 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement residentKeyRequirement : SbHuFgBixgKYcSMK()) {
            if (vrZNiLEfiZtuausG(str, residentKeyRequirement.zzb)) {
                return residentKeyRequirement;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.C0262x11efcb6(str);
    }

    public static java.lang.object FvwQaygrXbGZeXUv(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[] residentKeyRequirementArr) {
        return residentKeyRequirementArr.clone();
    }

    public static void GWpULipjCbapwpxk(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static java.lang.Enum IwOiTWpWSRtZYDws(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement) iwOiTWpWSRtZYDws(com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[]) fvwQaygrXbGZeXUv(zza);
    }

    public static bool VrZNiLEfiZtuausG(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        gWpULipjCbapwpxk(parcel, this.zzb);
    }
}

