namespace WillowMaze.Wasm.Decompiled;


public readonly class pae6bafbb<T, U> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 ffc813ffa;

    public pae6bafbb(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, org.reactivestreams.Publisher<U> publisher) {
        super(maybeSource);
        this.f795f3202 = publisher;
    }

    public static void SpfxDwtRLyPczTLo(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((15 + 22) % 22 > 0) {
        }
        spfxDwtRLyPczTLo(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p4c783800(maybeObserver, this.f36cd38f4));
    }
}

