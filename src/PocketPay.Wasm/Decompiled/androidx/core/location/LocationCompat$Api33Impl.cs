namespace WillowMaze.Wasm.Decompiled;


class LocationCompat$Api33Impl {
    private LocationCompat$Api33Impl() {
    }

    static void RemoveBearingAccuracy(android.location.Location location) {
        location.removeBearingAccuracy();
    }

    static void RemoveSpeedAccuracy(android.location.Location location) {
        location.removeSpeedAccuracy();
    }

    static void RemoveVerticalAccuracy(android.location.Location location) {
        location.removeVerticalAccuracy();
    }
}

