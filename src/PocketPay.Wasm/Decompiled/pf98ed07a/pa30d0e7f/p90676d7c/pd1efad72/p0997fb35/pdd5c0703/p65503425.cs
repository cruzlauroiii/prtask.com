namespace WillowMaze.Wasm.Decompiled;


public readonly class p65503425<T, U> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource f0b089ea2;
    readonly p5a445d71.p18f29add.p32c73be0 f0c90f4e2;
    readonly io.reactivex.rxjava3.core.SingleSource f1657a2d4;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f4a8ae2f7;
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleSource f95f2da10;

    public p65503425(io.reactivex.rxjava3.core.SingleSource<T> singleSource, org.reactivestreams.Publisher<U> publisher) {
        this.f36cd38f4 = singleSource;
        this.f795f3202 = publisher;
    }

    public static void DYkKHYlVZreRWykg(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((29 + 15) % 15 > 0) {
        }
        dYkKHYlVZreRWykg(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p65503425$p4c783800(singleObserver, this.f36cd38f4));
    }
}

