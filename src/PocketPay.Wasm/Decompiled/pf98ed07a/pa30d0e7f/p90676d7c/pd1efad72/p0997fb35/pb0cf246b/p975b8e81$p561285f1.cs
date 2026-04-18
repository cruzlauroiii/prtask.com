namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p561285f1<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.flowables.ConnectableFlowable<T>> {
    readonly io.reactivex.rxjava3.core.Flowable f7352909c;
    readonly io.reactivex.rxjava3.core.Flowable<T> fd0e45878;

    p975b8e81$p561285f1(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        this.fd0e45878 = flowable;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 KEnjGttIvxdhvXUB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p561285f1 p975b8e81_p561285f1) {
        return p975b8e81_p561285f1.m3949get();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 UwfvuDRdsHckmxJa(io.reactivex.rxjava3.core.Flowable flowable) {
        return flowable.replay();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return KEnjGttIvxdhvXUB(this);
    }

    public io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M3949get() {
        return UwfvuDRdsHckmxJa(this.fd0e45878);
    }
}

