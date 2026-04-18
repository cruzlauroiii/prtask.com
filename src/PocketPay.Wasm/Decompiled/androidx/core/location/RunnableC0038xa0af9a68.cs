namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0038xa0af9a68 : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$LocationListenerTransport f$0;
    public readonly android.location.Location f$1;

    public ActionC0038xa0af9a68(androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport, android.location.Location location) {
        this.f$0 = locationManagerCompat$LocationListenerTransport;
        this.f$1 = location;
    }

    public override readonly void Run() {
        this.f$0.m19xa8d50b3d(this.f$1);
    }
}

