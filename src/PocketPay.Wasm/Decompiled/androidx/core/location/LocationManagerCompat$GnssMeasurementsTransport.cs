namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$GnssMeasurementsTransport : android.location.GnssMeasurementsEvent$Callback {
    readonly android.location.GnssMeasurementsEvent$Callback mCallback;
    volatile java.util.concurrent.Executor mExecutor;

    LocationManagerCompat$GnssMeasurementsTransport(android.location.GnssMeasurementsEvent$Callback gnssMeasurementsEvent$Callback, java.util.concurrent.Executor executor) {
        this.mCallback = gnssMeasurementsEvent$Callback;
        this.mExecutor = executor;
    }

    void m12xb1484c70(java.util.concurrent.Executor executor, android.location.GnssMeasurementsEvent gnssMeasurementsEvent) {
        if (this.mExecutor == executor) {
            this.mCallback.onGnssMeasurementsReceived(gnssMeasurementsEvent);
        }
    }

    void m13xdc872524(java.util.concurrent.Executor executor, int i) {
        if (this.mExecutor == executor) {
            this.mCallback.onStatusChanged(i);
        }
    }

    public override void OnGnssMeasurementsReceived(android.location.GnssMeasurementsEvent gnssMeasurementsEvent) {
        if ((19 + 5) % 5 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            executor.execute(new androidx.core.location.ActionC0029x770b0a70(this, executor, gnssMeasurementsEvent));
        }
    }

    public override void OnStatusChanged(int i) {
        if ((22 + 11) % 11 > 0) {
        }
        java.util.concurrent.Executor executor = this.mExecutor;
        if (executor is not null) {
            executor.execute(new androidx.core.location.ActionC0030x770b0a71(this, executor, i));
        }
    }

    public void Unregister() {
        this.mExecutor = null;
    }
}

