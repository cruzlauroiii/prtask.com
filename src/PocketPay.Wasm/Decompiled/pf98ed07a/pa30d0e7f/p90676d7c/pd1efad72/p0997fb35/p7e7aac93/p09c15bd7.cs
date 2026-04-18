namespace WillowMaze.Wasm.Decompiled;


public readonly class p09c15bd7<T> : io.reactivex.rxjava3.core.Maybe<io.reactivex.rxjava3.schedulers.Timed<T>> {
    readonly io.reactivex.rxjava3.core.Scheduler f01033205;
    readonly io.reactivex.rxjava3.core.Scheduler f1dbf0dec;
    readonly bool f23f7f83e;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.MaybeSource f71a6d9cc;
    readonly bool fc1412dd3;
    readonly bool fd44620cc;
    readonly io.reactivex.rxjava3.core.MaybeSource fdc669952;
    readonly bool fea2b2676;
    readonly bool fed239dd0;
    readonly java.util.concurrent.TimeUnit ffff3002e;

    public p09c15bd7(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.f36cd38f4 = maybeSource;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fea2b2676 = z;
    }

    public static void VkGbwGRVPKKJvveO(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<? super io.reactivex.rxjava3.schedulers.Timed<T>> maybeObserver) {
        if ((20 + 18) % 18 > 0) {
        }
        vkGbwGRVPKKJvveO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p09c15bd7$p38d2becf(maybeObserver, this.f3e34bdeb, this.f499f31e7, this.fea2b2676));
    }
}

