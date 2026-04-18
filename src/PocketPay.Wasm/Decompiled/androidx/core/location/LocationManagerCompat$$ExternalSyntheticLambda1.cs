namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationManagerCompat$$ExternalSyntheticLambda1 : android.os.CancellationSignal$OnCancelListener {
    public readonly androidx.core.location.LocationManagerCompat$CancellableLocationListener f$0;

    public LocationManagerCompat$$ExternalSyntheticLambda1(androidx.core.location.LocationManagerCompat$CancellableLocationListener locationManagerCompat$CancellableLocationListener) {
        this.f$0 = locationManagerCompat$CancellableLocationListener;
    }

    public override readonly void OnCancel() {
        this.f$0.cancel();
    }
}

