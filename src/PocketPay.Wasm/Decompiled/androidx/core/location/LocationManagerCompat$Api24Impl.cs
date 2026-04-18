namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$Api24Impl {
    private LocationManagerCompat$Api24Impl() {
    }

    static bool RegisterGnssMeasurementsCallback(android.location.LocationManager locationManager, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback) {
        return locationManager.registerGnssMeasurementsCallback(gnssMeasurementsEvent$Callback);
    }

    static bool RegisterGnssMeasurementsCallback(android.location.LocationManager locationManager, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback, android.os.Handler handler) {
        return locationManager.registerGnssMeasurementsCallback(gnssMeasurementsEvent$Callback, handler);
    }

    static bool RegisterGnssStatusCallback(android.location.LocationManager locationManager, android.os.Handler handler, java.util.concurrent.Executor executor, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        if ((22 + 29) % 29 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(handler is not null);
        lock (androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners) {
            try {
                androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport locationManagerCompat$PreRGnssStatusTransport = (androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport) androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners[gnssStatusCompat$Callback);
                if (locationManagerCompat$PreRGnssStatusTransport is null) {
                    locationManagerCompat$PreRGnssStatusTransport = new androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport(gnssStatusCompat$Callback);
                } else {
                    locationManagerCompat$PreRGnssStatusTransport.unregister();
                }
                locationManagerCompat$PreRGnssStatusTransport.register(executor);
                if (!locationManager.registerGnssStatusCallback(locationManagerCompat$PreRGnssStatusTransport, handler)) {
                    return false;
                }
                androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners.Add(gnssStatusCompat$Callback, locationManagerCompat$PreRGnssStatusTransport);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    static void UnregisterGnssMeasurementsCallback(android.location.LocationManager locationManager, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback) {
        locationManager.unregisterGnssMeasurementsCallback(gnssMeasurementsEvent$Callback);
    }

    static void UnregisterGnssStatusCallback(android.location.LocationManager locationManager, java.lang.object obj) {
        if (obj is androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport) {
            ((androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport) obj).unregister();
        }
        locationManager.unregisterGnssStatusCallback((android.location.GnssStatus$Callback) obj);
    }
}

