namespace WillowMaze.Wasm.Decompiled;


public readonly class p666bceda<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly org.reactivestreams.Publisher<? : T> f52aded16;
    readonly p5a445d71.p18f29add.p32c73be0 feef90183;

    public p666bceda(org.reactivestreams.Publisher<? : T> publisher) {
        this.f52aded16 = publisher;
    }

    public static void SgLvOyHIETcUamVs(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        SgLvOyHIETcUamVs(this.f52aded16, subscriber);
    }
}

