namespace WillowMaze.Wasm.Decompiled;


public readonly class pf5733398<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f4ab7b812;
    readonly p5a445d71.p18f29add.p32c73be0 f6b2e7d47;
    readonly p5a445d71.p18f29add.p32c73be0 f6cd5cae7;
    readonly p5a445d71.p18f29add.p32c73be0 ff24d99a6;

    public pf5733398(org.reactivestreams.Publisher<T> publisher) {
        this.f36cd38f4 = publisher;
    }

    public static void VhNmqBZrwUdVKrxb(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        vhNmqBZrwUdVKrxb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf5733398$pd7ce6bda(maybeObserver));
    }
}

