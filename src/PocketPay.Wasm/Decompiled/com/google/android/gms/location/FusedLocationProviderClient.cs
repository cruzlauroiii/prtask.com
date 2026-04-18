namespace WillowMaze.Wasm.Decompiled;


public interface FusedLocationProviderClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {

    @java.lang.Deprecated
    public static readonly java.lang.string KEY_MOCK_LOCATION = "mockLocation";

    @java.lang.Deprecated
    public static readonly java.lang.string KEY_VERTICAL_ACCURACY = "verticalAccuracy";

    com.google.android.gms.tasks.Task<java.lang.void> flushLocations();

    com.google.android.gms.tasks.Task<android.location.Location> getCurrentLocation(int i, com.google.android.gms.tasks.CancellationToken cancellationToken);

    com.google.android.gms.tasks.Task<android.location.Location> getCurrentLocation(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest, com.google.android.gms.tasks.CancellationToken cancellationToken);

    com.google.android.gms.tasks.Task<android.location.Location> getLastLocation();

    com.google.android.gms.tasks.Task<android.location.Location> getLastLocation(com.google.android.gms.location.LastLocationRequest lastLocationRequest);

    com.google.android.gms.tasks.Task<com.google.android.gms.location.LocationAvailability> getLocationAvailability();

    @java.lang.Deprecated
    com.google.android.gms.tasks.Task<java.lang.void> removeDeviceOrientationUpdates(com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener);

    com.google.android.gms.tasks.Task<java.lang.void> removeLocationUpdates(android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> removeLocationUpdates(com.google.android.gms.location.LocationCallback locationCallback);

    com.google.android.gms.tasks.Task<java.lang.void> removeLocationUpdates(com.google.android.gms.location.LocationListener locationListener);

    @java.lang.Deprecated
    com.google.android.gms.tasks.Task<java.lang.void> requestDeviceOrientationUpdates(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener, android.os.Looper looper);

    @java.lang.Deprecated
    com.google.android.gms.tasks.Task<java.lang.void> requestDeviceOrientationUpdates(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, java.util.concurrent.Executor executor, com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener);

    com.google.android.gms.tasks.Task<java.lang.void> requestLocationUpdates(com.google.android.gms.location.LocationRequest locationRequest, android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> requestLocationUpdates(com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.location.LocationCallback locationCallback, android.os.Looper looper);

    com.google.android.gms.tasks.Task<java.lang.void> requestLocationUpdates(com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.location.LocationListener locationListener, android.os.Looper looper);

    com.google.android.gms.tasks.Task<java.lang.void> requestLocationUpdates(com.google.android.gms.location.LocationRequest locationRequest, java.util.concurrent.Executor executor, com.google.android.gms.location.LocationCallback locationCallback);

    com.google.android.gms.tasks.Task<java.lang.void> requestLocationUpdates(com.google.android.gms.location.LocationRequest locationRequest, java.util.concurrent.Executor executor, com.google.android.gms.location.LocationListener locationListener);

    com.google.android.gms.tasks.Task<java.lang.void> setMockLocation(android.location.Location location);

    com.google.android.gms.tasks.Task<java.lang.void> setMockMode(bool z);
}

