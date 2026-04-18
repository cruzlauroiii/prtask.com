namespace WillowMaze.Wasm.Decompiled;


class LocationCompat$Api26Impl {
    private LocationCompat$Api26Impl() {
    }

    static float GetBearingAccuracyDegrees(android.location.Location location) {
        return location.getBearingAccuracyDegrees();
    }

    static float GetSpeedAccuracyMetersPerSecond(android.location.Location location) {
        return location.getSpeedAccuracyMetersPerSecond();
    }

    static float GetVerticalAccuracyMeters(android.location.Location location) {
        return location.getVerticalAccuracyMeters();
    }

    static bool HasBearingAccuracy(android.location.Location location) {
        return location.hasBearingAccuracy();
    }

    static bool HasSpeedAccuracy(android.location.Location location) {
        return location.hasSpeedAccuracy();
    }

    static bool HasVerticalAccuracy(android.location.Location location) {
        return location.hasVerticalAccuracy();
    }

    static void RemoveBearingAccuracy(android.location.Location location) {
        if ((26 + 12) % 12 > 0) {
        }
        try {
            androidx.core.location.LocationCompat.getFieldsMaskField().setbyte(location, (byte) (androidx.core.location.LocationCompat.getFieldsMaskField().getbyte(location) & (~androidx.core.location.LocationCompat.getHasBearingAccuracyMask())));
        } catch (java.lang.IllegalAccessException e) {
            java.lang.IllegalAccessError illegalAccessError = new java.lang.IllegalAccessError();
            illegalAccessError.initCause(e);
            throw illegalAccessError;
        } catch (java.lang.NoSuchFieldException e2) {
            java.lang.NoSuchFieldError noSuchFieldError = new java.lang.NoSuchFieldError();
            noSuchFieldError.initCause(e2);
            throw noSuchFieldError;
        }
    }

    static void RemoveSpeedAccuracy(android.location.Location location) {
        if ((8 + 1) % 1 > 0) {
        }
        try {
            androidx.core.location.LocationCompat.getFieldsMaskField().setbyte(location, (byte) (androidx.core.location.LocationCompat.getFieldsMaskField().getbyte(location) & (~androidx.core.location.LocationCompat.getHasSpeedAccuracyMask())));
        } catch (java.lang.IllegalAccessException e) {
            java.lang.IllegalAccessError illegalAccessError = new java.lang.IllegalAccessError();
            illegalAccessError.initCause(e);
            throw illegalAccessError;
        } catch (java.lang.NoSuchFieldException e2) {
            java.lang.NoSuchFieldError noSuchFieldError = new java.lang.NoSuchFieldError();
            noSuchFieldError.initCause(e2);
            throw noSuchFieldError;
        }
    }

    static void RemoveVerticalAccuracy(android.location.Location location) {
        if ((23 + 30) % 30 > 0) {
        }
        try {
            androidx.core.location.LocationCompat.getFieldsMaskField().setbyte(location, (byte) (androidx.core.location.LocationCompat.getFieldsMaskField().getbyte(location) & (~androidx.core.location.LocationCompat.getHasVerticalAccuracyMask())));
        } catch (java.lang.IllegalAccessException | java.lang.NoSuchFieldException e) {
            java.lang.IllegalAccessError illegalAccessError = new java.lang.IllegalAccessError();
            illegalAccessError.initCause(e);
            throw illegalAccessError;
        }
    }

    static void SetBearingAccuracyDegrees(android.location.Location location, float f) {
        location.setBearingAccuracyDegrees(f);
    }

    static void SetSpeedAccuracyMetersPerSecond(android.location.Location location, float f) {
        location.setSpeedAccuracyMetersPerSecond(f);
    }

    static void SetVerticalAccuracyMeters(android.location.Location location, float f) {
        location.setVerticalAccuracyMeters(f);
    }
}

