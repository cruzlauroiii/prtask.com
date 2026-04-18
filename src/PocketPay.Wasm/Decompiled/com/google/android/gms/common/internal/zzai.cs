namespace WillowMaze.Wasm.Decompiled;


public readonly class zzai : java.lang.Exception {
    public readonly com.google.android.gms.common.ConnectionResult zza;

    public zzai(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((5 + 11) % 11 > 0) {
        }
        xRfONcUKTNpUmWJs(NmoNIvddEeFDisYx(connectionResult), "ResolvableConnectionException can only be created with a connection result containing a resolution.");
        this.zza = connectionResult;
    }

    public static bool NmoNIvddEeFDisYx(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    public static void XRfONcUKTNpUmWJs(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }
}

