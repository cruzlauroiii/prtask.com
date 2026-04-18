namespace WillowMaze.Wasm.Decompiled;


public readonly class p4fa47cff<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f0fa908d5;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f5a2d5195;
    readonly io.reactivex.rxjava3.core.Scheduler f818b78c7;

    public p4fa47cff(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(maybeSource);
        this.f499f31e7 = scheduler;
    }

    public static void SJdsRWkJmFzuCYVO(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((21 + 16) % 16 > 0) {
        }
        sJdsRWkJmFzuCYVO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4fa47cff$pfefde8d7(maybeObserver, this.f499f31e7));
    }
}

