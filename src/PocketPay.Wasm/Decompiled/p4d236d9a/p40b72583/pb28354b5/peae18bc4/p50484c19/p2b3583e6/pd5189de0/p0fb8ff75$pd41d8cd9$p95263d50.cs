namespace WillowMaze.Wasm.Decompiled;


public readonly class p0fb8ff75$pd41d8cd9$p95263d50 : android.location.LocationListener {
    public readonly io.reactivex.rxjava3.core.SingleEmitter f$0;
    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pd5189de0.p0fb8ff75 f$1;

    public p0fb8ff75$pd41d8cd9$p95263d50(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pd5189de0.p0fb8ff75 p0fb8ff75Var) {
        this.f$0 = singleEmitter;
        this.f$1 = p0fb8ff75Var;
    }

    public static void DsTDgTouqgelcOSj(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pd5189de0.p0fb8ff75 p0fb8ff75Var, android.location.Location location) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pd5189de0.p0fb8ff75.ma30d4642(singleEmitter, p0fb8ff75Var, location);
    }

    public override readonly void OnLocationChanged(android.location.Location location) {
        dsTDgTouqgelcOSj(this.f$0, this.f$1, location);
    }
}

