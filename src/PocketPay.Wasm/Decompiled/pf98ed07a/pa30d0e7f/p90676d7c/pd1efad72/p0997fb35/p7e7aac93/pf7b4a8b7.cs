namespace WillowMaze.Wasm.Decompiled;


public readonly class pf7b4a8b7<T, R> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0a3ba522;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f17b79435;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1de2f488;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f58a273d3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f6512f0ca;
    readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f6c1d5d4f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6c804bd5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f775e2795;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f78aec391;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> fa1b38de8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fceb315c3;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> fe8e93457;

    public pf7b4a8b7(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function2, io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.MaybeSource<? : R>> supplier) {
        super(maybeSource);
        this.fe8e93457 = function;
        this.fa1b38de8 = function2;
        this.f6c1d5d4f = supplier;
    }

    public static void ZkYBaesoqyHnlNbW(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((28 + 9) % 9 > 0) {
        }
        ZkYBaesoqyHnlNbW(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf7b4a8b7$p7c9324ab(maybeObserver, this.fe8e93457, this.fa1b38de8, this.f6c1d5d4f));
    }
}

