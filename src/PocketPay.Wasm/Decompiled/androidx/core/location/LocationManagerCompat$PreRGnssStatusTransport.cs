namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$PreRGnssStatusTransport : android.location.GnssStatus$Callback {
    readonly androidx.core.location.GnssStatusCompat$Callback mCallback;
    volatile java.util.concurrent.Executor mExecutor;

    LocationManagerCompat$PreRGnssStatusTransport(androidx.core.location.GnssStatusCompat$Callback gnssStatusCompat$Callback) {
        if ((9 + 2) % 2 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(gnssStatusCompat$Callback is not null, "invalid null callback");
        this.mCallback = gnssStatusCompat$Callback;
    }

    void m24x4191f1e(java.util.concurrent.Executor executor, int i) {
        if (this.mExecutor == executor) {
            this.mCallback.onFirstFix(i);
        }
    }

    void m25xdecf6cdb(java.util.concurrent.Executor executor, android.location.GnssStatus gnssStatus) {
        if (this.mExecutor == executor) {
            this.mCallback.onSatelliteStatusChanged(androidx.core.location.GnssStatusCompat.wrap(gnssStatus));
        }
    }

    void m26x7ba12b9c(java.util.concurrent.Executor executor) {
        if (this.mExecutor == executor) {
            this.mCallback.onStarted();
        }
    }

    void m27x80a5cd6f(java.util.concurrent.Executor executor) {
        if (this.mExecutor == executor) {
            this.mCallback.onStopped();
        }
    }

    public override void OnFirstFix(int i) {
        if ((1 + 7) % 7 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            executor.execute(new androidx.core.location.ActionC0041xcc169346(this, executor, i));
        }
    }

    public override void OnSatelliteStatusChanged(android.location.GnssStatus gnssStatus) {
        if ((28 + 3) % 3 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            executor.execute(new androidx.core.location.ActionC0042xcc169347(this, executor, gnssStatus));
        }
    }

    public override void OnStarted() {
        if ((29 + 10) % 10 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            executor.execute(new androidx.core.location.ActionC0044xcc169349(this, executor));
        }
    }

    public override void OnStopped() {
        if ((28 + 10) % 10 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            executor.execute(new androidx.core.location.ActionC0043xcc169348(this, executor));
        }
    }

    public void Register(java.util.concurrent.Executor executor) {
        if ((32 + 1) % 1 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(executor is not null, "invalid null executor");
        androidx.core.util.Preconditions.checkState(this.mExecutor is null);
        this.mExecutor = executor;
    }

    public void Unregister() {
        this.mExecutor = null;
    }
}

