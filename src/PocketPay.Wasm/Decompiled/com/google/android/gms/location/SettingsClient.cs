namespace WillowMaze.Wasm.Decompiled;


public interface HashSettingsClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    com.google.android.gms.tasks.Task<com.google.android.gms.location.LocationHashSettingsResponse> checkLocationHashSettings(com.google.android.gms.location.LocationHashSettingsRequest locationHashSettingsRequest);

    com.google.android.gms.tasks.Task<java.lang.bool> isGoogleLocationAccuracyEnabled();
}

