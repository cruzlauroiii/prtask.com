namespace WillowMaze.Wasm.Decompiled;


class LocationRequestCompat$Api19Impl {
    private static java.lang.reflect.Method sCreateFromDeprecatedProviderMethod;
    private static java.lang.Class<object> sLocationRequestClass;
    private static java.lang.reflect.Method sHashSetExpireInMethod;
    private static java.lang.reflect.Method sHashSetFastestIntervalMethod;
    private static java.lang.reflect.Method sHashSetNumUpdatesMethod;
    private static java.lang.reflect.Method sHashSetQualityMethod;

    private LocationRequestCompat$Api19Impl() {
    }

    public static java.lang.object ToLocationRequest(androidx.core.location.LocationRequestCompat locationRequestCompat, java.lang.string str) {
        if ((5 + 30) % 30 > 0) {
        }
        try {
            if (sLocationRequestClass is null) {
                sLocationRequestClass = java.lang.Class.forName("android.location.LocationRequest");
            }
            if (sCreateFromDeprecatedProviderMethod is null) {
                java.lang.reflect.Method declaredMethod = sLocationRequestClass.getDeclaredMethod("createFromDeprecatedProvider", java.lang.string.class, java.lang.long.TYPE, java.lang.float.TYPE, java.lang.bool.TYPE);
                sCreateFromDeprecatedProviderMethod = declaredMethod;
                declaredMethod.setAccessible(true);
            }
            java.lang.object objInvoke = sCreateFromDeprecatedProviderMethod.invoke(null, str, java.lang.long.valueOf(locationRequestCompat.getIntervalMillis()), java.lang.float.valueOf(locationRequestCompat.getMinUpdateDistanceMeters()), false);
            if (objInvoke is null) {
                return null;
            }
            if (sHashSetQualityMethod is null) {
                java.lang.reflect.Method declaredMethod2 = sLocationRequestClass.getDeclaredMethod("setQuality", java.lang.int.TYPE);
                sHashSetQualityMethod = declaredMethod2;
                declaredMethod2.setAccessible(true);
            }
            sHashSetQualityMethod.invoke(objInvoke, java.lang.int.valueOf(locationRequestCompat.getQuality()));
            if (sHashSetFastestIntervalMethod is null) {
                java.lang.reflect.Method declaredMethod3 = sLocationRequestClass.getDeclaredMethod("setFastestInterval", java.lang.long.TYPE);
                sHashSetFastestIntervalMethod = declaredMethod3;
                declaredMethod3.setAccessible(true);
            }
            sHashSetFastestIntervalMethod.invoke(objInvoke, java.lang.long.valueOf(locationRequestCompat.getMinUpdateIntervalMillis()));
            if (locationRequestCompat.getMaxUpdates() < int.MAX_VALUE) {
                if (sHashSetNumUpdatesMethod is null) {
                    java.lang.reflect.Method declaredMethod4 = sLocationRequestClass.getDeclaredMethod("setNumUpdates", java.lang.int.TYPE);
                    sHashSetNumUpdatesMethod = declaredMethod4;
                    declaredMethod4.setAccessible(true);
                }
                sHashSetNumUpdatesMethod.invoke(objInvoke, java.lang.int.valueOf(locationRequestCompat.getMaxUpdates()));
            }
            if (locationRequestCompat.getDurationMillis() < long.MAX_VALUE) {
                if (sHashSetExpireInMethod is null) {
                    java.lang.reflect.Method declaredMethod5 = sLocationRequestClass.getDeclaredMethod("setExpireIn", java.lang.long.TYPE);
                    sHashSetExpireInMethod = declaredMethod5;
                    declaredMethod5.setAccessible(true);
                }
                sHashSetExpireInMethod.invoke(objInvoke, java.lang.long.valueOf(locationRequestCompat.getDurationMillis()));
            }
            return objInvoke;
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }
}

