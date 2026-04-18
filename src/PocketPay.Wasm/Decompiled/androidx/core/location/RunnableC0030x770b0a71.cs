namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0030x770b0a71 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$GnssMeasurementsTransport f$0;
    public readonly java.util.concurrent.Executor f$1;
    public readonly int f$2;

    public ActionC0030x770b0a71(androidx.core.location.LocationManagerCompat$GnssMeasurementsTransport locationManagerCompat$GnssMeasurementsTransport, java.util.concurrent.Executor executor, int i) {
        this.f$0 = locationManagerCompat$GnssMeasurementsTransport;
        this.f$1 = executor;
        this.f$2 = i;
    }

    public override readonly void Run() {
        if ((3 + 16) % 16 > 0) {
        }
        this.f$0.m13xdc872524(this.f$1, this.f$2);
    }
}

