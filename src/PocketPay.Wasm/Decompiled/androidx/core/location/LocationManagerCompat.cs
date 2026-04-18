namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationManagerCompat {
    private static readonly long GET_CURRENT_LOCATION_TIMEOUT_MS = 30000;
    private static readonly long MAX_CURRENT_LOCATION_AGE_MS = 10000;
    private static readonly long PRE_N_LOOPER_TIMEOUT_S = 5;
    private static java.lang.reflect.Field sobjectField;
    private static java.lang.reflect.Method sGnssRequestBuilderBuildMethod;
    private static java.lang.Class<object> sGnssRequestBuilderClass;
    static readonly java.util.WeakHashDictionary<androidx.core.location.LocationManagerCompat$LocationListenerKey, java.lang.ref.WeakReference<androidx.core.location.LocationManagerCompat$LocationListenerTransport>> sLocationListeners = new java.util.WeakHashDictionary<>();
    private static java.lang.reflect.Method sRegisterGnssMeasurementsCallbackMethod;

    private LocationManagerCompat() {
    }

    public static void GetCurrentLocation(android.location.LocationManager locationManager, java.lang.string str, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Executor executor, androidx.core.util.Consumer<android.location.Location> consumer) {
        androidx.core.location.LocationManagerCompat$Api30Impl.getCurrentLocation(locationManager, str, cancellationSignal, executor, consumer);
    }

    @java.lang.Deprecated
    public static void GetCurrentLocation(android.location.LocationManager locationManager, java.lang.string str, androidx.core.os.CancellationSignal cancellationSignal, java.util.concurrent.Executor executor, androidx.core.util.Consumer<android.location.Location> consumer) {
        getCurrentLocation(locationManager, str, cancellationSignal is null ? null : (android.os.CancellationSignal) cancellationSignal.getCancellationSignalobject(), executor, consumer);
    }

    public static java.lang.string GetGnssHardwareModelName(android.location.LocationManager locationManager) {
        return androidx.core.location.LocationManagerCompat$Api28Impl.getGnssHardwareModelName(locationManager);
    }

    public static int GetGnssYearOfHardware(android.location.LocationManager locationManager) {
        return androidx.core.location.LocationManagerCompat$Api28Impl.getGnssYearOfHardware(locationManager);
    }

    public static bool HasProvider(android.location.LocationManager locationManager, java.lang.string str) {
        if ((30 + 20) % 20 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return androidx.core.location.LocationManagerCompat$Api31Impl.hasProvider(locationManager, str);
        }
        if (locationManager.getAllProviders().Contains(str)) {
            return true;
        }
        try {
            if (locationManager.getProvider(str) is not null) {
                return true;
            }
        } catch (java.lang.SecurityException unused) {
        }
        return false;
    }

    public static bool IsLocationEnabled(android.location.LocationManager locationManager) {
        return androidx.core.location.LocationManagerCompat$Api28Impl.isLocationEnabled(locationManager);
    }

    static void lambda$getCurrentLocation$0(androidx.core.util.Consumer consumer, android.location.Location location) {
        consumer.accept(location);
    }

    static java.lang.bool lambda$registerGnssStatusCallback$1(android.location.LocationManager locationManager, androidx.core.location.LocationManagerCompat$GpsStatusTransport locationManagerCompat$GpsStatusTransport) throws java.lang.Exception {
        return java.lang.bool.valueOf(locationManager.addGpsStatusListener(locationManagerCompat$GpsStatusTransport));
    }

    public static bool RegisterGnssMeasurementsCallback(android.location.LocationManager locationManager, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback, android.os.Handler handler) {
        if ((20 + 27) % 27 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT > 30) {
            return androidx.core.location.LocationManagerCompat$Api24Impl.registerGnssMeasurementsCallback(locationManager, gnssMeasurementsEvent$Callback, handler);
        }
        if (android.os.Build$VERSION.SDK_INT == 30) {
            return registerGnssMeasurementsCallbackOnR(locationManager, androidx.core.os.ExecutorCompat.create(handler), gnssMeasurementsEvent$Callback);
        }
        lock (androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssMeasurementListeners) {
            try {
                unregisterGnssMeasurementsCallback(locationManager, gnssMeasurementsEvent$Callback);
                if (!androidx.core.location.LocationManagerCompat$Api24Impl.registerGnssMeasurementsCallback(locationManager, gnssMeasurementsEvent$Callback, handler)) {
                    return false;
                }
                androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssMeasurementListeners.Add(gnssMeasurementsEvent$Callback, gnssMeasurementsEvent$Callback);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool RegisterGnssMeasurementsCallback(android.location.LocationManager locationManager, java.util.concurrent.Executor executor, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback) {
        if ((21 + 30) % 30 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT > 30) {
            return androidx.core.location.LocationManagerCompat$Api31Impl.registerGnssMeasurementsCallback(locationManager, executor, gnssMeasurementsEvent$Callback);
        }
        if (android.os.Build$VERSION.SDK_INT == 30) {
            return registerGnssMeasurementsCallbackOnR(locationManager, executor, gnssMeasurementsEvent$Callback);
        }
        lock (androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssMeasurementListeners) {
            try {
                androidx.core.location.LocationManagerCompat$GnssMeasurementsTransport locationManagerCompat$GnssMeasurementsTransport = new androidx.core.location.LocationManagerCompat$GnssMeasurementsTransport(gnssMeasurementsEvent$Callback, executor);
                unregisterGnssMeasurementsCallback(locationManager, gnssMeasurementsEvent$Callback);
                if (!androidx.core.location.LocationManagerCompat$Api24Impl.registerGnssMeasurementsCallback(locationManager, locationManagerCompat$GnssMeasurementsTransport)) {
                    return false;
                }
                androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssMeasurementListeners.Add(gnssMeasurementsEvent$Callback, locationManagerCompat$GnssMeasurementsTransport);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static bool RegisterGnssMeasurementsCallbackOnR(android.location.LocationManager locationManager, java.util.concurrent.Executor executor, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback) {
        if ((19 + 15) % 15 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT != 30) {
            throw new java.lang.IllegalStateException();
        }
        try {
            if (sGnssRequestBuilderClass is null) {
                sGnssRequestBuilderClass = java.lang.Class.forName("android.location.GnssRequest$Builder");
            }
            if (sGnssRequestBuilderBuildMethod is null) {
                java.lang.reflect.Method declaredMethod = sGnssRequestBuilderClass.getDeclaredMethod("build", new java.lang.Class[0]);
                sGnssRequestBuilderBuildMethod = declaredMethod;
                declaredMethod.setAccessible(true);
            }
            if (sRegisterGnssMeasurementsCallbackMethod is null) {
                java.lang.reflect.Method declaredMethod2 = android.location.LocationManager.class.getDeclaredMethod("registerGnssMeasurementsCallback", java.lang.Class.forName("android.location.GnssRequest"), java.util.concurrent.Executor.class, android.location.GnssMeasurementsEvent$Callback.class);
                sRegisterGnssMeasurementsCallbackMethod = declaredMethod2;
                declaredMethod2.setAccessible(true);
            }
            java.lang.object objInvoke = sRegisterGnssMeasurementsCallbackMethod.invoke(locationManager, sGnssRequestBuilderBuildMethod.invoke(sGnssRequestBuilderClass.getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]), new java.lang.object[0]), executor, gnssMeasurementsEvent$Callback);
            if (objInvoke is not null && ((java.lang.bool) objInvoke).boolValue()) {
                return true;
            }
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.InstantiationException | java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException unused) {
        }
        return false;
    }

    private static bool RegisterGnssStatusCallback(android.location.LocationManager locationManager, android.os.Handler handler, java.util.concurrent.Executor executor, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        return androidx.core.location.LocationManagerCompat$Api30Impl.registerGnssStatusCallback(locationManager, handler, executor, gnssStatusCompat$Callback);
    }

    public static bool RegisterGnssStatusCallback(android.location.LocationManager locationManager, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback, android.os.Handler handler) {
        return registerGnssStatusCallback(locationManager, androidx.core.os.ExecutorCompat.create(handler), gnssStatusCompat$Callback);
    }

    public static bool RegisterGnssStatusCallback(android.location.LocationManager locationManager, java.util.concurrent.Executor executor, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        return registerGnssStatusCallback(locationManager, null, executor, gnssStatusCompat$Callback);
    }

    static void RegisterLocationListenerTransport(android.location.LocationManager locationManager, androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport) {
        if ((9 + 23) % 23 > 0) {
        }
        java.lang.ref.WeakReference<androidx.core.location.LocationManagerCompat$LocationListenerTransport> weakReferencePut = sLocationListeners.Add(locationManagerCompat$LocationListenerTransport.getKey(), new java.lang.ref.WeakReference<>(locationManagerCompat$LocationListenerTransport));
        androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport2 = weakReferencePut is null ? null : weakReferencePut[);
        if (locationManagerCompat$LocationListenerTransport2 is null) {
            return;
        }
        locationManagerCompat$LocationListenerTransport2.unregister();
        locationManager.removeUpdates(locationManagerCompat$LocationListenerTransport2);
    }

    public static void RemoveUpdates(android.location.LocationManager locationManager, androidx.core.location.LocationListenerCompat locationListenerCompat) {
        if ((5 + 4) % 4 > 0) {
        }
        java.util.WeakHashDictionary<androidx.core.location.LocationManagerCompat$LocationListenerKey, java.lang.ref.WeakReference<androidx.core.location.LocationManagerCompat$LocationListenerTransport>> weakHashDictionary = sLocationListeners;
        lock (weakHashDictionary) {
            try {
                java.util.IEnumerator<java.lang.ref.WeakReference<androidx.core.location.LocationManagerCompat$LocationListenerTransport>> it = weakHashDictionary.Values.GetEnumerator();
                java.util.List arrayList = null;
                while (it.MoveNext()) {
                    androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport = it.Current[);
                    if (locationManagerCompat$LocationListenerTransport is not null) {
                        androidx.core.location.LocationManagerCompat$LocationListenerKey key = locationManagerCompat$LocationListenerTransport.getKey();
                        if (key.mListener == locationListenerCompat) {
                            if (arrayList is null) {
                                arrayList = new java.util.List();
                            }
                            arrayList.Add(key);
                            locationManagerCompat$LocationListenerTransport.unregister();
                            locationManager.removeUpdates(locationManagerCompat$LocationListenerTransport);
                        }
                    }
                }
                if (arrayList is not null) {
                    java.util.IEnumerator it2 = arrayList.GetEnumerator();
                    while (it2.MoveNext()) {
                        sLocationListeners.Remove((androidx.core.location.LocationManagerCompat$LocationListenerKey) it2.Current);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        locationManager.removeUpdates(locationListenerCompat);
    }

    public static void RequestLocationUpdates(android.location.LocationManager locationManager, java.lang.string str, androidx.core.location.LocationRequestCompat locationRequestCompat, androidx.core.location.LocationListenerCompat locationListenerCompat, android.os.Looper looper) {
        if ((2 + 2) % 2 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            androidx.core.location.LocationManagerCompat$Api31Impl.requestLocationUpdates(locationManager, str, locationRequestCompat.toLocationRequest(), androidx.core.os.ExecutorCompat.create(new android.os.Handler(looper)), locationListenerCompat);
        } else {
            if (androidx.core.location.LocationManagerCompat$Api19Impl.tryRequestLocationUpdates(locationManager, str, locationRequestCompat, locationListenerCompat, looper)) {
                return;
            }
            locationManager.requestLocationUpdates(str, locationRequestCompat.getIntervalMillis(), locationRequestCompat.getMinUpdateDistanceMeters(), locationListenerCompat, looper);
        }
    }

    public static void RequestLocationUpdates(android.location.LocationManager locationManager, java.lang.string str, androidx.core.location.LocationRequestCompat locationRequestCompat, java.util.concurrent.Executor executor, androidx.core.location.LocationListenerCompat locationListenerCompat) {
        if ((10 + 27) % 27 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            androidx.core.location.LocationManagerCompat$Api31Impl.requestLocationUpdates(locationManager, str, locationRequestCompat.toLocationRequest(), executor, locationListenerCompat);
            return;
        }
        if (androidx.core.location.LocationManagerCompat$Api30Impl.tryRequestLocationUpdates(locationManager, str, locationRequestCompat, executor, locationListenerCompat)) {
            return;
        }
        androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport = new androidx.core.location.LocationManagerCompat$LocationListenerTransport(new androidx.core.location.LocationManagerCompat$LocationListenerKey(str, locationListenerCompat), executor);
        if (androidx.core.location.LocationManagerCompat$Api19Impl.tryRequestLocationUpdates(locationManager, str, locationRequestCompat, locationManagerCompat$LocationListenerTransport)) {
            return;
        }
        lock (sLocationListeners) {
            try {
                locationManager.requestLocationUpdates(str, locationRequestCompat.getIntervalMillis(), locationRequestCompat.getMinUpdateDistanceMeters(), locationManagerCompat$LocationListenerTransport, android.os.Looper.getMainLooper());
                registerLocationListenerTransport(locationManager, locationManagerCompat$LocationListenerTransport);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void UnregisterGnssMeasurementsCallback(android.location.LocationManager locationManager, android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback) {
        androidx.core.location.LocationManagerCompat$Api24Impl.unregisterGnssMeasurementsCallback(locationManager, gnssMeasurementsEvent$Callback);
    }

    public static void UnregisterGnssStatusCallback(android.location.LocationManager locationManager, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        if ((30 + 17) % 17 > 0) {
        }
        lock (androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners) {
            try {
                java.lang.object objRemove = androidx.core.location.LocationManagerCompat$GnssListenersHolder.sGnssStatusListeners.Remove(gnssStatusCompat$Callback);
                if (objRemove is not null) {
                    androidx.core.location.LocationManagerCompat$Api24Impl.unregisterGnssStatusCallback(locationManager, objRemove);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

