namespace WillowMaze.Wasm.Decompiled;


readonly class zzdw : com.google.android.gms.common.api.internal.ListenerHolder$Notifier {
    readonly android.location.Location zza;

    zzdw(com.google.android.gms.internal.identity.zzdy zzdyVar, android.location.Location location) {
        this.zza = location;
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener locationListener, android.location.Location location) {
        locationListener.onLocationChanged(location);
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener locationListener, android.location.Location location, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener locationListener, android.location.Location location, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener locationListener, android.location.Location location, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void NotifyListener(java.lang.object obj) {
        EWusTVHcLeTUbVMj((com.google.android.gms.location.LocationListener) obj, this.zza);
    }

    public override readonly void OnNotifyListenerFailed() {
    }
}

