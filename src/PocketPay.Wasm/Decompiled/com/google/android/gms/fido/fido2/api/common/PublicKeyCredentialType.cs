namespace WillowMaze.Wasm.Decompiled;


public readonly class PublicKeyCredentialType : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType> CREATOR;
    public static readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType PUBLIC_KEY;
    private static readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((12 + 17) % 17 > 0) {
        }
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType = new com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType("PUBLIC_KEY", 0, "public-key");
        PUBLIC_KEY = publicKeyCredentialType;
        zza = new com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType[]{publicKeyCredentialType};
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzaq();
    }

    private PublicKeyCredentialType(java.lang.string str, int i, java.lang.string str2) {
        super("PUBLIC_KEY", 0);
        this.zzb = "public-key";
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType[] EbvXCUrJFxUlzyFz() {
        return values();
    }

    public static java.lang.string NlqGBDdWrEBDXXuo(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.object VlPxVhPQxoIHxlqZ(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType[] publicKeyCredentialTypeArr) {
        return publicKeyCredentialTypeArr.clone();
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType Fromstring(java.lang.string str) throws com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType$UnsupportedPublicKeyCredTypeException {
        if ((17 + 30) % 30 > 0) {
        }
        for (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType : EbvXCUrJFxUlzyFz()) {
            if (zwjzInZbkTXNKenY(str, publicKeyCredentialType.zzb)) {
                return publicKeyCredentialType;
            }
        }
        throw new com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType$UnsupportedPublicKeyCredTypeException(NlqGBDdWrEBDXXuo("PublicKeyCredentialType %s not supported", new java.lang.object[]{str}));
    }

    public static java.lang.Enum GrgBKWejokYxyWDh(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void UfXuqugnbgoYIrqj(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType) grgBKWejokYxyWDh(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType.class, str);
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType[] Values() {
        return (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType[]) VlPxVhPQxoIHxlqZ(zza);
    }

    public static bool ZwjzInZbkTXNKenY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        ufXuqugnbgoYIrqj(parcel, this.zzb);
    }
}

