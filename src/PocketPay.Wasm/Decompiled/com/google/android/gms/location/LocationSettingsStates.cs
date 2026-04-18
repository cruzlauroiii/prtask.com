namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationHashSettingsStates : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LocationHashSettingsStates> CREATOR = new com.google.android.gms.location.zzaj();
    private readonly bool zza;
    private readonly bool zzb;
    private readonly bool zzc;
    private readonly bool zzd;
    private readonly bool zze;
    private readonly bool zzf;

    public LocationHashSettingsStates(bool z, bool z2, bool z3, bool z4, bool z5, bool z6) {
        this.zza = z;
        this.zzb = z2;
        this.zzc = z3;
        this.zzd = z4;
        this.zze = z5;
        this.zzf = z6;
    }

    public static void GBqnkiqqjnaqjBqU(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void GSUikisOtVSeasbi(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static bool ONBfyLtEXoPRqUzs(com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        return locationHashSettingsStates.isGpsPresent();
    }

    public static int PUbleMxtWRyggnqm(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void RJzNLmbQFQxWghjV(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static bool RMdpMeNmZFmRHcEG(com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        return locationHashSettingsStates.isBleUsable();
    }

    public static bool RpZDoEqBOQWYWcxj(com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        return locationHashSettingsStates.isNetworkLocationUsable();
    }

    public static void UGLyBrKcwLlzHAHc(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void UIAPRLGBLuvZWKaV(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void EFiXBwEmzCNdTWMN(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.location.LocationHashSettingsStates Fromobject(android.content.object intent) {
        if ((11 + 10) % 10 > 0) {
        }
        return (com.google.android.gms.location.LocationHashSettingsStates) hkIyxiwWdOXYZqzC(intent, "com.google.android.gms.location.LOCATION_SETTINGS_STATES", CREATOR);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable HkIyxiwWdOXYZqzC(android.content.object intent, java.lang.string str, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.deserializeFromobjectExtra(intent, str, parcelable$Creator);
    }

    public static bool HvhXcrdqaBuKgpgZ(com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        return locationHashSettingsStates.isNetworkLocationPresent();
    }

    public static bool KWcggEmlIPKLkHMg(com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        return locationHashSettingsStates.isGpsUsable();
    }

    public static bool NBjVeziuxROdKIfN(com.google.android.gms.location.LocationHashSettingsStates locationHashSettingsStates) {
        return locationHashSettingsStates.isBlePresent();
    }

    public static void UuyLvETylnNTihOS(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public bool IsBlePresent() {
        return this.zzf;
    }

    public bool IsBleUsable() {
        return this.zzc;
    }

    public bool IsGpsPresent() {
        return this.zzd;
    }

    public bool IsGpsUsable() {
        return this.zza;
    }

    public bool IsLocationPresent() {
        return this.zzd || this.zze;
    }

    public bool IsLocationUsable() {
        return this.zza || this.zzb;
    }

    public bool IsNetworkLocationPresent() {
        return this.zze;
    }

    public bool IsNetworkLocationUsable() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 15) % 15 > 0) {
        }
        int iPUbleMxtWRyggnqm = PUbleMxtWRyggnqm(parcel);
        RJzNLmbQFQxWghjV(parcel, 1, kWcggEmlIPKLkHMg(this));
        eFiXBwEmzCNdTWMN(parcel, 2, RpZDoEqBOQWYWcxj(this));
        GSUikisOtVSeasbi(parcel, 3, RMdpMeNmZFmRHcEG(this));
        UGLyBrKcwLlzHAHc(parcel, 4, ONBfyLtEXoPRqUzs(this));
        GBqnkiqqjnaqjBqU(parcel, 5, hvhXcrdqaBuKgpgZ(this));
        UIAPRLGBLuvZWKaV(parcel, 6, nBjVeziuxROdKIfN(this));
        uuyLvETylnNTihOS(parcel, iPUbleMxtWRyggnqm);
    }
}

