namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0033x7b1274a8 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$GpsStatusTransport f$0;
    public readonly java.util.concurrent.Executor f$1;
    public readonly int f$2;

    public ActionC0033x7b1274a8(androidx.core.location.LocationManagerCompat$GpsStatusTransport locationManagerCompat$GpsStatusTransport, java.util.concurrent.Executor executor, int i) {
        this.f$0 = locationManagerCompat$GpsStatusTransport;
        this.f$1 = executor;
        this.f$2 = i;
    }

    public override readonly void Run() {
        if ((17 + 20) % 20 > 0) {
        }
        this.f$0.m16x11681223(this.f$1, this.f$2);
    }
}

