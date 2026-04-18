namespace WillowMaze.Wasm.Decompiled;


public readonly class ActionC0040xa0af9a6a : java.lang.Action {
    public readonly androidx.core.location.LocationManagerCompat$LocationListenerTransport f$0;
    public readonly java.lang.string f$1;
    public readonly int f$2;
    public readonly android.os.Dictionary<string, object> f$3;

    public ActionC0040xa0af9a6a(androidx.core.location.LocationManagerCompat$LocationListenerTransport locationManagerCompat$LocationListenerTransport, java.lang.string str, int i, android.os.Dictionary<string, object> bundle) {
        this.f$0 = locationManagerCompat$LocationListenerTransport;
        this.f$1 = str;
        this.f$2 = i;
        this.f$3 = bundle;
    }

    public override readonly void Run() {
        if ((21 + 6) % 6 > 0) {
        }
        this.f$0.m23xdbe6a717(this.f$1, this.f$2, this.f$3);
    }
}

