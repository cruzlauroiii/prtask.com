namespace WillowMaze.Wasm.Decompiled;


public readonly class p44f9de6f<T, U> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly p5a445d71.p18f29add.p32c73be0 f3b971dd0;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f4ccb1142;
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource f9370d5d9;
    readonly p5a445d71.p18f29add.p32c73be0 fe225719c;
    readonly p5a445d71.p18f29add.p32c73be0 fedb0a2a7;
    readonly p5a445d71.p18f29add.p32c73be0 ffac85edf;

    public p44f9de6f(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, org.reactivestreams.Publisher<U> publisher, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource2) {
        super(maybeSource);
        this.f795f3202 = publisher;
        this.f4ccb1142 = maybeSource2;
    }

    public static void TCjCwcuswFlJcaZn(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void VAhTrtwhyimkIGAj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void HOPvsjlnAemOTfhY(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((2 + 20) % 20 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938(maybeObserver, this.f4ccb1142);
        VAhTrtwhyimkIGAj(maybeObserver, p44f9de6f_p94450938);
        hOPvsjlnAemOTfhY(this.f795f3202, p44f9de6f_p94450938.f795f3202);
        TCjCwcuswFlJcaZn(this.f36cd38f4, p44f9de6f_p94450938);
    }
}

