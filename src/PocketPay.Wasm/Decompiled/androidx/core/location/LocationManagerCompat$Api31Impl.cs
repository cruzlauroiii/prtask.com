namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$Api31Impl {
    private LocationManagerCompat$Api31Impl() {
    }

    static bool HasProvider(android.location.LocationManager locationManager, java.lang.string str) {
        return locationManager.hasProvider(str);
    }

    static bool RegisterGnssMeasurementsCallback(android.location.LocationManager locationManager, java.util.concurrent.Executor executor, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback) {
        return locationManager.registerGnssMeasurementsCallback(executor, gnssMeasurementsEvent$Callback);
    }

    static void RequestLocationUpdates(android.location.LocationManager locationManager, java.lang.string str, android.location.LocationRequest locationRequest, java.util.concurrent.Executor executor, android.location.LocationListener locationListener) {
        locationManager.requestLocationUpdates(str, locationRequest, executor, locationListener);
    }
}

