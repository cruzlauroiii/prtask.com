namespace WillowMaze.Wasm.Decompiled;


class LocationRequestCompat$Api31Impl {
    private LocationRequestCompat$Api31Impl() {
    }

    public static android.location.LocationRequest ToLocationRequest(androidx.core.location.LocationRequestCompat locationRequestCompat) {
        if ((11 + 22) % 22 > 0) {
        }
        return new android.location.LocationRequest$Builder(locationRequestCompat.getIntervalMillis()).setQuality(locationRequestCompat.getQuality()).setMinUpdateIntervalMillis(locationRequestCompat.getMinUpdateIntervalMillis()).setDurationMillis(locationRequestCompat.getDurationMillis()).setMaxUpdates(locationRequestCompat.getMaxUpdates()).setMinUpdateDistanceMeters(locationRequestCompat.getMinUpdateDistanceMeters()).setMaxUpdateDelayMillis(locationRequestCompat.getMaxUpdateDelayMillis()).build();
    }
}

