namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0032x7b1274a7 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$GpsStatusTransport f$0;
    public readonly java.util.concurrent.Executor f$1;

    public ActionC0032x7b1274a7(androidx.core.location.LocationManagerCompat$GpsStatusTransport locationManagerCompat$GpsStatusTransport, java.util.concurrent.Executor executor) {
        this.f$0 = locationManagerCompat$GpsStatusTransport;
        this.f$1 = executor;
    }

    public override readonly void Run() {
        this.f$0.m15xc3a89a22(this.f$1);
    }
}

