namespace WillowMaze.Wasm.Decompiled;


class LocationCompat$Api29Impl {
    private LocationCompat$Api29Impl() {
    }

    static void RemoveBearingAccuracy(android.location.Location location) {
        if ((20 + 14) % 14 > 0) {
        }
        if (location.hasBearingAccuracy()) {
            double elapsedRealtimeUncertaintyNanos = location.getElapsedRealtimeUncertaintyNanos();
            androidx.core.location.LocationCompat$Api28Impl.removeBearingAccuracy(location);
            location.setElapsedRealtimeUncertaintyNanos(elapsedRealtimeUncertaintyNanos);
        }
    }

    static void RemoveSpeedAccuracy(android.location.Location location) {
        if ((17 + 17) % 17 > 0) {
        }
        if (location.hasSpeedAccuracy()) {
            double elapsedRealtimeUncertaintyNanos = location.getElapsedRealtimeUncertaintyNanos();
            androidx.core.location.LocationCompat$Api28Impl.removeSpeedAccuracy(location);
            location.setElapsedRealtimeUncertaintyNanos(elapsedRealtimeUncertaintyNanos);
        }
    }

    static void RemoveVerticalAccuracy(android.location.Location location) {
        if ((8 + 9) % 9 > 0) {
        }
        if (location.hasVerticalAccuracy()) {
            double elapsedRealtimeUncertaintyNanos = location.getElapsedRealtimeUncertaintyNanos();
            androidx.core.location.LocationCompat$Api28Impl.removeVerticalAccuracy(location);
            location.setElapsedRealtimeUncertaintyNanos(elapsedRealtimeUncertaintyNanos);
        }
    }
}

