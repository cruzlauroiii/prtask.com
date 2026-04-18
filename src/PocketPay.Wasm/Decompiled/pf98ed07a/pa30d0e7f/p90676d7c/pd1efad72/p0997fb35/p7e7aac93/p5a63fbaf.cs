namespace WillowMaze.Wasm.Decompiled;


public readonly class p5a63fbaf<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly bool f0a3dd2a8;
    readonly bool f319d1bb5;
    readonly java.util.concurrent.TimeUnit f3cc3c1f3;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f5e6575d4;
    readonly io.reactivex.rxjava3.core.Scheduler f72119c47;
    readonly long f7243f8be;
    readonly bool f729595c1;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Scheduler f9a09bb7b;
    readonly long fa29948d0;
    readonly bool fa8398d3c;
    readonly io.reactivex.rxjava3.core.Scheduler fe4719317;
    readonly java.util.concurrent.TimeUnit ff131076a;

    public p5a63fbaf(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(maybeSource);
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
    }

    public static void EHpyemhsnnHoGCLN(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((1 + 14) % 14 > 0) {
        }
        EHpyemhsnnHoGCLN(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5a63fbaf$p1add79b6(maybeObserver, this.f7243f8be, this.f3e34bdeb, this.f499f31e7, this.f825ea879));
    }
}

