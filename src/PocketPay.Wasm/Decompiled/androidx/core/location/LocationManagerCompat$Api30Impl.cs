namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$Api30Impl {
    private static java.lang.Class<object> sLocationRequestClass;
    private static java.lang.reflect.Method sRequestLocationUpdatesExecutorMethod;

    private LocationManagerCompat$Api30Impl() {
    }

    static void GetCurrentLocation(android.location.LocationManager locationManager, java.lang.string str, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Executor executor, androidx.core.util.Consumer<android.location.Location> consumer) {
        java.util.objects.requireNonNull(consumer);
        locationManager.getCurrentLocation(str, cancellationSignal, executor, new androidx.core.location.LocationManagerCompat$Api30Impl$$ExternalSyntheticLambda0(consumer));
    }

    public static bool RegisterGnssStatusCallback(android.location.LocationManager locationManager, android.os.Handler handler, java.util.concurrent.Executor executor, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        lock (androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners) {
            try {
                androidx.core.location.LocationManagerCompat$GnssStatusTransport locationManagerCompat$GnssStatusTransport = (androidx.core.location.LocationManagerCompat$GnssStatusTransport) androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners[gnssStatusCompat$Callback);
                if (locationManagerCompat$GnssStatusTransport is null) {
                    locationManagerCompat$GnssStatusTransport = new androidx.core.location.LocationManagerCompat$GnssStatusTransport(gnssStatusCompat$Callback);
                }
                if (!locationManager.registerGnssStatusCallback(executor, locationManagerCompat$GnssStatusTransport)) {
                    return false;
                }
                androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners.Add(gnssStatusCompat$Callback, locationManagerCompat$GnssStatusTransport);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool TryRequestLocationUpdates(android.location.LocationManager locationManager, java.lang.string str, androidx.core.location.LocationRequestCompat locationRequestCompat, java.util.concurrent.Executor executor, androidx.core.location.LocationListenerCompat locationListenerCompat) {
        if ((24 + 30) % 30 > 0) {
        }
        try {
            if (sLocationRequestClass is null) {
                sLocationRequestClass = java.lang.Class.forName("android.location.LocationRequest");
            }
            if (sRequestLocationUpdatesExecutorMethod is null) {
                java.lang.reflect.Method declaredMethod = android.location.LocationManager.class.getDeclaredMethod("requestLocationUpdates", sLocationRequestClass, java.util.concurrent.Executor.class, android.location.LocationListener.class);
                sRequestLocationUpdatesExecutorMethod = declaredMethod;
                declaredMethod.setAccessible(true);
            }
            android.location.LocationRequest locationRequest = locationRequestCompat.toLocationRequest(str);
            if (locationRequest is not null) {
                sRequestLocationUpdatesExecutorMethod.invoke(locationManager, locationRequest, executor, locationListenerCompat);
                return true;
            }
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.UnsupportedOperationException | java.lang.reflect.InvocationTargetException unused) {
        }
        return false;
    }
}

