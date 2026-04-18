namespace WillowMaze.Wasm.Decompiled;


readonly class pc9330d79$p8f74fe66<T, U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<java.lang.object> {
    private static readonly long f2c801480 = 8663801314800248617L;
    private static readonly long f93d8d059 = 8663801314800248617L;
    private static readonly long fc6e1e520 = 8663801314800248617L;
    private static readonly long fcb0b30ef = 8663801314800248617L;
    private static readonly long fea48be5a = 8663801314800248617L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 f3850f5f0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 fb3315f64;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 fbab2d40b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 fce1656f5;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutMaybe$TimeoutMainMaybeObserver<T, U> fd0e45878;

    pc9330d79$p8f74fe66(io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutMaybe$TimeoutMainMaybeObserver<T, U> maybeTimeoutMaybe$TimeoutMainMaybeObserver) {
        this.fd0e45878 = maybeTimeoutMaybe$TimeoutMainMaybeObserver;
    }

    public static void RwkzFGWDXYeiGHRH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 pc9330d79_p94450938, java.lang.Exception th) {
        pc9330d79_p94450938.otherError(th);
    }

    public static void IyVShMCyFojkJQUH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 pc9330d79_p94450938) {
        pc9330d79_p94450938.otherComplete();
    }

    public static bool QUGaaqocobbSToXD(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void WwqkEpzmASmDeUHW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 pc9330d79_p94450938) {
        pc9330d79_p94450938.otherComplete();
    }

    public override void OnComplete() {
        iyVShMCyFojkJQUH(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        RwkzFGWDXYeiGHRH(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        qUGaaqocobbSToXD(this, p7beea252Var);
    }

    public override void OnSuccess(java.lang.object obj) {
        wwqkEpzmASmDeUHW(this.fd0e45878);
    }
}

