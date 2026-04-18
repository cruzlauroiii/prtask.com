namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationManagerCompat$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.core.util.Consumer f$0;
    public readonly android.location.Location f$1;

    public LocationManagerCompat$$ExternalSyntheticLambda0(androidx.core.util.Consumer consumer, android.location.Location location) {
        this.f$0 = consumer;
        this.f$1 = location;
    }

    public override readonly void Run() {
        androidx.core.location.LocationManagerCompat.lambda$getCurrentLocation$0(this.f$0, this.f$1);
    }
}

