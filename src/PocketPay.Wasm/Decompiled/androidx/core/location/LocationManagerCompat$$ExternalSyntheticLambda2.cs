namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationManagerCompat$$ExternalSyntheticLambda2 : java.util.concurrent.Func {
    public readonly android.location.LocationManager f$0;
    public readonly androidx.core.location.LocationManagerCompat$GpsStatusTransport f$1;

    public LocationManagerCompat$$ExternalSyntheticLambda2(android.location.LocationManager locationManager, androidx.core.location.LocationManagerCompat$GpsStatusTransport locationManagerCompat$GpsStatusTransport) {
        this.f$0 = locationManager;
        this.f$1 = locationManagerCompat$GpsStatusTransport;
    }

    public override readonly java.lang.object Call() {
        return androidx.core.location.LocationManagerCompat.lambda$registerGnssStatusCallback$1(this.f$0, this.f$1);
    }
}

