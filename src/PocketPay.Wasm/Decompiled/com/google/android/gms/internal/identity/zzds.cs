namespace WillowMaze.Wasm.Decompiled;


readonly class zzds : com.google.android.gms.common.api.internal.ListenerHolder$Notifier {
    readonly com.google.android.gms.location.LocationResult zza;

    zzds(com.google.android.gms.internal.identity.zzdv zzdvVar, com.google.android.gms.location.LocationResult locationResult) {
        this.zza = locationResult;
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationResult locationResult) {
        locationCallback.onLocationResult(locationResult);
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationResult locationResult, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationResult locationResult, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationResult locationResult, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void NotifyListener(java.lang.object obj) {
        PCdAmlwUEfPoVzwk((com.google.android.gms.location.LocationCallback) obj, this.zza);
    }

    public override readonly void OnNotifyListenerFailed() {
    }
}

