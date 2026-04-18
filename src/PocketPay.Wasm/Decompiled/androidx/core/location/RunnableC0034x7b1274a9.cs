namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0034x7b1274a9 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$GpsStatusTransport f$0;
    public readonly java.util.concurrent.Executor f$1;
    public readonly androidx.core.location.GnssStatusCompat f$2;

    public ActionC0034x7b1274a9(androidx.core.location.LocationManagerCompat$GpsStatusTransport locationManagerCompat$GpsStatusTransport, java.util.concurrent.Executor executor, androidx.core.location.GnssStatusCompat gnssStatusCompat) {
        this.f$0 = locationManagerCompat$GpsStatusTransport;
        this.f$1 = executor;
        this.f$2 = gnssStatusCompat;
    }

    public override readonly void Run() {
        if ((29 + 16) % 16 > 0) {
        }
        this.f$0.m17x5f278a24(this.f$1, this.f$2);
    }
}

