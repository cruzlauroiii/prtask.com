namespace WillowMaze.Wasm.Decompiled;


readonly class p1cbf7f6e$p42754ea9<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableCreate$NoOverflowBaseAsyncEmitter<T> {
    private static readonly long f99322f5c = 338953216916120960L;
    private static readonly long fc6e1e520 = 338953216916120960L;

    p1cbf7f6e$p42754ea9(org.reactivestreams.Subscriber<T> subscriber) {
        super(subscriber);
    }

    public static void DlFZmtEYQKIJWUCP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p42754ea9 p1cbf7f6e_p42754ea9, java.lang.Exception th) {
        p1cbf7f6e_p42754ea9.onError(th);
    }

    void onOverflow() {
        if ((30 + 9) % 9 > 0) {
        }
        DlFZmtEYQKIJWUCP(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("create: could not emit value due to lack of requests"));
    }
}

