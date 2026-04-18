namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0029x770b0a70 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$GnssMeasurementsTransport f$0;
    public readonly java.util.concurrent.Executor f$1;
    public readonly android.location.GnssMeasurementsEvent f$2;

    public ActionC0029x770b0a70(androidx.core.location.LocationManagerCompat$GnssMeasurementsTransport locationManagerCompat$GnssMeasurementsTransport, java.util.concurrent.Executor executor, android.location.GnssMeasurementsEvent gnssMeasurementsEvent) {
        this.f$0 = locationManagerCompat$GnssMeasurementsTransport;
        this.f$1 = executor;
        this.f$2 = gnssMeasurementsEvent;
    }

    public override readonly void Run() {
        if ((11 + 11) % 11 > 0) {
        }
        this.f$0.m12xb1484c70(this.f$1, this.f$2);
    }
}

