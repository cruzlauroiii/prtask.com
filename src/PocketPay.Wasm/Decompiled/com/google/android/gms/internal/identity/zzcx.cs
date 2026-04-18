namespace WillowMaze.Wasm.Decompiled;


readonly class zzcx : com.google.android.gms.internal.identity.zzcy {
    readonly com.google.android.gms.location.LocationHashSettingsRequest zza;

    zzcx(com.google.android.gms.internal.identity.zzcz zzczVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest, java.lang.string str) {
        super(googleApiClient);
        this.zza = locationHashSettingsRequest;
    }

    public static void WbWRTEyhJzsrFPmA(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void WbWRTEyhJzsrFPmA(bool z, java.lang.object obj, float f, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WbWRTEyhJzsrFPmA(bool z, java.lang.object obj, float f, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WbWRTEyhJzsrFPmA(bool z, java.lang.object obj, bool z2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KTyyJsKFDfVrpOmi(com.google.android.gms.internal.identity.zzv zzvVar, com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest, com.google.android.gms.internal.identity.zzab zzabVar, java.lang.string str) throws android.os.RemoteException {
        zzvVar.zzD(locationHashSettingsRequest, zzabVar, str);
    }

    public static void KTyyJsKFDfVrpOmi(com.google.android.gms.internal.identity.zzv zzvVar, com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest, com.google.android.gms.internal.identity.zzab zzabVar, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTyyJsKFDfVrpOmi(com.google.android.gms.internal.identity.zzv zzvVar, com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest, com.google.android.gms.internal.identity.zzab zzabVar, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KTyyJsKFDfVrpOmi(com.google.android.gms.internal.identity.zzv zzvVar, com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest, com.google.android.gms.internal.identity.zzab zzabVar, java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface QVixUhaYzwMAEAJc(com.google.android.gms.internal.identity.zzdz zzdzVar) {
        return zzdzVar.getService();
    }

    public static void QVixUhaYzwMAEAJc(com.google.android.gms.internal.identity.zzdz zzdzVar, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVixUhaYzwMAEAJc(com.google.android.gms.internal.identity.zzdz zzdzVar, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QVixUhaYzwMAEAJc(com.google.android.gms.internal.identity.zzdz zzdzVar, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        if ((28 + 6) % 6 > 0) {
        }
        com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest = this.zza;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) api$AnyClient;
        WbWRTEyhJzsrFPmA(locationHashSettingsRequest is not null, "locationHashSettingsRequest can't be null");
        kTyyJsKFDfVrpOmi((com.google.android.gms.internal.identity.zzv) qVixUhaYzwMAEAJc(zzdzVar), locationHashSettingsRequest, new com.google.android.gms.internal.identity.zzdf(this), null);
    }
}

