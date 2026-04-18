namespace WillowMaze.Wasm.Decompiled;


readonly class zzdp : com.google.android.gms.common.api.internal.ListenerHolder$Notifier {
    readonly com.google.android.gms.location.DeviceOrientation zza;

    zzdp(com.google.android.gms.internal.identity.zzdq zzdqVar, com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        this.zza = deviceOrientation;
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener, com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        deviceOrientationListener.onDeviceOrientationChanged(deviceOrientation);
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener, com.google.android.gms.location.DeviceOrientation deviceOrientation, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener, com.google.android.gms.location.DeviceOrientation deviceOrientation, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener, com.google.android.gms.location.DeviceOrientation deviceOrientation, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void NotifyListener(java.lang.object obj) {
        WoXnVuPavnuKcDld((com.google.android.gms.location.DeviceOrientationListener) obj, this.zza);
    }

    public override readonly void OnNotifyListenerFailed() {
    }
}

