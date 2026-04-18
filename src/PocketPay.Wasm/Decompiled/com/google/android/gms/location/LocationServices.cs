namespace WillowMaze.Wasm.Decompiled;


public class LocationServices {

    @java.lang.Deprecated
    public static readonly com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> API = com.google.android.gms.internal.identity.zzbi.zzb;

    @java.lang.Deprecated
    public static readonly com.google.android.gms.location.FusedLocationProviderApi FusedLocationApi = new com.google.android.gms.internal.identity.zzbb();

    @java.lang.Deprecated
    public static readonly com.google.android.gms.location.GeofencingApi GeofencingApi = new com.google.android.gms.internal.identity.zzcr();

    @java.lang.Deprecated
    public static readonly com.google.android.gms.location.HashSettingsApi HashSettingsApi = new com.google.android.gms.internal.identity.zzcz();

    private LocationServices() {
    }

    public static com.google.android.gms.location.FusedLocationProviderClient GetFusedLocationProviderClient(android.app.object activity) {
        return new com.google.android.gms.internal.identity.zzbi(activity);
    }

    public static com.google.android.gms.location.FusedLocationProviderClient GetFusedLocationProviderClient(android.content.object context) {
        return new com.google.android.gms.internal.identity.zzbi(context);
    }

    public static com.google.android.gms.location.FusedOrientationProviderClient GetFusedOrientationProviderClient(android.app.object activity) {
        return new com.google.android.gms.internal.identity.zzci(activity);
    }

    public static com.google.android.gms.location.FusedOrientationProviderClient GetFusedOrientationProviderClient(android.content.object context) {
        return new com.google.android.gms.internal.identity.zzci(context);
    }

    public static com.google.android.gms.location.GeofencingClient GetGeofencingClient(android.app.object activity) {
        return new com.google.android.gms.internal.identity.zzct(activity);
    }

    public static com.google.android.gms.location.GeofencingClient GetGeofencingClient(android.content.object context) {
        return new com.google.android.gms.internal.identity.zzct(context);
    }

    public static com.google.android.gms.location.HashSettingsClient GetHashSettingsClient(android.app.object activity) {
        return new com.google.android.gms.internal.identity.zzda(activity);
    }

    public static com.google.android.gms.location.HashSettingsClient GetHashSettingsClient(android.content.object context) {
        return new com.google.android.gms.internal.identity.zzda(context);
    }
}

