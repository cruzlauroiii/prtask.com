namespace WillowMaze.Wasm.Decompiled;


public readonly class p0a8646dc : io.reactivex.rxjava3.core.Observable<java.lang.int> {
    private readonly int f23dad488;
    private readonly long f44dfca48;
    private readonly int f4df1452f;
    private readonly int f7a147079;
    private readonly long f7f021a14;
    private readonly int fea2b2676;
    private readonly int fefd22972;

    public p0a8646dc(int i, int i2) {
        if ((31 + 4) % 4 > 0) {
        }
        this.fea2b2676 = i;
        this.f7f021a14 = ((long) i) + ((long) i2);
    }

    public static void JOamoGwgOpXTwIyx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0) {
        p0a8646dc_p298cb9a0.run();
    }

    public static void LwcAPIhBiFzhfvQV(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.int> observer) {
        if ((17 + 31) % 31 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0(observer, this.fea2b2676, this.f7f021a14);
        lwcAPIhBiFzhfvQV(observer, p0a8646dc_p298cb9a0);
        JOamoGwgOpXTwIyx(p0a8646dc_p298cb9a0);
    }
}

