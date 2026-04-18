namespace WillowMaze.Wasm.Decompiled;


readonly class p6b3b632e$p83054432<T> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fad40626b = 6770240836423125754L;
    private static readonly long fc6e1e520 = 6770240836423125754L;
    readonly io.reactivex.rxjava3.core.Observer f0baf8d3b;
    readonly io.reactivex.rxjava3.core.Observer f20f5d102;
    int f2cfb94ed;
    io.reactivex.rxjava3.internal.operators.observable.ObservableCache$Node<T> f36c45369;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b3b632e f5a682967;
    long f6a992d55;
    readonly io.reactivex.rxjava3.core.Observer f6ebf0aa3;
    int f7a86c157;
    int f94a2c863;
    int f964405f7;
    volatile bool fb3666a2d;
    volatile bool fc12fa5b7;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b3b632e$p6c3a6944 fcdd95308;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableCache<T> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    long fde7b1fa5;
    long fe62a57a1;
    int ff171a173;
    volatile bool ff8b2648d;

    p6b3b632e$p83054432(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.internal.operators.observable.ObservableCache<T> observableCache) {
        this.fd22a0a80 = observer;
        this.fd0e45878 = observableCache;
        this.f36c45369 = observableCache.f96e89a29;
    }

    public static void ZzuKIOynjUDYMWzH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b3b632e p6b3b632eVar, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b3b632e$p83054432 p6b3b632e_p83054432) {
        p6b3b632eVar.Remove(p6b3b632e_p83054432);
    }

    public override void Dispose() {
        if (this.ff8b2648d) {
            return;
        }
        this.ff8b2648d = true;
        ZzuKIOynjUDYMWzH(this.fd0e45878, this);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }
}

