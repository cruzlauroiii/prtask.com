namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0031x7b1274a6 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$GpsStatusTransport f$0;
    public readonly java.util.concurrent.Executor f$1;

    public ActionC0031x7b1274a6(androidx.core.location.LocationManagerCompat$GpsStatusTransport locationManagerCompat$GpsStatusTransport, java.util.concurrent.Executor executor) {
        this.f$0 = locationManagerCompat$GpsStatusTransport;
        this.f$1 = executor;
    }

    public override readonly void Run() {
        this.f$0.m14x75e92221(this.f$1);
    }
}

