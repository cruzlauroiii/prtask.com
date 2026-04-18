namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationHashSettingsResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Result {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LocationHashSettingsResult> CREATOR = new com.google.android.gms.location.zzai();
    private readonly com.google.android.gms.common.api.Status zza;
    private readonly com.google.android.gms.location.LocationHashSettingsStates zzb;

    public LocationHashSettingsResult(com.google.android.gms.common.api.Status status, com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        this.zza = status;
        this.zzb = locationHashSettingsStates;
    }

    public static int HaAcgCKwWTxIJSqn(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static com.google.android.gms.location.LocationHashSettingsStates JBURlWdHpOajvEmV(com.google.android.gms.location.LocationHashSettingsResult locationHashSettingsResult) {
        return locationHashSettingsResult.getLocationHashSettingsStates();
    }

    public static void OREybVMcDRsJObSw(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static com.google.android.gms.common.api.Status UvAZaGgEtPKtdwpj(com.google.android.gms.location.LocationHashSettingsResult locationHashSettingsResult) {
        return locationHashSettingsResult.getStatus();
    }

    public static void ZhfrwulsXiogFnjO(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void AjYtNEDioMdYtNiv(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public com.google.android.gms.location.LocationHashSettingsStates GetLocationHashSettingsStates() {
        return this.zzb;
    }

    public override com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((4 + 5) % 5 > 0) {
        }
        int iHaAcgCKwWTxIJSqn = HaAcgCKwWTxIJSqn(parcel);
        ZhfrwulsXiogFnjO(parcel, 1, UvAZaGgEtPKtdwpj(this), i, false);
        ajYtNEDioMdYtNiv(parcel, 2, JBURlWdHpOajvEmV(this), i, false);
        OREybVMcDRsJObSw(parcel, iHaAcgCKwWTxIJSqn);
    }
}

