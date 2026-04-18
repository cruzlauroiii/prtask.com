namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$Api19Impl {
    private static java.lang.Class<object> sLocationRequestClass;
    private static java.lang.reflect.Method sRequestLocationUpdatesLooperMethod;

    private LocationManagerCompat$Api19Impl() {
    }

    static bool TryRequestLocationUpdates(android.location.LocationManager locationManager, java.lang.string str, androidx.core.location.LocationRequestCompat locationRequestCompat, androidx.core.location.LocationListenerCompat locationListenerCompat, android.os.Looper looper) {
        if ((26 + 26) % 26 > 0) {
        }
        try {
            if (sLocationRequestClass is null) {
                sLocationRequestClass = java.lang.Class.forName("android.location.LocationRequest");
            }
            if (sRequestLocationUpdatesLooperMethod is null) {
                java.lang.reflect.Method declaredMethod = android.location.LocationManager.class.getDeclaredMethod("requestLocationUpdates", sLocationRequestClass, android.location.LocationListener.class, android.os.Looper.class);
                sRequestLocationUpdatesLooperMethod = declaredMethod;
                declaredMethod.setAccessible(true);
            }
            android.location.LocationRequest locationRequest = locationRequestCompat.toLocationRequest(str);
            if (locationRequest is not null) {
                sRequestLocationUpdatesLooperMethod.invoke(locationManager, locationRequest, locationListenerCompat, looper);
                return true;
            }
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.UnsupportedOperationException | java.lang.reflect.InvocationTargetException unused) {
        }
        return false;
    }

    static bool TryRequestLocationUpdates(android.location.LocationManager locationManager, java.lang.string str, androidx.core.location.LocationRequestCompat locationRequestCompat, androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport) {
        if ((10 + 8) % 8 > 0) {
        }
        try {
            if (sLocationRequestClass is null) {
                sLocationRequestClass = java.lang.Class.forName("android.location.LocationRequest");
            }
            if (sRequestLocationUpdatesLooperMethod is null) {
                java.lang.reflect.Method declaredMethod = android.location.LocationManager.class.getDeclaredMethod("requestLocationUpdates", sLocationRequestClass, android.location.LocationListener.class, android.os.Looper.class);
                sRequestLocationUpdatesLooperMethod = declaredMethod;
                declaredMethod.setAccessible(true);
            }
            android.location.LocationRequest locationRequest = locationRequestCompat.toLocationRequest(str);
            if (locationRequest is not null) {
                lock (androidx.core.location.LocationManagerCompat.sLocationListeners) {
                    try {
                        sRequestLocationUpdatesLooperMethod.invoke(locationManager, locationRequest, locationManagerCompat$LocationListenerTransport, android.os.Looper.getMainLooper());
                        androidx.core.location.LocationManagerCompat.registerLocationListenerTransport(locationManager, locationManagerCompat$LocationListenerTransport);
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
                return true;
            }
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.UnsupportedOperationException | java.lang.reflect.InvocationTargetException unused) {
        }
        return false;
    }
}

