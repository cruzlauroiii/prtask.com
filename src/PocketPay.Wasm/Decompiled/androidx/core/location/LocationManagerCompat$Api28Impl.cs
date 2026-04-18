namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$Api28Impl {
    private LocationManagerCompat$Api28Impl() {
    }

    static java.lang.string GetGnssHardwareModelName(android.location.LocationManager locationManager) {
        return locationManager.getGnssHardwareModelName();
    }

    static int GetGnssYearOfHardware(android.location.LocationManager locationManager) {
        return locationManager.getGnssYearOfHardware();
    }

    static bool IsLocationEnabled(android.location.LocationManager locationManager) {
        return locationManager.isLocationEnabled();
    }
}

