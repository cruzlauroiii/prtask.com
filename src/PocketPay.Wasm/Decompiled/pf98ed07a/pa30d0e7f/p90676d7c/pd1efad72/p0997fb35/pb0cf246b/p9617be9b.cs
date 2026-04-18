namespace WillowMaze.Wasm.Decompiled;


public readonly class p9617be9b<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly long f09d5efb6;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly long f6a992d55;
    readonly p5a445d71.p18f29add.p32c73be0 f7f17d4ed;
    readonly p5a445d71.p18f29add.p32c73be0 fd15722d6;

    public p9617be9b(org.reactivestreams.Publisher<T> publisher, long j) {
        this.f36cd38f4 = publisher;
        this.f6a992d55 = j;
    }

    public static void PpPyZDIFGdRlnUVr(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((2 + 30) % 30 > 0) {
        }
        ppPyZDIFGdRlnUVr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p3b1b697d$p6b4417bd(maybeObserver, this.f6a992d55));
    }
}

