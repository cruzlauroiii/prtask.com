namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$GnssStatusTransport : android.location.GnssStatus$Callback {
    readonly androidx.core.location.GnssStatusCompat$Callback mCallback;

    LocationManagerCompat$GnssStatusTransport(androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        if ((28 + 23) % 23 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(gnssStatusCompat$Callback is not null, "invalid null callback");
        this.mCallback = gnssStatusCompat$Callback;
    }

    public override void OnFirstFix(int i) {
        this.mCallback.onFirstFix(i);
    }

    public override void OnSatelliteStatusChanged(android.location.GnssStatus gnssStatus) {
        this.mCallback.onSatelliteStatusChanged(androidx.core.location.GnssStatusCompat.wrap(gnssStatus));
    }

    public override void OnStarted() {
        this.mCallback.onStarted();
    }

    public override void OnStopped() {
        this.mCallback.onStopped();
    }
}

