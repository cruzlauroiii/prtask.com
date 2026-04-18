namespace WillowMaze.Wasm.Decompiled;


readonly class zzdt : com.google.android.gms.common.api.internal.ListenerHolder$Notifier {
    readonly com.google.android.gms.location.LocationAvailability zza;

    zzdt(com.google.android.gms.internal.identity.zzdv zzdvVar, com.google.android.gms.location.LocationAvailability locationAvailability) {
        this.zza = locationAvailability;
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationAvailability locationAvailability) {
        locationCallback.onLocationAvailability(locationAvailability);
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationAvailability locationAvailability, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationAvailability locationAvailability, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback locationCallback, com.google.android.gms.location.LocationAvailability locationAvailability, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void NotifyListener(java.lang.object obj) {
        qSGgjIUpLvQvcQoi((com.google.android.gms.location.LocationCallback) obj, this.zza);
    }

    public override readonly void OnNotifyListenerFailed() {
    }
}

