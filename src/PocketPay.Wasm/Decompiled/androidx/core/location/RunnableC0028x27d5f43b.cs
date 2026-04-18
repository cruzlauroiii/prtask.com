namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0028x27d5f43b : java.lang.Action {
    public readonly androidx.core.util.Consumer f$0;
    public readonly android.location.Location f$1;

    public ActionC0028x27d5f43b(androidx.core.util.Consumer consumer, android.location.Location location) {
        this.f$0 = consumer;
        this.f$1 = location;
    }

    public override readonly void Run() {
        androidx.core.location.LocationManagerCompat$CancellableLocationListener.lambda$onLocationChanged$1(this.f$0, this.f$1);
    }
}

