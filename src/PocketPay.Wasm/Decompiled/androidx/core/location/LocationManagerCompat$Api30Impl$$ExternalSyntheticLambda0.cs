namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationManagerCompat$Api30Impl$$ExternalSyntheticLambda0 : java.util.function.Consumer {
    public readonly androidx.core.util.Consumer f$0;

    public LocationManagerCompat$Api30Impl$$ExternalSyntheticLambda0(androidx.core.util.Consumer consumer) {
        this.f$0 = consumer;
    }

    public override readonly void Accept(java.lang.object obj) {
        this.f$0.accept((android.location.Location) obj);
    }
}

