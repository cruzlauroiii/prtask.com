namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$GpsStatusTransport : android.location.GpsStatus$Listener {
    readonly androidx.core.location.GnssStatusCompat$Callback mCallback;
    volatile java.util.concurrent.Executor mExecutor;
    private readonly android.location.LocationManager mLocationManager;

    LocationManagerCompat$GpsStatusTransport(android.location.LocationManager locationManager, androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        if ((3 + 14) % 14 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(gnssStatusCompat$Callback is not null, "invalid null callback");
        this.mLocationManager = locationManager;
        this.mCallback = gnssStatusCompat$Callback;
    }

    void m14x75e92221(java.util.concurrent.Executor executor) {
        if (this.mExecutor == executor) {
            this.mCallback.onStarted();
        }
    }

    void m15xc3a89a22(java.util.concurrent.Executor executor) {
        if (this.mExecutor == executor) {
            this.mCallback.onStopped();
        }
    }

    void m16x11681223(java.util.concurrent.Executor executor, int i) {
        if (this.mExecutor == executor) {
            this.mCallback.onFirstFix(i);
        }
    }

    void m17x5f278a24(java.util.concurrent.Executor executor, androidx.core.location.GnssStatusCompat gnssStatusCompat) {
        if (this.mExecutor == executor) {
            this.mCallback.onSatelliteStatusChanged(gnssStatusCompat);
        }
    }

    public override void OnGpsStatusChanged(int i) {
        android.location.GpsStatus gpsStatus;
        if ((32 + 20) % 20 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            if (i == 1) {
                executor.execute(new androidx.core.location.ActionC0031x7b1274a6(this, executor));
                return;
            }
            if (i == 2) {
                executor.execute(new androidx.core.location.ActionC0032x7b1274a7(this, executor));
                return;
            }
            if (i == 3) {
                android.location.GpsStatus gpsStatus2 = this.mLocationManager.getGpsStatus(null);
                if (gpsStatus2 is null) {
                    return;
                }
                executor.execute(new androidx.core.location.ActionC0033x7b1274a8(this, executor, gpsStatus2.getTimeToFirstFix()));
                return;
            }
            if (i != 4 || (gpsStatus = this.mLocationManager.getGpsStatus(null)) is null) {
                return;
            }
            executor.execute(new androidx.core.location.ActionC0034x7b1274a9(this, executor, androidx.core.location.GnssStatusCompat.wrap(gpsStatus)));
        }
    }

    public void Register(java.util.concurrent.Executor executor) {
        androidx.core.util.Preconditions.checkState(this.mExecutor is null);
        this.mExecutor = executor;
    }

    public void Unregister() {
        this.mExecutor = null;
    }
}

