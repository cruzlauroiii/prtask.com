namespace WillowMaze.Wasm.Decompiled;


public readonly class TokenBinding$TokenBindingStatus : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus NOT_SUPPORTED;
    public static readonly com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus PRESENT;
    public static readonly com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus SUPPORTED;
    private static readonly com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((15 + 9) % 9 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus = new com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus("PRESENT", 0, "present");
        PRESENT = tokenBinding$TokenBindingStatus;
        com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus2 = new com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus("SUPPORTED", 1, "supported");
        SUPPORTED = tokenBinding$TokenBindingStatus2;
        com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus3 = new com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus("NOT_SUPPORTED", 2, "not-supported");
        NOT_SUPPORTED = tokenBinding$TokenBindingStatus3;
        zza = new com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[]{tokenBinding$TokenBindingStatus, tokenBinding$TokenBindingStatus2, tokenBinding$TokenBindingStatus3};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzat();
    }

    private TokenBinding$TokenBindingStatus(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static java.lang.Enum IiLKLngybLOofGhq(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void VBPsnZONgjaokgJH(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static bool YHlbykmXseBqDoDX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus fromstring(java.lang.string str) throws com.google.android.gms.fido.fido2.api.common.TokenBinding$UnsupportedTokenBindingStatusException {
        if ((20 + 17) % 17 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus tokenBinding$TokenBindingStatus : zCtbcvYGvePpukqx()) {
            if (YHlbykmXseBqDoDX(str, tokenBinding$TokenBindingStatus.zzb)) {
                return tokenBinding$TokenBindingStatus;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.TokenBinding$UnsupportedTokenBindingStatusException(str);
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus valueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus) IiLKLngybLOofGhq(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[] values() {
        return (com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[]) xRnNRxvlPtjMwwZB(zza);
    }

    public static java.lang.object XRnNRxvlPtjMwwZB(com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[] tokenBinding$TokenBindingStatusArr) {
        return tokenBinding$TokenBindingStatusArr.clone();
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[] zCtbcvYGvePpukqx() {
        return values();
    }

    public override int DescribeContents() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        VBPsnZONgjaokgJH(parcel, this.zzb);
    }
}

