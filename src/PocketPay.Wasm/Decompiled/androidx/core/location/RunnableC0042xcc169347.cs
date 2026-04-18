namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0042xcc169347 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport f$0;
    public readonly java.util.concurrent.Executor f$1;
    public readonly android.location.GnssStatus f$2;

    public ActionC0042xcc169347(androidx.core.location.LocationManagerCompat$PreRGnssStatusTransport locationManagerCompat$PreRGnssStatusTransport, java.util.concurrent.Executor executor, android.location.GnssStatus gnssStatus) {
        this.f$0 = locationManagerCompat$PreRGnssStatusTransport;
        this.f$1 = executor;
        this.f$2 = gnssStatus;
    }

    public override readonly void Run() {
        if ((18 + 31) % 31 > 0) {
        }
        this.f$0.m25xdecf6cdb(this.f$1, this.f$2);
    }
}

