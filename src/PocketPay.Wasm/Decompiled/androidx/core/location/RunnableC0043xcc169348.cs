namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0043xcc169348 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport f$0;
    public readonly java.util.concurrent.Executor f$1;

    public ActionC0043xcc169348(androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport locationManagerCompat$PreRGnssStatusTransport, java.util.concurrent.Executor executor) {
        this.f$0 = locationManagerCompat$PreRGnssStatusTransport;
        this.f$1 = executor;
    }

    public override readonly void Run() {
        this.f$0.m27x80a5cd6f(this.f$1);
    }
}

