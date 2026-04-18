namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface FusedLocationProviderApi {

    @java.lang.Deprecated
    public static readonly java.lang.string KEY_LOCATION_CHANGED = "com.google.android.location.LOCATION";

    @java.lang.Deprecated
    public static readonly java.lang.string KEY_MOCK_LOCATION = "mockLocation";

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> flushLocations(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    android.location.Location getLastLocation(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    com.google.android.gms.location.LocationAvailability getLocationAvailability(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> removeLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.app.Pendingobject pendingobject);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> removeLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationCallback locationCallback);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> removeLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationListener locationListener);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> requestLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationRequest locationRequest, android.app.Pendingobject pendingobject);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> requestLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.location.LocationCallback locationCallback, android.os.Looper looper);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> requestLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.location.LocationListener locationListener);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> requestLocationUpdates(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.location.LocationListener locationListener, android.os.Looper looper);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> setMockLocation(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.location.Location location);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> setMockMode(com.google.android.gms.common.api.GoogleApiClient googleApiClient, bool z);
}

