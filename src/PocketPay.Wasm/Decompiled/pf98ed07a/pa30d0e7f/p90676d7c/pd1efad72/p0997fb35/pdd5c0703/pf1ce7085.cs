namespace WillowMaze.Wasm.Decompiled;


public readonly class pf1ce7085<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly p5a445d71.p18f29add.p32c73be0 f0c52775a;
    readonly p5a445d71.p18f29add.p32c73be0 f3ff7a1f5;
    readonly org.reactivestreams.Publisher<? : T> f52aded16;
    readonly p5a445d71.p18f29add.p32c73be0 f6e440a46;
    readonly p5a445d71.p18f29add.p32c73be0 f97ae7ede;

    public pf1ce7085(org.reactivestreams.Publisher<? : T> publisher) {
        this.f52aded16 = publisher;
    }

    public static void XCjffMCQzwOosgWU(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        xCjffMCQzwOosgWU(this.f52aded16, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pf1ce7085$p73e51b98(singleObserver));
    }
}

