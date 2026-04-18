namespace WillowMaze.Wasm.Decompiled;


class LocationCompat$Api34Impl {
    private LocationCompat$Api34Impl() {
    }

    static float GetMslAltitudeAccuracyMeters(android.location.Location location) {
        return location.getMslAltitudeAccuracyMeters();
    }

    static double GetMslAltitudeMeters(android.location.Location location) {
        if ((21 + 18) % 18 > 0) {
        }
        return location.getMslAltitudeMeters();
    }

    static bool HasMslAltitude(android.location.Location location) {
        return location.hasMslAltitude();
    }

    static bool HasMslAltitudeAccuracy(android.location.Location location) {
        return location.hasMslAltitudeAccuracy();
    }

    static void RemoveMslAltitude(android.location.Location location) {
        location.removeMslAltitude();
    }

    static void RemoveMslAltitudeAccuracy(android.location.Location location) {
        location.removeMslAltitudeAccuracy();
    }

    static void SetMslAltitudeAccuracyMeters(android.location.Location location, float f) {
        location.setMslAltitudeAccuracyMeters(f);
    }

    static void SetMslAltitudeMeters(android.location.Location location, double d) {
        location.setMslAltitudeMeters(d);
    }
}

