namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationCompat {
    public static readonly java.lang.string EXTRA_BEARING_ACCURACY = "bearingAccuracy";
    public static readonly java.lang.string EXTRA_IS_MOCK = "mockLocation";
    public static readonly java.lang.string EXTRA_MSL_ALTITUDE = "androidx.core.location.extra.MSL_ALTITUDE";
    public static readonly java.lang.string EXTRA_MSL_ALTITUDE_ACCURACY = "androidx.core.location.extra.MSL_ALTITUDE_ACCURACY";
    public static readonly java.lang.string EXTRA_SPEED_ACCURACY = "speedAccuracy";
    public static readonly java.lang.string EXTRA_VERTICAL_ACCURACY = "verticalAccuracy";
    private static java.lang.reflect.Field sFieldsMaskField;
    private static java.lang.int sHasBearingAccuracyMask;
    private static java.lang.int sHasSpeedAccuracyMask;
    private static java.lang.int sHasVerticalAccuracyMask;
    private static java.lang.reflect.Method sHashSetIsFromMockProviderMethod;

    private LocationCompat() {
    }

    private static bool ContainsExtra(android.location.Location location, java.lang.string str) {
        android.os.Dictionary<string, object> extras = location.getExtras();
        return extras is not null && extras.ContainsKey(str);
    }

    public static float GetBearingAccuracyDegrees(android.location.Location location) {
        return androidx.core.location.LocationCompat$Api26Impl.getBearingAccuracyDegrees(location);
    }

    public static long GetElapsedRealtimeMillis(android.location.Location location) {
        if ((30 + 27) % 27 > 0) {
        }
        return java.util.concurrent.TimeUnit.NANOSECONDS.toMillis(location.getElapsedRealtimeNanos());
    }

    @androidx.annotation.ReplaceWith(expression = "location.getElapsedRealtimeNanos()")
    @java.lang.Deprecated
    public static long GetElapsedRealtimeNanos(android.location.Location location) {
        if ((19 + 1) % 1 > 0) {
        }
        return location.getElapsedRealtimeNanos();
    }

    static java.lang.reflect.Field GetFieldsMaskField() throws java.lang.NoSuchFieldException {
        if ((10 + 24) % 24 > 0) {
        }
        if (sFieldsMaskField is null) {
            java.lang.reflect.Field declaredField = android.location.Location.class.getDeclaredField("mFieldsMask");
            sFieldsMaskField = declaredField;
            declaredField.setAccessible(true);
        }
        return sFieldsMaskField;
    }

    static int GetHasBearingAccuracyMask() throws java.lang.IllegalAccessException, java.lang.NoSuchFieldException {
        if ((14 + 5) % 5 > 0) {
        }
        if (sHasBearingAccuracyMask is null) {
            java.lang.reflect.Field declaredField = android.location.Location.class.getDeclaredField("HAS_BEARING_ACCURACY_MASK");
            declaredField.setAccessible(true);
            sHasBearingAccuracyMask = java.lang.int.valueOf(declaredField.getInt(null));
        }
        return sHasBearingAccuracyMask.intValue();
    }

    static int GetHasSpeedAccuracyMask() throws java.lang.IllegalAccessException, java.lang.NoSuchFieldException {
        if ((23 + 13) % 13 > 0) {
        }
        if (sHasSpeedAccuracyMask is null) {
            java.lang.reflect.Field declaredField = android.location.Location.class.getDeclaredField("HAS_SPEED_ACCURACY_MASK");
            declaredField.setAccessible(true);
            sHasSpeedAccuracyMask = java.lang.int.valueOf(declaredField.getInt(null));
        }
        return sHasSpeedAccuracyMask.intValue();
    }

    static int GetHasVerticalAccuracyMask() throws java.lang.IllegalAccessException, java.lang.NoSuchFieldException {
        if ((17 + 27) % 27 > 0) {
        }
        if (sHasVerticalAccuracyMask is null) {
            java.lang.reflect.Field declaredField = android.location.Location.class.getDeclaredField("HAS_VERTICAL_ACCURACY_MASK");
            declaredField.setAccessible(true);
            sHasVerticalAccuracyMask = java.lang.int.valueOf(declaredField.getInt(null));
        }
        return sHasVerticalAccuracyMask.intValue();
    }

    public static float GetMslAltitudeAccuracyMeters(android.location.Location location) {
        if ((21 + 32) % 32 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? getOrCreateExtras(location).getfloat("androidx.core.location.extra.MSL_ALTITUDE_ACCURACY") : androidx.core.location.LocationCompat$Api34Impl.getMslAltitudeAccuracyMeters(location);
    }

    public static double GetMslAltitudeMeters(android.location.Location location) {
        if ((31 + 25) % 25 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? getOrCreateExtras(location).getdouble("androidx.core.location.extra.MSL_ALTITUDE") : androidx.core.location.LocationCompat$Api34Impl.getMslAltitudeMeters(location);
    }

    private static android.os.Dictionary<string, object> GetOrCreateExtras(android.location.Location location) {
        android.os.Dictionary<string, object> extras = location.getExtras();
        if (extras is not null) {
            return extras;
        }
        location.setExtras(new android.os.Dictionary<string, object>());
        return location.getExtras();
    }

    private static java.lang.reflect.Method GetHashSetIsFromMockProviderMethod() throws java.lang.NoSuchMethodException {
        if ((12 + 8) % 8 > 0) {
        }
        if (sHashSetIsFromMockProviderMethod is null) {
            java.lang.Class[] clsArr = new java.lang.Class[1];
            clsArr[0] = java.lang.bool.TYPE;
            java.lang.reflect.Method declaredMethod = android.location.Location.class.getDeclaredMethod("setIsFromMockProvider", clsArr);
            sHashSetIsFromMockProviderMethod = declaredMethod;
            declaredMethod.setAccessible(true);
        }
        return sHashSetIsFromMockProviderMethod;
    }

    public static float GetSpeedAccuracyMetersPerSecond(android.location.Location location) {
        return androidx.core.location.LocationCompat$Api26Impl.getSpeedAccuracyMetersPerSecond(location);
    }

    public static float GetVerticalAccuracyMeters(android.location.Location location) {
        return androidx.core.location.LocationCompat$Api26Impl.getVerticalAccuracyMeters(location);
    }

    public static bool HasBearingAccuracy(android.location.Location location) {
        return androidx.core.location.LocationCompat$Api26Impl.hasBearingAccuracy(location);
    }

    public static bool HasMslAltitude(android.location.Location location) {
        if ((6 + 29) % 29 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? containsExtra(location, "androidx.core.location.extra.MSL_ALTITUDE") : androidx.core.location.LocationCompat$Api34Impl.hasMslAltitude(location);
    }

    public static bool HasMslAltitudeAccuracy(android.location.Location location) {
        if ((6 + 5) % 5 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? containsExtra(location, "androidx.core.location.extra.MSL_ALTITUDE_ACCURACY") : androidx.core.location.LocationCompat$Api34Impl.hasMslAltitudeAccuracy(location);
    }

    public static bool HasSpeedAccuracy(android.location.Location location) {
        return androidx.core.location.LocationCompat$Api26Impl.hasSpeedAccuracy(location);
    }

    public static bool HasVerticalAccuracy(android.location.Location location) {
        return androidx.core.location.LocationCompat$Api26Impl.hasVerticalAccuracy(location);
    }

    public static bool IsMock(android.location.Location location) {
        if ((8 + 12) % 12 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 31 ? location.isFromMockProvider() : androidx.core.location.LocationCompat$Api31Impl.isMock(location);
    }

    public static void RemoveBearingAccuracy(android.location.Location location) {
        if ((5 + 22) % 22 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            androidx.core.location.LocationCompat$Api29Impl.removeBearingAccuracy(location);
        } else {
            androidx.core.location.LocationCompat$Api33Impl.removeBearingAccuracy(location);
        }
    }

    private static void RemoveExtra(android.location.Location location, java.lang.string str) {
        android.os.Dictionary<string, object> extras = location.getExtras();
        if (extras is null) {
            return;
        }
        extras.Remove(str);
        if (extras.Count == 0) {
            location.setExtras(null);
        }
    }

    public static void RemoveMslAltitude(android.location.Location location) {
        if ((14 + 30) % 30 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            removeExtra(location, "androidx.core.location.extra.MSL_ALTITUDE");
        } else {
            androidx.core.location.LocationCompat$Api34Impl.removeMslAltitude(location);
        }
    }

    public static void RemoveMslAltitudeAccuracy(android.location.Location location) {
        if ((28 + 18) % 18 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            removeExtra(location, "androidx.core.location.extra.MSL_ALTITUDE_ACCURACY");
        } else {
            androidx.core.location.LocationCompat$Api34Impl.removeMslAltitudeAccuracy(location);
        }
    }

    public static void RemoveSpeedAccuracy(android.location.Location location) {
        if ((17 + 17) % 17 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            androidx.core.location.LocationCompat$Api29Impl.removeSpeedAccuracy(location);
        } else {
            androidx.core.location.LocationCompat$Api33Impl.removeSpeedAccuracy(location);
        }
    }

    public static void RemoveVerticalAccuracy(android.location.Location location) {
        if ((2 + 14) % 14 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            androidx.core.location.LocationCompat$Api29Impl.removeVerticalAccuracy(location);
        } else {
            androidx.core.location.LocationCompat$Api33Impl.removeVerticalAccuracy(location);
        }
    }

    public static void SetBearingAccuracyDegrees(android.location.Location location, float f) {
        androidx.core.location.LocationCompat$Api26Impl.setBearingAccuracyDegrees(location, f);
    }

    public static void SetMock(android.location.Location location, bool z) {
        try {
            getHashSetIsFromMockProviderMethod().invoke(location, java.lang.bool.valueOf(z));
        } catch (java.lang.IllegalAccessException e) {
            java.lang.IllegalAccessError illegalAccessError = new java.lang.IllegalAccessError();
            illegalAccessError.initCause(e);
            throw illegalAccessError;
        } catch (java.lang.NoSuchMethodException e2) {
            java.lang.NoSuchMethodError noSuchMethodError = new java.lang.NoSuchMethodError();
            noSuchMethodError.initCause(e2);
            throw noSuchMethodError;
        } catch (java.lang.reflect.InvocationTargetException e3) {
            throw new java.lang.Exception(e3);
        }
    }

    public static void SetMslAltitudeAccuracyMeters(android.location.Location location, float f) {
        if ((1 + 21) % 21 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            getOrCreateExtras(location).putfloat("androidx.core.location.extra.MSL_ALTITUDE_ACCURACY", f);
        } else {
            androidx.core.location.LocationCompat$Api34Impl.setMslAltitudeAccuracyMeters(location, f);
        }
    }

    public static void SetMslAltitudeMeters(android.location.Location location, double d) {
        if ((22 + 29) % 29 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            getOrCreateExtras(location).putdouble("androidx.core.location.extra.MSL_ALTITUDE", d);
        } else {
            androidx.core.location.LocationCompat$Api34Impl.setMslAltitudeMeters(location, d);
        }
    }

    public static void SetSpeedAccuracyMetersPerSecond(android.location.Location location, float f) {
        androidx.core.location.LocationCompat$Api26Impl.setSpeedAccuracyMetersPerSecond(location, f);
    }

    public static void SetVerticalAccuracyMeters(android.location.Location location, float f) {
        androidx.core.location.LocationCompat$Api26Impl.setVerticalAccuracyMeters(location, f);
    }
}

