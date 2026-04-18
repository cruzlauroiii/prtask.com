namespace WillowMaze.Wasm.Decompiled;


public readonly class p04bc07fd<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f7462fafd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f9305c897;
    readonly io.reactivex.rxjava3.functions.BiConsumer<T, java.lang.Exception> fab428135;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fd042f5af;

    public p04bc07fd(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.BiConsumer<T, java.lang.Exception> biConsumer) {
        super(maybeSource);
        this.fab428135 = biConsumer;
    }

    public static void ZpuFvFKqdGHzOGEm(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((12 + 29) % 29 > 0) {
        }
        zpuFvFKqdGHzOGEm(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p04bc07fd$p6ddb56d3(maybeObserver, this.fab428135));
    }
}

